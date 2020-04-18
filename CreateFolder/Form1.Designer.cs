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
            this.txtAddressSave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddRoot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdsChild = new System.Windows.Forms.TextBox();
            this.btMake = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bt_Choose_Save = new System.Windows.Forms.Button();
            this.bt_ChooseRoot = new System.Windows.Forms.Button();
            this.bt_ChooseChild = new System.Windows.Forms.Button();
            this.bt_Choose_Files = new System.Windows.Forms.Button();
            this.btConfig = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRootName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAddressSave
            // 
            this.txtAddressSave.Location = new System.Drawing.Point(192, 58);
            this.txtAddressSave.Name = "txtAddressSave";
            this.txtAddressSave.Size = new System.Drawing.Size(477, 22);
            this.txtAddressSave.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "AdressSave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "AddressRootFolder";
            // 
            // txtAddRoot
            // 
            this.txtAddRoot.Location = new System.Drawing.Point(192, 123);
            this.txtAddRoot.Name = "txtAddRoot";
            this.txtAddRoot.Size = new System.Drawing.Size(477, 22);
            this.txtAddRoot.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "AddressFinalChildFolder";
            // 
            // txtAdsChild
            // 
            this.txtAdsChild.Location = new System.Drawing.Point(192, 182);
            this.txtAdsChild.Name = "txtAdsChild";
            this.txtAdsChild.Size = new System.Drawing.Size(477, 22);
            this.txtAdsChild.TabIndex = 4;
            // 
            // btMake
            // 
            this.btMake.Location = new System.Drawing.Point(192, 280);
            this.btMake.Name = "btMake";
            this.btMake.Size = new System.Drawing.Size(477, 23);
            this.btMake.TabIndex = 6;
            this.btMake.Text = "Make It";
            this.btMake.UseVisualStyleBackColor = true;
            this.btMake.Click += new System.EventHandler(this.btMake_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bt_Choose_Save
            // 
            this.bt_Choose_Save.Location = new System.Drawing.Point(688, 57);
            this.bt_Choose_Save.Name = "bt_Choose_Save";
            this.bt_Choose_Save.Size = new System.Drawing.Size(128, 23);
            this.bt_Choose_Save.TabIndex = 7;
            this.bt_Choose_Save.Text = "Choose";
            this.bt_Choose_Save.UseVisualStyleBackColor = true;
            this.bt_Choose_Save.Click += new System.EventHandler(this.bt_Choose_Save_Click);
            // 
            // bt_ChooseRoot
            // 
            this.bt_ChooseRoot.Location = new System.Drawing.Point(688, 122);
            this.bt_ChooseRoot.Name = "bt_ChooseRoot";
            this.bt_ChooseRoot.Size = new System.Drawing.Size(128, 23);
            this.bt_ChooseRoot.TabIndex = 8;
            this.bt_ChooseRoot.Text = "Choose";
            this.bt_ChooseRoot.UseVisualStyleBackColor = true;
            this.bt_ChooseRoot.Click += new System.EventHandler(this.bt_ChooseRoot_Click);
            // 
            // bt_ChooseChild
            // 
            this.bt_ChooseChild.Location = new System.Drawing.Point(688, 182);
            this.bt_ChooseChild.Name = "bt_ChooseChild";
            this.bt_ChooseChild.Size = new System.Drawing.Size(128, 23);
            this.bt_ChooseChild.TabIndex = 9;
            this.bt_ChooseChild.Text = "ChooseAddress";
            this.bt_ChooseChild.UseVisualStyleBackColor = true;
            this.bt_ChooseChild.Click += new System.EventHandler(this.bt_ChooseChild_Click);
            // 
            // bt_Choose_Files
            // 
            this.bt_Choose_Files.Location = new System.Drawing.Point(688, 230);
            this.bt_Choose_Files.Name = "bt_Choose_Files";
            this.bt_Choose_Files.Size = new System.Drawing.Size(128, 23);
            this.bt_Choose_Files.TabIndex = 10;
            this.bt_Choose_Files.Text = "ChooseFile";
            this.bt_Choose_Files.UseVisualStyleBackColor = true;
            this.bt_Choose_Files.Click += new System.EventHandler(this.bt_Choose_Files_Click);
            // 
            // btConfig
            // 
            this.btConfig.Location = new System.Drawing.Point(192, 12);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(477, 23);
            this.btConfig.TabIndex = 11;
            this.btConfig.Text = "Config";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Root Name";
            // 
            // txtRootName
            // 
            this.txtRootName.Location = new System.Drawing.Point(192, 228);
            this.txtRootName.Name = "txtRootName";
            this.txtRootName.Size = new System.Drawing.Size(477, 22);
            this.txtRootName.TabIndex = 12;
            this.txtRootName.Text = "Website";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 323);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRootName);
            this.Controls.Add(this.btConfig);
            this.Controls.Add(this.bt_Choose_Files);
            this.Controls.Add(this.bt_ChooseChild);
            this.Controls.Add(this.bt_ChooseRoot);
            this.Controls.Add(this.bt_Choose_Save);
            this.Controls.Add(this.btMake);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdsChild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddRoot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddressSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddressSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddRoot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdsChild;
        private System.Windows.Forms.Button btMake;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bt_Choose_Save;
        private System.Windows.Forms.Button bt_ChooseRoot;
        private System.Windows.Forms.Button bt_ChooseChild;
        private System.Windows.Forms.Button bt_Choose_Files;
        private System.Windows.Forms.Button btConfig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRootName;
    }
}

