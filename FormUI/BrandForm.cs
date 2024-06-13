using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Linq;
using Entities;

namespace FormUI
{
    public partial class BrandForm : Form
    {
        public BrandForm()
        {
            InitializeComponent();
        }

        private LinqBrandDal linqBrandDal = new LinqBrandDal();
        private void BrandForm_Load(object sender, EventArgs e)
        {
            LoadBrands();
        }

        private void LoadBrands()
        {
            DataTable brandsTable = linqBrandDal.GetAll();
            dgwBrands.DataSource = brandsTable;
        }

        private void ListBrandByBrandName(string searchedText)
        {
            dgwBrands.DataSource = linqBrandDal.GetBrand(searchedText);
        }

        private void btnBrandAdd_Click(object sender, EventArgs e)
        {
            linqBrandDal.Add(new Brand
            {
                BrandName = tbxBrandName.Text
            });
            LoadBrands();
            MessageBox.Show("Marka Eklendi!");
        }

        private void dgwBrands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBrandNameUpdate.Text = dgwBrands.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnBrandUpdate_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand
            {
                BrandId = Convert.ToInt32(dgwBrands.CurrentRow.Cells[0].Value),
                BrandName = tbxBrandNameUpdate.Text
            };
            linqBrandDal.Update(brand);
            LoadBrands();
            MessageBox.Show("Marka Güncellendi!");
        }

        private void btnBrandDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwBrands.CurrentRow.Cells[0].Value);
            linqBrandDal.Delete(id);
            LoadBrands();
            MessageBox.Show("Marka Silindi");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchedText = tbxSearch.Text;

            if (string.IsNullOrEmpty(searchedText))
            {
                LoadBrands();
            }
            else
            {
                ListBrandByBrandName(searchedText);
            }
        }
    }
}