using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Order_Management_System.BLL;
using Hi_Tech_Order_Management_System.DAL;


namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class Order_Clerks : Form
    {
         FinalProjectMultitieringEntities7 dbEntities = new FinalProjectMultitieringEntities7();
        public Order_Clerks()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            Order odr = new Order();
            odr.OrderId = Convert.ToInt32(textBoxOrderId.Text.Trim());
            odr.OrderStatus = comboBox1.Text.Trim();
            odr.OrderType = comboBox2.Text.Trim();
            odr.RequiredDate = textBox1.Text.Trim();
            odr.ShippingDate = textBoxShippingDate.Text.Trim();
            odr.OrderDate = textBoxOrderDate.Text.Trim();

            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(textBoxEmployeeId.Text.Trim());

            Customer cst = new Customer();
            cst.CustomerId = Convert.ToInt32(textBoxCustomerId.Text.Trim());

            dbEntities.Orders.Add(odr);
            
            dbEntities.SaveChanges();
            MessageBox.Show("Order have been saved successfully");

            textBoxOrderId.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
            textBoxShippingDate.Text = "";
            textBoxOrderDate.Text = "";
           // odr.CustomerId = Convert.ToInt32(textBoxCustomerId.Text.Trim());
           //odr.


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Order odr = new Order();
            odr = dbEntities.Orders.Find(textBoxOrderId.Text.Trim());
            if (odr != null)
            {
                dbEntities.Orders.Remove(odr);
                dbEntities.SaveChanges(); 
                MessageBox.Show("Order Has been deleted successfully", "Confirmation");
            }

            else
            {

                MessageBox.Show("OrderId not found!", "Confirmation");
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listOdr = (from odr in dbEntities.Orders
                          select odr).ToList<Order>();

           
            dataGridView1.DataSource = listOdr;
       
    }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Orders ord = new Orders();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Order odr = new Order();
            odr = dbEntities.Orders.Find(Convert.ToInt32(textBoxOrderId.Text.Trim()));
            if (odr != null)
            {
                odr.OrderStatus = comboBox1.Text.Trim();
                odr.OrderType = comboBox2.Text.Trim();
                odr.RequiredDate = textBox1.Text.Trim();
                odr.ShippingDate = textBoxShippingDate.Text.Trim();
                odr.OrderStatus = comboBox1.Text.Trim();


            }
            else
            {
                MessageBox.Show("Order does not found");
                return; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenuForm odr = new MainMenuForm();
            odr.Hide();
            odr.ShowDialog();
        }
    }
}