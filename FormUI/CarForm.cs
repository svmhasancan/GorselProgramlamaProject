using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Linq;
using Entities;

namespace FormUI
{
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
        }
        LinqCarDal linqCarDal = new LinqCarDal();
        LinqBrandDal linqBrandDal = new LinqBrandDal();
        private LinqColorDal linqColorDal = new LinqColorDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCars();

            LoadBrands();

            LoadColors();
        }

        private void LoadColors()
        {
            var colors = linqColorDal.GetAll();
            cbxColor.DataSource = colors;
            cbxColor.DisplayMember = "ColorName";
            cbxColor.ValueMember = "ColorId";

            cbxColorUpdate.DataSource = colors;
            cbxColorUpdate.DisplayMember = "ColorName";
            cbxColorUpdate.ValueMember = "ColorId";
        }

        private void LoadBrands()
        {
            var brands = linqBrandDal.GetAll();
            cbxBrand.DataSource = brands;
            cbxBrand.DisplayMember = "BrandName";
            cbxBrand.ValueMember = "BrandId";

            cbxBrandUpdate.DataSource = brands;
            cbxBrandUpdate.DisplayMember = "BrandName";
            cbxBrandUpdate.ValueMember = "BrandId";
        }

        private void LoadCars()
        {
            DataTable carsTable = linqCarDal.GetAll();
            dgwCars.DataSource = carsTable;
        }

        private void ListCarsByCarName(string searchText)
        {
            dgwCars.DataSource = linqCarDal.GetCars(searchText);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            linqCarDal.Add(new Car
            {
                BrandId = Convert.ToInt32(cbxBrand.SelectedValue),
                ColorId = Convert.ToInt32(cbxColor.SelectedValue),
                Name = tbxName.Text,
                ModelYear = Convert.ToInt32(tbxModelYear.Text),
                DailyPrice = Convert.ToInt32(tbxDailyPrice.Text),
                Description = tbxDescription.Text,
                IsRented = false
            });
            MessageBox.Show("Araba Eklendi");
            ClearInputs();
            LoadCars();
        }

        private void ClearInputs()
        {
            cbxBrand.Text = "";
            cbxColor.Text = "";
            tbxName.Text = "";
            tbxModelYear.Text = "";
            tbxDailyPrice.Text = "";
            tbxDescription.Text = "";

            cbxBrandUpdate.Text = "";
            cbxColorUpdate.Text = "";
            tbxNameUpdate.Text = "";
            tbxModelYearUpdate.Text = "";
            tbxDailyPriceUpdate.Text = "";
            tbxDescriptionUpdate.Text = "";
        }

        private void dgwCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwCars.CurrentRow.Cells[3].Value.ToString();
            tbxModelYearUpdate.Text = dgwCars.CurrentRow.Cells[4].Value.ToString();
            tbxDailyPriceUpdate.Text = dgwCars.CurrentRow.Cells[5].Value.ToString();
            tbxDescriptionUpdate.Text = dgwCars.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Car car = new Car
            {
                CarId = Convert.ToInt32(dgwCars.CurrentRow.Cells[0].Value),
                BrandId = Convert.ToInt32(cbxBrandUpdate.SelectedValue),
                ColorId = Convert.ToInt32(cbxColorUpdate.SelectedValue),
                Name = tbxNameUpdate.Text,
                ModelYear = Convert.ToInt32(tbxModelYearUpdate.Text),
                DailyPrice = Convert.ToInt32(tbxDailyPriceUpdate.Text),
                Description = tbxDescriptionUpdate.Text,
                IsRented = false
            };
            linqCarDal.Update(car);

            ClearInputs();
            LoadCars();
            MessageBox.Show("Araç Güncellendi!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwCars.CurrentRow.Cells[0].Value);
            linqCarDal.Delete(id);
            MessageBox.Show("Araç Silindi!");
            LoadCars();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbxSearch.Text;
            
            if (string.IsNullOrEmpty(searchText))
            {
                LoadCars();
            }
            else
            {
                ListCarsByCarName(searchText);
            }
        }
    }
}