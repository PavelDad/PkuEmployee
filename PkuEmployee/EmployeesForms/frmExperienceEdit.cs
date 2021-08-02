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
    public partial class frmExperienceEdit : Form
    {
        Experience _experience;
        Actions _action;

        private frmExperienceEdit(Employee employee, Experience experience)
        {
            if (experience == null)
            {
                _action = Actions.Add;
                _experience = new Experience()
                {
                    Employee = employee
                };
            }
            else
            {
                _action = Actions.Edit;
                _experience = experience;
            }
            InitializeComponent();
        }

        public frmExperienceEdit(Employee employee)
            : this(employee, null) { }

        public frmExperienceEdit(Experience experience)
            : this(experience.Employee, experience) { }

        private async void frmExperienceEdit_Load(object sender, EventArgs e)
        {
            var list = await DataBase.Db.Organizations.OrderBy(x => x.Name).ToListAsync();
            if (list.Count == 0)
            {
                MessageBox.Show("Добавьте организации.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                return;
            }
            cbxOrganization.DataSource = list;

            switch (_action)
            {
                case Actions.Add:
                    cbxOrganization.SelectedIndex = 0;
                    dtpDismissalDate.Value = DateTime.Now.Date;
                    dtpRecruitmentDate.Value = DateTime.Now.Date;
                    break;
                case Actions.Edit:
                    cbxOrganization.SelectedItem = _experience.Organization;
                    dtpDismissalDate.Value = _experience.DismissalDate;
                    dtpRecruitmentDate.Value = _experience.RecruitmentDate;
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
            try
            {
                if (dtpRecruitmentDate.Value.Date >= dtpDismissalDate.Value.Date)
                {
                    throw new Exception("Дата приема на работу должны быть раньше даты увольнения.");
                }

                _experience.DismissalDate = dtpDismissalDate.Value.Date;
                _experience.Organization = (Organization)cbxOrganization.SelectedItem;
                _experience.RecruitmentDate = dtpRecruitmentDate.Value.Date;
                if (_action == Actions.Add)
                {
                    _experience.Employee.Experiences.Add(_experience);
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
