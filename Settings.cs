using System;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.txtBolNamespace.Text = Manager.GetTable(TableName.bolNameSpace)["value"].ToString();
            this.txtContentPlaceHolder.Text = Manager.GetTable(TableName.contentPlaceHolderID)["id"].ToString();
            this.txtDalNamespace.Text = Manager.GetTable(TableName.dalNameSpace)["value"].ToString();
            this.txtDataStructureNamespace.Text = Manager.GetTable(TableName.dsNameSpace)["value"].ToString();
            this.txtFacadeNamespace.Text = Manager.GetTable(TableName.facadeNameSpace)["value"].ToString();
            this.txtMasterPage.Text = Manager.GetTable(TableName.masterPageUrl)["path"].ToString();
            this.txtSaveFilePath.Text = Manager.GetTable(TableName.lastSaveFile)["path"].ToString();
            this.txtSaveProjectPath.Text = Manager.GetTable(TableName.saveProjectPath)["value"].ToString();
            this.txtDefaultNameSpace.Text = Manager.GetTable(TableName.defaultNamespace)["value"].ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Manager.GetTable(TableName.bolNameSpace)["value"] = this.txtBolNamespace.Text;
            Manager.GetTable(TableName.contentPlaceHolderID)["id"] = this.txtContentPlaceHolder.Text;
            Manager.GetTable(TableName.dalNameSpace)["value"] = this.txtDalNamespace.Text;
            Manager.GetTable(TableName.dsNameSpace)["value"] = this.txtDataStructureNamespace.Text;
            Manager.GetTable(TableName.facadeNameSpace)["value"] = this.txtFacadeNamespace.Text;
            Manager.GetTable(TableName.masterPageUrl)["path"] = this.txtMasterPage.Text;
            Manager.GetTable(TableName.lastSaveFile)["path"] = this.txtSaveFilePath.Text;
            Manager.GetTable(TableName.saveProjectPath)["value"] = this.txtSaveProjectPath.Text;
            Manager.GetTable(TableName.defaultNamespace)["value"] = this.txtDefaultNameSpace.Text;
            Manager.WriteDatas();
            Manager.FillSettings();
            MessageBox.Show("The Settings Saved Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnSaveFilePath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtSaveProjectPath.Text))
                this.folderBrowserDialog1.SelectedPath = this.txtSaveFilePath.Text;
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtSaveFilePath.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSaveProjectPath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtSaveProjectPath.Text))
                this.folderBrowserDialog1.SelectedPath = this.txtSaveProjectPath.Text;
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtSaveProjectPath.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

    }
}
