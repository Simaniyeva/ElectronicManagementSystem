using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ElectronicsSaleDBEntities entities = new ElectronicsSaleDBEntities();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            RegisterPage register = new RegisterPage();
            register.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (entities.Tbl_Login.Where(I=>I.UserName==Txt_UserName.Text && I.Password==Txt_Password.Text&&I.UserType==false).Count()>0)
            {
                AdminPage adminPage = new AdminPage();
                adminPage.Show();
                this.Hide();
            }
            else if ((entities.Tbl_Login.Where(I => I.UserName == Txt_UserName.Text && I.Password == Txt_Password.Text && I.UserType == true).Count() > 0))
            {
                UserPage userPage = new UserPage();
                userPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("UserName or Password are incorrect!");
            }
        }
    }
}
