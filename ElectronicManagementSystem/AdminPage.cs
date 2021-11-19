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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }
        ElectronicsSaleDBEntities entities = new ElectronicsSaleDBEntities();
        private void AdminPage_Load(object sender, EventArgs e)
        {
            Cmb_Category.DataSource = entities.Categories.ToList();
            Cmb_Category.DisplayMember = "CategoryName";
            Cmb_Category.ValueMember = "CategoryName";
            Cmb_Firm.DataSource = entities.Firms.ToList();
            Cmb_Firm.DisplayMember = "FirmName";
            Cmb_Firm.ValueMember = "FirmName";
            dataGridView1.DataSource = entities.Tbl_Products.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tbl_Products products = new Tbl_Products();
            products.ProductName = Txt_ProductName.Text;
            products.ProductPrice = Txt_PrductPrice.Text;
            products.ProductCount = Txt_ProductCount.Text;
            if (checkBox1.Checked==true)
            {
                products.NewOrOld = true;
            }

            else
            {
                products.NewOrOld = false;
            }
            var FirmID = entities.Firms.Where(I => I.FirmName == Cmb_Firm.Text).Select(I => I.FirmID).FirstOrDefault();
            products.FirmID = FirmID;
            var CatID = entities.Categories.Where(I => I.CategoryName == Cmb_Category.Text).Select(I => I.CategoryID).FirstOrDefault();
            products.CategoryID = CatID;
            entities.Tbl_Products.Add(products);
            entities.SaveChanges();
            MessageBox.Show("Product Added!");
        }
        int id;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            id = (int)dataGridView1.Rows[index].Cells[0].Value;
            Txt_ProductName.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
        Txt_PrductPrice.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
           Txt_ProductCount.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            int catId = (int)dataGridView1.Rows[index].Cells[5].Value;
            int firmId= (int)dataGridView1.Rows[index].Cells[6].Value;
            Cmb_Category.Text = entities.Categories.Where(I => I.CategoryID == catId).Select(I => I.CategoryName).FirstOrDefault().ToString();
            Cmb_Firm.Text = entities.Firms.Where(I => I.FirmID == firmId).Select(I => I.FirmName).FirstOrDefault().ToString();
            bool NewOrOld = (bool)dataGridView1.Rows[index].Cells[4].Value;
            if (NewOrOld)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tbl_Products products = entities.Tbl_Products.Where(I => I.ProductID == id).FirstOrDefault();
            var CatID = entities.Categories.Where(I => I.CategoryName == Cmb_Category.Text).Select(I => I.CategoryID).FirstOrDefault();
            var FirmID = entities.Firms.Where(I => I.FirmName == Cmb_Firm.Text).Select(I => I.FirmID).FirstOrDefault();
            if (products!=null)
            {
                products.ProductName = Txt_ProductName.Text;
                products.ProductPrice = Txt_PrductPrice.Text;
                products.ProductCount = Txt_ProductCount.Text;
                products.CategoryID = CatID;
                products.FirmID = FirmID;
                if (checkBox1.Checked)
                {
                    products.NewOrOld = true;
                }
                else
                {
                    products.NewOrOld = false;
                }
            }
            entities.SaveChanges();
            MessageBox.Show("Product Updated!");

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Tbl_Products DeleteProduct = (from db in entities.Tbl_Products where (db.ProductID == id) select (db)).FirstOrDefault();
            entities.Tbl_Products.Remove(DeleteProduct);
            entities.SaveChanges();
            MessageBox.Show("Product Deleted!");
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            int FindId = Convert.ToInt32(Txt_Search.Text);
            dataGridView1.DataSource = entities.Tbl_Products.Where(I => I.ProductID == FindId).ToList();
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            string SearchProduct = Txt_Search.Text;
            var query = from db in entities.Tbl_Products
                        where (db.ProductName.Contains(SearchProduct))
                        select (db);
            dataGridView1.DataSource = query.ToList();
        }

        private void Btn_GetAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.Tbl_Products.ToList();
        }
    }
}
