using System;
using System.Data;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        public FormSettings(PropertyCollection properties, Component.FormModelCollection formModel)
        {
            InitializeComponent();
            this.FormModel = formModel;
            this.props = properties;
        }

        readonly PropertyCollection props;
        readonly Component.FormModelCollection FormModel;

        private void FormSettings_Load(object sender, EventArgs e)
        {
            var dt = new DataTable("dt");
            dt.Columns.Add("Select");
            dt.Columns.Add("Name");
            dt.Columns.Add("Description");
            dt.Columns.Add("Control");
            dt.Columns.Add("Width");
            dt.Columns.Add("Validate");
            foreach (Property pr in this.props.GetAll)
            {
                DataRow dr = dt.NewRow();
                dr["Select"] = false;
                dr["Name"] = pr.Name;
                dr["Control"] = "TextBox";
                if (pr.DotNetType.Replace("?", "") != "string")
                    dr["Control"] = "Numeric";
                if (pr.DotNetType.Replace("?", "") == "string" && pr.Length == 10)
                    dr["Control"] = "DatePicker";
                if (pr.DotNetType.Replace("?", "") == "string" && pr.Length == 5)
                    dr["Control"] = "TimeBox";
                if (pr.DotNetType.Replace("?", "") == "guid" && pr.IsNull)
                    dr["Control"] = "ImageFile";
                if (!string.IsNullOrEmpty(pr.ParentName))
                    dr["Control"] = "DropDownList";
                if (pr.DotNetType.Replace("?", "") == "bool")
                    dr["Control"] = "CheckBox";
                dr["Description"] = pr.Description;
                dr["Validate"] = pr.Validate;
                dt.Rows.Add(dr);
            }
            this.dataGridView1.DataSource = dt;
            if (this.FormModel.Count > 0)
            {
                foreach (DataGridViewRow dr in this.dataGridView1.Rows)
                {
                    if (this.FormModel.Contains(dr.Cells[1].Value.ToString()))
                    {
                        dr.Cells[0].Value = true;
                        dr.Cells[2].Value = this.FormModel[dr.Cells[1].Value.ToString()].Description;
                        dr.Cells[3].Value = this.FormModel[dr.Cells[1].Value.ToString()].Control.ToString();
                        dr.Cells[4].Value = this.FormModel[dr.Cells[1].Value.ToString()].Width.ToString();
                        dr.Cells[5].Value = this.FormModel[dr.Cells[1].Value.ToString()].Validate;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.FormModel.Clear();
            foreach (DataGridViewRow dr in this.dataGridView1.Rows)
            {
                if (dr.Cells[0].Value != DBNull.Value)
                    if (bool.Parse(dr.Cells[0].Value.ToString()))
                    {
                        var itm = new Component.FormModel
                                      {
                                          Name = dr.Cells[1].Value.ToString(),
                                          Description = dr.Cells[2].Value.ToString(),
                                          Validate =
                                              dr.Cells[5].Value != DBNull.Value
                                                  ? Boolean.Parse(dr.Cells[5].Value.ToString())
                                                  : false,
                                          Width =
                                              dr.Cells[4].Value.ToString() != string.Empty
                                                  ? int.Parse(dr.Cells[4].Value.ToString())
                                                  : 200
                                      };
                        if (dr.Cells[3].Value.ToString() == string.Empty)
                            itm.Control = CodeGenerator.ControlType.TextBox;
                        else
                            switch (dr.Cells[3].Value.ToString())
                            {
                                case "CheckBox":
                                    itm.Control = CodeGenerator.ControlType.CheckBox;
                                    break;
                                case "DatePicker":
                                    itm.Control = CodeGenerator.ControlType.DatePicker;
                                    break;
                                case "TimeBox":
                                    itm.Control = CodeGenerator.ControlType.TimeBox;
                                    break;
                                case "DropDownList":
                                    itm.Control = CodeGenerator.ControlType.DropDownList;
                                    break;
                                case "Label":
                                    itm.Control = CodeGenerator.ControlType.Label;
                                    break;
                                case "PersonSelector":
                                    itm.Control = CodeGenerator.ControlType.PersonSelector;
                                    break;
                                case "TextBox":
                                    itm.Control = CodeGenerator.ControlType.TextBox;
                                    break;
                                case "Numeric":
                                    itm.Control = CodeGenerator.ControlType.Numeric;
                                    break;
                                case "ImageFile":
                                    itm.Control = CodeGenerator.ControlType.ImageFile;
                                    break;
                            }
                        this.FormModel.Add(itm);
                    }
            }
            this.Close();
        }

        private void chSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chSelectAll.Checked)
            {
                this.chDeselectAll.Checked = false;
                foreach (DataGridViewRow dr in this.dataGridView1.Rows)
                {
                    dr.Cells[0].Value = true;
                }
            }
        }

        private void chDeselectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chSelectAll.Checked)
            {
                this.chSelectAll.Checked = false;
                foreach (DataGridViewRow dr in this.dataGridView1.Rows)
                {
                    dr.Cells[0].Value = false;
                }
            }
        }
    }
}