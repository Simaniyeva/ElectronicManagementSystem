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
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
        }
        ElectronicsSaleDBEntities entities = new ElectronicsSaleDBEntities();
        private void Btn_Order_Click(object sender, EventArgs e)
        {
            Tbl_Order orders = new Tbl_Order();
            orders.ProductName = Txt_ProductName.Text;
            
            orders.OrderDate = dateTimePicker1.Value;
            var CatName = entities.Categories.Where(I => I.CategoryName == Cmb_Category.Text).Select(I => I.CategoryName).FirstOrDefault();
            orders.CategoryName = CatName;
            entities.Tbl_Order.Add(orders);
            entities.SaveChanges();
            MessageBox.Show("Order Added!");

        }
        int id;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            id = (int)dataGridView1.Rows[index].Cells[0].Value;
            Txt_ProductName.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            Txt_PrductPrice.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            int catId = (int)dataGridView1.Rows[index].Cells[5].Value;
            Cmb_Category.Text = entities.Categories.Where(I => I.CategoryID == catId).Select(I => I.CategoryName).FirstOrDefault().ToString();

        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            string SearchOrder= Txt_Search.Text;
            var query = from db in entities.Tbl_Order
                        where (db.ProductName.Contains(SearchOrder))
                        select (db);
            dataGridView1.DataSource = query.ToList();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            int FindId = Convert.ToInt32(Txt_Search.Text);
            dataGridView1.DataSource = entities.Tbl_Order.Where(I => I.ProductID == FindId).ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OrderBasket basket = new OrderBasket();
            basket.Show();
            this.Hide();
                
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.Tbl_Products.ToList();
        }
    }
}
