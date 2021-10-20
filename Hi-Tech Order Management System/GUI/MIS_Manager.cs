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
using Hi_Tech_Order_Management_System.Validation;
using System.Data.SqlClient;

namespace Hi_Tech_Order_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void add_click(object sender, EventArgs e)
        {
            
            string UserId = textBox2.Text.Trim();
            if (!Validation.Validation.IsValidName(UserId))
            {
                MessageBox.Show("Invalid User Name", "Error");
                textBox4.Clear();
                textBox4.Focus();
                return;

            }

            string Password = textBox1.Text.Trim();
            if (!Validation.Validation.IsValidName(Password))
            {
                MessageBox.Show("Invalid Password", "Error");
                textBox5.Clear();
                textBox5.Focus();
                return;
            }

            string EmployeeId = textBox3.Text.Trim();
            if (!Validation.Validation.IsValidId(EmployeeId,4))
            {
                MessageBox.Show("Invalid Employee Id", "Error");
                textBox4.Clear();
                textBox4.Focus();
                return;

            }

            User usr = new User();
            usr.UserName= textBox2.Text.Trim();
            usr.Password = textBox1.Text.Trim();
            usr.EmployeeId = Convert.ToInt32(textBox3.Text.Trim());

            usr.SaveUser(usr);
            
            MessageBox.Show("The User have been saved successfully", "Conformation");
          


        }

    

    private void usr_update(object sender, EventArgs e)
        {
            User usr = new User();
            usr.EmployeeId = Convert.ToInt32(textBox3.Text);
            usr.UserName = textBox2.Text;
            usr.Password = textBox1.Text;
            usr.Update(usr);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("This Employee has been updated successfully!", "Confirmation");
        }

        private void usr_delete(object sender, EventArgs e)
        {
            string userId = textBox2.Text.Trim();
            if (!Validation.Validation.IsValidId(userId, 4))
            {
                MessageBox.Show("Invalid user id", "Error");
                textBox2.Clear();
                textBox2.Focus();
                return;
            }
            User user = new User();
            
           
            

        }

        private void employee_information(object sender, EventArgs e)
        {

        }

        private void em_update(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(textBox4.Text);
            emp.FirstName = textBox5.Text;
            emp.LastName = textBox6.Text;
            emp.JobId = Convert.ToInt32(textBox7.Text);
            emp.UpdateEmployee(emp);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("This Employee has been updated successfully!", "Confirmation");

        }

        private void emp_delete(object sender, EventArgs e)
        {

        }

        private void emp_search(object sender, EventArgs e)
        {
            

            string tempId = textBox8.Text.Trim();
            if (!Validation.Validation.IsValidId(tempId, 4))
            {
                MessageBox.Show("Invalid Employee Id", "Error");
                textBox8.Clear();
                textBox8.Focus();
                return;
            }

            // perform search operation by Employee ID
            Employee emp = new Employee();
            emp = emp.SearchById(Convert.ToInt32(textBox8.Text.Trim()));
            if (emp != null)
            {
                textBox4.Text = emp.EmployeeId.ToString();
                textBox5.Text = emp.FirstName;
                textBox6.Text = emp.LastName;
                textBox7.Text = emp.JobId.ToString();
                textBox9.Text = emp.PhoneNUmber;

            }
            else
            {
                MessageBox.Show("Employee not found !", "Invalid Employee ID");
                textBox8.Clear();
                textBox8.Focus();
            }



        }






        private void button8_Click(object sender, EventArgs e)
        {
            string tempId = textBoxInput.Text.Trim();
            if (!Validation.Validation.IsValidId(tempId, 4))
            {
                MessageBox.Show("Invalid Employee Id", "Error");
                textBoxInput.Clear();
                textBoxInput.Focus();
                return;
            }

            // perform search operation by Employee ID
            User usr = new User();
            usr = usr.GetUser(Convert.ToInt32(textBoxInput.Text.Trim()));
            if (usr != null)
            {
                textBox2.Text = usr.UserName;
                textBox1.Text = usr.Password;
                textBox3.Text = usr.EmployeeId.ToString();
                

            }
            else
            {
                MessageBox.Show("Employee not found !", "Invalid Employee ID");
                textBox8.Clear();
                textBox8.Focus();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection connDB = UtilityDB.ConnectDb();
            MessageBox.Show(connDB.State.ToString(), "Database Connection");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            List <Employee> listemp = new List<Employee>();
            listemp = emp.GetEmployeeList();
            dataGridView2.DataSource = listemp;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string EmpId = textBox4.Text.Trim();
            if (!Validation.Validation.IsValidId(EmpId, 4))
            {
                MessageBox.Show("Invalid Employee Id", "Error");
                textBox4.Clear();
                textBox4.Focus();
                return;

            }

            string empFName = textBox5.Text.Trim();
            if (!Validation.Validation.IsValidName(empFName))
            {
                MessageBox.Show("Invalid First Name", "Error");
                textBox5.Clear();
                textBox5.Focus();
                return;
            }


            string tempLName = textBox6.Text.Trim();
            if (!Validation.Validation.IsValidName(tempLName))
            {
                MessageBox.Show("Invalid Last Name", "Error");
                textBox6.Clear();
                textBox6.Focus();
                return;
            }

            string tempJob = textBox7.Text.Trim();
            if (!Validation.Validation.IsValidId(tempJob,4))
            {
                MessageBox.Show("Job Cannot be empty", "Error");
                textBox7.Clear();
                textBox7.Focus();
                return;
            }

            string tempPNumber = textBox9.Text.Trim();
            //if (!Validation.Validation.IsValidId(EmpId, 11))
            //{
            //    MessageBox.Show("Invalid Phone Number", "Error");
            //    textBox9.Clear();
            //    textBox9.Focus();
            //    return;

            //}



            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(textBox4.Text);
            emp.FirstName = textBox5.Text.Trim();
            emp.LastName = textBox6.Text.Trim();
            emp.JobId = Convert.ToInt32(textBox7.Text);
            emp.PhoneNUmber = textBox9.Text.Trim();

            emp.SaveEmployee(emp);
            MessageBox.Show("Information is saved Successfully");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            User usr = new User();

            List<User> listusr = new List<User>();
            listusr = usr.GetEmployeeList();
            dataGridView1.DataSource = listusr;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

