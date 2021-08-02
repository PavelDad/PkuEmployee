
namespace PkuEmployee.EmployeesForms
{
    partial class frmExperienceEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpRecruitmentDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDismissalDate = new System.Windows.Forms.DateTimePicker();
            this.cbxOrganization = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Организация:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата приема на работу:";
            // 
            // dtpRecruitmentDate
            // 
            this.dtpRecruitmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRecruitmentDate.Location = new System.Drawing.Point(147, 38);
            this.dtpRecruitmentDate.Name = "dtpRecruitmentDate";
            this.dtpRecruitmentDate.Size = new System.Drawing.Size(91, 20);
            this.dtpRecruitmentDate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дата увольнения:";
            // 
            // dtpDismissalDate
            // 
            this.dtpDismissalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDismissalDate.Location = new System.Drawing.Point(348, 38);
            this.dtpDismissalDate.Name = "dtpDismissalDate";
            this.dtpDismissalDate.Size = new System.Drawing.Size(91, 20);
            this.dtpDismissalDate.TabIndex = 7;
            // 
            // cbxOrganization
            // 
            this.cbxOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrganization.FormattingEnabled = true;
            this.cbxOrganization.Location = new System.Drawing.Point(95, 12);
            this.cbxOrganization.Name = "cbxOrganization";
            this.cbxOrganization.Size = new System.Drawing.Size(344, 21);
            this.cbxOrganization.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(364, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(283, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmExperienceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 97);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxOrganization);
            this.Controls.Add(this.dtpDismissalDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpRecruitmentDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExperienceEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExperienceEdit";
            this.Load += new System.EventHandler(this.frmExperienceEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpRecruitmentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDismissalDate;
        private System.Windows.Forms.ComboBox cbxOrganization;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}