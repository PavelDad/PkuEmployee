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

namespace PkuEmployee.Reports
{
    public partial class frmExperienceReport : Form
    {
        List<Employee> db_list;
        List<ExperienceReport> list;
        SortableBindingList<ExperienceReport> sbl;
        public frmExperienceReport()
        {
            InitializeComponent();
        }

        void ReloadData()
        {
            var filter = tbxFilter.Text.ToLower();
            list = new List<ExperienceReport>();
            foreach (var item in db_list)
            {
                var current = (DateTime.Now.Date - item.RecruitmentDate).Days;
                var all = (item.Experiences.Select(x => (x.DismissalDate - x.RecruitmentDate).Days).Sum() + current) / 365;
                current /= 365;
                list.Add(new ExperienceReport()
                {
                    Name = item.FullName,
                    All = all,
                    Current = current
                });
            }
            sbl = new SortableBindingList<ExperienceReport>(list.Where(x=>x.Name.ToLower().Contains(filter)).ToList());
            dgvEmployees.DataSource = sbl;
        }


        private async void frmExperienceReport_Load(object sender, EventArgs e)
        {
            db_list = await DataBase.Db.Employees.Where(x => !x.DismissalDate.HasValue).ToListAsync();
            ReloadData();
        }

        private void pbxEmployeeAdd_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workBook;
            Microsoft.Office.Interop.Excel.Worksheet workSheet;

            workBook = excelApp.Workbooks.Open(Environment.CurrentDirectory + @"\Templates\Experience.xlt");
            workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets.get_Item(1);

            var i = 2;
            foreach (var item in sbl.ToList())
            {
                i++;
                workSheet.Cells[i, 1] = i - 2;
                workSheet.Cells[i, 2] = item.Name;
                workSheet.Cells[i, 3] = item.All;
                workSheet.Cells[i, 4] = item.Current;
            }

            Microsoft.Office.Interop.Excel.Range rng = workSheet.Range[workSheet.Cells[2, 1], workSheet.Cells[i, 4]];
            rng.Columns.AutoFit();
            Microsoft.Office.Interop.Excel.Borders border = rng.Borders;
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            excelApp.Visible = true;
            excelApp.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;
            excelApp.ActiveWindow.Activate();
        }

        private void pbxEmployeeAdd_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            control.Top += 2;
            control.Left += 2;
        }

        private void pbxEmployeeAdd_MouseUp(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            control.Top -= 2;
            control.Left -= 2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tbxFilter.Text = string.Empty;
        }

        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            ReloadData();
        }
    }
}
