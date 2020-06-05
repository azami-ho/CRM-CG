using System.Data.SqlClient;

namespace CodeGenerator
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblProcessing = new System.Windows.Forms.ToolStripStatusLabel();
            this.prog = new System.Windows.Forms.ToolStripProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.saveBOFile = new System.Windows.Forms.SaveFileDialog();
            this.saveDalFile = new System.Windows.Forms.SaveFileDialog();
            this.saveFacadeFile = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTableQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label52 = new System.Windows.Forms.Label();
            this.cmbTableNames = new System.Windows.Forms.ComboBox();
            this.tabReact = new System.Windows.Forms.TabPage();
            this.txtCodeBehindReact = new System.Windows.Forms.RichTextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.BtnGenerateReact = new System.Windows.Forms.Button();
            this.BtnSaveFileToMvc = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.TxtTitleReact = new System.Windows.Forms.TextBox();
            this.BtnFieldSettingReact = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtSectionsMvc = new System.Windows.Forms.TextBox();
            this.CheckMasterMvc = new System.Windows.Forms.CheckBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.TxtlayoutMvc = new System.Windows.Forms.TextBox();
            this.viewGroup = new System.Windows.Forms.GroupBox();
            this.chListViewMvc = new System.Windows.Forms.CheckBox();
            this.chCreateViewMvc = new System.Windows.Forms.CheckBox();
            this.chEditViewMvc = new System.Windows.Forms.CheckBox();
            this.chDeleteViewMvc = new System.Windows.Forms.CheckBox();
            this.chDetailViewMvc = new System.Windows.Forms.CheckBox();
            this.chGenerateControllerMvc = new System.Windows.Forms.CheckBox();
            this.chUseResourceMvc = new System.Windows.Forms.CheckBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtComponentName = new System.Windows.Forms.TextBox();
            this.chGenerateViewsMvc = new System.Windows.Forms.CheckBox();
            this.tpFacade = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnGenerateFacade = new System.Windows.Forms.Button();
            this.btnCopyToClipboardFacade = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.drpFacadeAction = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txtFacadeMethodName = new System.Windows.Forms.TextBox();
            this.chWithFilterFacade = new System.Windows.Forms.CheckBox();
            this.chGenerateAllFacade = new System.Windows.Forms.CheckBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtDsNamespaceFacade = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtNamespaceFacade = new System.Windows.Forms.TextBox();
            this.chGenerateFacade = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFacadeParentClass = new System.Windows.Forms.TextBox();
            this.rtbFacade = new System.Windows.Forms.RichTextBox();
            this.tpBOL = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerateSP = new System.Windows.Forms.Button();
            this.btnCopyToClipboardSP = new System.Windows.Forms.Button();
            this.chGenerateAllBol = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtNamespaceBol = new System.Windows.Forms.TextBox();
            this.chGenerateBOLClass = new System.Windows.Forms.CheckBox();
            this.rtbBol = new System.Windows.Forms.RichTextBox();
            this.tpDAL = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGenerateMethodDAL = new System.Windows.Forms.Button();
            this.btnCopyToclipboardMethodDAl = new System.Windows.Forms.Button();
            this.cbClassModifierMethod = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chGenerateDataProvider = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNamespaceDAL = new System.Windows.Forms.TextBox();
            this.SaveToDalFile = new System.Windows.Forms.Button();
            this.rtbMethodDAl = new System.Windows.Forms.RichTextBox();
            this.tpClass = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerateClass = new System.Windows.Forms.Button();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.cbClassModifier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chAllClass = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdsNamespaceClass = new System.Windows.Forms.TextBox();
            this.rtbClass = new System.Windows.Forms.RichTextBox();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabReact.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.viewGroup.SuspendLayout();
            this.tpFacade.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tpBOL.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpDAL.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tpClass.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "cs";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.SupportMultiDottedExtensions = true;
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 69);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Generate Collection";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(527, 16);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "partial";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Property Modifier :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Class Modifier :";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "public",
            "internal",
            "private",
            "protected",
            "internal protected",
            "static",
            "internal static"});
            this.comboBox1.Location = new System.Drawing.Point(395, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "public sealed",
            "internal sealed",
            "public",
            "internal",
            "public abstract",
            "internal abstract",
            "public static",
            "internal static"});
            this.comboBox2.Location = new System.Drawing.Point(395, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(126, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(495, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save To File";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(376, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Copy to clipboard";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(295, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(80, 13);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(202, 21);
            this.comboBox3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Table Name :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblProcessing,
            this.prog});
            this.statusStrip1.Location = new System.Drawing.Point(0, 507);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(728, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblProcessing
            // 
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(39, 17);
            this.lblProcessing.Text = "Ready";
            // 
            // prog
            // 
            this.prog.Name = "prog";
            this.prog.Size = new System.Drawing.Size(300, 16);
            this.prog.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(528, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "BOL Namespace :";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(528, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 25;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(443, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(79, 13);
            this.label30.TabIndex = 26;
            this.label30.Text = "Object\'s prefix :";
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(528, 66);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(123, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Generate BOL Layer";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(196, 41);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(73, 17);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "With Filter";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 71);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(74, 13);
            this.label31.TabIndex = 9;
            this.label31.Text = "Mthod Name :";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Get",
            "Insert",
            "Update",
            "Delete"});
            this.comboBox4.Location = new System.Drawing.Point(80, 40);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(88, 21);
            this.comboBox4.TabIndex = 1;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 42);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(46, 13);
            this.label32.TabIndex = 7;
            this.label32.Text = "Action : ";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(596, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Copy to clipboard";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(522, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Generate";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(80, 13);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(311, 21);
            this.comboBox5.TabIndex = 0;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 16);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(71, 13);
            this.label33.TabIndex = 0;
            this.label33.Text = "Table Name :";
            // 
            // saveBOFile
            // 
            this.saveBOFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveBOFile_FileOk);
            // 
            // saveDalFile
            // 
            this.saveDalFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveDalFile_FileOk);
            // 
            // saveFacadeFile
            // 
            this.saveFacadeFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFacadeFile_FileOk);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 30);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.refreshTablesToolStripMenuItem,
            this.changeTableQueryToolStripMenuItem,
            this.changeDatabaseToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem1.Text = "Setting";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.settingsToolStripMenuItem.Text = "Change Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.mnSettings_Click);
            // 
            // refreshTablesToolStripMenuItem
            // 
            this.refreshTablesToolStripMenuItem.Name = "refreshTablesToolStripMenuItem";
            this.refreshTablesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshTablesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.refreshTablesToolStripMenuItem.Text = "Refresh Tables";
            this.refreshTablesToolStripMenuItem.Click += new System.EventHandler(this.mnRefreshTables_Click);
            // 
            // changeTableQueryToolStripMenuItem
            // 
            this.changeTableQueryToolStripMenuItem.Name = "changeTableQueryToolStripMenuItem";
            this.changeTableQueryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.changeTableQueryToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.changeTableQueryToolStripMenuItem.Text = "Change &Table Query";
            this.changeTableQueryToolStripMenuItem.Click += new System.EventHandler(this.mnChangeTableQuery_Click);
            // 
            // changeDatabaseToolStripMenuItem
            // 
            this.changeDatabaseToolStripMenuItem.Name = "changeDatabaseToolStripMenuItem";
            this.changeDatabaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.changeDatabaseToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.changeDatabaseToolStripMenuItem.Text = "Change &Database";
            this.changeDatabaseToolStripMenuItem.Click += new System.EventHandler(this.mnChangeDatabase_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(7, 37);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(70, 13);
            this.label52.TabIndex = 2;
            this.label52.Text = "Table Name :";
            // 
            // cmbTableNames
            // 
            this.cmbTableNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTableNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableNames.FormattingEnabled = true;
            this.cmbTableNames.Location = new System.Drawing.Point(83, 34);
            this.cmbTableNames.Name = "cmbTableNames";
            this.cmbTableNames.Size = new System.Drawing.Size(628, 21);
            this.cmbTableNames.TabIndex = 1;
            this.cmbTableNames.SelectedIndexChanged += new System.EventHandler(this.cmbTableNames_SelectedIndexChanged);
            // 
            // tabReact
            // 
            this.tabReact.BackColor = System.Drawing.Color.Tan;
            this.tabReact.Controls.Add(this.groupBox9);
            this.tabReact.Controls.Add(this.txtCodeBehindReact);
            this.tabReact.Location = new System.Drawing.Point(4, 22);
            this.tabReact.Name = "tabReact";
            this.tabReact.Padding = new System.Windows.Forms.Padding(3);
            this.tabReact.Size = new System.Drawing.Size(721, 442);
            this.tabReact.TabIndex = 6;
            this.tabReact.Text = "React";
            // 
            // txtCodeBehindReact
            // 
            this.txtCodeBehindReact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeBehindReact.BackColor = System.Drawing.Color.GhostWhite;
            this.txtCodeBehindReact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeBehindReact.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCodeBehindReact.Location = new System.Drawing.Point(8, 211);
            this.txtCodeBehindReact.Name = "txtCodeBehindReact";
            this.txtCodeBehindReact.Size = new System.Drawing.Size(704, 225);
            this.txtCodeBehindReact.TabIndex = 3;
            this.txtCodeBehindReact.Text = "";
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.chGenerateViewsMvc);
            this.groupBox9.Controls.Add(this.txtComponentName);
            this.groupBox9.Controls.Add(this.label45);
            this.groupBox9.Controls.Add(this.chUseResourceMvc);
            this.groupBox9.Controls.Add(this.chGenerateControllerMvc);
            this.groupBox9.Controls.Add(this.viewGroup);
            this.groupBox9.Controls.Add(this.groupBox8);
            this.groupBox9.Controls.Add(this.BtnFieldSettingReact);
            this.groupBox9.Controls.Add(this.TxtTitleReact);
            this.groupBox9.Controls.Add(this.label47);
            this.groupBox9.Controls.Add(this.BtnSaveFileToMvc);
            this.groupBox9.Controls.Add(this.BtnGenerateReact);
            this.groupBox9.Location = new System.Drawing.Point(3, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(707, 199);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            // 
            // BtnGenerateReact
            // 
            this.BtnGenerateReact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenerateReact.Location = new System.Drawing.Point(597, 94);
            this.BtnGenerateReact.Name = "BtnGenerateReact";
            this.BtnGenerateReact.Size = new System.Drawing.Size(102, 23);
            this.BtnGenerateReact.TabIndex = 8;
            this.BtnGenerateReact.Text = "Generate";
            this.BtnGenerateReact.UseVisualStyleBackColor = true;
            this.BtnGenerateReact.Click += new System.EventHandler(this.BtnGenerateReact_Click);
            // 
            // BtnSaveFileToMvc
            // 
            this.BtnSaveFileToMvc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaveFileToMvc.Enabled = false;
            this.BtnSaveFileToMvc.Location = new System.Drawing.Point(597, 123);
            this.BtnSaveFileToMvc.Name = "BtnSaveFileToMvc";
            this.BtnSaveFileToMvc.Size = new System.Drawing.Size(102, 23);
            this.BtnSaveFileToMvc.TabIndex = 9;
            this.BtnSaveFileToMvc.Text = "Save To File";
            this.BtnSaveFileToMvc.UseVisualStyleBackColor = true;
            this.BtnSaveFileToMvc.Click += new System.EventHandler(this.BtnSaveFileToMvc_Click);
            // 
            // label47
            // 
            this.label47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(491, 16);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(34, 13);
            this.label47.TabIndex = 12;
            this.label47.Text = "Title :";
            // 
            // TxtTitleReact
            // 
            this.TxtTitleReact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTitleReact.ForeColor = System.Drawing.Color.DarkRed;
            this.TxtTitleReact.Location = new System.Drawing.Point(530, 13);
            this.TxtTitleReact.Name = "TxtTitleReact";
            this.TxtTitleReact.Size = new System.Drawing.Size(169, 21);
            this.TxtTitleReact.TabIndex = 4;
            // 
            // BtnFieldSettingReact
            // 
            this.BtnFieldSettingReact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFieldSettingReact.Location = new System.Drawing.Point(597, 65);
            this.BtnFieldSettingReact.Name = "BtnFieldSettingReact";
            this.BtnFieldSettingReact.Size = new System.Drawing.Size(102, 23);
            this.BtnFieldSettingReact.TabIndex = 7;
            this.BtnFieldSettingReact.Text = "Fields Settings";
            this.BtnFieldSettingReact.UseVisualStyleBackColor = true;
            this.BtnFieldSettingReact.Click += new System.EventHandler(this.BtnFieldSettingReact_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.TxtlayoutMvc);
            this.groupBox8.Controls.Add(this.label40);
            this.groupBox8.Controls.Add(this.label44);
            this.groupBox8.Controls.Add(this.CheckMasterMvc);
            this.groupBox8.Controls.Add(this.txtSectionsMvc);
            this.groupBox8.Location = new System.Drawing.Point(3, 13);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(254, 99);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            // 
            // txtSectionsMvc
            // 
            this.txtSectionsMvc.Enabled = false;
            this.txtSectionsMvc.Location = new System.Drawing.Point(58, 50);
            this.txtSectionsMvc.Multiline = true;
            this.txtSectionsMvc.Name = "txtSectionsMvc";
            this.txtSectionsMvc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSectionsMvc.Size = new System.Drawing.Size(190, 43);
            this.txtSectionsMvc.TabIndex = 2;
            // 
            // CheckMasterMvc
            // 
            this.CheckMasterMvc.AutoSize = true;
            this.CheckMasterMvc.Location = new System.Drawing.Point(6, 7);
            this.CheckMasterMvc.Name = "CheckMasterMvc";
            this.CheckMasterMvc.Size = new System.Drawing.Size(86, 17);
            this.CheckMasterMvc.TabIndex = 0;
            this.CheckMasterMvc.Text = "Master Page";
            this.CheckMasterMvc.UseVisualStyleBackColor = true;
            this.CheckMasterMvc.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(3, 48);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(47, 13);
            this.label44.TabIndex = 17;
            this.label44.Text = "Sections";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(9, 24);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(44, 13);
            this.label40.TabIndex = 18;
            this.label40.Text = "Layout:";
            // 
            // TxtlayoutMvc
            // 
            this.TxtlayoutMvc.Enabled = false;
            this.TxtlayoutMvc.Location = new System.Drawing.Point(58, 24);
            this.TxtlayoutMvc.Name = "TxtlayoutMvc";
            this.TxtlayoutMvc.Size = new System.Drawing.Size(190, 21);
            this.TxtlayoutMvc.TabIndex = 1;
            // 
            // viewGroup
            // 
            this.viewGroup.Controls.Add(this.chDetailViewMvc);
            this.viewGroup.Controls.Add(this.chDeleteViewMvc);
            this.viewGroup.Controls.Add(this.chEditViewMvc);
            this.viewGroup.Controls.Add(this.chCreateViewMvc);
            this.viewGroup.Controls.Add(this.chListViewMvc);
            this.viewGroup.Location = new System.Drawing.Point(266, 94);
            this.viewGroup.Name = "viewGroup";
            this.viewGroup.Size = new System.Drawing.Size(313, 52);
            this.viewGroup.TabIndex = 13;
            this.viewGroup.TabStop = false;
            this.viewGroup.Text = "Actions";
            // 
            // chListViewMvc
            // 
            this.chListViewMvc.AutoSize = true;
            this.chListViewMvc.Checked = true;
            this.chListViewMvc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chListViewMvc.Location = new System.Drawing.Point(265, 16);
            this.chListViewMvc.Name = "chListViewMvc";
            this.chListViewMvc.Size = new System.Drawing.Size(42, 17);
            this.chListViewMvc.TabIndex = 20;
            this.chListViewMvc.Text = "List";
            this.chListViewMvc.UseVisualStyleBackColor = true;
            // 
            // chCreateViewMvc
            // 
            this.chCreateViewMvc.AutoSize = true;
            this.chCreateViewMvc.Checked = true;
            this.chCreateViewMvc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chCreateViewMvc.Location = new System.Drawing.Point(199, 16);
            this.chCreateViewMvc.Name = "chCreateViewMvc";
            this.chCreateViewMvc.Size = new System.Drawing.Size(59, 17);
            this.chCreateViewMvc.TabIndex = 21;
            this.chCreateViewMvc.Text = "Create";
            this.chCreateViewMvc.UseVisualStyleBackColor = true;
            // 
            // chEditViewMvc
            // 
            this.chEditViewMvc.AutoSize = true;
            this.chEditViewMvc.Checked = true;
            this.chEditViewMvc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chEditViewMvc.Location = new System.Drawing.Point(6, 16);
            this.chEditViewMvc.Name = "chEditViewMvc";
            this.chEditViewMvc.Size = new System.Drawing.Size(44, 17);
            this.chEditViewMvc.TabIndex = 22;
            this.chEditViewMvc.Text = "Edit";
            this.chEditViewMvc.UseVisualStyleBackColor = true;
            // 
            // chDeleteViewMvc
            // 
            this.chDeleteViewMvc.AutoSize = true;
            this.chDeleteViewMvc.Checked = true;
            this.chDeleteViewMvc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chDeleteViewMvc.Location = new System.Drawing.Point(127, 16);
            this.chDeleteViewMvc.Name = "chDeleteViewMvc";
            this.chDeleteViewMvc.Size = new System.Drawing.Size(57, 17);
            this.chDeleteViewMvc.TabIndex = 23;
            this.chDeleteViewMvc.Text = "Delete";
            this.chDeleteViewMvc.UseVisualStyleBackColor = true;
            // 
            // chDetailViewMvc
            // 
            this.chDetailViewMvc.AutoSize = true;
            this.chDetailViewMvc.Checked = true;
            this.chDetailViewMvc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chDetailViewMvc.Location = new System.Drawing.Point(68, 16);
            this.chDetailViewMvc.Name = "chDetailViewMvc";
            this.chDetailViewMvc.Size = new System.Drawing.Size(53, 17);
            this.chDetailViewMvc.TabIndex = 24;
            this.chDetailViewMvc.Text = "Detail";
            this.chDetailViewMvc.UseVisualStyleBackColor = true;
            // 
            // chGenerateControllerMvc
            // 
            this.chGenerateControllerMvc.AutoSize = true;
            this.chGenerateControllerMvc.Checked = true;
            this.chGenerateControllerMvc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chGenerateControllerMvc.Location = new System.Drawing.Point(471, 69);
            this.chGenerateControllerMvc.Name = "chGenerateControllerMvc";
            this.chGenerateControllerMvc.Size = new System.Drawing.Size(121, 17);
            this.chGenerateControllerMvc.TabIndex = 21;
            this.chGenerateControllerMvc.Text = "Generate Controller";
            this.chGenerateControllerMvc.UseVisualStyleBackColor = true;
            // 
            // chUseResourceMvc
            // 
            this.chUseResourceMvc.AutoSize = true;
            this.chUseResourceMvc.Checked = true;
            this.chUseResourceMvc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chUseResourceMvc.Location = new System.Drawing.Point(366, 69);
            this.chUseResourceMvc.Name = "chUseResourceMvc";
            this.chUseResourceMvc.Size = new System.Drawing.Size(97, 17);
            this.chUseResourceMvc.TabIndex = 22;
            this.chUseResourceMvc.Text = "Use Resources";
            this.chUseResourceMvc.UseVisualStyleBackColor = true;
            // 
            // label45
            // 
            this.label45.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(457, 42);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(69, 13);
            this.label45.TabIndex = 24;
            this.label45.Text = "Component :";
            // 
            // txtComponentName
            // 
            this.txtComponentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComponentName.ForeColor = System.Drawing.Color.DarkRed;
            this.txtComponentName.Location = new System.Drawing.Point(530, 39);
            this.txtComponentName.Name = "txtComponentName";
            this.txtComponentName.Size = new System.Drawing.Size(169, 21);
            this.txtComponentName.TabIndex = 23;
            // 
            // chGenerateViewsMvc
            // 
            this.chGenerateViewsMvc.AutoSize = true;
            this.chGenerateViewsMvc.Checked = true;
            this.chGenerateViewsMvc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chGenerateViewsMvc.Location = new System.Drawing.Point(263, 69);
            this.chGenerateViewsMvc.Name = "chGenerateViewsMvc";
            this.chGenerateViewsMvc.Size = new System.Drawing.Size(101, 17);
            this.chGenerateViewsMvc.TabIndex = 19;
            this.chGenerateViewsMvc.Text = "Generate Views";
            this.chGenerateViewsMvc.UseVisualStyleBackColor = true;
            // 
            // tpFacade
            // 
            this.tpFacade.BackColor = System.Drawing.Color.YellowGreen;
            this.tpFacade.Controls.Add(this.rtbFacade);
            this.tpFacade.Controls.Add(this.groupBox6);
            this.tpFacade.Location = new System.Drawing.Point(4, 22);
            this.tpFacade.Name = "tpFacade";
            this.tpFacade.Size = new System.Drawing.Size(721, 442);
            this.tpFacade.TabIndex = 4;
            this.tpFacade.Text = "Facade";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.txtFacadeParentClass);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.chGenerateFacade);
            this.groupBox6.Controls.Add(this.txtNamespaceFacade);
            this.groupBox6.Controls.Add(this.label34);
            this.groupBox6.Controls.Add(this.txtDsNamespaceFacade);
            this.groupBox6.Controls.Add(this.label35);
            this.groupBox6.Controls.Add(this.chGenerateAllFacade);
            this.groupBox6.Controls.Add(this.chWithFilterFacade);
            this.groupBox6.Controls.Add(this.txtFacadeMethodName);
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Controls.Add(this.drpFacadeAction);
            this.groupBox6.Controls.Add(this.label37);
            this.groupBox6.Controls.Add(this.btnCopyToClipboardFacade);
            this.groupBox6.Controls.Add(this.btnGenerateFacade);
            this.groupBox6.Location = new System.Drawing.Point(7, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(707, 123);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // btnGenerateFacade
            // 
            this.btnGenerateFacade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateFacade.Location = new System.Drawing.Point(522, 90);
            this.btnGenerateFacade.Name = "btnGenerateFacade";
            this.btnGenerateFacade.Size = new System.Drawing.Size(68, 23);
            this.btnGenerateFacade.TabIndex = 6;
            this.btnGenerateFacade.Text = "Generate";
            this.btnGenerateFacade.UseVisualStyleBackColor = true;
            this.btnGenerateFacade.Click += new System.EventHandler(this.btnGenerateFacade_Click);
            // 
            // btnCopyToClipboardFacade
            // 
            this.btnCopyToClipboardFacade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyToClipboardFacade.Enabled = false;
            this.btnCopyToClipboardFacade.Location = new System.Drawing.Point(596, 90);
            this.btnCopyToClipboardFacade.Name = "btnCopyToClipboardFacade";
            this.btnCopyToClipboardFacade.Size = new System.Drawing.Size(99, 23);
            this.btnCopyToClipboardFacade.TabIndex = 7;
            this.btnCopyToClipboardFacade.Text = "Copy to clipboard";
            this.btnCopyToClipboardFacade.UseVisualStyleBackColor = true;
            this.btnCopyToClipboardFacade.Click += new System.EventHandler(this.btnCopyToClipboardFacade_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(26, 16);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(47, 13);
            this.label37.TabIndex = 7;
            this.label37.Text = "Action : ";
            // 
            // drpFacadeAction
            // 
            this.drpFacadeAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpFacadeAction.FormattingEnabled = true;
            this.drpFacadeAction.Items.AddRange(new object[] {
            "Get",
            "Insert",
            "Update",
            "Delete"});
            this.drpFacadeAction.Location = new System.Drawing.Point(86, 13);
            this.drpFacadeAction.Name = "drpFacadeAction";
            this.drpFacadeAction.Size = new System.Drawing.Size(88, 21);
            this.drpFacadeAction.TabIndex = 1;
            this.drpFacadeAction.SelectedIndexChanged += new System.EventHandler(this.drpFacadeAction_SelectedIndexChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 44);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(74, 13);
            this.label36.TabIndex = 9;
            this.label36.Text = "Mthod Name :";
            // 
            // txtFacadeMethodName
            // 
            this.txtFacadeMethodName.Location = new System.Drawing.Point(86, 41);
            this.txtFacadeMethodName.Name = "txtFacadeMethodName";
            this.txtFacadeMethodName.Size = new System.Drawing.Size(189, 21);
            this.txtFacadeMethodName.TabIndex = 3;
            // 
            // chWithFilterFacade
            // 
            this.chWithFilterFacade.AutoSize = true;
            this.chWithFilterFacade.Location = new System.Drawing.Point(180, 15);
            this.chWithFilterFacade.Name = "chWithFilterFacade";
            this.chWithFilterFacade.Size = new System.Drawing.Size(75, 17);
            this.chWithFilterFacade.TabIndex = 2;
            this.chWithFilterFacade.Text = "With Filter";
            this.chWithFilterFacade.UseVisualStyleBackColor = true;
            // 
            // chGenerateAllFacade
            // 
            this.chGenerateAllFacade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chGenerateAllFacade.AutoSize = true;
            this.chGenerateAllFacade.Location = new System.Drawing.Point(527, 66);
            this.chGenerateAllFacade.Name = "chGenerateAllFacade";
            this.chGenerateAllFacade.Size = new System.Drawing.Size(139, 17);
            this.chGenerateAllFacade.TabIndex = 5;
            this.chGenerateAllFacade.Text = "Generate Facade Layer";
            this.chGenerateAllFacade.UseVisualStyleBackColor = true;
            this.chGenerateAllFacade.CheckedChanged += new System.EventHandler(this.chGenerateAllFacade_CheckedChanged);
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(443, 16);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(84, 13);
            this.label35.TabIndex = 26;
            this.label35.Text = "Object\'s prefix :";
            // 
            // txtDsNamespaceFacade
            // 
            this.txtDsNamespaceFacade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDsNamespaceFacade.Location = new System.Drawing.Point(528, 13);
            this.txtDsNamespaceFacade.Name = "txtDsNamespaceFacade";
            this.txtDsNamespaceFacade.Size = new System.Drawing.Size(173, 21);
            this.txtDsNamespaceFacade.TabIndex = 25;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(413, 42);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(107, 13);
            this.label34.TabIndex = 28;
            this.label34.Text = "Facade Namespace :";
            // 
            // txtNamespaceFacade
            // 
            this.txtNamespaceFacade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamespaceFacade.Location = new System.Drawing.Point(528, 40);
            this.txtNamespaceFacade.Name = "txtNamespaceFacade";
            this.txtNamespaceFacade.Size = new System.Drawing.Size(173, 21);
            this.txtNamespaceFacade.TabIndex = 27;
            // 
            // chGenerateFacade
            // 
            this.chGenerateFacade.AutoSize = true;
            this.chGenerateFacade.Checked = true;
            this.chGenerateFacade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chGenerateFacade.Location = new System.Drawing.Point(6, 96);
            this.chGenerateFacade.Name = "chGenerateFacade";
            this.chGenerateFacade.Size = new System.Drawing.Size(137, 17);
            this.chGenerateFacade.TabIndex = 30;
            this.chGenerateFacade.Text = "Generate Facade Class";
            this.chGenerateFacade.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Parent Class :";
            // 
            // txtFacadeParentClass
            // 
            this.txtFacadeParentClass.Location = new System.Drawing.Point(86, 67);
            this.txtFacadeParentClass.Name = "txtFacadeParentClass";
            this.txtFacadeParentClass.Size = new System.Drawing.Size(189, 21);
            this.txtFacadeParentClass.TabIndex = 32;
            this.txtFacadeParentClass.Text = "BaseFacade";
            // 
            // rtbFacade
            // 
            this.rtbFacade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFacade.BackColor = System.Drawing.Color.GhostWhite;
            this.rtbFacade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFacade.ForeColor = System.Drawing.Color.DarkBlue;
            this.rtbFacade.Location = new System.Drawing.Point(7, 135);
            this.rtbFacade.Name = "rtbFacade";
            this.rtbFacade.Size = new System.Drawing.Size(707, 300);
            this.rtbFacade.TabIndex = 4;
            this.rtbFacade.Text = "";
            // 
            // tpBOL
            // 
            this.tpBOL.BackColor = System.Drawing.Color.SlateGray;
            this.tpBOL.Controls.Add(this.rtbBol);
            this.tpBOL.Controls.Add(this.groupBox2);
            this.tpBOL.Location = new System.Drawing.Point(4, 22);
            this.tpBOL.Name = "tpBOL";
            this.tpBOL.Padding = new System.Windows.Forms.Padding(3);
            this.tpBOL.Size = new System.Drawing.Size(721, 442);
            this.tpBOL.TabIndex = 1;
            this.tpBOL.Text = "BOL";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chGenerateBOLClass);
            this.groupBox2.Controls.Add(this.txtNamespaceBol);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.chGenerateAllBol);
            this.groupBox2.Controls.Add(this.btnCopyToClipboardSP);
            this.groupBox2.Controls.Add(this.btnGenerateSP);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnGenerateSP
            // 
            this.btnGenerateSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateSP.Location = new System.Drawing.Point(4, 62);
            this.btnGenerateSP.Name = "btnGenerateSP";
            this.btnGenerateSP.Size = new System.Drawing.Size(598, 23);
            this.btnGenerateSP.TabIndex = 6;
            this.btnGenerateSP.Text = "Generate";
            this.btnGenerateSP.UseVisualStyleBackColor = true;
            this.btnGenerateSP.Click += new System.EventHandler(this.btnGenerateSP_Click);
            // 
            // btnCopyToClipboardSP
            // 
            this.btnCopyToClipboardSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyToClipboardSP.Enabled = false;
            this.btnCopyToClipboardSP.Location = new System.Drawing.Point(608, 62);
            this.btnCopyToClipboardSP.Name = "btnCopyToClipboardSP";
            this.btnCopyToClipboardSP.Size = new System.Drawing.Size(99, 23);
            this.btnCopyToClipboardSP.TabIndex = 7;
            this.btnCopyToClipboardSP.Text = "Copy to clipboard";
            this.btnCopyToClipboardSP.UseVisualStyleBackColor = true;
            this.btnCopyToClipboardSP.Click += new System.EventHandler(this.btnCopyToClipboardSP_Click);
            // 
            // chGenerateAllBol
            // 
            this.chGenerateAllBol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chGenerateAllBol.AutoSize = true;
            this.chGenerateAllBol.Location = new System.Drawing.Point(572, 20);
            this.chGenerateAllBol.Name = "chGenerateAllBol";
            this.chGenerateAllBol.Size = new System.Drawing.Size(123, 17);
            this.chGenerateAllBol.TabIndex = 5;
            this.chGenerateAllBol.Text = "Generate BOL Layer";
            this.chGenerateAllBol.UseVisualStyleBackColor = true;
            this.chGenerateAllBol.CheckedChanged += new System.EventHandler(this.chGenerateAllSP_CheckedChanged);
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(4, 17);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(69, 13);
            this.label29.TabIndex = 28;
            this.label29.Text = "Namespace :";
            // 
            // txtNamespaceBol
            // 
            this.txtNamespaceBol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamespaceBol.Location = new System.Drawing.Point(79, 14);
            this.txtNamespaceBol.Name = "txtNamespaceBol";
            this.txtNamespaceBol.Size = new System.Drawing.Size(173, 21);
            this.txtNamespaceBol.TabIndex = 27;
            // 
            // chGenerateBOLClass
            // 
            this.chGenerateBOLClass.AutoSize = true;
            this.chGenerateBOLClass.Checked = true;
            this.chGenerateBOLClass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chGenerateBOLClass.Location = new System.Drawing.Point(6, 41);
            this.chGenerateBOLClass.Name = "chGenerateBOLClass";
            this.chGenerateBOLClass.Size = new System.Drawing.Size(121, 17);
            this.chGenerateBOLClass.TabIndex = 29;
            this.chGenerateBOLClass.Text = "Generate BOL Class";
            this.chGenerateBOLClass.UseVisualStyleBackColor = true;
            // 
            // rtbBol
            // 
            this.rtbBol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbBol.BackColor = System.Drawing.Color.GhostWhite;
            this.rtbBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBol.ForeColor = System.Drawing.Color.DarkBlue;
            this.rtbBol.Location = new System.Drawing.Point(6, 103);
            this.rtbBol.Name = "rtbBol";
            this.rtbBol.Size = new System.Drawing.Size(707, 332);
            this.rtbBol.TabIndex = 2;
            this.rtbBol.Text = "";
            // 
            // tpDAL
            // 
            this.tpDAL.BackColor = System.Drawing.Color.LightCoral;
            this.tpDAL.Controls.Add(this.rtbMethodDAl);
            this.tpDAL.Controls.Add(this.groupBox3);
            this.tpDAL.Location = new System.Drawing.Point(4, 22);
            this.tpDAL.Name = "tpDAL";
            this.tpDAL.Padding = new System.Windows.Forms.Padding(3);
            this.tpDAL.Size = new System.Drawing.Size(721, 442);
            this.tpDAL.TabIndex = 2;
            this.tpDAL.Text = "DAL";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.SaveToDalFile);
            this.groupBox3.Controls.Add(this.txtNamespaceDAL);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.chGenerateDataProvider);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cbClassModifierMethod);
            this.groupBox3.Controls.Add(this.btnCopyToclipboardMethodDAl);
            this.groupBox3.Controls.Add(this.btnGenerateMethodDAL);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(707, 98);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btnGenerateMethodDAL
            // 
            this.btnGenerateMethodDAL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateMethodDAL.Location = new System.Drawing.Point(6, 64);
            this.btnGenerateMethodDAL.Name = "btnGenerateMethodDAL";
            this.btnGenerateMethodDAL.Size = new System.Drawing.Size(485, 23);
            this.btnGenerateMethodDAL.TabIndex = 10;
            this.btnGenerateMethodDAL.Text = "Generate";
            this.btnGenerateMethodDAL.UseVisualStyleBackColor = true;
            this.btnGenerateMethodDAL.Click += new System.EventHandler(this.btnGenerateMethodDAL_Click);
            // 
            // btnCopyToclipboardMethodDAl
            // 
            this.btnCopyToclipboardMethodDAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyToclipboardMethodDAl.Enabled = false;
            this.btnCopyToclipboardMethodDAl.Location = new System.Drawing.Point(497, 64);
            this.btnCopyToclipboardMethodDAl.Name = "btnCopyToclipboardMethodDAl";
            this.btnCopyToclipboardMethodDAl.Size = new System.Drawing.Size(109, 23);
            this.btnCopyToclipboardMethodDAl.TabIndex = 11;
            this.btnCopyToclipboardMethodDAl.Text = "Copy to clipboard";
            this.btnCopyToclipboardMethodDAl.UseVisualStyleBackColor = true;
            this.btnCopyToclipboardMethodDAl.Click += new System.EventHandler(this.btnCopyToclipboardMethod_Click);
            // 
            // cbClassModifierMethod
            // 
            this.cbClassModifierMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClassModifierMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassModifierMethod.FormattingEnabled = true;
            this.cbClassModifierMethod.Items.AddRange(new object[] {
            "public sealed",
            "internal sealed",
            "public",
            "internal",
            "public abstract",
            "internal abstract",
            "public static",
            "internal static"});
            this.cbClassModifierMethod.Location = new System.Drawing.Point(523, 13);
            this.cbClassModifierMethod.Name = "cbClassModifierMethod";
            this.cbClassModifierMethod.Size = new System.Drawing.Size(173, 21);
            this.cbClassModifierMethod.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(437, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Class Modifier :";
            // 
            // chGenerateDataProvider
            // 
            this.chGenerateDataProvider.AutoSize = true;
            this.chGenerateDataProvider.Location = new System.Drawing.Point(6, 40);
            this.chGenerateDataProvider.Name = "chGenerateDataProvider";
            this.chGenerateDataProvider.Size = new System.Drawing.Size(81, 17);
            this.chGenerateDataProvider.TabIndex = 5;
            this.chGenerateDataProvider.Text = "Create DAL";
            this.chGenerateDataProvider.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Namespace :";
            // 
            // txtNamespaceDAL
            // 
            this.txtNamespaceDAL.Location = new System.Drawing.Point(81, 13);
            this.txtNamespaceDAL.Name = "txtNamespaceDAL";
            this.txtNamespaceDAL.Size = new System.Drawing.Size(219, 21);
            this.txtNamespaceDAL.TabIndex = 4;
            // 
            // SaveToDalFile
            // 
            this.SaveToDalFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveToDalFile.Enabled = false;
            this.SaveToDalFile.Location = new System.Drawing.Point(612, 64);
            this.SaveToDalFile.Name = "SaveToDalFile";
            this.SaveToDalFile.Size = new System.Drawing.Size(84, 23);
            this.SaveToDalFile.TabIndex = 23;
            this.SaveToDalFile.Text = "Save To File";
            this.SaveToDalFile.UseVisualStyleBackColor = true;
            this.SaveToDalFile.Click += new System.EventHandler(this.SaveToDalFile_Click);
            // 
            // rtbMethodDAl
            // 
            this.rtbMethodDAl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMethodDAl.BackColor = System.Drawing.Color.GhostWhite;
            this.rtbMethodDAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMethodDAl.ForeColor = System.Drawing.Color.DarkBlue;
            this.rtbMethodDAl.Location = new System.Drawing.Point(6, 110);
            this.rtbMethodDAl.Name = "rtbMethodDAl";
            this.rtbMethodDAl.Size = new System.Drawing.Size(707, 305);
            this.rtbMethodDAl.TabIndex = 3;
            this.rtbMethodDAl.Text = "";
            // 
            // tpClass
            // 
            this.tpClass.BackColor = System.Drawing.Color.SkyBlue;
            this.tpClass.Controls.Add(this.rtbClass);
            this.tpClass.Controls.Add(this.groupBox1);
            this.tpClass.Location = new System.Drawing.Point(4, 22);
            this.tpClass.Name = "tpClass";
            this.tpClass.Padding = new System.Windows.Forms.Padding(3);
            this.tpClass.Size = new System.Drawing.Size(721, 442);
            this.tpClass.TabIndex = 0;
            this.tpClass.Text = "DataStructure";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtdsNamespaceClass);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.chAllClass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbClassModifier);
            this.groupBox1.Controls.Add(this.btnSaveToFile);
            this.groupBox1.Controls.Add(this.btnCopyToClipboard);
            this.groupBox1.Controls.Add(this.btnGenerateClass);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnGenerateClass
            // 
            this.btnGenerateClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateClass.Location = new System.Drawing.Point(6, 64);
            this.btnGenerateClass.Name = "btnGenerateClass";
            this.btnGenerateClass.Size = new System.Drawing.Size(486, 23);
            this.btnGenerateClass.TabIndex = 7;
            this.btnGenerateClass.Text = "Generate";
            this.btnGenerateClass.UseVisualStyleBackColor = true;
            this.btnGenerateClass.Click += new System.EventHandler(this.btnGenerateClass_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyToClipboard.Enabled = false;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(498, 64);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(113, 23);
            this.btnCopyToClipboard.TabIndex = 8;
            this.btnCopyToClipboard.Text = "Copy to clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveToFile.Enabled = false;
            this.btnSaveToFile.Location = new System.Drawing.Point(617, 64);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(84, 23);
            this.btnSaveToFile.TabIndex = 10;
            this.btnSaveToFile.Text = "Save To File";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // cbClassModifier
            // 
            this.cbClassModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClassModifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassModifier.FormattingEnabled = true;
            this.cbClassModifier.Items.AddRange(new object[] {
            "public sealed",
            "internal sealed",
            "public",
            "internal",
            "public abstract",
            "internal abstract",
            "public static",
            "internal static"});
            this.cbClassModifier.Location = new System.Drawing.Point(575, 13);
            this.cbClassModifier.Name = "cbClassModifier";
            this.cbClassModifier.Size = new System.Drawing.Size(126, 21);
            this.cbClassModifier.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Class Modifier :";
            // 
            // chAllClass
            // 
            this.chAllClass.AutoSize = true;
            this.chAllClass.Location = new System.Drawing.Point(9, 41);
            this.chAllClass.Name = "chAllClass";
            this.chAllClass.Size = new System.Drawing.Size(151, 17);
            this.chAllClass.TabIndex = 6;
            this.chAllClass.Text = "Create class for all tables!";
            this.chAllClass.UseVisualStyleBackColor = true;
            this.chAllClass.CheckedChanged += new System.EventHandler(this.chAllClass_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Namespace :";
            // 
            // txtdsNamespaceClass
            // 
            this.txtdsNamespaceClass.Location = new System.Drawing.Point(80, 13);
            this.txtdsNamespaceClass.Name = "txtdsNamespaceClass";
            this.txtdsNamespaceClass.Size = new System.Drawing.Size(219, 21);
            this.txtdsNamespaceClass.TabIndex = 1;
            // 
            // rtbClass
            // 
            this.rtbClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbClass.BackColor = System.Drawing.Color.GhostWhite;
            this.rtbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbClass.ForeColor = System.Drawing.Color.DarkBlue;
            this.rtbClass.Location = new System.Drawing.Point(6, 109);
            this.rtbClass.Name = "rtbClass";
            this.rtbClass.Size = new System.Drawing.Size(707, 311);
            this.rtbClass.TabIndex = 0;
            this.rtbClass.Text = "";
            this.rtbClass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtbClass_MouseClick);
            // 
            // tab1
            // 
            this.tab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1.Controls.Add(this.tpClass);
            this.tab1.Controls.Add(this.tpDAL);
            this.tab1.Controls.Add(this.tpBOL);
            this.tab1.Controls.Add(this.tpFacade);
            this.tab1.Controls.Add(this.tabReact);
            this.tab1.Location = new System.Drawing.Point(0, 61);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(729, 468);
            this.tab1.TabIndex = 1;
            this.tab1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 529);
            this.Controls.Add(this.cmbTableNames);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tab1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(608, 212);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genrator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabReact.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.viewGroup.ResumeLayout(false);
            this.viewGroup.PerformLayout();
            this.tpFacade.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tpBOL.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpDAL.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tpClass.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblProcessing;
        private System.Windows.Forms.ToolStripProgressBar prog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label33;
        private SqlConnection Connection;
        private System.Windows.Forms.SaveFileDialog saveBOFile;
        private System.Windows.Forms.SaveFileDialog saveDalFile;
        private System.Windows.Forms.SaveFileDialog saveFacadeFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.ComboBox cmbTableNames;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTableQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabReact;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox chGenerateViewsMvc;
        private System.Windows.Forms.TextBox txtComponentName;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.CheckBox chUseResourceMvc;
        private System.Windows.Forms.CheckBox chGenerateControllerMvc;
        private System.Windows.Forms.GroupBox viewGroup;
        private System.Windows.Forms.CheckBox chDetailViewMvc;
        private System.Windows.Forms.CheckBox chDeleteViewMvc;
        private System.Windows.Forms.CheckBox chEditViewMvc;
        private System.Windows.Forms.CheckBox chCreateViewMvc;
        private System.Windows.Forms.CheckBox chListViewMvc;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox TxtlayoutMvc;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.CheckBox CheckMasterMvc;
        private System.Windows.Forms.TextBox txtSectionsMvc;
        private System.Windows.Forms.Button BtnFieldSettingReact;
        private System.Windows.Forms.TextBox TxtTitleReact;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Button BtnSaveFileToMvc;
        private System.Windows.Forms.Button BtnGenerateReact;
        private System.Windows.Forms.RichTextBox txtCodeBehindReact;
        private System.Windows.Forms.TabPage tpFacade;
        private System.Windows.Forms.RichTextBox rtbFacade;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtFacadeParentClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chGenerateFacade;
        private System.Windows.Forms.TextBox txtNamespaceFacade;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtDsNamespaceFacade;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox chGenerateAllFacade;
        private System.Windows.Forms.CheckBox chWithFilterFacade;
        private System.Windows.Forms.TextBox txtFacadeMethodName;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox drpFacadeAction;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnCopyToClipboardFacade;
        private System.Windows.Forms.Button btnGenerateFacade;
        private System.Windows.Forms.TabPage tpBOL;
        private System.Windows.Forms.RichTextBox rtbBol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chGenerateBOLClass;
        private System.Windows.Forms.TextBox txtNamespaceBol;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox chGenerateAllBol;
        private System.Windows.Forms.Button btnCopyToClipboardSP;
        private System.Windows.Forms.Button btnGenerateSP;
        private System.Windows.Forms.TabPage tpDAL;
        private System.Windows.Forms.RichTextBox rtbMethodDAl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SaveToDalFile;
        private System.Windows.Forms.TextBox txtNamespaceDAL;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chGenerateDataProvider;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbClassModifierMethod;
        private System.Windows.Forms.Button btnCopyToclipboardMethodDAl;
        private System.Windows.Forms.Button btnGenerateMethodDAL;
        private System.Windows.Forms.TabPage tpClass;
        private System.Windows.Forms.RichTextBox rtbClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdsNamespaceClass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chAllClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbClassModifier;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnGenerateClass;
        private System.Windows.Forms.TabControl tab1;
    }
}

