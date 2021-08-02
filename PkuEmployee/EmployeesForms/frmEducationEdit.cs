using Microsoft.EntityFrameworkCore;
using PkuEmployee.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PkuEmployee.EmployeesForms
{
    public partial class frmEducationEdit : Form
    {
        Education _education;
        Actions _action;

        private frmEducationEdit(Employee employee, Education education)
        {
            if (education == null)
            {
                _education = new Education()
                {
                    Employee = employee
                };
                _action = Actions.Add;
            }
            else
            {
                _education = education;
                _action = Actions.Edit;
            }
            InitializeComponent();
        }

        public frmEducationEdit(Employee employee)
            : this(employee, null) { }

        public frmEducationEdit(Education education)
            : this(education.Employee, education) { }

        private async void frmEducationEdit_Load(object sender, EventArgs e)
        {
            var list = await DataBase.Db.Organizations.OrderBy(x => x.Name).ToListAsync();
            if (list.Count == 0)
            {
                MessageBox.Show("Добавьте организации.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                return;
            }
            cbxOrganization.DataSource = list;
            nudIssueYear.Maximum = DateTime.Now.Year;

            switch (_action)
            {
                case Actions.Add:
                    cbxOrganization.SelectedIndex = 0;
                    tbxDocNo.Text = string.Empty;
                    tbxSpecialty.Text = string.Empty;
                    nudIssueYear.Value = DateTime.Now.Year;
                    break;
                case Actions.Edit:
                    cbxOrganization.SelectedItem = _education.Organization;
                    tbxDocNo.Text = _education.DocNo;
                    tbxSpecialty.Text = _education.Specialty;
                    nudIssueYear.Value = _education.IssueYear;
                    break;
                default:
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _education.DocNo = tbxDocNo.Text;
            _education.IssueYear = (int)nudIssueYear.Value;
            _education.Organization = (Organization)cbxOrganization.SelectedItem;
            _education.Specialty = tbxSpecialty.Text;
            if (_action == Actions.Add)
            {
                _education.Employee.Educations.Add(_education);
            }
            //DataBase.Db.Update(_education);
            DialogResult = DialogResult.OK;
        }
    }
}
