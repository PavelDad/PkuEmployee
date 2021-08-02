
namespace PkuEmployee
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.RecruitmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DismissalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chbxDismissed = new System.Windows.Forms.CheckBox();
            this.mspMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nationalitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experienceReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxEmployeeDelete = new System.Windows.Forms.PictureBox();
            this.pbxEmployeeEdit = new System.Windows.Forms.PictureBox();
            this.pbxEmployeeAdd = new System.Windows.Forms.PictureBox();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEmployee = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.mspMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).BeginInit();
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
            this.noDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.RecruitmentDate,
            this.DismissalDate,
            this.idDataGridViewTextBoxColumn});
            this.dgvEmployees.DataSource = this.bsEmployee;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 81);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(984, 636);
            this.dgvEmployees.TabIndex = 0;
            // 
            // RecruitmentDate
            // 
            this.RecruitmentDate.DataPropertyName = "RecruitmentDate";
            this.RecruitmentDate.FillWeight = 80F;
            this.RecruitmentDate.HeaderText = "Дата приема";
            this.RecruitmentDate.Name = "RecruitmentDate";
            this.RecruitmentDate.ReadOnly = true;
            // 
            // DismissalDate
            // 
            this.DismissalDate.DataPropertyName = "DismissalDate";
            this.DismissalDate.FillWeight = 80F;
            this.DismissalDate.HeaderText = "Дата увольнения";
            this.DismissalDate.Name = "DismissalDate";
            this.DismissalDate.ReadOnly = true;
            // 
            // chbxDismissed
            // 
            this.chbxDismissed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxDismissed.AutoSize = true;
            this.chbxDismissed.Location = new System.Drawing.Point(912, 46);
            this.chbxDismissed.Name = "chbxDismissed";
            this.chbxDismissed.Size = new System.Drawing.Size(84, 17);
            this.chbxDismissed.TabIndex = 2;
            this.chbxDismissed.Text = "Уволенные";
            this.chbxDismissed.UseVisualStyleBackColor = true;
            this.chbxDismissed.CheckedChanged += new System.EventHandler(this.chbxDismissed_CheckedChanged);
            // 
            // mspMain
            // 
            this.mspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.directoriesToolStripMenuItem,
            this.orbersToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mspMain.Location = new System.Drawing.Point(0, 0);
            this.mspMain.Name = "mspMain";
            this.mspMain.Size = new System.Drawing.Size(1008, 24);
            this.mspMain.TabIndex = 3;
            this.mspMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // directoriesToolStripMenuItem
            // 
            this.directoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subjectsToolStripMenuItem,
            this.postsToolStripMenuItem,
            this.nationalitiesToolStripMenuItem,
            this.organizationsToolStripMenuItem});
            this.directoriesToolStripMenuItem.Name = "directoriesToolStripMenuItem";
            this.directoriesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.directoriesToolStripMenuItem.Text = "Справочники";
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.subjectsToolStripMenuItem.Text = "Дисциплины";
            this.subjectsToolStripMenuItem.Click += new System.EventHandler(this.subjectsToolStripMenuItem_Click);
            // 
            // postsToolStripMenuItem
            // 
            this.postsToolStripMenuItem.Name = "postsToolStripMenuItem";
            this.postsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.postsToolStripMenuItem.Text = "Должности";
            this.postsToolStripMenuItem.Click += new System.EventHandler(this.postsToolStripMenuItem_Click);
            // 
            // nationalitiesToolStripMenuItem
            // 
            this.nationalitiesToolStripMenuItem.Name = "nationalitiesToolStripMenuItem";
            this.nationalitiesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.nationalitiesToolStripMenuItem.Text = "Национальности";
            this.nationalitiesToolStripMenuItem.Click += new System.EventHandler(this.nationalitiesToolStripMenuItem_Click);
            // 
            // organizationsToolStripMenuItem
            // 
            this.organizationsToolStripMenuItem.Name = "organizationsToolStripMenuItem";
            this.organizationsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.organizationsToolStripMenuItem.Text = "Организации";
            this.organizationsToolStripMenuItem.Click += new System.EventHandler(this.organizationsToolStripMenuItem_Click);
            // 
            // orbersToolStripMenuItem
            // 
            this.orbersToolStripMenuItem.Name = "orbersToolStripMenuItem";
            this.orbersToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.orbersToolStripMenuItem.Text = "Приказы";
            this.orbersToolStripMenuItem.Click += new System.EventHandler(this.orbersToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeCardToolStripMenuItem,
            this.subjectReportToolStripMenuItem,
            this.experienceReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reportsToolStripMenuItem.Text = "Отчеты";
            // 
            // employeeCardToolStripMenuItem
            // 
            this.employeeCardToolStripMenuItem.Name = "employeeCardToolStripMenuItem";
            this.employeeCardToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.employeeCardToolStripMenuItem.Text = "Личная карточка сотрудника";
            this.employeeCardToolStripMenuItem.Click += new System.EventHandler(this.employeeCardToolStripMenuItem_Click);
            // 
            // subjectReportToolStripMenuItem
            // 
            this.subjectReportToolStripMenuItem.Name = "subjectReportToolStripMenuItem";
            this.subjectReportToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.subjectReportToolStripMenuItem.Text = "Преподаватели на дисциплинах";
            this.subjectReportToolStripMenuItem.Click += new System.EventHandler(this.subjectReportToolStripMenuItem_Click);
            // 
            // experienceReportToolStripMenuItem
            // 
            this.experienceReportToolStripMenuItem.Name = "experienceReportToolStripMenuItem";
            this.experienceReportToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.experienceReportToolStripMenuItem.Text = "Стажи сотрудников";
            this.experienceReportToolStripMenuItem.Click += new System.EventHandler(this.experienceReportToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tbxFilter
            // 
            this.tbxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFilter.Location = new System.Drawing.Point(629, 51);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(201, 20);
            this.tbxFilter.TabIndex = 4;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Фильтрация (ИИН, ФИО, Должность):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PkuEmployee.Properties.Resources.icons8_clear_filters_48px;
            this.pictureBox1.Location = new System.Drawing.Point(836, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // pbxEmployeeDelete
            // 
            this.pbxEmployeeDelete.Image = global::PkuEmployee.Properties.Resources.icons8_delete_48px_1;
            this.pbxEmployeeDelete.Location = new System.Drawing.Point(120, 27);
            this.pbxEmployeeDelete.Name = "pbxEmployeeDelete";
            this.pbxEmployeeDelete.Size = new System.Drawing.Size(48, 48);
            this.pbxEmployeeDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEmployeeDelete.TabIndex = 1;
            this.pbxEmployeeDelete.TabStop = false;
            this.pbxEmployeeDelete.Click += new System.EventHandler(this.pbxEmployeeDelete_Click);
            this.pbxEmployeeDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pbxEmployeeDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // pbxEmployeeEdit
            // 
            this.pbxEmployeeEdit.Image = global::PkuEmployee.Properties.Resources.icons8_check_file_48px;
            this.pbxEmployeeEdit.Location = new System.Drawing.Point(66, 27);
            this.pbxEmployeeEdit.Name = "pbxEmployeeEdit";
            this.pbxEmployeeEdit.Size = new System.Drawing.Size(48, 48);
            this.pbxEmployeeEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEmployeeEdit.TabIndex = 1;
            this.pbxEmployeeEdit.TabStop = false;
            this.pbxEmployeeEdit.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pbxEmployeeEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pbxEmployeeEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // pbxEmployeeAdd
            // 
            this.pbxEmployeeAdd.Image = global::PkuEmployee.Properties.Resources.icons8_plus_48px;
            this.pbxEmployeeAdd.Location = new System.Drawing.Point(12, 27);
            this.pbxEmployeeAdd.Name = "pbxEmployeeAdd";
            this.pbxEmployeeAdd.Size = new System.Drawing.Size(48, 48);
            this.pbxEmployeeAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEmployeeAdd.TabIndex = 1;
            this.pbxEmployeeAdd.TabStop = false;
            this.pbxEmployeeAdd.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbxEmployeeAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pbxEmployeeAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.FillWeight = 80F;
            this.noDataGridViewTextBoxColumn.HeaderText = "ИИН";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.FillWeight = 80F;
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.FillWeight = 40F;
            this.ageDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Национальность";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            this.nationalityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            this.postDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            this.postDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsEmployee
            // 
            this.bsEmployee.DataSource = typeof(PkuEmployee.Model.Employee);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.chbxDismissed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxEmployeeDelete);
            this.Controls.Add(this.pbxEmployeeEdit);
            this.Controls.Add(this.pbxEmployeeAdd);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.mspMain);
            this.MainMenuStrip = this.mspMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отдел кадров";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.mspMain.ResumeLayout(false);
            this.mspMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.BindingSource bsEmployee;
        private System.Windows.Forms.PictureBox pbxEmployeeAdd;
        private System.Windows.Forms.PictureBox pbxEmployeeEdit;
        private System.Windows.Forms.PictureBox pbxEmployeeDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecruitmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DismissalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chbxDismissed;
        private System.Windows.Forms.MenuStrip mspMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nationalitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem experienceReportToolStripMenuItem;
        private System.Windows.Forms.TextBox tbxFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem orbersToolStripMenuItem;
    }
}

