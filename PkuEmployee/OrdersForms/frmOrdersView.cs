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
using Word = Microsoft.Office.Interop.Word;

namespace PkuEmployee.OrdersForms
{
    public partial class frmOrdersView : Form
    {
        async Task ReloadData()
        {
            var filter = tbxFilter.Text.ToLower();
            var sbl = new SortableBindingList<Order>(
                (await DataBase.Db.Orders
                .Where(x => 
                    x.CreateDate.Date >= dtpFrom.Value.Date 
                    && x.CreateDate.Date <= dtpTo.Value.Date)
                .OrderBy(x => x.CreateDate)
                .ThenBy(x => x.Number)
                .ThenBy(x => x.Employee)
                .ToListAsync())
                .Where(
                    x =>
                        x.Employee.ToString().Contains(filter)
                        || x.Name.ToLower().Contains(filter)
                    )
                .ToList()
                );
            bsOrder.DataSource = sbl;
        }

        public frmOrdersView()
        {
            InitializeComponent();
        }

        private async void frmOrdersView_Load(object sender, EventArgs e)
        {
            if (DataBase.Db.Orders.Count() == 0)
            {
                dtpFrom.Value = DateTime.Now.Date;
                dtpTo.Value = DateTime.Now.Date;
            }
            else
            {
                dtpFrom.Value = DataBase.Db.Orders.Select(x => x.CreateDate).Min().Date;
                dtpTo.Value = DataBase.Db.Orders.Select(x => x.CreateDate).Max().Date;
            }

            await ReloadData();
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

        private async void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            await ReloadData();
        }

        private void pbxClear_Click(object sender, EventArgs e)
        {
            if (DataBase.Db.Orders.Count() == 0)
            {
                dtpFrom.Value = DateTime.Now.Date;
                dtpTo.Value = DateTime.Now.Date;
            }
            else
            {
                dtpFrom.Value = DataBase.Db.Orders.Select(x => x.CreateDate).Min().Date;
                dtpTo.Value = DataBase.Db.Orders.Select(x => x.CreateDate).Max().Date;
            }
            tbxFilter.Clear();
        }

        private async void pbxOrderAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new frmOrderEdit())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    await ReloadData();
                }
            }
        }

        private async void pbxOrderEdit_Click(object sender, EventArgs e)
        {
            if (bsOrder.Current == null)
            {
                return;
            }
            var current = (Order)bsOrder.Current;
            using (var frm = new frmOrderEdit(current))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    await ReloadData();
                }
            }
        }

        private async void pbxOrderDelete_Click(object sender, EventArgs e)
        {
            if (bsOrder.Current == null)
            {
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить выделенный приказ?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            var current = (Order)bsOrder.Current;
            DataBase.Db.Orders.Remove(current);
            await DataBase.Db.SaveChangesAsync();
            await ReloadData();
        }

        private void pbxExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workBook;
            Microsoft.Office.Interop.Excel.Worksheet workSheet;

            workBook = excelApp.Workbooks.Open(Environment.CurrentDirectory + @"\Templates\Orders.xlt");
            workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets.get_Item(1);

            var i = 2;
            foreach (var item in (SortableBindingList<Order>)bsOrder.DataSource)
            {
                i++;
                workSheet.Cells[i, 1] = item.CreateDate;
                workSheet.Cells[i, 2] = item.Number.ToString();
                workSheet.Cells[i, 3] = item.Employee.ToString();
                workSheet.Cells[i, 4] = item.Name;
            }

            Microsoft.Office.Interop.Excel.Range rng = workSheet.Range[workSheet.Cells[2, 1], workSheet.Cells[i, 4]];
            rng.Columns.AutoFit();
            Microsoft.Office.Interop.Excel.Borders border = rng.Borders;
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            excelApp.Visible = true;
            excelApp.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;
            excelApp.ActiveWindow.Activate();
        }

        private async void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            await ReloadData();
        }

        private void pbxWord_Click(object sender, EventArgs e)
        {
            if (bsOrder.Current == null)
            {
                MessageBox.Show("Выделите приказ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Order opder = (Order)bsOrder.Current;

            Word._Application application;
            Word._Document document = null;
            Word.Range rng = null;

            Object missingObj = System.Reflection.Missing.Value;
            Object trueObj = true;
            Object falseObj = false;

            //создаем обьект приложения word
            application = new Word.Application();
            // создаем путь к файлу
            Object templatePathObj = Application.StartupPath + @"\Templates\OrderCard.dot";

            // если вылетим не этом этапе, приложение останется открытым
            try
            {
                document = application.Documents.Add(ref templatePathObj, ref missingObj, ref missingObj, ref missingObj);

                //Номер
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#NUM#", ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{opder.Number}");
                    rng.Paste();
                }
                //Дата
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#CREATEDATE#", ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{opder.CreateDate.ToShortDateString()}");
                    rng.Paste();
                }
                //Заголовок
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#NAME#", ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{opder.Name}");
                    rng.Paste();
                }
                //Текст
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#DESCRIPTION#", ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{opder.Description}");
                    rng.Paste();
                }
                //Сотрудник
                rng = document.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute("&#EMPLOYEE#", ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj))
                {
                    rng.Select();
                    Clipboard.SetText($"{opder.Employee.ShortName}");
                    rng.Paste();
                }

                application.WindowState = Word.WdWindowState.wdWindowStateMaximize;
                application.ActiveWindow.Activate();
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
    }
}
