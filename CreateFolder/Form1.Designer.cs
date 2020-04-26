namespace CreateFolder
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Commit2 = new System.Windows.Forms.Label();
            this.tbEndCommit = new System.Windows.Forms.TextBox();
            this.label_Commit1 = new System.Windows.Forms.Label();
            this.tbBeginCommit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_IncludeDirectory = new System.Windows.Forms.CheckBox();
            this.label_IncludeFileTypes = new System.Windows.Forms.Label();
            this.tbFileSelect = new System.Windows.Forms.TextBox();
            this.label_Savepath = new System.Windows.Forms.Label();
            this.tbSavePath = new System.Windows.Forms.TextBox();
            this.label_ProjectPath = new System.Windows.Forms.Label();
            this.Btn_UpdateConfig = new System.Windows.Forms.Button();
            this.label_GitExePath = new System.Windows.Forms.Label();
            this.tbGitExePath = new System.Windows.Forms.TextBox();
            this.tbProjectPath = new System.Windows.Forms.TextBox();
            this.btnGeneratePackage = new System.Windows.Forms.Button();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkedListBox_Result = new System.Windows.Forms.CheckedListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Commit2);
            this.groupBox2.Controls.Add(this.tbEndCommit);
            this.groupBox2.Controls.Add(this.label_Commit1);
            this.groupBox2.Controls.Add(this.tbBeginCommit);
            this.groupBox2.Location = new System.Drawing.Point(13, 256);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(437, 107);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Commit";
            // 
            // label_Commit2
            // 
            this.label_Commit2.AutoSize = true;
            this.label_Commit2.Location = new System.Drawing.Point(13, 70);
            this.label_Commit2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Commit2.Name = "label_Commit2";
            this.label_Commit2.Size = new System.Drawing.Size(83, 17);
            this.label_Commit2.TabIndex = 13;
            this.label_Commit2.Text = "End Commit";
            // 
            // tbEndCommit
            // 
            this.tbEndCommit.Location = new System.Drawing.Point(149, 66);
            this.tbEndCommit.Margin = new System.Windows.Forms.Padding(4);
            this.tbEndCommit.Name = "tbEndCommit";
            this.tbEndCommit.Size = new System.Drawing.Size(265, 22);
            this.tbEndCommit.TabIndex = 11;
            // 
            // label_Commit1
            // 
            this.label_Commit1.AutoSize = true;
            this.label_Commit1.Location = new System.Drawing.Point(13, 38);
            this.label_Commit1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Commit1.Name = "label_Commit1";
            this.label_Commit1.Size = new System.Drawing.Size(94, 17);
            this.label_Commit1.TabIndex = 8;
            this.label_Commit1.Text = "Begin Commit";
            // 
            // tbBeginCommit
            // 
            this.tbBeginCommit.Location = new System.Drawing.Point(149, 34);
            this.tbBeginCommit.Margin = new System.Windows.Forms.Padding(4);
            this.tbBeginCommit.Name = "tbBeginCommit";
            this.tbBeginCommit.Size = new System.Drawing.Size(265, 22);
            this.tbBeginCommit.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_IncludeDirectory);
            this.groupBox1.Controls.Add(this.label_IncludeFileTypes);
            this.groupBox1.Controls.Add(this.tbFileSelect);
            this.groupBox1.Controls.Add(this.label_Savepath);
            this.groupBox1.Controls.Add(this.tbSavePath);
            this.groupBox1.Controls.Add(this.label_ProjectPath);
            this.groupBox1.Controls.Add(this.Btn_UpdateConfig);
            this.groupBox1.Controls.Add(this.label_GitExePath);
            this.groupBox1.Controls.Add(this.tbGitExePath);
            this.groupBox1.Controls.Add(this.tbProjectPath);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(437, 235);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // checkBox_IncludeDirectory
            // 
            this.checkBox_IncludeDirectory.AutoSize = true;
            this.checkBox_IncludeDirectory.Location = new System.Drawing.Point(17, 177);
            this.checkBox_IncludeDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_IncludeDirectory.Name = "checkBox_IncludeDirectory";
            this.checkBox_IncludeDirectory.Size = new System.Drawing.Size(87, 38);
            this.checkBox_IncludeDirectory.TabIndex = 15;
            this.checkBox_IncludeDirectory.Text = "Include\r\nDirectory\r\n";
            this.checkBox_IncludeDirectory.UseVisualStyleBackColor = true;
            // 
            // label_IncludeFileTypes
            // 
            this.label_IncludeFileTypes.AutoSize = true;
            this.label_IncludeFileTypes.Location = new System.Drawing.Point(13, 143);
            this.label_IncludeFileTypes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_IncludeFileTypes.Name = "label_IncludeFileTypes";
            this.label_IncludeFileTypes.Size = new System.Drawing.Size(73, 17);
            this.label_IncludeFileTypes.TabIndex = 9;
            this.label_IncludeFileTypes.Text = "File Select";
            // 
            // tbFileSelect
            // 
            this.tbFileSelect.Location = new System.Drawing.Point(149, 139);
            this.tbFileSelect.Margin = new System.Windows.Forms.Padding(4);
            this.tbFileSelect.Name = "tbFileSelect";
            this.tbFileSelect.Size = new System.Drawing.Size(265, 22);
            this.tbFileSelect.TabIndex = 8;
            // 
            // label_Savepath
            // 
            this.label_Savepath.AutoSize = true;
            this.label_Savepath.Location = new System.Drawing.Point(13, 111);
            this.label_Savepath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Savepath.Name = "label_Savepath";
            this.label_Savepath.Size = new System.Drawing.Size(73, 17);
            this.label_Savepath.TabIndex = 7;
            this.label_Savepath.Text = "Save Path";
            // 
            // tbSavePath
            // 
            this.tbSavePath.Location = new System.Drawing.Point(149, 102);
            this.tbSavePath.Margin = new System.Windows.Forms.Padding(4);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.Size = new System.Drawing.Size(265, 22);
            this.tbSavePath.TabIndex = 3;
            // 
            // label_ProjectPath
            // 
            this.label_ProjectPath.AutoSize = true;
            this.label_ProjectPath.Location = new System.Drawing.Point(13, 79);
            this.label_ProjectPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ProjectPath.Name = "label_ProjectPath";
            this.label_ProjectPath.Size = new System.Drawing.Size(85, 17);
            this.label_ProjectPath.TabIndex = 6;
            this.label_ProjectPath.Text = "Project Path";
            // 
            // Btn_UpdateConfig
            // 
            this.Btn_UpdateConfig.Location = new System.Drawing.Point(149, 177);
            this.Btn_UpdateConfig.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UpdateConfig.Name = "Btn_UpdateConfig";
            this.Btn_UpdateConfig.Size = new System.Drawing.Size(267, 37);
            this.Btn_UpdateConfig.TabIndex = 1;
            this.Btn_UpdateConfig.Text = "Update Config";
            this.Btn_UpdateConfig.UseVisualStyleBackColor = true;
            // 
            // label_GitExePath
            // 
            this.label_GitExePath.AutoSize = true;
            this.label_GitExePath.Location = new System.Drawing.Point(13, 46);
            this.label_GitExePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GitExePath.Name = "label_GitExePath";
            this.label_GitExePath.Size = new System.Drawing.Size(86, 17);
            this.label_GitExePath.TabIndex = 5;
            this.label_GitExePath.Text = "Git Exe Path";
            // 
            // tbGitExePath
            // 
            this.tbGitExePath.Location = new System.Drawing.Point(149, 38);
            this.tbGitExePath.Margin = new System.Windows.Forms.Padding(4);
            this.tbGitExePath.Name = "tbGitExePath";
            this.tbGitExePath.Size = new System.Drawing.Size(265, 22);
            this.tbGitExePath.TabIndex = 2;
            // 
            // tbProjectPath
            // 
            this.tbProjectPath.Location = new System.Drawing.Point(149, 70);
            this.tbProjectPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbProjectPath.Name = "tbProjectPath";
            this.tbProjectPath.Size = new System.Drawing.Size(265, 22);
            this.tbProjectPath.TabIndex = 4;
            // 
            // btnGeneratePackage
            // 
            this.btnGeneratePackage.Enabled = false;
            this.btnGeneratePackage.Location = new System.Drawing.Point(29, 434);
            this.btnGeneratePackage.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeneratePackage.Name = "btnGeneratePackage";
            this.btnGeneratePackage.Size = new System.Drawing.Size(399, 37);
            this.btnGeneratePackage.TabIndex = 17;
            this.btnGeneratePackage.Text = "Generate Package";
            this.btnGeneratePackage.UseVisualStyleBackColor = true;
            // 
            // btnGetFile
            // 
            this.btnGetFile.Location = new System.Drawing.Point(29, 390);
            this.btnGetFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(399, 37);
            this.btnGetFile.TabIndex = 16;
            this.btnGetFile.Text = "GetFile";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBox_Result);
            this.groupBox3.Location = new System.Drawing.Point(487, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(734, 434);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // checkedListBox_Result
            // 
            this.checkedListBox_Result.FormattingEnabled = true;
            this.checkedListBox_Result.Location = new System.Drawing.Point(8, 23);
            this.checkedListBox_Result.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox_Result.Name = "checkedListBox_Result";
            this.checkedListBox_Result.Size = new System.Drawing.Size(718, 378);
            this.checkedListBox_Result.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 511);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGeneratePackage);
            this.Controls.Add(this.btnGetFile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_Commit2;
        private System.Windows.Forms.TextBox tbEndCommit;
        private System.Windows.Forms.Label label_Commit1;
        private System.Windows.Forms.TextBox tbBeginCommit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_IncludeDirectory;
        private System.Windows.Forms.Label label_IncludeFileTypes;
        private System.Windows.Forms.TextBox tbFileSelect;
        private System.Windows.Forms.Label label_Savepath;
        private System.Windows.Forms.TextBox tbSavePath;
        private System.Windows.Forms.Label label_ProjectPath;
        private System.Windows.Forms.Button Btn_UpdateConfig;
        private System.Windows.Forms.Label label_GitExePath;
        private System.Windows.Forms.TextBox tbGitExePath;
        private System.Windows.Forms.TextBox tbProjectPath;
        private System.Windows.Forms.Button btnGeneratePackage;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox_Result;
    }
}

