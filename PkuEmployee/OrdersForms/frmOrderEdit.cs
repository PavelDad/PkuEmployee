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
using System.Data.Linq;
using Microsoft.EntityFrameworkCore;

namespace PkuEmployee.OrdersForms
{
    public partial class frmOrderEdit : Form
    {
        Order _order = null;
        Actions _action;
        public frmOrderEdit(Order order)
        {
            InitializeComponent();
            if (order == null)
            {
                _action = Actions.Add;
                _order = new Order();
                this.Text = "Добавление приказа";
            }
            else
            {
                _action = Actions.Edit;
                _order = order;
                this.Text = "Изменение приказа";
            }
        }

        public frmOrderEdit()
            : this(null) { }

        private async void frmOrderEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.Db.Employees.Count() == 0)
                {
                    throw new Exception("Добавьте хотя бы одного сотрудника.");
                }
                var list = await DataBase.Db.Employees.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ThenBy(x=>x.SecondName).ToListAsync();
                cbxEmployee.DataSource = list;
                switch (_action)
                {
                    case Actions.Add:
                        dtpCreateDate.Value = DateTime.Now.Date;
                        nudNumber.Value = 0;
                        cbxEmployee.SelectedIndex = 0;
                        tbxName.Text = string.Empty;
                        tbxDescription.Text = string.Empty;
                        break;
                    case Actions.Edit:
                        dtpCreateDate.Value = _order.CreateDate.Date;
                        nudNumber.Value = _order.Number;
                        cbxEmployee.SelectedItem = _order.Employee;
                        tbxName.Text = _order.Name;
                        tbxDescription.Text = _order.Description;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                _order.CreateDate = dtpCreateDate.Value.Date;
                _order.Description = tbxDescription.Text;
                _order.Employee = (Employee)cbxEmployee.SelectedItem;
                _order.Name = tbxName.Text;
                _order.Number = (int)nudNumber.Value;
                if (_order.Id == 0)
                {
                    DataBase.Db.Add(_order);
                }
                await DataBase.Db.SaveChangesAsync();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
