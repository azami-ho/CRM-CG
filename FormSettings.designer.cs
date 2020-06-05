namespace CodeGenerator
{
    partial class FormSettings
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chSelectAll = new System.Windows.Forms.CheckBox();
            this.chDeselectAll = new System.Windows.Forms.CheckBox();
            this.chSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(525, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(606, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chSelect,
            this.FieldName,
            this.Description,
            this.ControlType,
            this.Width,
            this.Validate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 355);
            this.dataGridView1.TabIndex = 3;
            // 
            // chSelectAll
            // 
            this.chSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chSelectAll.AutoSize = true;
            this.chSelectAll.Location = new System.Drawing.Point(12, 377);
            this.chSelectAll.Name = "chSelectAll";
            this.chSelectAll.Size = new System.Drawing.Size(70, 17);
            this.chSelectAll.TabIndex = 4;
            this.chSelectAll.Text = "Select All";
            this.chSelectAll.UseVisualStyleBackColor = true;
            this.chSelectAll.CheckedChanged += new System.EventHandler(this.chSelectAll_CheckedChanged);
            // 
            // chDeselectAll
            // 
            this.chDeselectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chDeselectAll.AutoSize = true;
            this.chDeselectAll.Location = new System.Drawing.Point(88, 377);
            this.chDeselectAll.Name = "chDeselectAll";
            this.chDeselectAll.Size = new System.Drawing.Size(82, 17);
            this.chDeselectAll.TabIndex = 5;
            this.chDeselectAll.Text = "Deselect All";
            this.chDeselectAll.UseVisualStyleBackColor = true;
            this.chDeselectAll.CheckedChanged += new System.EventHandler(this.chDeselectAll_CheckedChanged);
            // 
            // chSelect
            // 
            this.chSelect.DataPropertyName = "Select";
            this.chSelect.HeaderText = "";
            this.chSelect.Name = "chSelect";
            this.chSelect.Width = 25;
            // 
            // FieldName
            // 
            this.FieldName.DataPropertyName = "Name";
            this.FieldName.HeaderText = "Field Name";
            this.FieldName.Name = "FieldName";
            this.FieldName.ReadOnly = true;
            this.FieldName.Width = 150;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 150;
            // 
            // ControlType
            // 
            this.ControlType.DataPropertyName = "Control";
            this.ControlType.HeaderText = "Type";
            this.ControlType.Items.AddRange(new object[] {
            "TextBox",
            "Numeric",
            "Label",
            "DropDownList",
            "CheckBox",
            "DatePicker",
            "TimeBox",
            "PersonSelector",
            "ImageFile"});
            this.ControlType.Name = "ControlType";
            this.ControlType.Width = 120;
            // 
            // Width
            // 
            this.Width.DataPropertyName = "Width";
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            this.Width.Width = 80;
            // 
            // Validate
            // 
            this.Validate.DataPropertyName = "Validate";
            this.Validate.HeaderText = "Validate";
            this.Validate.Name = "Validate";
            this.Validate.Width = 65;
            // 
            // FormSettings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(693, 402);
            this.Controls.Add(this.chDeselectAll);
            this.Controls.Add(this.chSelectAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chSelectAll;
        private System.Windows.Forms.CheckBox chDeselectAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewComboBoxColumn ControlType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Validate;
    }
}