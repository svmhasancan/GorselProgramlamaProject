using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            CarForm carForm = new CarForm();
            carForm.ShowDialog();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorForm colorForm = new ColorForm();
            colorForm.ShowDialog();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            BrandForm brandForm = new BrandForm();
            brandForm.ShowDialog();
        }
    }
}
