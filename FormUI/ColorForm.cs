using DataAccess.Linq;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Color = Entities.Color;

namespace FormUI
{
    public partial class ColorForm : Form
    {
        public ColorForm()
        {
            InitializeComponent();
        }

        private LinqColorDal linqColorDal = new LinqColorDal();
        private void ColorForm_Load(object sender, EventArgs e)
        {
            LoadColors();
        }

        private void LoadColors()
        {
            DataTable colorsTable = linqColorDal.GetAll();
            dgwColors.DataSource = colorsTable;
        }

        private void ListColorsByColorName(string key)
        {
            dgwColors.DataSource = linqColorDal.GetColor(key);
        }

        private void btnColorAdd_Click(object sender, EventArgs e)
        {
            linqColorDal.Add(new Color
            {
                ColorName = tbxColorName.Text
            });
            ClearInputs();
            LoadColors();
            MessageBox.Show("Renk Eklendi");
        }

        private void btnColorUpdate_Click(object sender, EventArgs e)
        {
            Color color = new Color
            {
                ColorId = Convert.ToInt32(dgwColors.CurrentRow.Cells[0].Value),
                ColorName = tbxColorNameUpdate.Text
            };
            linqColorDal.Update(color);
            ClearInputs();
            LoadColors();
            MessageBox.Show("Renk Güncellendi!");
        }

        private void ClearInputs()
        {
            tbxColorName.Text = "";
            tbxColorNameUpdate.Text = "";
        }

        private void dgwColors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxColorNameUpdate.Text = dgwColors.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnColorDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwColors.CurrentRow.Cells[0].Value);
            linqColorDal.Delete(id);
            LoadColors();
            MessageBox.Show("Renk Silindi!");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchedKey = tbxSearch.Text;

            if (string.IsNullOrEmpty(searchedKey))
            {
                LoadColors();
            }
            else
            {
                ListColorsByColorName(searchedKey);
            }
        }
    }
}