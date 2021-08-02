
namespace PkuEmployee.Reports
{
    partial class frmExperienceReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.pbxEmployeeAdd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsExperienceReport = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsExperienceReport)).BeginInit();
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
            this.nameDataGridViewTextBoxColumn,
            this.allDataGridViewTextBoxColumn,
            this.currentDataGridViewTextBoxColumn});
            this.dgvEmployees.DataSource = this.bsExperienceReport;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 66);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(624, 468);
            this.dgvEmployees.TabIndex = 3;
            // 
            // pbxEmployeeAdd
            // 
            this.pbxEmployeeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxEmployeeAdd.Image = global::PkuEmployee.Properties.Resources.icons8_microsoft_excel_2019_48px;
            this.pbxEmployeeAdd.Location = new System.Drawing.Point(588, 12);
            this.pbxEmployeeAdd.Name = "pbxEmployeeAdd";
            this.pbxEmployeeAdd.Size = new System.Drawing.Size(48, 48);
            this.pbxEmployeeAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEmployeeAdd.TabIndex = 4;
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
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Фильтрация (ФИО):";
            // 
            // tbxFilter
            // 
            this.tbxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFilter.Location = new System.Drawing.Point(12, 36);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(201, 20);
            this.tbxFilter.TabIndex = 10;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PkuEmployee.Properties.Resources.icons8_clear_filters_48px;
            this.pictureBox1.Location = new System.Drawing.Point(219, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxEmployeeAdd_MouseUp);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allDataGridViewTextBoxColumn
            // 
            this.allDataGridViewTextBoxColumn.DataPropertyName = "All";
            this.allDataGridViewTextBoxColumn.HeaderText = "Общий стаж";
            this.allDataGridViewTextBoxColumn.Name = "allDataGridViewTextBoxColumn";
            this.allDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentDataGridViewTextBoxColumn
            // 
            this.currentDataGridViewTextBoxColumn.DataPropertyName = "Current";
            this.currentDataGridViewTextBoxColumn.HeaderText = "В текущей организации";
            this.currentDataGridViewTextBoxColumn.Name = "currentDataGridViewTextBoxColumn";
            this.currentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsExperienceReport
            // 
            this.bsExperienceReport.DataSource = typeof(PkuEmployee.Reports.ExperienceReport);
            // 
            // frmExperienceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxEmployeeAdd);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "frmExperienceReport";
            this.Text = "Стажи сотрудников";
            this.Load += new System.EventHandler(this.frmExperienceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsExperienceReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxEmployeeAdd;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.BindingSource bsExperienceReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}