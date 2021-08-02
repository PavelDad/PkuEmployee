
namespace PkuEmployee.Reports
{
    partial class frmSubjectsReport
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
            this.pbxEmployeeAdd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSubjectReport = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubjectReport)).BeginInit();
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
            this.subjectDataGridViewTextBoxColumn,
            this.employeesDataGridViewTextBoxColumn});
            this.dgvEmployees.DataSource = this.bsSubjectReport;
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
            this.dgvEmployees.Size = new System.Drawing.Size(952, 579);
            this.dgvEmployees.TabIndex = 1;
            // 
            // pbxEmployeeAdd
            // 
            this.pbxEmployeeAdd.Image = global::PkuEmployee.Properties.Resources.icons8_microsoft_excel_2019_48px;
            this.pbxEmployeeAdd.Location = new System.Drawing.Point(916, 12);
            this.pbxEmployeeAdd.Name = "pbxEmployeeAdd";
            this.pbxEmployeeAdd.Size = new System.Drawing.Size(48, 48);
            this.pbxEmployeeAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEmployeeAdd.TabIndex = 2;
            this.pbxEmployeeAdd.TabStop = false;
            this.pbxEmployeeAdd.Click += new System.EventHandler(this.pbxEmployeeAdd_Click);
            this.pbxEmployeeAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseDown);
            this.pbxEmployeeAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фильтрация (Дисциплина):";
            // 
            // tbxFilter
            // 
            this.tbxFilter.Location = new System.Drawing.Point(12, 36);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(201, 20);
            this.tbxFilter.TabIndex = 7;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PkuEmployee.Properties.Resources.icons8_clear_filters_48px;
            this.pictureBox1.Location = new System.Drawing.Point(219, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseUp);
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Дисциплина";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeesDataGridViewTextBoxColumn
            // 
            this.employeesDataGridViewTextBoxColumn.DataPropertyName = "Employees";
            this.employeesDataGridViewTextBoxColumn.HeaderText = "Сотрудники";
            this.employeesDataGridViewTextBoxColumn.Name = "employeesDataGridViewTextBoxColumn";
            this.employeesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsSubjectReport
            // 
            this.bsSubjectReport.DataSource = typeof(PkuEmployee.Reports.SubjectReport);
            // 
            // frmSubjectsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 657);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxEmployeeAdd);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "frmSubjectsReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Преподаватели на дисциплинах";
            this.Load += new System.EventHandler(this.frmSubjectsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubjectReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsSubjectReport;
        private System.Windows.Forms.PictureBox pbxEmployeeAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}