using Microsoft.EntityFrameworkCore;
using PkuEmployee.DirectoriesForms;
using PkuEmployee.EmployeesForms;
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
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using PkuEmployee.Reports;
using PkuEmployee.OrdersForms;

namespace PkuEmployee
{
    public enum Actions
    {
        Add,
        Edit
    }
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        async Task ReloadData(bool dismissed)
        {
            var filter = tbxFilter.Text.ToLower();
            DismissalDate.Visible = dismissed;
            var sbl = new SortableBindingList<Employee>(
                (await DataBase.Db.Employees
                .Where(x => x.DismissalDate.HasValue == dismissed)
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ThenBy(x => x.SecondName)
                .ToListAsync())
                .Where(
                    x=>
                        x.FullName.ToLower().Contains(filter)
                        || x.No.ToLower().Contains(filter)
                        || x.Post.ToString().ToLower().Contains(filter)
                    )
                .ToList()
                );
            bsEmployee.DataSource = sbl;
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            await ReloadData(chbxDismissed.Checked);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            control.Top += 2;
            control.Left += 2;

        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            control.Top -= 2;
            control.Left -= 2;
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            using (var frm = new frmEmployeeEdit())
            {
                //    if (frm.ShowDialog() == DialogResult.OK)
                //    {
                frm.ShowDialog();
                await ReloadData(chbxDismissed.Checked);
                //} 
            }
        }

        private async void pictureBox2_Click(object sender, EventArgs e)
        {
            if (bsEmployee.Current == null)
            {
                return;
            }
            var current = (Employee)bsEmployee.Current;
            using (var frm = new frmEmployeeEdit(current))
            {
                //if (frm.ShowDialog() == DialogResult.OK)
                //{
                frm.ShowDialog();
                await ReloadData(chbxDismissed.Checked);
                //}
            }
        }

