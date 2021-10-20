using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Order_Management_System.DAL;
using Hi_Tech_Order_Management_System.BLL;
using Hi_Tech_Order_Management_System.Validation;
using System.Data.SqlClient;
using System.Xml;
//using Hi_Tech_Order_Management_System.Validation;

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class Sales_Manager : Form
    {
        SqlDataAdapter da;
        DataSet dscustomers;
        DataTable dtcustomers;
        SqlCommandBuilder sqlBuilder;

        Customer cs = new Customer();


        public Sales_Manager()
        {
            InitializeComponent();
        }

        private void list_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            List<Customer> listcst = new List<Customer>();
            //listcst = customer.GetEmployeeList();

            dataGridViewDataset.DataSource = listcst;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dscustomers = new DataSet("CustomerDB");
            dtcustomers = new DataTable("Customers");
            dscustomers.Tables.Add(dtcustomers);
            dtcustomers.Columns.Add("CustomerId", typeof(Int32));
            dtcustomers.Columns.Add("CustomerName", typeof(string));
            dtcustomers.Columns.Add("StreetName", typeof (string));
            dtcustomers.Columns.Add("Province" , typeof(string));
            dtcustomers.Columns.Add("City" , typeof(string));
            dtcustomers.Columns.Add("PostalCode", typeof(string));
            dtcustomers.Columns.Add("ContactName", typeof(string));
            dtcustomers.Columns.Add("ContactEmail", typeof(string));
            dtcustomers.Columns.Add("CreditLimit", typeof(string));
            dtcustomers.PrimaryKey = new DataColumn[] { dtcustomers.Columns["CustomerId"] };

            da = new SqlDataAdapter("SELECT * FROM CUSTOMERS", UtilityDB.ConnectDb());
            sqlBuilder = new SqlCommandBuilder(da);

        }

        private void add_Click(object sender, EventArgs e)
        {


            DataRow dr = dtcustomers.NewRow();
            dr["CustomerId"] = textBoxcstId.Text.Trim();
            dr["CustomerName"] = textBoxcstName.Text.Trim();
            dr["StreetName"] = textBoxstrName.Text.Trim();
            dr["Province"] = textBoxProvName.Text.Trim();
            dr["City"] = textBoxCityName.Text.Trim();
            dr["PostalCode"] = textBoxPostalCode.Text.Trim();
            dr["ContactName"] = textBoxCtName.Text.Trim();
            dr["ContactEmail"] = textBoxEmail.Text.Trim();
            dr["CreditLimit"] = textBoxCreditLim.Text.Trim();

            dtcustomers.Rows.Add(dr);
            MessageBox.Show(dr.RowState.ToString());
            textBoxcstId.Text = "";
            textBoxcstName.Text = "";
            textBoxstrName.Text = "";
            textBoxProvName.Text = "";
            textBoxCityName.Text = "";
            textBoxPostalCode.Text = "";
            textBoxCtName.Text = "";
            textBoxEmail.Text = "";
            textBoxCreditLim.Text = "";

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //da.Fill(dsCollegeDB.Tables["Students"]);
            //dataGridViewStudentFromDS.DataSource = dsCollegeDB.Tables["Students"];

            da.Fill(dscustomers.Tables["Customers"]);
            dataGridViewDataset.DataSource = dscustomers.Tables["Customers"];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(textBoxcstId.Text.Trim());
            DataRow dr = dtcustomers.Rows.Find(customerId);

            //dr["CustomerName"] = textBoxcstName.Text.Trim();
            dr["StreetName"] = textBoxstrName.Text.Trim();
            dr["Province"] = textBoxProvName.Text.Trim();
            dr["City"] = textBoxCityName.Text.Trim();
            dr["PostalCode"] = textBoxPostalCode.Text.Trim();
            dr["ContactName"] = textBoxCtName.Text.Trim();
            dr["ContactEmail"] = textBoxEmail.Text.Trim();
            dr["CreditLimit"] = textBoxCreditLim.Text.Trim();
            MessageBox.Show(dr.RowState.ToString());
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(textBoxcstId.Text.Trim());
            DataRow dr = dtcustomers.Rows.Find(searchId);
            if (dr != null)
            {
                textBoxcstName.Text = dr["CustomerName"].ToString();
                textBoxstrName.Text = dr["StreetName"].ToString();
                textBoxProvName.Text = dr["Province"].ToString();
                textBoxCityName.Text = dr["City"].ToString();
                textBoxPostalCode.Text = dr["PostalCode"].ToString();
                textBoxCtName.Text = dr["ContactName"].ToString();
                textBoxEmail.Text = dr["ContactEmail"].ToString();
                textBoxCreditLim.Text = dr["CreditLimit"].ToString();


            }
            else
            {
                MessageBox.Show("Student not found!", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainMenuForm cus = new MainMenuForm();
            this.Hide();
            cus.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cusId = Convert.ToInt32(textBoxcstId.Text.Trim());
            DataRow dr = dtcustomers.Rows.Find(cusId);
            dr.Delete();
            MessageBox.Show(dr.RowState.ToString());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxcstId.Text = "";
            textBoxcstName.Text = "";
            textBoxstrName.Text = "";
            textBoxProvName.Text = "";
            textBoxCityName.Text = "";
            textBoxPostalCode.Text = "";
            textBoxCtName.Text = "";
            textBoxEmail.Text = "";
            textBoxCreditLim.Text = "";
        }
    }
}
