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
    public partial class frmsblEmployeesSubjectEdit : Form
    {
        EmployeesSubject _employeesSubject;

        public frmsblEmployeesSubjectEdit(Employee employee)
        {
            _employeesSubject = new EmployeesSubject()
            {
                Employee = employee
            };
            InitializeComponent();
        }

        private async void frmsblEmployeesSubjectEdit_Load(object sender, EventArgs e)
        {
            var list = (await DataBase.Db.Subjects.OrderBy(x => x.Name).ToListAsync())
                            .Where(x => _employeesSubject.Employee.EmployeesSubjects.Find(y => y.Subject == x) == null)
                            .ToList();
            if (list.Count == 0)
            {
                MessageBox.Show("Добавьте дисциплины.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                return;
            }
            cbxSubject.DataSource = list;
            cbxSubject.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _employeesSubject.Subject = (Subject)cbxSubject.SelectedItem;
            _employeesSubject.Employee.EmployeesSubjects.Add(_employeesSubject);
            DialogResult = DialogResult.OK;
        }
    }
}
