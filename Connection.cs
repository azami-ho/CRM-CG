using System;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace CodeGenerator
{
    public partial class Connection : Form
    {
        Server server;
        public Connection()
        {
            InitializeComponent();
        }

        #region Events

        private void Connection_Load(object sender, EventArgs e)
        {
            this.txtDataSource.Text = Manager.GetTable(TableName.connectionString)["dataSource"].ToString();
            this.chWindowsAuthentiction.Checked = bool.Parse(Manager.GetTable(TableName.connectionString)["integratedSecurity"].ToString());
            this.txtUsername.Text = Manager.GetTable(TableName.connectionString)["uid"].ToString();
            this.txtPassword.Text = Manager.GetTable(TableName.connectionString)["pwd"].ToString();
            if (!string.IsNullOrEmpty(Manager.GetTable(TableName.connectionString)["dataBase"].ToString()))
            {
                this.LoadDatabases();
                this.cbDataBase.SelectedText = Manager.GetTable(TableName.connectionString)["dataBase"].ToString();
            }
        }

        private void chWindowsAuthentiction_CheckedChanged(object sender, EventArgs e)
        {
            this.gbSqlAuthentication.Enabled = !this.chWindowsAuthentiction.Checked;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.validConnection(this.GetConnectionString(false)))
                {
                    this.GetConnectionString(true);
                    Manager.FillSettings();
                    var frm = new Form1(this.GetConnectionString(false));
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(@"Invalid Conneciton!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Conneciton!" + Environment.NewLine + ex.Message);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(this.validConnection(this.GetConnectionString(false))
                                    ? @"Test connection successfully!"
                                    : @"Invalid Conneciton!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Conneciton!" + Environment.NewLine + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void txtDataSource_Leave(object sender, EventArgs e)
        {
            try
            {
                this.LoadDatabases();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbDataBase_DropDown(object sender, EventArgs e)
        {
            try
            {
                this.LoadDatabases();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Connection_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Methods
        private void LoadDatabases()
        {
            this.cbDataBase.Items.Clear();
            string serverInstance = this.txtDataSource.Text;
            var serverConnection = new ServerConnection(serverInstance);
            server = new Server(serverConnection);
            try
            {
                foreach (Database db in server.Databases)
                    this.cbDataBase.Items.Add(db.Name);
            }
            catch (Exception ex)
            {
                try
                {
                    serverConnection = new ServerConnection(serverInstance, this.txtUsername.Text.Trim(), this.txtPassword.Text);
                    server = new Server(serverConnection);
                    foreach (Database db in server.Databases)
                    {
                        this.cbDataBase.Items.Add(db.Name);
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Unable to connect\"" + server.Name + "\"" + Environment.NewLine + ex.Message);
                }
            }
        }

        private string GetConnectionString(bool writeToFile)
        {
            string str = "";
            //Data Source
            if (this.txtDataSource.Text != string.Empty)
            {
                Manager.GetTable(TableName.connectionString)["dataSource"] = this.txtDataSource.Text;
                str += "Data Source = " + this.txtDataSource.Text + ";";
            }
            else
                MessageBox.Show(@"Please set the DataSource!");
            //DataBase
            if (!string.IsNullOrEmpty(this.cbDataBase.Text))
            {
                Manager.GetTable(TableName.connectionString)["dataBase"] = this.cbDataBase.Text;
                str += "Initial Catalog = " + this.cbDataBase.Text + ";";
            }
            else
                MessageBox.Show(@"Please set the Data Base!");
            //Security
            if (this.chWindowsAuthentiction.Checked)
            {
                Manager.GetTable(TableName.connectionString)["integratedSecurity"] = "true";
                str += "Integrated Security = True;";
            }
            else
            {
                Manager.GetTable(TableName.connectionString)["integratedSecurity"] = "false";
                Manager.GetTable(TableName.connectionString)["uid"] = this.txtUsername.Text;
                Manager.GetTable(TableName.connectionString)["pwd"] = this.txtPassword.Text;
                str += "UID = " + this.txtUsername.Text + ";";
                str += "PWD = " + this.txtPassword.Text + ";";
            }
            if (writeToFile)
            {
                Manager.WriteDatas();
            }
            return str;
        }

        private bool validConnection(string connectionString)
        {
            var connection = new System.Data.SqlClient.SqlConnection(connectionString);
            connection.Open();
            connection.Dispose();
            return true;
        }

        #endregion


    }
}