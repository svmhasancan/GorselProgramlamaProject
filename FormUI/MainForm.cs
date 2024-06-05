using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Concretes.Linq;
using Entities;

namespace FormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private LinqUserDal linqUserDal = new LinqUserDal();
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = tbxUserName.Text;
            string password = tbxPassword.Text;
            List<User> users = linqUserDal.GetUser(userName,password);
            if (users.Count > 0)
            {
                User loggedInUser = users.First();
                string userRole = loggedInUser.Role.Trim();

                if (userRole.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    // Eğer kullanıcı admin ise AdminForm'u açıyoruz
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else
                {
                    // Kullanıcı admin değilse farklı bir form (örneğin UserForm) açıyoruz
                    //UserForm userForm = new UserForm();
                    //userForm.Show();
                }

                // Mevcut formu kapatıyoruz
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
            }
        }
    }
}
