using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Order_Management_System.Validation;
using Hi_Tech_Order_Management_System.BLL;
using Hi_Tech_Order_Management_System.DAL;
using System.Data.SqlClient;
 


namespace Hi_Tech_Order_Management_System.GUI
{
   
    public partial class UserSecurityFrom : Form
    {

        SqlDataAdapter da;
        DataSet dsSecurity;
        DataTable dtSecurity;
        SqlCommandBuilder sqlBuilder;

        public UserSecurityFrom()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string id = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            da = new SqlDataAdapter("SELECT * FROM login", UtilityDB.ConnectDb());
            sqlBuilder = new SqlCommandBuilder(da);

            da.Fill(dtSecurity);
            if (dtSecurity.Rows.Count > 0 )
            {
                MessageBox.Show("The login is successfull and you have entered into the application", "ok");
                MainMenuForm form = new MainMenuForm();
                this.Hide();
                form.ShowDialog();
            }

            else
            {
                MessageBox.Show("You have entered the wrong information");
            }
            




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UserSecurityFrom_Load(object sender, EventArgs e)
        {
            dsSecurity = new DataSet("SecurityDB");
            dtSecurity = new DataTable("Security");
            dsSecurity.Tables.Add(dtSecurity);
            dtSecurity.Columns.Add("UserName", typeof(string));
            dtSecurity.Columns.Add("Password", typeof(string));

            dtSecurity.PrimaryKey = new DataColumn[] { dtSecurity.Columns["UserName"] };

           

        }
    }
    }
