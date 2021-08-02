
namespace PkuEmployee.DirectoriesForms
{
    partial class frmDirictoriesView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpgSubjects = new System.Windows.Forms.TabPage();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSubject = new System.Windows.Forms.BindingSource(this.components);
            this.tpgPosts = new System.Windows.Forms.TabPage();
            this.dgvPost = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPost = new System.Windows.Forms.BindingSource(this.components);
            this.tpgNationalities = new System.Windows.Forms.TabPage();
            this.dgvNationality = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsNationality = new System.Windows.Forms.BindingSource(this.components);
            this.tpgOrganizations = new System.Windows.Forms.TabPage();
            this.dgvOrganization = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOrganization = new System.Windows.Forms.BindingSource(this.components);
            this.pbxEmployeeDelete = new System.Windows.Forms.PictureBox();
            this.pbxEmployeeEdit = new System.Windows.Forms.PictureBox();
            this.pbxEmployeeAdd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tpgSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubject)).BeginInit();
            this.tpgPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPost)).BeginInit();
            this.tpgNationalities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNationality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNationality)).BeginInit();
            this.tpgOrganizations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrganization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpgSubjects);
            this.tabControl1.Controls.Add(this.tpgPosts);
            this.tabControl1.Controls.Add(this.tpgNationalities);
            this.tabControl1.Controls.Add(this.tpgOrganizations);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 651);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tpgSubjects
            // 
            this.tpgSubjects.Controls.Add(this.dgvSubject);
            this.tpgSubjects.Location = new System.Drawing.Point(4, 22);
            this.tpgSubjects.Name = "tpgSubjects";
            this.tpgSubjects.Padding = new System.Windows.Forms.Padding(3);
            this.tpgSubjects.Size = new System.Drawing.Size(976, 625);
            this.tpgSubjects.TabIndex = 0;
            this.tpgSubjects.Text = "Дисциплины";
            this.tpgSubjects.UseVisualStyleBackColor = true;
            // 
            // dgvSubject
            // 
            this.dgvSubject.AllowUserToAddRows = false;
            this.dgvSubject.AllowUserToDeleteRows = false;
            this.dgvSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubject.AutoGenerateColumns = false;
            this.dgvSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubject.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgvSubject.DataSource = this.bsSubject;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubject.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSubject.Location = new System.Drawing.Point(6, 6);
            this.dgvSubject.MultiSelect = false;
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.ReadOnly = true;
            this.dgvSubject.RowHeadersVisible = false;
            this.dgvSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubject.Size = new System.Drawing.Size(964, 613);
            this.dgvSubject.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование дисциплины";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsSubject
            // 
            this.bsSubject.DataSource = typeof(PkuEmployee.Model.Subject);
            // 
            // tpgPosts
            // 
            this.tpgPosts.Controls.Add(this.dgvPost);
            this.tpgPosts.Location = new System.Drawing.Point(4, 22);
            this.tpgPosts.Name = "tpgPosts";
            this.tpgPosts.Padding = new System.Windows.Forms.Padding(3);
            this.tpgPosts.Size = new System.Drawing.Size(976, 625);
            this.tpgPosts.TabIndex = 1;
            this.tpgPosts.Text = "Должности";
            this.tpgPosts.UseVisualStyleBackColor = true;
            // 
            // dgvPost
            // 
            this.dgvPost.AllowUserToAddRows = false;
            this.dgvPost.AllowUserToDeleteRows = false;
            this.dgvPost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPost.AutoGenerateColumns = false;
            this.dgvPost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPost.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1});
            this.dgvPost.DataSource = this.bsPost;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPost.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPost.Location = new System.Drawing.Point(6, 6);
            this.dgvPost.MultiSelect = false;
            this.dgvPost.Name = "dgvPost";
            this.dgvPost.ReadOnly = true;
            this.dgvPost.RowHeadersVisible = false;
            this.dgvPost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPost.Size = new System.Drawing.Size(964, 613);
            this.dgvPost.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Наименование должности";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bsPost
            // 
            this.bsPost.DataSource = typeof(PkuEmployee.Model.Post);
            // 
            // tpgNationalities
            // 
            this.tpgNationalities.Controls.Add(this.dgvNationality);
            this.tpgNationalities.Location = new System.Drawing.Point(4, 22);
            this.tpgNationalities.Name = "tpgNationalities";
            this.tpgNationalities.Padding = new System.Windows.Forms.Padding(3);
            this.tpgNationalities.Size = new System.Drawing.Size(976, 625);
            this.tpgNationalities.TabIndex = 2;
            this.tpgNationalities.Text = "Национальности";
            this.tpgNationalities.UseVisualStyleBackColor = true;
            // 
            // dgvNationality
            // 
            this.dgvNationality.AllowUserToAddRows = false;
            this.dgvNationality.AllowUserToDeleteRows = false;
            this.dgvNationality.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNationality.AutoGenerateColumns = false;
            this.dgvNationality.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNationality.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNationality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNationality.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2});
            this.dgvNationality.DataSource = this.bsNationality;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNationality.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvNationality.Location = new System.Drawing.Point(6, 6);
            this.dgvNationality.MultiSelect = false;
            this.dgvNationality.Name = "dgvNationality";
            this.dgvNationality.ReadOnly = true;
            this.dgvNationality.RowHeadersVisible = false;
            this.dgvNationality.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNationality.Size = new System.Drawing.Size(964, 613);
            this.dgvNationality.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Наименование национальности";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // bsNationality
            // 
            this.bsNationality.DataSource = typeof(PkuEmployee.Model.Nationality);
            // 
            // tpgOrganizations
            // 
            this.tpgOrganizations.Controls.Add(this.dgvOrganization);
            this.tpgOrganizations.Location = new System.Drawing.Point(4, 22);
            this.tpgOrganizations.Name = "tpgOrganizations";
            this.tpgOrganizations.Padding = new System.Windows.Forms.Padding(3);
            this.tpgOrganizations.Size = new System.Drawing.Size(976, 625);
            this.tpgOrganizations.TabIndex = 3;
            this.tpgOrganizations.Text = "Организации";
            this.tpgOrganizations.UseVisualStyleBackColor = true;
            // 
            // dgvOrganization
            // 
            this.dgvOrganization.AllowUserToAddRows = false;
            this.dgvOrganization.AllowUserToDeleteRows = false;
            this.dgvOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrganization.AutoGenerateColumns = false;
            this.dgvOrganization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrganization.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrganization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganization.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn3});
            this.dgvOrganization.DataSource = this.bsOrganization;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrganization.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvOrganization.Location = new System.Drawing.Point(6, 6);
            this.dgvOrganization.MultiSelect = false;
            this.dgvOrganization.Name = "dgvOrganization";
            this.dgvOrganization.ReadOnly = true;
            this.dgvOrganization.RowHeadersVisible = false;
            this.dgvOrganization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrganization.Size = new System.Drawing.Size(964, 613);
            this.dgvOrganization.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idDataGridViewTextBoxColumn3.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Наименование организации";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            this.nameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // bsOrganization
            // 
            this.bsOrganization.DataSource = typeof(PkuEmployee.Model.Organization);
            // 
            // pbxEmployeeDelete
            // 
            this.pbxEmployeeDelete.Image = global::PkuEmployee.Properties.Resources.icons8_delete_48px_1;
            this.pbxEmployeeDelete.Location = new System.Drawing.Point(120, 12);
            this.pbxEmployeeDelete.Name = "pbxEmployeeDelete";
            this.pbxEmployeeDelete.Size = new System.Drawing.Size(48, 48);
            this.pbxEmployeeDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEmployeeDelete.TabIndex = 2;
            this.pbxEmployeeDelete.TabStop = false;
            this.pbxEmployeeDelete.Click += new System.EventHandler(this.pbxEmployeeDelete_Click);
            // 
            // pbxEmployeeEdit
            // 
            this.pbxEmployeeEdit.Image = global::PkuEmployee.Properties.Resources.icons8_check_file_48px;
            this.pbxEmployeeEdit.Location = new System.Drawing.Point(66, 12);
            this.pbxEmployeeEdit.Name = "pbxEmployeeEdit";
            this.pbxEmployeeEdit.Size = new System.Drawing.Size(48, 48);
            this.pbxEmployeeEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEmployeeEdit.TabIndex = 3;
            this.pbxEmployeeEdit.TabStop = false;
            this.pbxEmployeeEdit.Click += new System.EventHandler(this.pbxEmployeeEdit_Click);
            // 
            // pbxEmployeeAdd
            // 
            this.pbxEmployeeAdd.Image = global::PkuEmployee.Properties.Resources.icons8_plus_48px;
            this.pbxEmployeeAdd.Location = new System.Drawing.Point(12, 12);
            this.pbxEmployeeAdd.Name = "pbxEmployeeAdd";
            this.pbxEmployeeAdd.Size = new System.Drawing.Size(48, 48);
            this.pbxEmployeeAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEmployeeAdd.TabIndex = 4;
            this.pbxEmployeeAdd.TabStop = false;
            this.pbxEmployeeAdd.Click += new System.EventHandler(this.pbxEmployeeAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фильтрация:";
            // 
            // tbxFilter
            // 
            this.tbxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFilter.Location = new System.Drawing.Point(731, 36);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(201, 20);
            this.tbxFilter.TabIndex = 7;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PkuEmployee.Properties.Resources.icons8_clear_filters_48px;
            this.pictureBox1.Location = new System.Drawing.Point(938, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmDirictoriesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxEmployeeDelete);
            this.Controls.Add(this.pbxEmployeeEdit);
            this.Controls.Add(this.pbxEmployeeAdd);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDirictoriesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочники";
            this.Load += new System.EventHandler(this.frmDirictoriesView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpgSubjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubject)).EndInit();
            this.tpgPosts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPost)).EndInit();
            this.tpgNationalities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNationality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNationality)).EndInit();
            this.tpgOrganizations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrganization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployeeAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpgSubjects;
        private System.Windows.Forms.TabPage tpgPosts;
        private System.Windows.Forms.TabPage tpgNationalities;
        private System.Windows.Forms.TabPage tpgOrganizations;
        private System.Windows.Forms.PictureBox pbxEmployeeDelete;
        private System.Windows.Forms.PictureBox pbxEmployeeEdit;
        private System.Windows.Forms.PictureBox pbxEmployeeAdd;
        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.DataGridView dgvPost;
        private System.Windows.Forms.DataGridView dgvNationality;
        private System.Windows.Forms.DataGridView dgvOrganization;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bsPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource bsNationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource bsOrganization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}