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

namespace PkuEmployee.DirectoriesForms
{
    public partial class frmDirectoriesEdit<T> : Form where T : class, INameble, new()
    {
        T _source;
        Actions _action;
        public frmDirectoriesEdit(T source)
        {
            if (source == null)
            {
                _action = Actions.Add;
                _source = new T();
            }
            else
            {
                _action = Actions.Edit;
                _source = source;
            }
            InitializeComponent();
        }

        public frmDirectoriesEdit()
            : this(null) { }

        private void frmDirectoriesEdit_Load(object sender, EventArgs e)
        {
            switch (_action)
            {
                case Actions.Add:
                    this.Text = "Добавление";
                    tbxName.Text = string.Empty;
                    break;
                case Actions.Edit:
                    this.Text = "Редактирование";
                    tbxName.Text = _source.Name;
                    break;
                default:
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxName.Text))
                {
                    throw new Exception("Заполните наименование.");
                }

                _source.Name = tbxName.Text;
                if (_action == Actions.Add)
                {
                    DataBase.Db.Add(_source);
                }
                await DataBase.Db.SaveChangesAsync();
                DialogResult = DialogResult.OK;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
