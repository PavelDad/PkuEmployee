
namespace PkuEmployee.OrdersForms
{
    partial class frmOrdersView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.pbxWord = new System.Windows.Forms.PictureBox();
            this.pbxExcel = new System.Windows.Forms.PictureBox();
            this.pbxClear = new System.Windows.Forms.PictureBox();
            this.pbxOrderDelete = new System.Windows.Forms.PictureBox();
            this.pbxOrderEdit = new System.Windows.Forms.PictureBox();
            this.pbxOrderAdd = new System.Windows.Forms.PictureBox();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOrder = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOrderDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOrderEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOrderAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.AutoGenerateColumns = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CreateDate,
            this.numberDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvEmployees.DataSource = this.bsOrder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 66);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(984, 651);
            this.dgvEmployees.TabIndex = 1;
            // 
            // tbxFilter
            // 
            this.tbxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFilter.Location = new System.Drawing.Point(738, 40);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(201, 20);
            this.tbxFilter.TabIndex = 7;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // pbxWord
            // 
            this.pbxWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxWord.Image = global::PkuEmployee.Properties.Resources.icons8_microsoft_word_2019_48px;
            this.pbxWord.Location = new System.Drawing.Point(630, 12);
            this.pbxWord.Name = "pbxWord";
            this.pbxWord.Size = new System.Drawing.Size(48, 48);
            this.pbxWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxWord.TabIndex = 9;
            this.pbxWord.TabStop = false;
            this.pbxWord.Click += new System.EventHandler(this.pbxWord_Click);
            this.pbxWord.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseDown);
            this.pbxWord.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseUp);
            // 
            // pbxExcel
            // 
            this.pbxExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxExcel.Image = global::PkuEmployee.Properties.Resources.icons8_microsoft_excel_2019_48px;
            this.pbxExcel.Location = new System.Drawing.Point(684, 12);
            this.pbxExcel.Name = "pbxExcel";
            this.pbxExcel.Size = new System.Drawing.Size(48, 48);
            this.pbxExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxExcel.TabIndex = 9;
            this.pbxExcel.TabStop = false;
            this.pbxExcel.Click += new System.EventHandler(this.pbxExcel_Click);
            this.pbxExcel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseDown);
            this.pbxExcel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseUp);
            // 
            // pbxClear
            // 
            this.pbxClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxClear.Image = global::PkuEmployee.Properties.Resources.icons8_clear_filters_48px;
            this.pbxClear.Location = new System.Drawing.Point(948, 12);
            this.pbxClear.Name = "pbxClear";
            this.pbxClear.Size = new System.Drawing.Size(48, 48);
            this.pbxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxClear.TabIndex = 6;
            this.pbxClear.TabStop = false;
            this.pbxClear.Click += new System.EventHandler(this.pbxClear_Click);
            this.pbxClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseDown);
            this.pbxClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseUp);
            // 
            // pbxOrderDelete
            // 
            this.pbxOrderDelete.Image = global::PkuEmployee.Properties.Resources.icons8_delete_48px_1;
            this.pbxOrderDelete.Location = new System.Drawing.Point(120, 12);
            this.pbxOrderDelete.Name = "pbxOrderDelete";
            this.pbxOrderDelete.Size = new System.Drawing.Size(48, 48);
            this.pbxOrderDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOrderDelete.TabIndex = 2;
            this.pbxOrderDelete.TabStop = false;
            this.pbxOrderDelete.Click += new System.EventHandler(this.pbxOrderDelete_Click);
            this.pbxOrderDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseDown);
            this.pbxOrderDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseUp);
            // 
            // pbxOrderEdit
            // 
            this.pbxOrderEdit.Image = global::PkuEmployee.Properties.Resources.icons8_check_file_48px;
            this.pbxOrderEdit.Location = new System.Drawing.Point(66, 12);
            this.pbxOrderEdit.Name = "pbxOrderEdit";
            this.pbxOrderEdit.Size = new System.Drawing.Size(48, 48);
            this.pbxOrderEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOrderEdit.TabIndex = 3;
            this.pbxOrderEdit.TabStop = false;
            this.pbxOrderEdit.Click += new System.EventHandler(this.pbxOrderEdit_Click);
            this.pbxOrderEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseDown);
            this.pbxOrderEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseUp);
            // 
            // pbxOrderAdd
            // 
            this.pbxOrderAdd.Image = global::PkuEmployee.Properties.Resources.icons8_plus_48px;
            this.pbxOrderAdd.Location = new System.Drawing.Point(12, 12);
            this.pbxOrderAdd.Name = "pbxOrderAdd";
            this.pbxOrderAdd.Size = new System.Drawing.Size(48, 48);
            this.pbxOrderAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOrderAdd.TabIndex = 4;
            this.pbxOrderAdd.TabStop = false;
            this.pbxOrderAdd.Click += new System.EventHandler(this.pbxOrderAdd_Click);
            this.pbxOrderAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseDown);
            this.pbxOrderAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseUp);
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.FillWeight = 50F;
            this.CreateDate.HeaderText = "Дата";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(738, 12);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(96, 20);
            this.dtpFrom.TabIndex = 10;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(846, 12);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(96, 20);
            this.dtpTo.TabIndex = 10;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.FillWeight = 30F;
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.FillWeight = 80F;
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 90F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Заголовок";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Текст приказа";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsOrder
            // 
            this.bsOrder.DataSource = typeof(PkuEmployee.Model.Order);
            // 
            // frmOrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.pbxWord);
            this.Controls.Add(this.pbxExcel);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.pbxClear);
            this.Controls.Add(this.pbxOrderDelete);
            this.Controls.Add(this.pbxOrderEdit);
            this.Controls.Add(this.pbxOrderAdd);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "frmOrdersView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приказы";
            this.Load += new System.EventHandler(this.frmOrdersView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOrderDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOrderEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOrderAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.BindingSource bsOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pbxOrderDelete;
        private System.Windows.Forms.PictureBox pbxOrderEdit;
        private System.Windows.Forms.PictureBox pbxOrderAdd;
        private System.Windows.Forms.TextBox tbxFilter;
        private System.Windows.Forms.PictureBox pbxClear;
        private System.Windows.Forms.PictureBox pbxExcel;
        private System.Windows.Forms.PictureBox pbxWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
    }
}