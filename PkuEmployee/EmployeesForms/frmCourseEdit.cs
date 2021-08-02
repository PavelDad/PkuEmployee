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
    public partial class frmCourseEdit : Form
    {
        Course _course;
        Actions _action;

        private frmCourseEdit(Employee employee, Course course)
        {
            if (course == null)
            {
                _action = Actions.Add;
                _course = new Course()
                {
                    Employee = employee
                };
            }
            else
            {
                _action = Actions.Edit;
                _course = course;
            }
            InitializeComponent();
        }

        public frmCourseEdit(Employee employee)
            : this(employee, null) { }

        public frmCourseEdit(Course course)
            : this(course.Employee, course) { }

        private async void frmCourseEdit_Load(object sender, EventArgs e)
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
                    nudNumberOfHours.Value = 0;
                    break;
                case Actions.Edit:
                    cbxOrganization.SelectedItem = _course.Organization;
                    dtpDismissalDate.Value = _course.DismissalDate;
                    dtpRecruitmentDate.Value = _course.RecruitmentDate;
                    nudNumberOfHours.Value = _course.NumberOfHours;
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

                _course.DismissalDate = dtpDismissalDate.Value.Date;
                _course.Organization = (Organization)cbxOrganization.SelectedItem;
                _course.RecruitmentDate = dtpRecruitmentDate.Value.Date;
                _course.NumberOfHours = (int)nudNumberOfHours.Value;
                if (_action == Actions.Add)
                {
                    _course.Employee.Courses.Add(_course);
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
