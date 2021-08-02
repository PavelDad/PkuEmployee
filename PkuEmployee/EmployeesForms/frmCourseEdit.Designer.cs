
namespace PkuEmployee.EmployeesForms
{
    partial class frmCourseEdit
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxOrganization = new System.Windows.Forms.ComboBox();
            this.dtpDismissalDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpRecruitmentDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNumberOfHours = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfHours)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(303, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(222, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxOrganization
            // 
            this.cbxOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrganization.FormattingEnabled = true;
            this.cbxOrganization.Location = new System.Drawing.Point(95, 12);
            this.cbxOrganization.Name = "cbxOrganization";
            this.cbxOrganization.Size = new System.Drawing.Size(283, 21);
            this.cbxOrganization.TabIndex = 16;
            // 
            // dtpDismissalDate
            // 
            this.dtpDismissalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDismissalDate.Location = new System.Drawing.Point(287, 38);
            this.dtpDismissalDate.Name = "dtpDismissalDate";
            this.dtpDismissalDate.Size = new System.Drawing.Size(91, 20);
            this.dtpDismissalDate.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата окончания:";
            // 
            // dtpRecruitmentDate
            // 
            this.dtpRecruitmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRecruitmentDate.Location = new System.Drawing.Point(92, 38);
            this.dtpRecruitmentDate.Name = "dtpRecruitmentDate";
            this.dtpRecruitmentDate.Size = new System.Drawing.Size(91, 20);
            this.dtpRecruitmentDate.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Дата начала:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Организация:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количество часов:";
            // 
            // nudNumberOfHours
            // 
            this.nudNumberOfHours.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNumberOfHours.Location = new System.Drawing.Point(119, 65);
            this.nudNumberOfHours.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.nudNumberOfHours.Name = "nudNumberOfHours";
            this.nudNumberOfHours.Size = new System.Drawing.Size(97, 20);
            this.nudNumberOfHours.TabIndex = 19;
            // 
            // frmCourseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 97);
            this.Controls.Add(this.nudNumberOfHours);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxOrganization);
            this.Controls.Add(this.dtpDismissalDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpRecruitmentDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCourseEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCourseEdit";
            this.Load += new System.EventHandler(this.frmCourseEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxOrganization;
        private System.Windows.Forms.DateTimePicker dtpDismissalDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpRecruitmentDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudNumberOfHours;
    }
}