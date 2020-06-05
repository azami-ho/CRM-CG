using System;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class TableQuery : Form
    {
        public TableQuery(string query)
        {
            InitializeComponent();
            this.txtQuery.Text = query;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.query = this.txtQuery.Text;
            this.Close();
        }

        private string query;
        public string Query
        {
            get { return query; }
            private set { query = value; }
        }

        private void TableQuery_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtQuery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }

    }
}