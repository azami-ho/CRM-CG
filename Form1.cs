using CodeGenerator.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1(string connectionString)
        {
            InitializeComponent();
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }

        #region Variables

        private string tableQuery = string.Empty;
        private readonly PropertyCollection props = new PropertyCollection();
        private readonly PropertyCollection keys = new PropertyCollection();
        private string tableName = "";
        private ActionType actionType = ActionType.Select;
        private ActionType methodActionType = ActionType.Select;
        private FormModelCollection formModel = new FormModelCollection();
        #endregion

        #region Events


        private void saveBOFile_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(saveBOFile.FileName, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(rtbBol.Text);
            sw.Flush();
            sw.Close();
            fs.Close();
            FileInfo x = new FileInfo(saveBOFile.FileName);
            Manager.GetTable(TableName.lastSaveFile)["path"] = x.DirectoryName;
            Manager.WriteDatas();
        }

        private void saveFacadeFile_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(saveFacadeFile.FileName, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(rtbFacade.Text);
            sw.Flush();
            sw.Close();
            fs.Close();
            FileInfo x = new FileInfo(saveFacadeFile.FileName);
            Manager.GetTable(TableName.lastSaveFile)["path"] = x.DirectoryName;
            Manager.WriteDatas();
        }

        private void saveDalFile_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(saveDalFile.FileName, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(rtbMethodDAl.Text);
            sw.Flush();
            sw.Close();
            fs.Close();
            FileInfo x = new FileInfo(saveDalFile.FileName);
            Manager.GetTable(TableName.lastSaveFile)["path"] = x.DirectoryName;
            Manager.WriteDatas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
            TableNameLoader();
            tableName = cmbTableNames.Text;
            cbClassModifier.SelectedIndex = 0;
            cbClassModifierMethod.SelectedIndex = 0;
            txtdsNamespaceClass.Text = Manager.GetTable(TableName.dsNameSpace)["value"].ToString();
        }

        private void TableNameLoader()
        {
            //this.BindTableName(this.cbTableNameClass);
            //this.BindTableName(this.cbTableNameBol);
            //this.BindTableName(this.cbTableNameFacade);
            //this.BindTableName(this.cbTableNameMethods);
            //this.BindTableName(this.cbTableNameAsp);
            //this.BindTableName(this.CmdTableMvc);
            //this.BindTableName(this.cbTableNameSP);
            //this.BindTableName(this.cbNgAaTableNames);

            BindTableName(cmbTableNames);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tab1.SelectedTab.Name)
            {
                case "tpClass":
                    //this.tableName = this.cbTableNamesClass.Text;
                    break;
                case "tpSP":
                    //this.tableName = this.cbTableNameBol.Text;
                    break;
                case "tpMethods":
                    //this.tableName = this.cbTableNamesMethods.Text;
                    break;
                case "tbaspForm":
                    //this.tableName = this.cbTableNameAsp.Text;
                    GetTableDescription(tableName);
                    break;
                case "tabMvcForm":
                    //this.tableName = this.CmdTableMvc.Text;
                    GetTableDescription(tableName);
                    break;

            }
            lblProcessing.Text = @"Ready";
        }

        #region Class

        private void btnGenerateClass_Click(object sender, EventArgs e)
        {
            if (chAllClass.Checked)
            {
                if (Manager.Settings.saveProjectPath != string.Empty)
                {
                    if (Directory.Exists(Manager.Settings.saveProjectPath))
                    {
                        folderBrowserDialog1.SelectedPath = Manager.Settings.saveProjectPath;
                    }
                }

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    prog.Visible = true;
                    prog.Step = 1;
                    prog.Minimum = 0;
                    prog.Maximum = cmbTableNames.Items.Count;
                    lblProcessing.Text = @"Generating classes....";
                    bool standardPath = false;
                    string path = folderBrowserDialog1.SelectedPath;
                    if (path.StartsWith(Manager.Settings.saveProjectPath))
                    {
                        if (path == Manager.Settings.saveProjectPath)
                        {
                            path = Manager.Settings.saveProjectPath + "\\DataStructure";
                        }
                        standardPath = path == Manager.Settings.saveProjectPath + "\\DataStructure";
                    }

                    foreach (object item in cmbTableNames.Items)
                    {
                        prog.Increment(1);
                        try
                        {
                            string directory = path;
                            string table = ((DataRowView)(item)).Row.ItemArray[0].ToString();
                            if (table != "sysdiagrams")
                            {
                                if (standardPath)
                                {
                                    directory = path + "\\" + table.Split('.')[0];
                                }
                                if (!Directory.Exists(directory))
                                {
                                    Directory.CreateDirectory(directory);
                                }

                                FileStream fs = new FileStream(directory + "\\" + table.Split('.')[1] + ".cs", FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
                                StreamWriter sw = new StreamWriter(fs);
                                sw.Write(GenerateDataStructureFileContent(table, directory));
                                sw.Flush();
                                sw.Close();
                                fs.Close();
                            }
                        }
                        catch { }
                    }
                    lblProcessing.Text = prog.Value + @" class(es) generated.";
                    MessageBox.Show(@"Command(s) completed successfully.");
                    Manager.GetTable(TableName.saveProjectPath)["value"] = folderBrowserDialog1.SelectedPath;
                    Manager.WriteDatas();
                    lblProcessing.Text = @"Ready";
                }
            }
            else
            {
                prog.Visible = true;
                rtbClass.Text = GenerateClass(tableName);
                rtbClass.Focus();
                rtbClass.SelectAll();
                //Configs
                btnSaveToFile.Enabled = true;
                btnCopyToClipboard.Enabled = true;
                lblProcessing.Text = @"Generated class for " + tableName + "!";
            }
            Manager.GetTable(TableName.dsNameSpace)["value"] = txtdsNamespaceClass.Text;
            Manager.WriteDatas();
            prog.Visible = false;
        }

        //private void cbTableNameClass_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.tableName = this.cbTableNameClass.Text;
        //}

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbClass.Text);
            lblProcessing.Text = @"The class(es) copied to clipboard.";
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            ShowSaveFileDialog(tableName.Split('.')[1]);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string path = new FileInfo(saveFileDialog1.FileName).DirectoryName;
            string content = string.Empty;
            switch (tab1.SelectedTab.Name)
            {
                case "tpClass":
                    content = GenerateDataStructureFileContent(tableName, path);
                    break;
                case "tpDAL":
                    content = GenerateDalClass(tableName, path);
                    break;
            }

            SaveFileDialogFile(content);
        }

        private void chAllClass_CheckedChanged(object sender, EventArgs e)
        {
            if (chAllClass.Checked)
            {
                //this.cmbTableNames.Enabled = false;
                cbClassModifier.Enabled = false;
                btnCopyToClipboard.Enabled = false;
                btnSaveToFile.Enabled = false;
            }
            else
            {
                //this.cmbTableNames.Enabled = true;
                cbClassModifier.Enabled = true;
                btnCopyToClipboard.Enabled = true;
                btnSaveToFile.Enabled = true;
            }
        }

        private void rtbClass_MouseClick(object sender, MouseEventArgs e)
        {
            lblProcessing.Text = @"Ready";
        }

        #endregion

        #region Bol

        private void btnGenerateSP_Click(object sender, EventArgs e)
        {
            if (chGenerateAllBol.Checked)
            {
                if (Manager.Settings.saveProjectPath != string.Empty)
                {
                    if (Directory.Exists(Manager.Settings.saveProjectPath))
                    {
                        folderBrowserDialog1.SelectedPath = Manager.Settings.saveProjectPath;
                    }
                }

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    prog.Visible = true;
                    prog.Step = 1;
                    prog.Minimum = 0;
                    prog.Maximum = cmbTableNames.Items.Count;
                    lblProcessing.Text = @"Generating BOL Layer....";
                    foreach (object item in cmbTableNames.Items)
                    {
                        prog.Increment(1);
                        try
                        {
                            string table = ((DataRowView)(item)).Row.ItemArray[0].ToString();
                            if (table != "sysdiagrams")
                            {
                                string txt = GenerateBoClass(table);
                                FileStream fs = new FileStream(folderBrowserDialog1.SelectedPath + "\\" + table.Split('.')[1] + "BO.cs", FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
                                StreamWriter sw = new StreamWriter(fs);
                                sw.Write(txt);
                                sw.Flush();
                                sw.Close();
                                fs.Close();
                            }
                        }
                        catch { }
                    }
                    lblProcessing.Text = prog.Value + @" class(es) generated.";
                    MessageBox.Show(@"Command(s) completed successfully.");
                    prog.Visible = false;
                    Manager.GetTable(TableName.saveProjectPath)["value"] = folderBrowserDialog1.SelectedPath;
                    Manager.WriteDatas();
                    lblProcessing.Text = @"Ready";
                }
            }
            else if (chGenerateBOLClass.Checked)
            {

                string table = ((DataRowView)(cmbTableNames.SelectedItem)).Row.ItemArray[3].ToString();
                GenerateBoClass(table);

                saveBOFile.FileName = table + "BO.cs";
                saveBOFile.InitialDirectory = Manager.GetTable(TableName.lastSaveFile)["path"].ToString() !=
                                                   string.Empty
                                                       ? Manager.GetTable(TableName.lastSaveFile)["path"].ToString()
                                                       : "C:\\";
                saveBOFile.ShowDialog();
            }
            prog.Visible = false;
        }

        private string GenerateBoClass(string table)
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("using Radyn.Framework;");
            str.AppendLine();
            if (txtNamespaceBol.Text != string.Empty)
            {
                str.AppendLine("namespace " + txtNamespaceBol.Text);
                str.AppendLine("{");
            }
            str.AppendLine("internal class " + table + "BO : BusinessBase<" + table + ">");
            str.AppendLine("{");

            str.AppendLine("}");
            if (txtNamespaceBol.Text != string.Empty)
            {
                str.AppendLine("}");
            }

            rtbBol.Text = str.ToString();
            return str.ToString();
        }

        private void chGenerateAllSP_CheckedChanged(object sender, EventArgs e)
        {
            btnCopyToClipboardSP.Enabled = !chGenerateAllBol.Checked;
        }

        private void btnCopyToClipboardSP_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbBol.Text);
            lblProcessing.Text = @"The method copied to clipboard.";
        }

        #endregion

        #region Facade

        private void btnGenerateFacade_Click(object sender, EventArgs e)
        {
            if (chGenerateAllFacade.Checked)
            {
                if (Manager.Settings.saveProjectPath != string.Empty)
                {
                    if (Directory.Exists(Manager.Settings.saveProjectPath))
                    {
                        folderBrowserDialog1.SelectedPath = Manager.Settings.saveProjectPath;
                    }
                }

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    prog.Visible = true;
                    prog.Step = 1;
                    prog.Minimum = 0;
                    prog.Maximum = cmbTableNames.Items.Count;
                    lblProcessing.Text = @"Generating Facade Layer....";
                    foreach (object item in cmbTableNames.Items)
                    {
                        prog.Increment(1);
                        try
                        {
                            string table = ((DataRowView)(item)).Row.ItemArray[3].ToString();
                            if (table != "sysdiagrams")
                            {
                                string txt = GenerateFacadeClass(table);
                                FileStream fs = new FileStream(folderBrowserDialog1.SelectedPath + "\\" + table + "Facade.cs", FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
                                StreamWriter sw = new StreamWriter(fs);
                                sw.Write(txt);
                                sw.Flush();
                                sw.Close();
                                fs.Close();

                                //Generate Interface
                                string interfacePath = folderBrowserDialog1.SelectedPath + "\\Interface";
                                if (!Directory.Exists(interfacePath))
                                {
                                    Directory.CreateDirectory(interfacePath);
                                }

                                GenerateFacadeInterface(table);
                                fs = new FileStream(interfacePath + "\\I" + table + "Facade.cs", FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
                                sw = new StreamWriter(fs);
                                sw.Write(rtbFacade.Text);
                                sw.Flush();
                                sw.Close();
                                fs.Close();
                            }
                        }
                        catch
                        {

                        }
                    }
                    lblProcessing.Text = prog.Value + @" class(es) generated.";
                    MessageBox.Show(@"Command(s) completed successfully.");
                    prog.Visible = false;
                    Manager.GetTable(TableName.saveProjectPath)["value"] = folderBrowserDialog1.SelectedPath;
                    Manager.WriteDatas();
                    lblProcessing.Text = @"Ready";

                }
            }
            else if (chGenerateFacade.Checked)
            {
                string table = ((DataRowView)(cmbTableNames.SelectedItem)).Row.ItemArray[0].ToString();
                GenerateFacadeClass(table);
                table = ((DataRowView)(cmbTableNames.SelectedItem)).Row.ItemArray[3].ToString();
                saveFacadeFile.FileName = table + "Facade.cs";
                saveFacadeFile.InitialDirectory = Manager.GetTable(TableName.lastSaveFile)["path"].ToString() !=
                                                       string.Empty
                                                           ? Manager.GetTable(TableName.lastSaveFile)["path"].ToString()
                                                           : "C:\\";
                saveFacadeFile.ShowDialog();
                GenerateFacadeInterface(table);
                saveFacadeFile.FileName = $"I{table}Facade.cs";
                saveFacadeFile.InitialDirectory = Manager.GetTable(TableName.lastSaveFile)["path"].ToString() !=
                                                       string.Empty
                                                           ? Manager.GetTable(TableName.lastSaveFile)["path"].ToString()
                                                           : "C:\\";
                string interfacePath = saveFacadeFile.InitialDirectory + "\\Interface";
                if (!Directory.Exists(interfacePath))
                {
                    Directory.CreateDirectory(interfacePath);
                }

                GenerateFacadeInterface(table);
                FileStream fs = new FileStream(interfacePath + "\\I" + table + "Facade.cs", FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(rtbFacade.Text);
                sw.Flush();
                sw.Close();
                fs.Close();

            }
            else
            {
                rtbFacade.Text = GenerateFacadeMethod(tableName);
                btnCopyToClipboardFacade.Enabled = true;
                lblProcessing.Text = $"Generated method for {tableName} table.";
            }
            prog.Visible = false;
        }

        private string GenerateFacadeClass(string table)
        {
            GetColumns(table);
            table = table.Split('.')[1];
            StringBuilder str = new StringBuilder();
            if (txtNamespaceFacade.Text != string.Empty)
            {
                str.AppendLine("namespace " + txtNamespaceFacade.Text);
                str.AppendLine("{");
            }
            str.AppendLine(string.Format("internal sealed class {0}Facade : " + txtFacadeParentClass.Text + "<{0}>, I{0}Facade", table));
            str.AppendLine("{");

            str.AppendLine("internal " + table + "Facade() { }");
            str.AppendLine();
            str.AppendLine("internal " + table + "Facade(IConnectionHandler connectionHandler) ");
            str.AppendLine(": base(connectionHandler){}");
            str.AppendLine();

            str.AppendLine("}");
            str.AppendLine("}");
            rtbFacade.Text = str.ToString();
            return str.ToString();
        }


        private void GenerateFacadeInterface(string table)
        {
            StringBuilder str = new StringBuilder();
            if (txtNamespaceFacade.Text != string.Empty)
            {
                str.AppendLine("namespace " + txtNamespaceFacade.Text);
                str.AppendLine("{");
            }
            str.AppendLine(string.Format("public interface I{0}Facade : IBaseFacade<{0}>", table));
            str.AppendLine("{");

            str.AppendLine("}");
            if (txtNamespaceFacade.Text != string.Empty)
            {
                str.AppendLine("}");
            }

            rtbFacade.Text = str.ToString();
        }


        private string GenerateFacadeMethod(string table)
        {
            GetColumns(table);
            string tmp = "";
            StringBuilder str = new StringBuilder();
            switch (actionType)
            {
                case ActionType.Select:
                    if (chWithFilterFacade.Checked)
                    {
                        str.Append("public " + table + " Get(");
                        tmp = keys.GetAll.Aggregate(tmp, (current, prop) => current + (prop.DotNetType + " " + prop.Name + ", "));
                        if (keys.Count > 0)
                        {
                            tmp = tmp.Substring(0, tmp.Length - 2);
                        }

                        str.AppendLine(tmp + ")");
                    }
                    else
                    {
                        str.AppendLine("public " + table + "Collection GetAll()");
                    }
                    str.AppendLine("{");
                    str.AppendLine($"var bo = new {table}BO();");
                    str.AppendLine("try");
                    str.AppendLine("{");
                    str.AppendLine("base.ConnectionHandler.Connection.Open();");
                    if (chWithFilterFacade.Checked)
                    {
                        str.Append("\treturn bo.Get(base.ConnectionHandler");
                        tmp = string.Empty;
                        if (keys.Count > 0)
                        {
                            tmp = keys.GetAll.Aggregate(tmp, (current, prop) => current + (", " + prop.Name));
                        }
                        if (props.HasForeignKey)
                        {
                            str.AppendLine(tmp + "));");
                        }
                        else
                        {
                            str.AppendLine(tmp + ");");
                        }
                    }
                    else
                    {
                        str.Append("return bo.GetAll(base.ConnectionHandler);");
                    }
                    str.AppendLine("}");
                    str.AppendLine("catch (KnownException)");
                    str.AppendLine("{");
                    str.AppendLine("throw;");
                    str.AppendLine("}");
                    str.AppendLine("catch (Exception ex)");
                    str.AppendLine("{");
                    str.AppendLine("throw new KnownException(\"خطا در بازیابی اطلاعات.\", ex);");
                    str.AppendLine("}");
                    break;
                case ActionType.Insert:
                    str.Append("public bool Insert(" + table + " obj)");
                    str.AppendLine("{");
                    str.AppendLine($"var bo = new {table}BO();");
                    str.AppendLine("try");
                    str.AppendLine("{");
                    str.AppendLine("base.ConnectionHandler.Connection.Open();");
                    str.Append("\treturn bo.Insert(base.ConnectionHandler, obj);");
                    str.AppendLine("}");
                    str.AppendLine("catch (KnownException)");
                    str.AppendLine("{");
                    str.AppendLine("throw;");
                    str.AppendLine("}");
                    str.AppendLine("catch (Exception ex)");
                    str.AppendLine("{");
                    str.AppendLine("throw new KnownException(\"خطا در ثبت اطلاعات.\", ex);");
                    str.AppendLine("}");
                    break;
                case ActionType.Update:
                    str.Append("public bool Update(" + table + " obj)");
                    str.AppendLine("{");
                    str.AppendLine($"var bo = new {table}BO();");
                    str.AppendLine("try");
                    str.AppendLine("{");
                    str.AppendLine("base.ConnectionHandler.Connection.Open();");
                    str.Append("\treturn bo.Update(base.ConnectionHandler, obj);");
                    str.AppendLine("}");
                    str.AppendLine("catch (KnownException)");
                    str.AppendLine("{");
                    str.AppendLine("throw;");
                    str.AppendLine("}");
                    str.AppendLine("catch (Exception ex)");
                    str.AppendLine("{");
                    str.AppendLine("throw new KnownException(\"خطا در ثبت اطلاعات.\", ex);");
                    str.AppendLine("}");
                    break;
                case ActionType.Delete:
                    str.Append("public bool Delete(");
                    tmp = keys.GetAll.Aggregate(tmp, (current, prop) => current + (prop.DotNetType + " " + prop.Name + ", "));
                    if (keys.Count > 0)
                    {
                        tmp = tmp.Substring(0, tmp.Length - 2);
                    }

                    str.AppendLine(tmp + ")");
                    str.AppendLine("{");
                    str.AppendLine("var bo = new " + table + "BO();");
                    str.AppendLine("try");
                    str.AppendLine("{");
                    str.AppendLine("base.ConnectionHandler.Connection.Open();");
                    str.Append("\treturn bo.Delete(base.ConnectionHandler");
                    tmp = string.Empty;
                    if (keys.Count > 0)
                    {
                        tmp = keys.GetAll.Aggregate(tmp, (current, prop) => current + (", " + prop.Name));
                    }
                    str.AppendLine(tmp + ");");
                    str.AppendLine("}");
                    str.AppendLine("catch (KnownException)");
                    str.AppendLine("{");
                    str.AppendLine("throw;");
                    str.AppendLine("}");
                    str.AppendLine("catch (Exception ex)");
                    str.AppendLine("{");
                    str.AppendLine("throw new KnownException(\"خطا در حذف اطلاعات.\", ex);");
                    str.AppendLine("}"); break;
            }
            str.AppendLine("\tfinally");
            str.AppendLine("\t{");
            str.AppendLine("\t\tif (this.ConnectionHandler.Connection.State == System.Data.ConnectionState.Open)");
            str.AppendLine("\t\t\tthis.ConnectionHandler.Connection.Close();");
            str.AppendLine("\t}");
            str.AppendLine("\t}");
            return str.ToString();
        }
        #endregion

        #region MethodGenerate


        private string GenerateDalClass(string table, string path)
        {
            StringBuilder str = new StringBuilder();
            try
            {
                if (table != "sysdiagrams")
                {
                    str = new StringBuilder();
                    str.AppendLine("using Radyn.Framework;");
                    str.AppendLine("using Radyn.Framework.DbHelper;");
                    str.AppendLine();



                    string _namespace = Manager.Settings.defaultNamespace + ".DAL";
                    string projectNamespace = Manager.settings.saveProjectPath + "\\DAL\\";
                    if (path.StartsWith(projectNamespace))
                    {
                        string additionalNamespace = path.Substring(projectNamespace.Length, path.Length - projectNamespace.Length);
                        foreach (string folder in additionalNamespace.Split('\\'))
                        {
                            _namespace += "." + folder;
                        }
                    }

                    str.AppendLine("namespace " + _namespace);
                    str.AppendLine("{");
                    string tableN = table.Split('.')[1];
                    str.AppendLine(cbClassModifierMethod.SelectedItem + " class " + tableN + "DA : DALBase<" + tableN + ">");
                    str.AppendLine("{");
                    str.AppendLine("\tpublic " + tableN + "DA(IConnectionHandler connectionHandler): base(connectionHandler){}");

                    //Command Builder
                    str.AppendLine("\tinternal class " + tableN + "CommandBuilder{}");
                    str.AppendLine("}");

                    str.AppendLine("}");
                    rtbMethodDAl.Text = str.ToString();

                }
            }
            catch { }
            return str.ToString();
        }

        //private void cbTableNameMethods_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.tableName = this.cbTableNameMethods.Text;
        //    this.ChangeMethodName();
        //}

        private void btnCopyToclipboardMethod_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbMethodDAl.Text);
            lblProcessing.Text = "The method copied to clipboard.";
        }

        #endregion

        #region AspForm


        private void btnFeildSetting_Click(object sender, EventArgs e)
        {
            GetColumns(tableName);
            FormSettings frm = new FormSettings(props, formModel);
            frm.ShowDialog();
        }

        private void mnChangeDatabase_Click(object sender, EventArgs e)
        {
            Connection frm = new Connection();
            Hide();
            frm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void closeGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnRefreshTables_Click(object sender, EventArgs e)
        {
            tableQuery = string.Empty;
            TableNameLoader();
        }

        private void mnSettings_Click(object sender, EventArgs e)
        {
            Settings frm = new Settings();
            frm.ShowDialog();
            LoadSettings();
        }

        #endregion

        #region React
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            txtSectionsMvc.Enabled = CheckMasterMvc.Checked;
            TxtlayoutMvc.Enabled = CheckMasterMvc.Checked;
        }
        private void BtnFieldSettingReact_Click(object sender, EventArgs e)
        {
            GetColumns(tableName);
            FormSettings frm = new FormSettings(props, formModel);
            frm.ShowDialog();
        }
        private void BtnGenerateReact_Click(object sender, EventArgs e)
        {
            if (!chGenerateControllerMvc.Checked && !chGenerateViewsMvc.Checked)
            {
                return;
            }

            if (!chGenerateControllerMvc.Checked && !chListViewMvc.Checked && !chCreateViewMvc.Checked && !chEditViewMvc.Checked && !chDetailViewMvc.Checked && !chDeleteViewMvc.Checked)
            {
                return;
            }
            if (chGenerateControllerMvc.Checked)
            {
                txtCodeBehindReact.Text = GenerateController();
            }

            BtnSaveFileToMvc.Enabled = true;
        }
        private void BtnSaveFileToMvc_Click(object sender, EventArgs e)
        {
            string[] strings = tableName.Split('.');
            string table = strings[1];
            if (Manager.Settings.saveProjectPath != string.Empty)
            {
                if (Directory.Exists(Manager.Settings.saveProjectPath))
                {
                    folderBrowserDialog1.SelectedPath = Manager.Settings.saveProjectPath;
                }
            }

            string selectedPath = "";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedPath = folderBrowserDialog1.SelectedPath;
            }

            if (string.IsNullOrEmpty(selectedPath))
            {
                return;
            }

            //GenerateViews(selectedPath);
            //if (chGenerateControllerMvc.Checked)
            //{
            FileStream fs = new FileStream($"{selectedPath}\\{table}Controller.cs", FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
            StreamWriter sw = new StreamWriter(fs);
            //if (chGeneratePartialView.Checked)
            //{
            //    sw.Write(GeneratePartialController());

            //}
            //else
            //{
                sw.Write(GenerateController());

            //}

            sw.Flush();
            sw.Close();
            fs.Close();
            Manager.GetTable(TableName.lastSaveFile)["path"] = selectedPath;
            Manager.WriteDatas();
            //}
            //BtnSaveFileToMvc.Enabled = false;
            //BtnGenerateMvc.Enabled = true;
        }
        #region Generate Controller
        private string GenerateController()
        {
            string[] strings = tableName.Split('.');
            string table = strings[1];
            string component = string.IsNullOrEmpty(txtComponentName.Text) ? strings[0] : txtComponentName.Text;
            string keyParameter = "";
            string keyValues = "";
            string keyHttp = "";
            GetColumns(tableName);
            if (keys.Count > 0)
            {
                foreach (Property key in keys.GetAll)
                {
                    keyParameter += string.Format("{0} {1},", key.DotNetType, this.GetCamelCase(key.Name));
                    keyValues += string.Format("{0} ,", this.GetCamelCase(key.Name));
                    keyHttp += "{" + this.GetCamelCase(key.Name) + "}/";
                }
                keyParameter = keyParameter.Substring(0, keyParameter.Length - 1).Trim();
                keyValues = keyValues.Substring(0, keyValues.Length - 1).Trim();
                keyHttp = keyHttp.Substring(0, keyHttp.Length - 1).Trim();
            }


            StringBuilder str = new StringBuilder();
            str.AppendLine("using Microsoft.AspNetCore.Mvc;");
            str.AppendLine(string.Format("using Radyn.{0};", component));
            str.AppendLine(string.Format("using Radyn.{0}.DataStructure;", component));
            str.AppendLine("using System;");
            str.AppendLine("using System.Threading.Tasks;");
            str.AppendLine();

            str.AppendLine(string.Format("namespace Radyn.WebApp.Areas.{0}.Controllers", component));
            str.AppendLine("{");

            str.AppendLine(string.Format("[Area(\"{0}\")]", component));

            str.AppendLine("[ApiController]");

            str.AppendLine(string.Format("[Route(\"{0}/[controller]\")]", this.GetCamelCase(component)));

            str.AppendLine("public class " + table + "Controller : ControllerBase");
            str.AppendLine("{");
            /////////////////////////////////////////Content

            //Index
            str.AppendLine("[HttpGet(\"index\")]");
            str.AppendLine("public async Task<IActionResult> Index()");
            str.AppendLine("{");
            str.AppendLine("try");
            str.AppendLine("{");
            str.AppendLine(string.Format("var result = await {0}Component.Instance.{1}Facade.GetAllAsync();", component, table));
            str.AppendLine("return Ok(result);");
            str.AppendLine("}");
            str.AppendLine("catch (Exception ex)");
            str.AppendLine("{");
            str.AppendLine("return BadRequest(ex.Message);");
            str.AppendLine("}");
            str.AppendLine("}");
            //Index

            str.AppendLine("");

            //Get
            str.AppendLine(string.Format("[HttpGet(\"get/{0}\")]", keyHttp));
            str.AppendLine("public async Task<IActionResult> Get(" + keyParameter + ")");
            str.AppendLine("{");
            str.AppendLine("try");
            str.AppendLine("{");
            str.AppendLine(string.Format("var result = await {0}Component.Instance.{1}Facade.GetAsync({2});", component, table, keyValues));
            str.AppendLine("return Ok(result);");
            str.AppendLine("}");
            str.AppendLine("catch (Exception ex)");
            str.AppendLine("{");
            str.AppendLine("return BadRequest(ex.Message);");
            str.AppendLine("}");
            str.AppendLine("}");
            str.AppendLine();
            //Get



            //Create

            str.AppendLine("[HttpPost(\"create\")]");
            str.AppendLine(string.Format("public async Task<IActionResult> Create([FromBody] {0} {1})",table,this.GetCamelCase(table)));
            str.AppendLine("{");
            str.AppendLine("try");
            str.AppendLine("{");
            str.AppendLine("if ("+this.GetCamelCase(table)+" != null)");
            str.AppendLine("{");
            str.AppendLine(string.Format("if (await {0}Component.Instance.{1}Facade.InsertAsync({2})) return Ok({2});", component,table,this.GetCamelCase(table)));
            str.AppendLine("}");
            str.AppendLine("return Ok(null);");
            str.AppendLine("}");
            str.AppendLine("catch (Exception ex)");
            str.AppendLine("{");
            str.AppendLine("return BadRequest(ex.Message);");
            str.AppendLine("}");
            str.AppendLine("}");

            //Create




            str.AppendLine("");

            //Edit

            str.AppendLine("[HttpPost(\"edit\")]");
            str.AppendLine(string.Format("public async Task<IActionResult> Edit([FromBody] {0} {1})", table, this.GetCamelCase(table)));
            str.AppendLine("{");
            str.AppendLine("try");
            str.AppendLine("{");
            str.AppendLine("if (" + this.GetCamelCase(table) + " != null)");
            str.AppendLine("{");
            str.AppendLine(string.Format("if (await {0}Component.Instance.{1}Facade.UpdateAsync({2})) return Ok({2});", component, table, this.GetCamelCase(table)));
            str.AppendLine("}");
            str.AppendLine("return Ok(null);");
            str.AppendLine("}");
            str.AppendLine("catch (Exception ex)");
            str.AppendLine("{");
            str.AppendLine("return BadRequest(ex.Message);");
            str.AppendLine("}");
            str.AppendLine("}");
            //Edit

            str.AppendLine("");

            //Delete
            str.AppendLine(string.Format("[HttpGet(\"delete/{0}\")]", keyHttp));
            str.AppendLine("public async Task<IActionResult> Delete(" + keyParameter + ")");
            str.AppendLine("{");
            str.AppendLine("try");
            str.AppendLine("{");
            str.AppendLine(string.Format("return Ok(await {0}Component.Instance.{1}Facade.DeleteAsync({2}));", component, table, keyValues));
            str.AppendLine("}");
            str.AppendLine("catch (Exception ex)");
            str.AppendLine("{");
            str.AppendLine("return BadRequest(ex.Message);");
            str.AppendLine("}");
            str.AppendLine("}");
            //Delete

            /////////////////////////////////////////Content
            str.AppendLine("}");
            str.AppendLine("}");


            return str.ToString();
        }

        #endregion


        //private void CmdTableMvc_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.tableName = this.CmdTableMvc.Text;
        //    this.formModel = new Component.FormModelCollection();
        //    this.GetTableDescription(this.tableName);
        //    this.txtTitleAsp.Text = this.props.TableDescription;
        //    this.txtFarsiDescAsp.Text = this.props.TableDescription;
        //}

        #endregion

        #endregion

        #region Methods

        private void BindTableName(ComboBox combo)
        {
            SqlDataAdapter da = new SqlDataAdapter("", Connection);
            if (string.IsNullOrEmpty(tableQuery))
            {
                da.SelectCommand.CommandText = "SELECT Table_schema + '.' + TABLE_NAME TableName ,* FROM INFORMATION_SCHEMA.TABLES ORDER BY TableName";
            }
            else
            {
                da.SelectCommand.CommandText = "SELECT Table_schema + '.' + TABLE_NAME TableName ,* FROM INFORMATION_SCHEMA.TABLES WHERE " + tableQuery + " ORDER BY TableName";
            }

            DataTable dt = new DataTable();
            da.Fill(dt);
            combo.DataSource = dt;
            combo.DisplayMember = "TableName";
        }

        private void GetTableDescription(string table)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                command.CommandText = "SELECT     ep.value AS [Description] " +
                                      "FROM         sys.extended_properties AS ep INNER JOIN " +
                                      "sys.tables AS t ON ep.major_id = t.object_id " +
                                      "WHERE     (ep.minor_id = 0) AND t.name = '" + table + "'";
                if (Connection.State == ConnectionState.Closed || Connection.State == ConnectionState.Broken)
                {
                    Connection.Open();
                }

                object retValue = command.ExecuteScalar();
                if (retValue != null)
                {
                    if (retValue != DBNull.Value)
                    {
                        props.TableDescription = retValue.ToString();
                    }
                }

                command.Dispose();
            }
        }

        private void GetColumns(string table)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                string tableName = table.Split('.')[1];
                string schema = table.Split('.')[0];

                command.CommandText = "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableName + "' AND TABLE_SCHEMA = '" + schema + "'";
                if (Connection.State == ConnectionState.Closed || Connection.State == ConnectionState.Broken)
                {
                    Connection.Open();
                }

                SqlDataReader dr = command.ExecuteReader();
                props.Clear();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Property pr = new Property
                        {
                            Name = dr["COLUMN_NAME"].ToString(),
                            SqlType = dr["DATA_TYPE"].ToString(),
                            DefaultValue = dr["COLUMN_DEFAULT"].ToString(),
                            IsNull = (dr["IS_NULLABLE"].ToString() == "YES"),
                            Validate = dr["IS_NULLABLE"].ToString() != "YES",
                            Length = dr["CHARACTER_MAXIMUM_LENGTH"] != DBNull.Value ? int.Parse(dr["CHARACTER_MAXIMUM_LENGTH"].ToString()) : (int?)null
                        };
                        pr.DotNetType = GetDotNetType(pr);
                        pr.DefaultValue = pr.DefaultValue.Replace("(", "").Replace(")", "");
                        if (dr["CHARACTER_MAXIMUM_LENGTH"] != DBNull.Value)
                        {
                            pr.Length = int.Parse(dr["CHARACTER_MAXIMUM_LENGTH"].ToString());
                        }
                        else
                        {
                            pr.Length = null;
                        }

                        if (pr.DefaultValue != string.Empty)
                        {
                            if (pr.SqlType == "Bit")
                            {
                                pr.DefaultValue = (pr.DefaultValue == "0" ? "false" : "true");
                            }

                            if (pr.DotNetType == "string")
                            {
                                pr.DefaultValue = "\"" + pr.DefaultValue + "\"";
                            }
                        }
                        props.Add(pr);
                        props.Schema = dr["TABLE_SCHEMA"].ToString();
                    }
                    dr.Close();
                }
                command.CommandText = "SELECT     ep.value FROM  sys.extended_properties AS ep INNER JOIN " +
                                      "sys.tables AS t ON ep.major_id = t.object_id INNER JOIN " +
                                      "sys.schemas ON t.schema_id = sys.schemas.schema_id " +
                                      "WHERE     (t.name = '" + tableName + "') AND (ep.minor_id = 0) AND sys.schemas.name = '" + schema + "'";
                object caption = command.ExecuteScalar();
                props.TableDescription = caption != null && !(caption is DBNull) ? caption.ToString() : string.Empty;

                command.CommandText = "SELECT  c.name AS [Column Name], value AS [Extended Property] " +
                                      " FROM sys.extended_properties AS ep INNER JOIN " +
                                      "sys.tables AS t ON ep.major_id = t.object_id INNER JOIN " +
                                      "sys.columns AS c ON ep.major_id = c.object_id AND ep.minor_id = c.column_id INNER JOIN " +
                                      "sys.schemas ON t.schema_id = sys.schemas.schema_id " +
                                      "WHERE t.name = '" + tableName + "' AND sys.schemas.name='" + schema + "'";
                dr = command.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (props[dr[0].ToString()] != null)
                        {
                            props[dr[0].ToString()].Description = dr[1].ToString();
                        }
                    }
                    dr.Close();
                }
                command.CommandText = "SELECT     c.name,  c.is_identity FROM sys.tables AS t INNER JOIN " +
                                      "sys.columns AS c ON t.object_id = c.object_id INNER JOIN " +
                                      "sys.schemas ON t.schema_id = sys.schemas.schema_id " +
                                      "WHERE     (t.name = '" + tableName + "') AND sys.schemas.name = '" + schema + "'";
                dr = command.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (props[dr[0].ToString()] != null)
                        {
                            props[dr[0].ToString()].IsIdentity = bool.Parse(dr[1].ToString());
                        }
                    }
                    dr.Close();
                }
                command.CommandText = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE (TABLE_NAME = '" + tableName + "') AND (TABLE_SCHEMA= '" + schema + "') AND (CONSTRAINT_NAME LIKE 'pk%')";
                dr = command.ExecuteReader();
                keys.Clear();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        foreach (Property pr in props.GetAll)
                        {
                            if (pr.Name == dr[0].ToString())
                            {
                                keys.Add(pr);
                            }
                        }
                    }
                    dr.Close();
                }
                command.CommandText = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE (TABLE_NAME = '" + tableName + "') AND (CONSTRAINT_NAME LIKE 'ix%') AND (TABLE_SCHEMA= '" + schema + "')";
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    props[dr[0].ToString()].IsUnique = true;
                }
                dr.Close();
                command.CommandText =
                    "SELECT     INFORMATION_SCHEMA.KEY_COLUMN_USAGE.COLUMN_NAME, INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.TABLE_NAME, " +
                    "INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS.UNIQUE_CONSTRAINT_NAME " +
                    "FROM         INFORMATION_SCHEMA.KEY_COLUMN_USAGE INNER JOIN " +
                    "INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS ON  " +
                    "INFORMATION_SCHEMA.KEY_COLUMN_USAGE.CONSTRAINT_NAME = INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS.CONSTRAINT_NAME INNER " +
                    "JOIN " +
                    "INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE ON  " +
                    "INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS.CONSTRAINT_NAME = INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.CONSTRAINT_NAME " +
                    "WHERE     (INFORMATION_SCHEMA.KEY_COLUMN_USAGE.CONSTRAINT_NAME LIKE N'FK%')  AND (INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.TABLE_NAME = N'" +
                    tableName + "') AND (INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.TABLE_SCHEMA = N'" + schema + "')";
                dr = command.ExecuteReader();
                Dictionary<string, string> pk = new Dictionary<string, string>();
                if (dr != null)
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            if (!pk.ContainsKey(dr["COLUMN_NAME"].ToString()))
                            {
                                pk.Add(dr["COLUMN_NAME"].ToString(), dr["UNIQUE_CONSTRAINT_NAME"].ToString());
                            }
                        }
                    }

                    dr.Close();
                    props.HasForeignKey = false;
                    foreach (string str in pk.Keys)
                    {
                        command.CommandText = "SELECT     COLUMN_NAME, TABLE_NAME, CONSTRAINT_NAME FROM         INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE     (CONSTRAINT_NAME = '" + pk[str] + "')";
                        dr = command.ExecuteReader();
                        if (dr == null)
                        {
                            continue;
                        }

                        props.HasForeignKey = dr.HasRows;
                        while (dr.Read())
                        {
                            props[str].ParentName = dr["TABLE_NAME"].ToString();
                            props[str].ParentField = dr["COLUMN_NAME"].ToString();
                        }
                        dr.Close();
                    }
                }
                command.Dispose();
            }
        }

        private void LoadSettings()
        {
            txtNamespaceBol.Text = Manager.Settings.bolNameSpace;
            txtNamespaceDAL.Text = Manager.Settings.dalNameSpace;
            txtdsNamespaceClass.Text = Manager.Settings.dsNameSpace;
            txtDsNamespaceFacade.Text = Manager.Settings.dsNameSpace;
            txtNamespaceFacade.Text = Manager.Settings.facadeNameSpace;
        }

        #region Class
        private string GenerateClass(string table)
        {
            GetColumns(table);
            lblProcessing.Text = "Generating class for " + table + " table...";
            if (!chAllClass.Checked)
            {
                prog.Minimum = 0;
                prog.Minimum = props.Count;
            }
            //Code Generating
            StringBuilder str = new StringBuilder();
            str.AppendLine("[Serializable]");
            if (!string.IsNullOrEmpty(props.TableDescription))
            {
                str.AppendLine(string.Format("[Description(\"{0}\")]", props.TableDescription));
            }

            str.AppendLine(string.Format("[Schema(\"{0}\")]", props.Schema));
            table = table.Split('.')[1];
            str.AppendLine(cbClassModifier.SelectedItem + " class " + table + " : DataStructureBase<" + table + ">");
            str.AppendLine("{");
            foreach (Property pr in props.GetAll)
            {
                if (!chAllClass.Checked)
                {
                    prog.Increment(1);
                }
                string fieldName = "_" + this.GetCamelCase(pr.Name);
                if (pr.ParentName != string.Empty)
                {
                    str.AppendLine("\tprivate " + pr.DotNetType + " " + fieldName + (pr.DefaultValue != string.Empty ? " = " + pr.DefaultValue + ";" : ";"));

                    GetPropertyAttributes(str, pr, false);

                    str.AppendLine("\tpublic " + pr.DotNetType + " " + pr.Name);
                    str.AppendLine("\t{");
                    str.AppendLine("\t\tget");
                    str.AppendLine("\t\t{");
                    str.AppendLine("\t\t\treturn this." + fieldName + ";");
                    str.AppendLine("\t\t}");
                    str.AppendLine("\t\tset");
                    str.AppendLine("\t\t{");
                    str.AppendLine("\t\t\tbase.SetPropertyValue(\"" + pr.Name + "\", value);");
                    if (pr.IsNull)
                    {
                        str.AppendLine("\t\t\tif (value.HasValue)");
                        str.AppendLine("\t\t\t\tthis." + pr.ParentName + " = new " + pr.ParentName + " { " + pr.ParentField + " = value.Value };");
                        str.AppendLine("\t\t\telse");
                        str.AppendLine("\t\t\t\tthis." + pr.ParentName + " = null;");
                    }
                    else
                    {
                        str.AppendLine("\t\t\t\tthis." + pr.ParentName + " = new " + pr.ParentName + " { " + pr.ParentField + " = value };");
                    }

                    str.AppendLine("\t\t}");
                    str.AppendLine("\t}");
                    str.AppendLine($"[Assosiation(PropName = \"{pr.Name}\")]");
                    str.AppendLine($"public {pr.ParentName} {pr.ParentName}" + " {get; set;}");
                    str.AppendLine();
                }
                else
                {
                    str.AppendLine("private" + " " + pr.DotNetType + " " + fieldName + ";");
                    GetPropertyAttributes(str, pr, false);
                    str.AppendLine("\tpublic " + pr.DotNetType + " " + pr.Name);
                    str.AppendLine("{");
                    str.AppendLine("get { return " + fieldName + "; }");
                    str.AppendLine("set { base.SetPropertyValue(\"" + pr.Name + "\", value); }");
                    str.AppendLine("}");
                    str.AppendLine();
                }

            }
            str.AppendLine();
            str.AppendLine("[DisableAction(DisableInsert = true, DisableUpdate = true, DiableSelect = true)]");
            str.AppendLine(" public override string DescriptionField");
            str.AppendLine("{");
            str.AppendLine("    get { return this.Title; }");
            str.AppendLine("}");

            str.AppendLine("}");

            //Collection Generating
            return str.ToString();
        }

        private string GenerateDataStructureFileContent(string table, string path)
        {
            string content = "using System;\r\nusing Radyn.Framework;\r\n\r\n";
            string _namespace = Manager.Settings.defaultNamespace + ".DataStructure";
            string projectNamespace = Manager.settings.saveProjectPath + "\\DataStructure\\";
            if (path.StartsWith(projectNamespace))
            {
                string additionalNamespace = path.Substring(projectNamespace.Length, path.Length - projectNamespace.Length);
                foreach (string folder in additionalNamespace.Split('\\'))
                {
                    _namespace += "." + folder;
                }
            }


            content += "namespace " + _namespace + " \r\n{";
            content += GenerateClass(table) + "\r\n}";
            return content;
        }

        private void GetPropertyAttributes(StringBuilder str, Property pr, bool isParent)
        {
            if (!string.IsNullOrEmpty(pr.Description))
            {
                str.AppendLine(string.Format("[Layout(Caption = \"{0}\")]", pr.Description));
            }

            if (isParent)
            {
                str.AppendLine("[Assosiation]");
            }
            else
            {
                if (keys.GetAll.Any(x => x.Name.Equals(pr.Name)))
                {
                    str.AppendLine("[Key(" + pr.IsIdentity.ToString().ToLower() + ")]");
                }
                if (pr.IsUnique)
                {
                    str.AppendLine("[Unique]");
                }

                if (pr.IsNull)
                {
                    str.AppendLine("[IsNullable]");
                }

                if (pr.Length.HasValue)
                {
                    str.AppendLine("[DbType(\"" + pr.SqlType.ToLower() + "(" + (pr.Length.Value == -1 ? "max" : pr.Length.Value.ToString()) + ")" + "\")]");
                }
                else
                {
                    str.AppendLine("[DbType(\"" + pr.SqlType.ToLower() + "\")]");
                }
            }
        }

        private string GetDotNetType(Property pr)
        {
            string retVal = "";
            switch (pr.SqlType.ToLower())
            {
                case "bigint":
                    retVal = "Int64" + (pr.IsNull ? "?" : "");
                    pr.SqlType = SqlDbType.BigInt.ToString();
                    break;
                case "bit":
                    retVal = "bool" + (pr.IsNull ? "?" : "");
                    pr.SqlType = SqlDbType.Bit.ToString();
                    break;
                case "char":
                    pr.SqlType = SqlDbType.Char.ToString();
                    retVal = "string";
                    break;
                case "uniqueidentifier":
                    pr.SqlType = SqlDbType.UniqueIdentifier.ToString();
                    retVal = "Guid" + (pr.IsNull ? "?" : "");
                    break;
                case "nchar":
                    pr.SqlType = SqlDbType.NChar.ToString();
                    retVal = "string";
                    break;
                case "ntext":
                    pr.SqlType = SqlDbType.NText.ToString();
                    retVal = "string";
                    break;
                case "nvarchar":
                    pr.SqlType = SqlDbType.NVarChar.ToString();
                    retVal = "string";
                    break;
                case "text":
                    pr.SqlType = SqlDbType.Text.ToString();
                    retVal = "string";
                    break;
                case "varchar":
                    pr.SqlType = SqlDbType.VarChar.ToString();
                    retVal = "string";
                    break;
                case "datetime":
                    pr.SqlType = SqlDbType.DateTime.ToString();
                    retVal = "DateTime" + (pr.IsNull ? "?" : "");
                    break;
                case "smalldatetime":
                    retVal = "DateTime" + (pr.IsNull ? "?" : "");
                    break;
                case "money":
                    pr.SqlType = SqlDbType.Money.ToString();
                    retVal = "decimal" + (pr.IsNull ? "?" : "");
                    break;
                case "smallmoney":
                    pr.SqlType = SqlDbType.SmallMoney.ToString();
                    retVal = "decimal" + (pr.IsNull ? "?" : "");
                    break;
                case "decimal":
                    pr.SqlType = SqlDbType.Decimal.ToString();
                    retVal = "decimal" + (pr.IsNull ? "?" : "");
                    break;
                case "float":
                    pr.SqlType = SqlDbType.Float.ToString();
                    retVal = "double" + (pr.IsNull ? "?" : "");
                    break;
                case "int":
                    pr.SqlType = SqlDbType.Int.ToString();
                    retVal = "Int32" + (pr.IsNull ? "?" : "");
                    break;
                case "numeric":
                case "real":
                    pr.SqlType = SqlDbType.Real.ToString();
                    retVal = "double" + (pr.IsNull ? "?" : "");
                    break;
                case "smallint":
                    pr.SqlType = SqlDbType.SmallInt.ToString();
                    retVal = "Int16" + (pr.IsNull ? "?" : "");
                    break;
                case "tinyint":
                    pr.SqlType = SqlDbType.TinyInt.ToString();
                    retVal = "byte" + (pr.IsNull ? "?" : "");
                    break;
                case "image":
                    pr.SqlType = SqlDbType.Image.ToString();
                    retVal = "byte[]";
                    break;
                case "varbinary":
                    pr.SqlType = SqlDbType.VarBinary.ToString();
                    retVal = "byte[]";
                    break;
            }

            return retVal;
        }

        #endregion

        #region Facade


        private void drpFacadeAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFacadeName();
            chWithFilterFacade.Text = @"With Filter";
            switch (drpFacadeAction.SelectedItem.ToString().ToLower())
            {
                case "get":
                    actionType = ActionType.Select;
                    break;
                case "update":
                    actionType = ActionType.Update;
                    break;
                case "delete":
                    actionType = ActionType.Delete;
                    break;
                case "insert":
                    chWithFilterFacade.Text = @"Return Identity";
                    actionType = ActionType.Insert;
                    break;
            }
        }

        private void chGenerateAllFacade_CheckedChanged(object sender, EventArgs e)
        {
            if (chGenerateAllFacade.Checked)
            {
                //this.cmbTableNames.Enabled = false;
                txtFacadeMethodName.Enabled = false;
                drpFacadeAction.Enabled = false;
                chWithFilterFacade.Enabled = false;
                btnCopyToClipboardFacade.Enabled = false;
            }
            else
            {
                //this.cmbTableNames.Enabled = true;
                txtFacadeMethodName.Enabled = true;
                drpFacadeAction.Enabled = true;
                chWithFilterFacade.Enabled = true;
                btnCopyToClipboardFacade.Enabled = true;
            }
        }

        private void btnCopyToClipboardFacade_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbFacade.Text);
            lblProcessing.Text = @"The method copied to clipboard.";
        }

        private void ChangeFacadeName()
        {
            if (drpFacadeAction.SelectedItem != null)
            {
                txtFacadeMethodName.Text = drpFacadeAction.SelectedItem.ToString();
            }
        }

        private void ChangeFacadeName(string table)
        {
            if (drpFacadeAction.SelectedItem != null)
            {
                txtFacadeMethodName.Text = table;
            }
        }

        #endregion
        private void mnChangeTableQuery_Click(object sender, EventArgs e)
        {
            TableQuery frm = new TableQuery(tableQuery);
            frm.ShowDialog();
            tableQuery = frm.Query;
            TableNameLoader();
        }

        #endregion


        private void cmbTableNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableName = cmbTableNames.Text;
            formModel = new FormModelCollection();
            GetTableDescription(tableName);
            ChangeFacadeName();
            //Set Component
            if (tableName.Contains("."))
            {
                var component = tableName.Split('.')[0];
                txtComponentName.Text = component;
                TxtTitleReact.Text = tableName.Split('.')[1];
            }
            else
            {
                TxtTitleReact.Text = tableName;
            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGenerateMethodDAL_Click(object sender, EventArgs e)
        {
            if (chGenerateDataProvider.Checked)
            {
                if (Manager.Settings.saveProjectPath != string.Empty)
                {
                    if (Directory.Exists(Manager.Settings.saveProjectPath))
                    {
                        folderBrowserDialog1.SelectedPath = Manager.Settings.saveProjectPath;
                    }
                }

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    prog.Visible = true;
                    prog.Step = 1;
                    prog.Minimum = 0;
                    prog.Maximum = cmbTableNames.Items.Count;
                    lblProcessing.Text = @"Generating Data Access Layer....";
                    foreach (object item in cmbTableNames.Items)
                    {
                        prog.Increment(1);
                        try
                        {
                            string table = ((DataRowView)(item)).Row.ItemArray[0].ToString();
                            string txt = GenerateDalClass(table, "");
                            FileStream fs = new FileStream(folderBrowserDialog1.SelectedPath + "\\" + table.Split('.')[1] + "DA.cs", FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
                            StreamWriter sw = new StreamWriter(fs);
                            sw.Write(txt);
                            sw.Flush();
                            sw.Close();
                            fs.Close();
                        }
                        catch { }
                    }
                    lblProcessing.Text = prog.Value + @" class(es) generated.";
                    MessageBox.Show(@"Command(s) completed successfully.");
                    prog.Visible = false;
                    Manager.GetTable(TableName.saveProjectPath)["value"] = folderBrowserDialog1.SelectedPath;
                    Manager.WriteDatas();
                    lblProcessing.Text = @"Ready";
                }

            }
            else
            {
                rtbMethodDAl.Text = GenerateDalClass(tableName, "");
                lblProcessing.Text = @"The method generated.";
                btnCopyToclipboardMethodDAl.Enabled = true;
                SaveToDalFile.Enabled = true;
            }
        }

        private void SaveToDalFile_Click(object sender, EventArgs e)
        {
            ShowSaveFileDialog(tableName.Split('.')[1] + "DA");
        }

        private void ShowSaveFileDialog(string fileName)
        {
            if (Manager.GetTable(TableName.lastSaveFile)["path"].ToString() != string.Empty)
            {
                saveFileDialog1.InitialDirectory = Manager.GetTable(TableName.lastSaveFile)["path"].ToString();
            }
            else
            {
                saveFileDialog1.InitialDirectory = "C:\\";
            }
            saveFileDialog1.FileName = fileName + ".cs";
            saveFileDialog1.ShowDialog();
        }

        private void SaveFileDialogFile(string fileContent)
        {
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
            FileInfo fileInfo = new FileInfo(saveFileDialog1.FileName);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(fileContent);
            sw.Flush();
            sw.Close();
            fs.Close();
            Manager.GetTable(TableName.lastSaveFile)["path"] = fileInfo.DirectoryName;
            Manager.WriteDatas();
        }

        private void chGeneratePartialView_CheckedChanged(object sender, EventArgs e)
        {
            chEditViewMvc.Visible = true;
            chListViewMvc.Visible = true;
            chDeleteViewMvc.Visible = true;
            chDetailViewMvc.Visible = true;
            chCreateViewMvc.Visible = true;
        }

        private string GetCamelCase(string txt)
        {
            if (string.IsNullOrEmpty(txt)) return txt;
            return txt[0].ToString().ToLower() + txt.Substring(1, txt.Length - 1);
        }
    }
}