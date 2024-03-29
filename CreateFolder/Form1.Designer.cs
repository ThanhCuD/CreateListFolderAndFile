﻿namespace CreateFolder
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
            this.tbSearchSourceSmaller = new System.Windows.Forms.TextBox();
            this.cbEndCommit = new System.Windows.Forms.ComboBox();
            this.cbBeginCommit = new System.Windows.Forms.ComboBox();
            this.label_Commit2 = new System.Windows.Forms.Label();
            this.label_Commit1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCAAS = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumtake = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkListBox_Package = new System.Windows.Forms.CheckedListBox();
            this.bt_OpenSavePath = new System.Windows.Forms.Button();
            this.btCleanSaveFolder = new System.Windows.Forms.Button();
            this.bt_copy_address = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSearchSourceSmaller);
            this.groupBox2.Controls.Add(this.cbEndCommit);
            this.groupBox2.Controls.Add(this.cbBeginCommit);
            this.groupBox2.Controls.Add(this.label_Commit2);
            this.groupBox2.Controls.Add(this.label_Commit1);
            this.groupBox2.Location = new System.Drawing.Point(10, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 87);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Commit";
            // 
            // tbSearchSourceSmaller
            // 
            this.tbSearchSourceSmaller.Location = new System.Drawing.Point(190, 28);
            this.tbSearchSourceSmaller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearchSourceSmaller.Name = "tbSearchSourceSmaller";
            this.tbSearchSourceSmaller.Size = new System.Drawing.Size(123, 20);
            this.tbSearchSourceSmaller.TabIndex = 20;
            // 
            // cbEndCommit
            // 
            this.cbEndCommit.FormattingEnabled = true;
            this.cbEndCommit.Location = new System.Drawing.Point(112, 54);
            this.cbEndCommit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEndCommit.Name = "cbEndCommit";
            this.cbEndCommit.Size = new System.Drawing.Size(201, 21);
            this.cbEndCommit.TabIndex = 19;
            // 
            // cbBeginCommit
            // 
            this.cbBeginCommit.FormattingEnabled = true;
            this.cbBeginCommit.Location = new System.Drawing.Point(112, 28);
            this.cbBeginCommit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBeginCommit.Name = "cbBeginCommit";
            this.cbBeginCommit.Size = new System.Drawing.Size(66, 21);
            this.cbBeginCommit.TabIndex = 14;
            // 
            // label_Commit2
            // 
            this.label_Commit2.AutoSize = true;
            this.label_Commit2.Location = new System.Drawing.Point(10, 57);
            this.label_Commit2.Name = "label_Commit2";
            this.label_Commit2.Size = new System.Drawing.Size(74, 13);
            this.label_Commit2.TabIndex = 13;
            this.label_Commit2.Text = "Bigger Commit";
            // 
            // label_Commit1
            // 
            this.label_Commit1.AutoSize = true;
            this.label_Commit1.Location = new System.Drawing.Point(10, 31);
            this.label_Commit1.Name = "label_Commit1";
            this.label_Commit1.Size = new System.Drawing.Size(78, 13);
            this.label_Commit1.TabIndex = 8;
            this.label_Commit1.Text = "Smaller Commit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCAAS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNumtake);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_IncludeFileTypes);
            this.groupBox1.Controls.Add(this.tbFileSelect);
            this.groupBox1.Controls.Add(this.label_Savepath);
            this.groupBox1.Controls.Add(this.tbSavePath);
            this.groupBox1.Controls.Add(this.label_ProjectPath);
            this.groupBox1.Controls.Add(this.Btn_UpdateConfig);
            this.groupBox1.Controls.Add(this.label_GitExePath);
            this.groupBox1.Controls.Add(this.tbGitExePath);
            this.groupBox1.Controls.Add(this.tbProjectPath);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 240);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // cbCAAS
            // 
            this.cbCAAS.AutoSize = true;
            this.cbCAAS.Location = new System.Drawing.Point(189, 147);
            this.cbCAAS.Name = "cbCAAS";
            this.cbCAAS.Size = new System.Drawing.Size(54, 17);
            this.cbCAAS.TabIndex = 14;
            this.cbCAAS.Text = "CAAS";
            this.cbCAAS.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // tbNumtake
            // 
            this.tbNumtake.Location = new System.Drawing.Point(112, 145);
            this.tbNumtake.Name = "tbNumtake";
            this.tbNumtake.Size = new System.Drawing.Size(27, 20);
            this.tbNumtake.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number Commit";
            // 
            // label_IncludeFileTypes
            // 
            this.label_IncludeFileTypes.AutoSize = true;
            this.label_IncludeFileTypes.Location = new System.Drawing.Point(10, 117);
            this.label_IncludeFileTypes.Name = "label_IncludeFileTypes";
            this.label_IncludeFileTypes.Size = new System.Drawing.Size(56, 13);
            this.label_IncludeFileTypes.TabIndex = 9;
            this.label_IncludeFileTypes.Text = "File Select";
            // 
            // tbFileSelect
            // 
            this.tbFileSelect.Location = new System.Drawing.Point(112, 113);
            this.tbFileSelect.Name = "tbFileSelect";
            this.tbFileSelect.Size = new System.Drawing.Size(200, 20);
            this.tbFileSelect.TabIndex = 8;
            // 
            // label_Savepath
            // 
            this.label_Savepath.AutoSize = true;
            this.label_Savepath.Location = new System.Drawing.Point(10, 90);
            this.label_Savepath.Name = "label_Savepath";
            this.label_Savepath.Size = new System.Drawing.Size(57, 13);
            this.label_Savepath.TabIndex = 7;
            this.label_Savepath.Text = "Save Path";
            // 
            // tbSavePath
            // 
            this.tbSavePath.Location = new System.Drawing.Point(112, 83);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.Size = new System.Drawing.Size(200, 20);
            this.tbSavePath.TabIndex = 3;
            // 
            // label_ProjectPath
            // 
            this.label_ProjectPath.AutoSize = true;
            this.label_ProjectPath.Location = new System.Drawing.Point(10, 64);
            this.label_ProjectPath.Name = "label_ProjectPath";
            this.label_ProjectPath.Size = new System.Drawing.Size(65, 13);
            this.label_ProjectPath.TabIndex = 6;
            this.label_ProjectPath.Text = "Project Path";
            // 
            // Btn_UpdateConfig
            // 
            this.Btn_UpdateConfig.Location = new System.Drawing.Point(26, 189);
            this.Btn_UpdateConfig.Name = "Btn_UpdateConfig";
            this.Btn_UpdateConfig.Size = new System.Drawing.Size(272, 27);
            this.Btn_UpdateConfig.TabIndex = 1;
            this.Btn_UpdateConfig.Text = "Update Config";
            this.Btn_UpdateConfig.UseVisualStyleBackColor = true;
            this.Btn_UpdateConfig.Click += new System.EventHandler(this.Btn_UpdateConfig_Click);
            // 
            // label_GitExePath
            // 
            this.label_GitExePath.AutoSize = true;
            this.label_GitExePath.Location = new System.Drawing.Point(10, 37);
            this.label_GitExePath.Name = "label_GitExePath";
            this.label_GitExePath.Size = new System.Drawing.Size(66, 13);
            this.label_GitExePath.TabIndex = 5;
            this.label_GitExePath.Text = "Git Exe Path";
            // 
            // tbGitExePath
            // 
            this.tbGitExePath.Location = new System.Drawing.Point(112, 31);
            this.tbGitExePath.Name = "tbGitExePath";
            this.tbGitExePath.Size = new System.Drawing.Size(200, 20);
            this.tbGitExePath.TabIndex = 2;
            // 
            // tbProjectPath
            // 
            this.tbProjectPath.Location = new System.Drawing.Point(112, 57);
            this.tbProjectPath.Name = "tbProjectPath";
            this.tbProjectPath.Size = new System.Drawing.Size(200, 20);
            this.tbProjectPath.TabIndex = 4;
            // 
            // btnGeneratePackage
            // 
            this.btnGeneratePackage.Enabled = false;
            this.btnGeneratePackage.Location = new System.Drawing.Point(22, 433);
            this.btnGeneratePackage.Name = "btnGeneratePackage";
            this.btnGeneratePackage.Size = new System.Drawing.Size(299, 30);
            this.btnGeneratePackage.TabIndex = 17;
            this.btnGeneratePackage.Text = "Generate Package";
            this.btnGeneratePackage.UseVisualStyleBackColor = true;
            this.btnGeneratePackage.Click += new System.EventHandler(this.btnGeneratePackage_Click);
            // 
            // btnGetFile
            // 
            this.btnGetFile.Location = new System.Drawing.Point(22, 397);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(299, 30);
            this.btnGetFile.TabIndex = 16;
            this.btnGetFile.Text = "GetFile";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBox_Result);
            this.groupBox3.Location = new System.Drawing.Point(365, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 264);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // checkedListBox_Result
            // 
            this.checkedListBox_Result.FormattingEnabled = true;
            this.checkedListBox_Result.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox_Result.Name = "checkedListBox_Result";
            this.checkedListBox_Result.Size = new System.Drawing.Size(744, 214);
            this.checkedListBox_Result.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkListBox_Package);
            this.groupBox4.Location = new System.Drawing.Point(365, 304);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(760, 295);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results";
            // 
            // checkListBox_Package
            // 
            this.checkListBox_Package.FormattingEnabled = true;
            this.checkListBox_Package.Location = new System.Drawing.Point(6, 19);
            this.checkListBox_Package.Name = "checkListBox_Package";
            this.checkListBox_Package.Size = new System.Drawing.Size(744, 244);
            this.checkListBox_Package.TabIndex = 14;
            // 
            // bt_OpenSavePath
            // 
            this.bt_OpenSavePath.Enabled = false;
            this.bt_OpenSavePath.Location = new System.Drawing.Point(22, 470);
            this.bt_OpenSavePath.Name = "bt_OpenSavePath";
            this.bt_OpenSavePath.Size = new System.Drawing.Size(299, 30);
            this.bt_OpenSavePath.TabIndex = 20;
            this.bt_OpenSavePath.Text = "Open Save Path";
            this.bt_OpenSavePath.UseVisualStyleBackColor = true;
            this.bt_OpenSavePath.Click += new System.EventHandler(this.bt_OpenSavePath_Click);
            // 
            // btCleanSaveFolder
            // 
            this.btCleanSaveFolder.Location = new System.Drawing.Point(22, 506);
            this.btCleanSaveFolder.Name = "btCleanSaveFolder";
            this.btCleanSaveFolder.Size = new System.Drawing.Size(299, 30);
            this.btCleanSaveFolder.TabIndex = 21;
            this.btCleanSaveFolder.Text = "Clean Save Folder";
            this.btCleanSaveFolder.UseVisualStyleBackColor = true;
            this.btCleanSaveFolder.Click += new System.EventHandler(this.btCleanSaveFolder_Click);
            // 
            // bt_copy_address
            // 
            this.bt_copy_address.Location = new System.Drawing.Point(21, 543);
            this.bt_copy_address.Name = "bt_copy_address";
            this.bt_copy_address.Size = new System.Drawing.Size(299, 30);
            this.bt_copy_address.TabIndex = 22;
            this.bt_copy_address.Text = "Copy Address File";
            this.bt_copy_address.UseVisualStyleBackColor = true;
            this.bt_copy_address.Click += new System.EventHandler(this.bt_copy_address_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 609);
            this.Controls.Add(this.bt_copy_address);
            this.Controls.Add(this.btCleanSaveFolder);
            this.Controls.Add(this.bt_OpenSavePath);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGeneratePackage);
            this.Controls.Add(this.btnGetFile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_Commit2;
        private System.Windows.Forms.Label label_Commit1;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.ComboBox cbBeginCommit;
        private System.Windows.Forms.ComboBox cbEndCommit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumtake;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox checkListBox_Package;
        private System.Windows.Forms.Button bt_OpenSavePath;
        private System.Windows.Forms.Button btCleanSaveFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_copy_address;
        private System.Windows.Forms.CheckBox cbCAAS;
        private System.Windows.Forms.TextBox tbSearchSourceSmaller;
    }
}

