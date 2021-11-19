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
    public partial class OrderBasket : Form
    {
        public OrderBasket()
        {
            InitializeComponent();
        }
        ElectronicsSaleDBEntities entities = new ElectronicsSaleDBEntities();
        private void OrderBasket_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.Tbl_Order.ToList();
        }
        int id;
        private void Btn_DeleteOrder_Click(object sender, EventArgs e)
        {
            Tbl_Order DeleteOrder = (from db in entities.Tbl_Order where (db.OrderID == id) select (db)).FirstOrDefault();
            entities.Tbl_Order.Remove(DeleteOrder);
            entities.SaveChanges();
            MessageBox.Show("Order deleted!");
        }

        private void Btn_GetAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.Tbl_Order.ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = dataGridView1.SelectedCells[0].RowIndex;
            id = (int)dataGridView1.Rows[index].Cells[0].Value;
            Txt_ProductName.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            Txt_OrderID.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            
        }
    }
}
