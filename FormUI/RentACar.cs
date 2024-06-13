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
using Color = System.Drawing.Color;

namespace FormUI
{
    public partial class RentACar : Form
    {
        private LinqCarDal carDal = new LinqCarDal();
        private LinqRentalDal rentalDal = new LinqRentalDal();
        private LinqBrandDal brandDal = new LinqBrandDal();
        private int loggedInUserId;
        public RentACar(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        private void RentACar_Load(object sender, EventArgs e)
        {
            LoadCars();

            LoadBrands();
        }

        private void LoadBrands()
        {
            cbxBrands.DataSource = brandDal.GetAll();
            cbxBrands.DisplayMember = "BrandName";
            cbxBrands.ValueMember = "BrandId";
        }

        private void LoadCars()
        {
            dgwRentals.DataSource = carDal.GetAll();
        }

        private void ListCarsByCarName(string key)
        {
            dgwRentals.DataSource = carDal.GetCars(key);
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (CheckCar())
            {
                Rental rental = new Rental
                {
                    UserId = loggedInUserId,
                    CarId = Convert.ToInt32(dgwRentals.CurrentRow.Cells[0].Value),
                    RentalDate = Convert.ToDateTime(dtpRentalDate.Text),
                    ReturnDate = Convert.ToDateTime(dtpReturnDate.Text)
                };

                rentalDal.RentCar(rental);
                MessageBox.Show("Araç Kiralandı");
                LoadCars();
            }
            else
            {
                MessageBox.Show("Bu Araç Zaten Kiralanmış");
                MessageBox.Show("Araç Kiralanamadı!");
            }

            lblAmount.Text = "Tutar : ";
            dtpRentalDate.Value = DateTime.Now;
            dtpReturnDate.Value = DateTime.Now;
        }

        private void btnDeliverCar_Click(object sender, EventArgs e)
        {
            if (CheckCar() == false)
            {
                int carId = Convert.ToInt32(dgwRentals.CurrentRow.Cells[0].Value);
                rentalDal.DeliverCar(carId);
                LoadCars();
                MessageBox.Show("Araç Teslim Edildi");
            }
            else
            {
                MessageBox.Show("Bu Araç Kiralanmamış!");
            }
        }

        private bool CheckCar()
        {
            bool success = true;
            var result = dgwRentals.CurrentRow.Cells[7].Value.ToString();

            if (result == "True")
            {
                success = false;
            }

            return success;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string brandName = cbxBrands.Text;
            dgwRentals.DataSource = carDal.GetCarsByBrand(brandName);
        }

        private void btnRemoveFilters_Click(object sender, EventArgs e)
        {
            LoadBrands();
            LoadCars();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchedText = tbxSearch.Text;

            if (string.IsNullOrEmpty(searchedText))
            {
                LoadCars();
            }
            else
            {
                ListCarsByCarName(searchedText);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime rentalDate = dtpRentalDate.Value;
            DateTime returnDate = dtpReturnDate.Value;

            decimal dailyPrice = Convert.ToDecimal(dgwRentals.CurrentRow.Cells[5].Value);

            TimeSpan differance = returnDate - rentalDate;

            int days = differance.Days;

            if (days <= 0)
            {
                MessageBox.Show("Lütfen Geçerli Bir Teslim Günü Seçiniz!");
            }
            else
            {
                decimal result = days * dailyPrice;

                lblAmount.Text = "Tutar : " + result.ToString();
            }
        }
    }
}