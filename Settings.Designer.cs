namespace CodeGenerator
{
    partial class Settings
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
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDefaultNameSpace = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveProjectPath = new System.Windows.Forms.Button();
            this.btnSaveFilePath = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtContentPlaceHolder = new System.Windows.Forms.TextBox();
            this.txtMasterPage = new System.Windows.Forms.TextBox();
            this.txtSaveProjectPath = new System.Windows.Forms.TextBox();
            this.txtSaveFilePath = new System.Windows.Forms.TextBox();
            this.txtDalNamespace = new System.Windows.Forms.TextBox();
            this.txtFacadeNamespace = new System.Windows.Forms.TextBox();
            this.txtBolNamespace = new System.Windows.Forms.TextBox();
            this.txtDataStructureNamespace = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.label3);
            this.gbMain.Controls.Add(this.txtDefaultNameSpace);
            this.gbMain.Controls.Add(this.btnClose);
            this.gbMain.Controls.Add(this.btnSaveProjectPath);
            this.gbMain.Controls.Add(this.btnSaveFilePath);
            this.gbMain.Controls.Add(this.btnSave);
            this.gbMain.Controls.Add(this.txtContentPlaceHolder);
            this.gbMain.Controls.Add(this.txtMasterPage);
            this.gbMain.Controls.Add(this.txtSaveProjectPath);
            this.gbMain.Controls.Add(this.txtSaveFilePath);
            this.gbMain.Controls.Add(this.txtDalNamespace);
            this.gbMain.Controls.Add(this.txtFacadeNamespace);
            this.gbMain.Controls.Add(this.txtBolNamespace);
            this.gbMain.Controls.Add(this.txtDataStructureNamespace);
            this.gbMain.Controls.Add(this.lbl7);
            this.gbMain.Controls.Add(this.lbl1);
            this.gbMain.Controls.Add(this.lbl5);
            this.gbMain.Controls.Add(this.lbl6);
            this.gbMain.Controls.Add(this.lbl4);
            this.gbMain.Controls.Add(this.lbl2);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(495, 288);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "DefaultNamespace :";
            // 
            // txtDefaultNameSpace
            // 
            this.txtDefaultNameSpace.Location = new System.Drawing.Point(156, 15);
            this.txtDefaultNameSpace.Name = "txtDefaultNameSpace";
            this.txtDefaultNameSpace.Size = new System.Drawing.Size(292, 20);
            this.txtDefaultNameSpace.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(260, 253);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveProjectPath
            // 
            this.btnSaveProjectPath.Location = new System.Drawing.Point(450, 166);
            this.btnSaveProjectPath.Name = "btnSaveProjectPath";
            this.btnSaveProjectPath.Size = new System.Drawing.Size(29, 23);
            this.btnSaveProjectPath.TabIndex = 7;
            this.btnSaveProjectPath.Text = "...";
            this.btnSaveProjectPath.UseVisualStyleBackColor = true;
            this.btnSaveProjectPath.Click += new System.EventHandler(this.btnSaveProjectPath_Click);
            // 
            // btnSaveFilePath
            // 
            this.btnSaveFilePath.Location = new System.Drawing.Point(450, 141);
            this.btnSaveFilePath.Name = "btnSaveFilePath";
            this.btnSaveFilePath.Size = new System.Drawing.Size(29, 23);
            this.btnSaveFilePath.TabIndex = 5;
            this.btnSaveFilePath.Text = "...";
            this.btnSaveFilePath.UseVisualStyleBackColor = true;
            this.btnSaveFilePath.Click += new System.EventHandler(this.btnSaveFilePath_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(179, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtContentPlaceHolder
            // 
            this.txtContentPlaceHolder.Location = new System.Drawing.Point(156, 217);
            this.txtContentPlaceHolder.Name = "txtContentPlaceHolder";
            this.txtContentPlaceHolder.Size = new System.Drawing.Size(292, 20);
            this.txtContentPlaceHolder.TabIndex = 9;
            // 
            // txtMasterPage
            // 
            this.txtMasterPage.Location = new System.Drawing.Point(156, 191);
            this.txtMasterPage.Name = "txtMasterPage";
            this.txtMasterPage.Size = new System.Drawing.Size(292, 20);
            this.txtMasterPage.TabIndex = 8;
            // 
            // txtSaveProjectPath
            // 
            this.txtSaveProjectPath.Location = new System.Drawing.Point(156, 166);
            this.txtSaveProjectPath.Name = "txtSaveProjectPath";
            this.txtSaveProjectPath.Size = new System.Drawing.Size(292, 20);
            this.txtSaveProjectPath.TabIndex = 6;
            // 
            // txtSaveFilePath
            // 
            this.txtSaveFilePath.Location = new System.Drawing.Point(156, 141);
            this.txtSaveFilePath.Name = "txtSaveFilePath";
            this.txtSaveFilePath.Size = new System.Drawing.Size(292, 20);
            this.txtSaveFilePath.TabIndex = 4;
            // 
            // txtDalNamespace
            // 
            this.txtDalNamespace.Location = new System.Drawing.Point(156, 116);
            this.txtDalNamespace.Name = "txtDalNamespace";
            this.txtDalNamespace.Size = new System.Drawing.Size(292, 20);
            this.txtDalNamespace.TabIndex = 3;
            // 
            // txtFacadeNamespace
            // 
            this.txtFacadeNamespace.Location = new System.Drawing.Point(156, 91);
            this.txtFacadeNamespace.Name = "txtFacadeNamespace";
            this.txtFacadeNamespace.Size = new System.Drawing.Size(292, 20);
            this.txtFacadeNamespace.TabIndex = 2;
            // 
            // txtBolNamespace
            // 
            this.txtBolNamespace.Location = new System.Drawing.Point(156, 66);
            this.txtBolNamespace.Name = "txtBolNamespace";
            this.txtBolNamespace.Size = new System.Drawing.Size(292, 20);
            this.txtBolNamespace.TabIndex = 1;
            // 
            // txtDataStructureNamespace
            // 
            this.txtDataStructureNamespace.Location = new System.Drawing.Point(156, 41);
            this.txtDataStructureNamespace.Name = "txtDataStructureNamespace";
            this.txtDataStructureNamespace.Size = new System.Drawing.Size(292, 20);
            this.txtDataStructureNamespace.TabIndex = 0;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(6, 219);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(119, 13);
            this.lbl7.TabIndex = 7;
            this.lbl7.Text = "ContentPlaceHolderID :";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 194);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(98, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Master Page URL :";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(6, 144);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(82, 13);
            this.lbl5.TabIndex = 5;
            this.lbl5.Text = "Save File Path :";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(6, 169);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(99, 13);
            this.lbl6.TabIndex = 4;
            this.lbl6.Text = "Save Project Path :";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(6, 119);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(96, 13);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "DAL NameSpace :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(6, 94);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(111, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Facade NameSpace :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BOL NameSpace :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Structure NameSpace :";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 312);
            this.Controls.Add(this.gbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtBolNamespace;
        private System.Windows.Forms.TextBox txtDataStructureNamespace;
        private System.Windows.Forms.Button btnSaveProjectPath;
        private System.Windows.Forms.Button btnSaveFilePath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtContentPlaceHolder;
        private System.Windows.Forms.TextBox txtMasterPage;
        private System.Windows.Forms.TextBox txtSaveProjectPath;
        private System.Windows.Forms.TextBox txtSaveFilePath;
        private System.Windows.Forms.TextBox txtDalNamespace;
        private System.Windows.Forms.TextBox txtFacadeNamespace;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDefaultNameSpace;
    }
}