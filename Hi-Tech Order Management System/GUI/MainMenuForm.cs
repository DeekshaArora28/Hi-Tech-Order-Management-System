using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void employeeAndUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Manager cusForm = new Sales_Manager();
            this.Hide();
            cusForm.ShowDialog();
        }

        private void formsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory_Controller bookForm = new Inventory_Controller();
            this.Hide();
            bookForm.ShowDialog();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_Clerks orderForm = new Order_Clerks();
            this.Hide();
            orderForm.ShowDialog();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void employeeAndUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 empUser = new Form1();
            this.Hide();
            empUser.ShowDialog();

        }

        private void customerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Manager cust = new Sales_Manager();
            this.Hide();
            cust.ShowDialog();
        }

        private void booksFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory_Controller books = new Inventory_Controller();
            this.Hide();
            books.ShowDialog();
        }

        private void orderFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_Clerks order = new Order_Clerks();
            this.Hide();
            order.ShowDialog();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }
    }
}
