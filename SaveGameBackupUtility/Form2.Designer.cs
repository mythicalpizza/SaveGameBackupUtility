namespace SaveGameBackupUtility
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrefsCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrefsCancel
            // 
            this.btnPrefsCancel.Location = new System.Drawing.Point(197, 226);
            this.btnPrefsCancel.Name = "btnPrefsCancel";
            this.btnPrefsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnPrefsCancel.TabIndex = 0;
            this.btnPrefsCancel.Text = "Cancel";
            this.btnPrefsCancel.UseVisualStyleBackColor = true;
            this.btnPrefsCancel.Click += new System.EventHandler(this.btnPrefsCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPrefsCancel);
            this.Name = "Form2";
            this.Text = "Preferences";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrefsCancel;
    }
}