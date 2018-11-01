using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Xml;

namespace SaveGameBackupUtility
{
    public partial class Form1 : Form
    {
        List<string> loadedGameTitles = new List<string>();
        List<string> loadedBackupPaths = new List<string>();
        List<string> loadedSavePaths = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void txtBackupDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            applicationInit();
        }

        /*
         * Initialize the application
         */
        private void applicationInit()
        {
            loadSavedData();
        }

        /*
         * This clears the paths from the two textboxes, removes the list of game presets from the dropdown and reloads it
         * (Usually used after the list of presets has been changed, such as one being deleted)
         */
        private void reload()
        {
            for (int i = 0; i < gameList.Items.Count; i++){
                gameList.Items.Remove(gameList.Items[i]);
            }
            txtBackupDir.Text = "";
            txtSaveGameDir.Text = "";

            loadSavedData();
        }

        /*
         * Loads the all saved game presets into memory
         */
        private void loadSavedData()
        {
            //Create folder in appdata if it does not exist
            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SaveGameBackupUtility")))
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SaveGameBackupUtility"));
            }

            List<string> files = Directory.GetFiles(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SaveGameBackupUtility")).ToList();


            foreach (string f in files)
            {
                if (File.Exists(f))
                {
                    string[] lines = System.IO.File.ReadAllLines(f);
                    loadedGameTitles.Add(lines[0]);
                    loadedBackupPaths.Add(lines[1]);
                    loadedSavePaths.Add(lines[2]);
                }
            }

            loadGameTitles();
        }

        /*
         * Add all the loaded presets into the dropdown box
         */
        private void loadGameTitles()
        {
            foreach(string i in loadedGameTitles)
            {
                gameList.Items.Add(i);
            }
        }

        private void btnBackupDirBrowse_Click(object sender, EventArgs e)
        {
            chooseFolder(txtBackupDir);
        }

        private void btnSaveDirBrowse_Click(object sender, EventArgs e)
        {
            chooseFolder(txtSaveGameDir);
        }

        private void chooseFolder(TextBox txtBox)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private string getTodaysDate()
        {
            return DateTime.Today.ToString("M-dd-yyyy");
        }

        private string genTimestamp() {
            string timestamp = "";
            DateTime now = DateTime.Now;
            timestamp += now.Hour + "-" + now.Minute + "-" + now.Second + "-" + now.Millisecond;

            return timestamp;
        }

        private void enableForm(bool what = true)
        {
            menuStrip1.Enabled = what;
            gameList.Enabled = what;
            txtBackupDir.Enabled = what;
            txtSaveGameDir.Enabled = what;
            chkremoveAfterBackup.Enabled = what;
            btnInitBackup.Enabled = what;
            btnBackupDirBrowse.Enabled = what;
            btnSaveDirBrowse.Enabled = what;
        }