        private async void pbxEmployeeDelete_Click(object sender, EventArgs e)
        {
            if (bsEmployee.Current == null)
            {
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить выделенную запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            var employee = (Employee)bsEmployee.Current;
            DataBase.Db.Employees.Remove(employee);
            await DataBase.Db.SaveChangesAsync();
            await ReloadData(chbxDismissed.Checked);
        }

        private async void chbxDismissed_CheckedChanged(object sender, EventArgs e)
        {
            await ReloadData(chbxDismissed.Checked);
        }

        private async void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmDirictoriesView(0))
            {
                frm.ShowDialog();
                await ReloadData(chbxDismissed.Checked);
            }
        }

        private async void postsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmDirictoriesView(1))
            {
                frm.ShowDialog();
                await ReloadData(chbxDismissed.Checked);
            }
        }

        private async void nationalitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmDirictoriesView(2))
            {
                frm.ShowDialog();
                await ReloadData(chbxDismissed.Checked);
            }
        }

        private async void organizationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmDirictoriesView(3))
            {
                frm.ShowDialog();
                await ReloadData(chbxDismissed.Checked);
            }
        }

        private void employeeCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bsEmployee.Current == null)
            {
                MessageBox.Show("Выделите сорудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Employee employee = (Employee)bsEmployee.Current;

            Word._Application application;
            Word._Document document = null;
            Word.Range rng = null;

            Object missingObj = System.Reflection.Missing.Value;
            Object trueObj = true;
            Object falseObj = false;

            //создаем обьект приложения word
            application = new Word.Application();
            // создаем путь к файлу
            Object templatePathObj = Application.StartupPath + @"\Templates\EmployeeCard.dot";

            // если вылетим не этом этапе, приложение останется открытым
            try
            {
                document = application.Documents.Add(ref templatePathObj, ref missingObj, ref missingObj, ref missingObj);
                
                //ФИО
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#FIO#",ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj,ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj,ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{employee.FullName}");
                    rng.Paste();
                }
                
                //Фото
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#PHOTO#",
                    ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj,
                    ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj,
                    ref missingObj, ref missingObj))
                {
                    rng.Select();
                    if (employee.Photo != null)
                    {
                        byte[] newImageByte = employee.Photo;
                        var ms = new MemoryStream(newImageByte, 0, newImageByte.Length);
                        Image image = Image.FromStream(ms, true);
                        var k = image.Width / (double)image.Height;
                        image = (Image)(new Bitmap(image, new Size(120, (int)(120 / k))));
                        Clipboard.SetImage(image);
                        rng.Paste();
                    }
                }

                //ИИН
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#IIN#", ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{employee.No}");
                    rng.Paste();
                }

                //Дата рождения
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#BIRTHDATE#", ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{employee.BirthDate.ToShortDateString()}");
                    rng.Paste();
                }

                //Национальность
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#NATIONALITY#", ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{employee.Nationality.Name}");
                    rng.Paste();
                }

                //Документ
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#IDCARDNAME#", ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{employee.IdCardName}");
                    rng.Paste();
                }

                //Номер документа
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#IDCARDNO#", ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{employee.IdCardNo}");
                    rng.Paste();
                }

                //Когда выдан
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#IDCARDDATE#", ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{employee.IdCardDate.ToShortDateString()}");
                    rng.Paste();
                }

                //Кем выдан
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#IDCARDGOV#", ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{employee.IdCardGov}");
                    rng.Paste();
                }

                //Дата приема на работу
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#RECRUITMENTDATE#", ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{employee.RecruitmentDate.ToShortDateString()}");
                    rng.Paste();
                }

                //Должность
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#POST#", ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{employee.Post.Name}");
                    rng.Paste();
                }

                //Дополнительная информация
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#DESCRIPTION#", ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{(string.IsNullOrWhiteSpace(employee.Description)? "-" : employee.Description)}");
                    rng.Paste();
                }

                //Таблица образования
                Word.Table _table = document.Tables[2];
                for (int i = 1; i < employee.Educations.Count; i++)
                {
                    _table.Rows.Add(ref missingObj);
                }
                int idx = 2;
                foreach (var item in employee.Educations)
                {
                    rng = _table.Cell(idx, 1).Range;
                    Clipboard.SetText(item.Organization.ToString());
                    rng.Paste();
                    rng = _table.Cell(idx, 2).Range;
                    Clipboard.SetText(item.Specialty);
                    rng.Paste();
                    rng = _table.Cell(idx, 3).Range;
                    Clipboard.SetText(item.IssueYear.ToString());
                    rng.Paste();
                    rng = _table.Cell(idx, 4).Range;
                    Clipboard.SetText(item.DocNo);
                    rng.Paste();
                    idx++;
                }

                //Таблица трудовой стаж
                _table = document.Tables[3];
                for (int i = 1; i < employee.Experiences.Count; i++)
                {
                    _table.Rows.Add(ref missingObj);
                }
                idx = 2;
                foreach (var item in employee.Experiences)
                {
                    rng = _table.Cell(idx, 1).Range;
                    Clipboard.SetText(item.Organization.ToString());
                    rng.Paste();
                    rng = _table.Cell(idx, 2).Range;
                    Clipboard.SetText(item.RecruitmentDate.ToShortDateString());
                    rng.Paste();
                    rng = _table.Cell(idx, 3).Range;
                    Clipboard.SetText(item.DismissalDate.ToShortDateString());
                    rng.Paste();
                    idx++;
                }

                //Таблица курсы повышения квалификации
                _table = document.Tables[4];
                for (int i = 1; i < employee.Courses.Count; i++)
                {
                    _table.Rows.Add(ref missingObj);
                }
                idx = 2;
                foreach (var item in employee.Courses)
                {
                    rng = _table.Cell(idx, 1).Range;
                    Clipboard.SetText(item.Organization.ToString());
                    rng.Paste();
                    rng = _table.Cell(idx, 2).Range;
                    Clipboard.SetText(item.RecruitmentDate.ToShortDateString());
                    rng.Paste();
                    rng = _table.Cell(idx, 3).Range;
                    Clipboard.SetText(item.DismissalDate.ToShortDateString());
                    rng.Paste();
                    rng = _table.Cell(idx, 4).Range;
                    Clipboard.SetText(item.NumberOfHours.ToString());
                    rng.Paste();
                    idx++;
                }

                //ФИО (подпись)
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#FIO2#", ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{employee.ShortName}");
                    rng.Paste();
                }

                application.Visible = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                application.Quit(ref missingObj, ref missingObj, ref missingObj);
                document = null;
                application = null;
            }
        }

        private void subjectReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmSubjectsReport())
            {
                frm.ShowDialog();
            }
        }

        private void experienceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmExperienceReport())
            {
                frm.ShowDialog();
            }
        }

        private async void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            await ReloadData(chbxDismissed.Checked);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            tbxFilter.Text = string.Empty;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите завешить работу с программой?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmAbout())
            {
                frm.ShowDialog();
            }
        }

        private void orbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmOrdersView())
            {
                frm.ShowDialog();
            }
        }
    }
}
