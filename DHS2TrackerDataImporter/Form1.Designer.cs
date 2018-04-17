namespace DHS2TrackerDataImporter
{
    partial class FrmImportTrackerData
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPostData = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.progressBarImport = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SelectFile = new System.Windows.Forms.Button();
            this.TxtFilepath = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbProgram = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 386);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.btnPostData);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 310);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1024, 76);
            this.panel5.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPostData
            // 
            this.btnPostData.Location = new System.Drawing.Point(158, 8);
            this.btnPostData.Name = "btnPostData";
            this.btnPostData.Size = new System.Drawing.Size(123, 54);
            this.btnPostData.TabIndex = 0;
            this.btnPostData.Text = "Import Data";
            this.btnPostData.UseVisualStyleBackColor = true;
            this.btnPostData.Click += new System.EventHandler(this.btnPostData_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbProgram);
            this.panel4.Controls.Add(this.progressBarImport);
            this.panel4.Location = new System.Drawing.Point(0, 124);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1024, 262);
            this.panel4.TabIndex = 2;
            // 
            // progressBarImport
            // 
            this.progressBarImport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBarImport.Location = new System.Drawing.Point(12, 120);
            this.progressBarImport.Name = "progressBarImport";
            this.progressBarImport.Size = new System.Drawing.Size(269, 23);
            this.progressBarImport.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SelectFile);
            this.panel3.Controls.Add(this.TxtFilepath);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 71);
            this.panel3.TabIndex = 1;
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(746, 16);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(87, 33);
            this.SelectFile.TabIndex = 1;
            this.SelectFile.Text = "Select";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // TxtFilepath
            // 
            this.TxtFilepath.Location = new System.Drawing.Point(12, 9);
            this.TxtFilepath.Multiline = true;
            this.TxtFilepath.Name = "TxtFilepath";
            this.TxtFilepath.ReadOnly = true;
            this.TxtFilepath.Size = new System.Drawing.Size(728, 44);
            this.TxtFilepath.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 53);
            this.panel2.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbProgram
            // 
            this.cmbProgram.FormattingEnabled = true;
            this.cmbProgram.Items.AddRange(new object[] {
            "Community Service",
            "Medical Internship"});
            this.cmbProgram.Location = new System.Drawing.Point(504, 16);
            this.cmbProgram.Name = "cmbProgram";
            this.cmbProgram.Size = new System.Drawing.Size(215, 24);
            this.cmbProgram.TabIndex = 1;
            // 
            // FrmImportTrackerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 386);
            this.Controls.Add(this.panel1);
            this.Name = "FrmImportTrackerData";
            this.ShowIcon = false;
            this.Text = "Import DHIS 2 TrackedEntityInstance";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnPostData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ProgressBar progressBarImport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.TextBox TxtFilepath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbProgram;
    }
}

