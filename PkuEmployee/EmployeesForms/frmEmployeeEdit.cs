using Microsoft.EntityFrameworkCore;
using PkuEmployee.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PkuEmployee.EmployeesForms
{
    public partial class frmEmployeeEdit : Form
    {
        Employee _employee = null;
        Actions _action;
        MemoryStream _ms;

        public frmEmployeeEdit(Employee employee)
        {
            InitializeComponent();
            if (employee == null)
            {
                _action = Actions.Add;
                _employee = new Employee();
            }
            else
            {
                _action = Actions.Edit;
                _employee = employee;
            }
        }

        public frmEmployeeEdit()
            : this(null) { }

        private void btmBrowse_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "JPEG|*.jpg;*.jpeg|PNG|*.png";
                ofd.Title = "Выбор фото";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbxPhoto.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private async void frmEmployeeEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.Db.Nationalities.Count() == 0)
                {
                    throw new Exception("Заполните справочник Национальности");
                }
                if (DataBase.Db.Posts.Count() == 0)
                {
                    throw new Exception("Заполните справочник Должности");
                }

                var sblEducation = new SortableBindingList<Education>(await DataBase.Db.Educations.Where(x => x.Employee == _employee).OrderBy(x => x.IssueYear).ToListAsync());
                bsEducation.DataSource = sblEducation;
                var sblExperience = new SortableBindingList<Experience>(await DataBase.Db.Experiences.Where(x => x.Employee == _employee).OrderBy(x => x.RecruitmentDate).ToListAsync());
                bsExperience.DataSource = sblExperience;
                var sblCourse = new SortableBindingList<Course>(await DataBase.Db.Courses.Where(x => x.Employee == _employee).OrderBy(x => x.RecruitmentDate).ToListAsync());
                bsCourse.DataSource = sblCourse;
                var sblEmployeesSubject = new SortableBindingList<EmployeesSubject>(await DataBase.Db.EmployeesSubjects.Where(x => x.Employee == _employee).OrderBy(x => x.Subject).ToListAsync());
                bsEmployeesSubject.DataSource = sblEmployeesSubject;

                var nationalities = await DataBase.Db.Nationalities.OrderBy(x => x.Name).ToListAsync();
                var posts = await DataBase.Db.Posts.OrderBy(x => x.Name).ToListAsync();

                cbxNationality.DataSource = nationalities;
                cbxPost.DataSource = posts;

                switch (_action)
                {
                    case Actions.Add:
                        this.Text = "Добавление сотрудника";
                        cbxPost.SelectedIndex = 0;
                        cbxNationality.SelectedIndex = 0;

                        dtpBirthDate.Value = DateTime.Now.Date;
                        dtpDismissalDate.Value = DateTime.Now.Date;
                        dtpIdCardDate.Value = DateTime.Now.Date;
                        dtpIdCardValidity.Value = DateTime.Now.Date;
                        dtpRecruitmentDate.Value = DateTime.Now.Date;

                        chbxDismissal.Checked = false;

                        mtbxNo.Text = string.Empty;
                        tbxDescription.Text = string.Empty;
                        tbxFirstName.Text = string.Empty;
                        tbxIdCardGov.Text = string.Empty;
                        tbxIdCardName.Text = string.Empty;
                        tbxIdCardNo.Text = string.Empty;
                        tbxLastName.Text = string.Empty;
                        tbxSecondName.Text = string.Empty;
                        break;
                    case Actions.Edit:
                        this.Text = "Редактирование сотрудника";
                        cbxNationality.SelectedItem = _employee.Nationality;
                        cbxPost.SelectedItem = _employee.Post;

                        dtpBirthDate.Value = _employee.BirthDate;
                        dtpDismissalDate.Value = _employee.DismissalDate ?? DateTime.Now.Date;
                        dtpIdCardDate.Value = _employee.IdCardDate;
                        dtpIdCardValidity.Value = _employee.IdCardValidity;
                        dtpRecruitmentDate.Value = _employee.RecruitmentDate;

                        chbxDismissal.Checked = (_employee.DismissalDate.HasValue);

                        mtbxNo.Text = _employee.No;
                        tbxDescription.Text = _employee.Description;
                        tbxFirstName.Text = _employee.FirstName;
                        tbxIdCardGov.Text = _employee.IdCardGov;
                        tbxIdCardName.Text = _employee.IdCardName;
                        tbxIdCardNo.Text = _employee.IdCardNo;
                        tbxLastName.Text = _employee.LastName;
                        tbxSecondName.Text = _employee.SecondName;

                        if (_employee.Photo != null)
                        {
                            byte[] newImageByte = _employee.Photo;
                            _ms = new MemoryStream(newImageByte, 0, newImageByte.Length);
                            pbxPhoto.Image = Image.FromStream(_ms, true);
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            

        }

        private void chbxDismissal_CheckedChanged(object sender, EventArgs e)
        {
            var visible = chbxDismissal.Checked;
            label14.Visible = visible;
            dtpDismissalDate.Visible = visible;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DataBase.ResetContextState();
            DialogResult = DialogResult.Cancel;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mtbxNo.Text))
                {
                    throw new Exception("Заполните ИИН.");
                }
                if (DataBase.Db.Employees.Where(x=>x.No == mtbxNo.Text && x.Id != _employee.Id).ToList().Count > 0)
                {
                    throw new Exception("ИИН не уникален.");
                }
                if (string.IsNullOrWhiteSpace(tbxFirstName.Text) || string.IsNullOrWhiteSpace(tbxLastName.Text))
                {
                    throw new Exception("Заполните ФИО.");
                }
                if (chbxDismissal.Checked && dtpDismissalDate.Value.Date <= dtpRecruitmentDate.Value.Date)
                {
                    throw new Exception("Дата увольнения должа быть позже даты приема на работу.");
                }
                if (string.IsNullOrWhiteSpace(tbxIdCardGov.Text) || string.IsNullOrWhiteSpace(tbxIdCardName.Text) || string.IsNullOrWhiteSpace(tbxIdCardNo.Text))
                {
                    throw new Exception("Заполните данные о документе.");
                }

                _employee.BirthDate = dtpBirthDate.Value.Date;
                _employee.Description = tbxDescription.Text;
                _employee.DismissalDate = (chbxDismissal.Checked) ? (DateTime?)dtpDismissalDate.Value.Date : null;
                _employee.FirstName = tbxFirstName.Text;
                _employee.IdCardDate = dtpIdCardDate.Value.Date;
                _employee.IdCardGov = tbxIdCardGov.Text;
                _employee.IdCardName = tbxIdCardName.Text;
                _employee.IdCardNo = tbxIdCardNo.Text;
                _employee.IdCardValidity = dtpIdCardValidity.Value.Date;
                _employee.LastName = tbxLastName.Text;
                _employee.Nationality = (Nationality)cbxNationality.SelectedItem;
                _employee.No = mtbxNo.Text;
                _employee.Photo = DataBase.ImageToBase64(pbxPhoto.Image);
                _employee.Post = (Post)cbxPost.SelectedItem;
                _employee.RecruitmentDate = dtpRecruitmentDate.Value.Date;
                _employee.SecondName = tbxSecondName.Text;
                DataBase.Db.Update(_employee);
                await DataBase.Db.SaveChangesAsync();
                DialogResult = DialogResult.OK;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            control.Top += 1;
            control.Left += 1;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            control.Top -= 1;
            control.Left -= 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (var frm = new frmEducationEdit(_employee))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var sblEducation = new SortableBindingList<Education>(_employee.Educations.OrderBy(x => x.IssueYear).ToList());
                    bsEducation.DataSource = sblEducation;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (bsEducation.Current == null)
            {
                return;
            }
            var education = (Education)bsEducation.Current;
            using (var frm = new frmEducationEdit(education))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var sblEducation = new SortableBindingList<Education>(_employee.Educations.OrderBy(x => x.IssueYear).ToList());
                    bsEducation.DataSource = sblEducation;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (bsEducation.Current == null)
            {
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить выделенную запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            var education = (Education)bsEducation.Current;
            _employee.Educations.Remove(education);
            var sblEducation = new SortableBindingList<Education>(_employee.Educations.OrderBy(x => x.IssueYear).ToList());
            bsEducation.DataSource = sblEducation;
        }

        private void pbxExperiencesAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new frmExperienceEdit(_employee))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var sblExperience = new SortableBindingList<Experience>(_employee.Experiences.OrderBy(x => x.RecruitmentDate).ToList());
                    bsExperience.DataSource = sblExperience;
                }
            }
        }

        private void pbxExperiencesEdit_Click(object sender, EventArgs e)
        {
            if (bsExperience.Current == null)
            {
                return;
            }
            var experience = (Experience)bsExperience.Current;
            using (var frm = new frmExperienceEdit(experience))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var sblExperience = new SortableBindingList<Experience>(_employee.Experiences.OrderBy(x => x.RecruitmentDate).ToList());
                    bsExperience.DataSource = sblExperience;
                }
            }
        }

        private void pbxExperiencesDelete_Click(object sender, EventArgs e)
        {
            if (bsExperience.Current == null)
            {
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить выделенную запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            var experience = (Experience)bsExperience.Current;
            _employee.Experiences.Remove(experience);
            var sblExperience = new SortableBindingList<Experience>(_employee.Experiences.OrderBy(x => x.RecruitmentDate).ToList());
            bsExperience.DataSource = sblExperience;
        }

        private void pbxCourseAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new frmCourseEdit(_employee))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var sblCourse = new SortableBindingList<Course>(_employee.Courses.OrderBy(x => x.RecruitmentDate).ToList());
                    bsCourse.DataSource = sblCourse;
                }
            }
        }

        private void pbxCourseEdit_Click(object sender, EventArgs e)
        {
            if (bsCourse.Current == null)
            {
                return;
            }
            var course = (Course)bsCourse.Current;
            using (var frm = new frmCourseEdit(course))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var sblCourse = new SortableBindingList<Course>(_employee.Courses.OrderBy(x => x.RecruitmentDate).ToList());
                    bsCourse.DataSource = sblCourse;
                }
            }
        }

        private void pbxCourseDelete_Click(object sender, EventArgs e)
        {
            if (bsCourse.Current == null)
            {
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить выделенную запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            var course = (Course)bsCourse.Current;
            _employee.Courses.Remove(course);
            var sblCourse = new SortableBindingList<Course>(_employee.Courses.OrderBy(x => x.RecruitmentDate).ToList());
            bsCourse.DataSource = sblCourse;
        }

        private void pbxEmployeesSubjectAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new frmsblEmployeesSubjectEdit(_employee))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var sblEmployeesSubject = new SortableBindingList<EmployeesSubject>(_employee.EmployeesSubjects.OrderBy(x => x.Subject).ToList());
                    bsEmployeesSubject.DataSource = sblEmployeesSubject;
                }
            }
        }

        private void pbxEmployeesSubjectDelete_Click(object sender, EventArgs e)
        {
            if (bsEmployeesSubject.Current == null)
            {
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить выделенную запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            var employeeSubject = (EmployeesSubject)bsEmployeesSubject.Current;
            _employee.EmployeesSubjects.Remove(employeeSubject);
            var sblEmployeesSubject = new SortableBindingList<EmployeesSubject>(_employee.EmployeesSubjects.OrderBy(x => x.Subject).ToList());
            bsEmployeesSubject.DataSource = sblEmployeesSubject;
        }
    }
}