        private void btnInitBackup_Click(object sender, EventArgs e)
        {
            //Check if both the save and backup directories exist before starting
            if (!Directory.Exists(txtBackupDir.Text) || !Directory.Exists(txtSaveGameDir.Text))
            {
                MessageBox.Show("One of the selected directories does not exist. Please check the path and try again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Check how many files there are, alert if none
                if (Directory.GetFiles(txtSaveGameDir.Text).Length < 1)
                {
                    MessageBox.Show("There are no files to backup in the selected directory. Proceed anyway?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    backup();
                }
            }
        }

        /*
         * Back up the files
         */
        private void backup()
        {
            string backPath = txtBackupDir.Text;
            string savePath = txtSaveGameDir.Text;
            string[] files = Directory.GetFiles(savePath).Select(p => Path.GetFileName(p)).ToArray();
            bool removedPreset = false;
            string today = getTodaysDate();
            string timestamp = genTimestamp();
            int stepsRequired = files.Count();
            int failedTransfers = 0;
            List<string> failedFiles = new List<string>();

            //Disable form interection while backup is in progress
            enableForm(false);

            //Reset the completion status bar
            setStatus("Initiating backup...");
            resetCompStatusBar(stepsRequired);

            //Attempt to back up files
            setStatus("Beginning backup.");

            //Create directory for today, if there isnt one
            setStatus("Searching for daily backup directory...");
            if(!Directory.Exists(Path.Combine(backPath, today)))
            {
                setStatus("Not found, creating...");
                Directory.CreateDirectory(Path.Combine(backPath, today));
            }

            //Create filepath
            string filePath = Path.Combine(backPath, today, timestamp);

            //create directory for right now
            setStatus("Creating directory with timestamp...");
            Directory.CreateDirectory(filePath);

            foreach (string f in files)
            {
                setStatus("Copying " + f + "...");
                try
                {
                    File.Copy(Path.Combine(savePath, f), Path.Combine(filePath, f), true);
                }
                catch
                {
                    failedTransfers++;
                    failedFiles.Add(f);
                    setStatus("Failed.");
                }
                pgbCompletionStatus.PerformStep();
            }

            //Save, or remove
            if (!chkremoveAfterBackup.Checked)
            {
                setStatus("File transfer complete. Saving preset...");
                save();
            }
            else
            {
                setStatus("File transfer complete. Deleting preset...");
                string deletePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SaveGameBackupUtility");
                remove(Path.Combine(deletePath, gameList.Text + ".txt"));
                removedPreset = true;
            }

            string resultMsg = "Backup complete." + (removedPreset ? "The preset for this game has been removed." : "");

            if(failedTransfers > 0)
            {
                string msg = "The backup completed, but encountered errors. The following files failed to be backed up:" + "\n";
                foreach(string str in failedFiles)
                {
                    msg += str + "\n";
                }
                MessageBox.Show(msg, "Completed with errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //MessageBox.Show(resultMsg, "Backup Completed", MessageBoxButtons.OK);
            if (removedPreset)
            {
                reload();
            }

            //Unlock form
            enableForm(true);
        }

        private void showCompletionMessage(int filesCopied, int filesSkipped, bool removedPreset)
        {
            string message = "Backup Completed." + "\n" + filesCopied.ToString() + " files were backed up successfully." + "\n" + filesSkipped.ToString() + " files were skipped." + "\n" + (removedPreset ? "" : "The preset for this game has been removed.");
            MessageBox.Show(message, "Backup Completed", MessageBoxButtons.OK);
        }

        private void helpLinkBackupDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This is the directory that your save files will be backed up to.");
        }

        private void helpLinkSaveDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This is the directory that your save files are located in by default.");
        }

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are about to delete the selected game preset from this utility. This will NOT affect your game installation or it's saves, nor will it delete your previous backups. All this does is remove the saved paths from this utility's config file. To backup this game again, you will have to re-add the game to this utilitry. Continue?", "Delete Game?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                //Access xml document and remove preset
                MessageBox.Show("Kyle, you haven't added this feature yet!");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void gameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = loadedGameTitles.IndexOf(gameList.Text);
            txtBackupDir.Text = loadedBackupPaths[index];
            txtSaveGameDir.Text = loadedSavePaths[index];
        }

        private void remove(string fileToDelete)
        {
            if (File.Exists(fileToDelete))
            {
                File.Delete(fileToDelete);
            }
        }

        private void save()
        {
            // Create folder in appdata if it does not exist
            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SaveGameBackupUtility")))
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SaveGameBackupUtility"));
            }

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SaveGameBackupUtility");
            if (!string.IsNullOrWhiteSpace(gameList.Text))
            {
                string[] lines = {gameList.Text, txtBackupDir.Text, txtSaveGameDir.Text };
                string fileName = gameList.Text + ".txt";
                if (!File.Exists(Path.Combine(path, fileName)))
                {
                    System.IO.File.WriteAllLines(Path.Combine(path, fileName), lines);
                }
                else
                {
                    File.Delete(Path.Combine(path, fileName));
                    System.IO.File.WriteAllLines(Path.Combine(path, fileName), lines);
                }
            }
        }

        private void btnBackupDirBrowse_Click_1(object sender, EventArgs e)
        {
            chooseFolder(txtBackupDir);
        }

        private void btnSaveDirBrowse_Click_1(object sender, EventArgs e)
        {
            chooseFolder(txtSaveGameDir);
        }

        private void btnInitBackup_Click_1(object sender, EventArgs e)
        {
            //Check if both the save and backup directories exist before starting
            if (!Directory.Exists(txtBackupDir.Text) || !Directory.Exists(txtSaveGameDir.Text))
            {
                MessageBox.Show("One of the selected directories does not exist. Please check the path and try again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Check how many files there are, alert if none
                if (Directory.GetFiles(txtSaveGameDir.Text).Length < 1)
                {
                    MessageBox.Show("There are no files to backup in the selected directory. Proceed anyway?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    backup();
                }
            }
        }

        private void chkremoveAfterBackup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void setStatus(string str)
        {
            //Set text
            lblStatus.Text = "Status: " + str;
        }

        private void resetCompStatusBar(int newMax = 100)
        {
            pgbCompletionStatus.Minimum = 0;
            pgbCompletionStatus.Maximum = newMax;
            pgbCompletionStatus.Value = 0;
            pgbCompletionStatus.Step = 1;
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 prefs = new Form2();
            prefs.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadPresetManually();
        }

        private void loadPresetManually()
        {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            if (!File.Exists(file))
            {
                MessageBox.Show("The file you selected does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string[] lines = System.IO.File.ReadAllLines(file);
                gameList.Text = lines[0];
                txtBackupDir.Text = lines[1];
                txtSaveGameDir.Text = lines[2];
            }
        }
    }
}
