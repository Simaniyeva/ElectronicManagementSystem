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
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        ElectronicsSaleDBEntities entities = new ElectronicsSaleDBEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            Tbl_Login logins = new Tbl_Login();
            logins.UserName = Txt_UserName.Text;
            logins.Password = Txt_Password.Text;
            logins.Email = Txt_Email.Text;
            if (radioButton1.Checked==true)
            {
                logins.UserType = false;
            }
            if (radioButton2.Checked==true)
            {
                logins.UserType = true;
            }
            entities.Tbl_Login.Add(logins);
            entities.SaveChanges();
            MessageBox.Show("User Added!");

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
