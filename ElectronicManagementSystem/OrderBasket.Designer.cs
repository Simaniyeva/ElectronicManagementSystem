
namespace ElectronicManagementSystem
{
    partial class OrderBasket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_DeleteOrder = new System.Windows.Forms.Button();
            this.Btn_GetAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_ProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_OrderID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 307);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Btn_DeleteOrder
            // 
            this.Btn_DeleteOrder.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteOrder.Location = new System.Drawing.Point(338, 353);
            this.Btn_DeleteOrder.Name = "Btn_DeleteOrder";
            this.Btn_DeleteOrder.Size = new System.Drawing.Size(152, 52);
            this.Btn_DeleteOrder.TabIndex = 1;
            this.Btn_DeleteOrder.Text = "Delete Order";
            this.Btn_DeleteOrder.UseVisualStyleBackColor = true;
            this.Btn_DeleteOrder.Click += new System.EventHandler(this.Btn_DeleteOrder_Click);
            // 
            // Btn_GetAll
            // 
            this.Btn_GetAll.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GetAll.Location = new System.Drawing.Point(567, 353);
            this.Btn_GetAll.Name = "Btn_GetAll";
            this.Btn_GetAll.Size = new System.Drawing.Size(152, 52);
            this.Btn_GetAll.TabIndex = 2;
            this.Btn_GetAll.Text = "All Orders";
            this.Btn_GetAll.UseVisualStyleBackColor = true;
            this.Btn_GetAll.Click += new System.EventHandler(this.Btn_GetAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Product Name";
            // 
            // Txt_ProductName
            // 
            this.Txt_ProductName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ProductName.Location = new System.Drawing.Point(12, 164);
            this.Txt_ProductName.Name = "Txt_ProductName";
            this.Txt_ProductName.Size = new System.Drawing.Size(245, 33);
            this.Txt_ProductName.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "Order ID";
            // 
            // Txt_OrderID
            // 
            this.Txt_OrderID.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_OrderID.Location = new System.Drawing.Point(12, 77);
            this.Txt_OrderID.Name = "Txt_OrderID";
            this.Txt_OrderID.Size = new System.Drawing.Size(245, 33);
            this.Txt_OrderID.TabIndex = 25;
            // 
            // OrderBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_OrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_ProductName);
            this.Controls.Add(this.Btn_GetAll);
            this.Controls.Add(this.Btn_DeleteOrder);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "OrderBasket";
            this.Text = "OrderBasket";
            this.Load += new System.EventHandler(this.OrderBasket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_DeleteOrder;
        private System.Windows.Forms.Button Btn_GetAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_OrderID;
    }
}