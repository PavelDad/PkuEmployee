using Microsoft.EntityFrameworkCore;
using PkuEmployee.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PkuEmployee.DirectoriesForms
{
    public partial class frmDirictoriesView : Form
    {
        TabPage _tabPage;
        public frmDirictoriesView(int index)
        {
            InitializeComponent();
            _tabPage = tabControl1.TabPages[index];
            tabControl1.SelectTab(_tabPage);
        }

        async Task ReloadTables()
        {
            var filter = tbxFilter.Text;

            var sblNationality = new SortableBindingList<Nationality>((await DataBase.Db.Nationalities.OrderBy(x => x.Name).ToListAsync())
                .Where(x=>x.Name.ToLower().Contains(filter)).ToList());
            var sblOrganization = new SortableBindingList<Organization>((await DataBase.Db.Organizations.OrderBy(x => x.Name).ToListAsync())
                .Where(x => x.Name.ToLower().Contains(filter)).ToList());
            var sblPost = new SortableBindingList<Post>((await DataBase.Db.Posts.OrderBy(x => x.Name).ToListAsync())
                .Where(x => x.Name.ToLower().Contains(filter)).ToList());
            var sblSubject = new SortableBindingList<Subject>((await DataBase.Db.Subjects.OrderBy(x => x.Name).ToListAsync())
                .Where(x => x.Name.ToLower().Contains(filter)).ToList());

            bsPost.DataSource = sblPost;
            bsOrganization.DataSource = sblOrganization;
            bsNationality.DataSource = sblNationality;
            bsSubject.DataSource = sblSubject;
        }

        private async void pbxEmployeeAdd_Click(object sender, EventArgs e)
        {
            DataGridView dgv = _tabPage.Controls.OfType<DataGridView>().FirstOrDefault();
            if (dgv.Name == "dgvSubject")
            {
                using (var frm = new frmDirectoriesEdit<Subject>())
                {
                    frm.ShowDialog();
                }
            }
            else
            if (dgv.Name == "dgvPost")
            {
                using (var frm = new frmDirectoriesEdit<Post>())
                {
                    frm.ShowDialog();
                }
            }
            else
            if (dgv.Name == "dgvNationality")
            {
                using (var frm = new frmDirectoriesEdit<Nationality>())
                {
                    frm.ShowDialog();
                }
            }
            else
            if (dgv.Name == "dgvOrganization")
            {
                using (var frm = new frmDirectoriesEdit<Organization>())
                {
                    frm.ShowDialog();
                }
            }
            await ReloadTables();
        }

        private async void frmDirictoriesView_Load(object sender, EventArgs e)
        {
            await ReloadTables();
        }

        private async void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            _tabPage = e.TabPage;
            _tabPage.Controls.OfType<DataGridView>().FirstOrDefault().Columns[0].Visible = false;
            await ReloadTables();
        }

        private async void pbxEmployeeEdit_Click(object sender, EventArgs e)
        {
            DataGridView dgv = _tabPage.Controls.OfType<DataGridView>().FirstOrDefault();
            if (dgv.Name == "dgvSubject")
            {
                if (bsSubject.Current == null)
                {
                    MessageBox.Show("Нечего редактировать.","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var frm = new frmDirectoriesEdit<Subject>((Subject)bsSubject.Current))
                {
                    frm.ShowDialog();
                }
            }
            else
            if (dgv.Name == "dgvPost")
            {
                if (bsPost.Current == null)
                {
                    MessageBox.Show("Нечего редактировать.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var frm = new frmDirectoriesEdit<Post>((Post)bsPost.Current))
                {
                    frm.ShowDialog();
                }
            }
            else
            if (dgv.Name == "dgvNationality")
            {
                if (bsNationality.Current == null)
                {
                    MessageBox.Show("Нечего редактировать.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var frm = new frmDirectoriesEdit<Nationality>((Nationality)bsNationality.Current))
                {
                    frm.ShowDialog();
                }
            }
            else
            if (dgv.Name == "dgvOrganization")
            {
                if (bsOrganization.Current == null)
                {
                    MessageBox.Show("Нечего редактировать.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var frm = new frmDirectoriesEdit<Organization>((Organization)bsOrganization.Current))
                {
                    frm.ShowDialog();
                }
            }
            await ReloadTables();
        }

        private async void pbxEmployeeDelete_Click(object sender, EventArgs e)
        {
            DataGridView dgv = _tabPage.Controls.OfType<DataGridView>().FirstOrDefault();
            if (dgv.Name == "dgvSubject")
            {
                if (bsSubject.Current == null)
                {
                    MessageBox.Show("Нечего удалять.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Вы действительно хотите удалить выделенную запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                DataBase.Db.Remove(bsSubject.Current);
            }
            else
            if (dgv.Name == "dgvPost")
            {
                if (bsPost.Current == null)
                {
                    MessageBox.Show("Нечего удалять.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Вы действительно хотите удалить выделенную запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                DataBase.Db.Remove(bsPost.Current);
            }
            else
            if (dgv.Name == "dgvNationality")
            {
                if (bsNationality.Current == null)
                {
                    MessageBox.Show("Нечего удалять.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Вы действительно хотите удалить выделенную запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                DataBase.Db.Remove(bsNationality.Current);
            }
            else
            if (dgv.Name == "dgvOrganization")
            {
                if (bsOrganization.Current == null)
                {
                    MessageBox.Show("Нечего удалять.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Вы действительно хотите удалить выделенную запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                DataBase.Db.Remove(bsOrganization.Current);
            }
            await DataBase.Db.SaveChangesAsync();
            await ReloadTables();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tbxFilter.Clear();
        }

        private async void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            await ReloadTables();
        }
    }
}
