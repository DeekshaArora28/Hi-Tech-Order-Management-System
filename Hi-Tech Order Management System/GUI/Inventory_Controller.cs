using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Hi_Tech_Order_Management_System.BLL;
using Hi_Tech_Order_Management_System.DAL;


namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class Inventory_Controller : Form
    {
        SqlDataAdapter da;
        DataSet dsbooks;
        DataTable dtbooks;
        SqlCommandBuilder sqlBuilder;

        Books bs = new Books();

        public Inventory_Controller()
        {
            InitializeComponent();
        }

        private void list_Click(object sender, EventArgs e)
        {

            //Books books = new Books();

            //List<Books> listbooks = new List<Books>();
            //listbooks = books.GetList();
            //dataGridViewBooks.DataSource = listbooks;

            da.Fill(dsbooks.Tables["Books"]);
            dataGridViewBooks.DataSource = dsbooks.Tables["Books"];

        }

        private void search_click(object sender, EventArgs e)
        {
            int bookId  = Convert.ToInt32(textISBN.Text.Trim());
            DataRow dr = dtbooks.Rows.Find(bookId);
            if (dr != null)
            {
                textISBN.Text = dr["ISBN"].ToString();
                textBookTitle.Text = dr["BookTitle"].ToString();
                textBoxQOH.Text = dr["QOH"].ToString();
                textBoxUnitPrice.Text = dr["UnitPrice"].ToString();
                textBoxCategory.Text = dr["CategoryId"].ToString();
                textBoxPublisher.Text = dr["PublisherId"].ToString();
                

            }
            else
            {
                MessageBox.Show("Book not found!", "Invalid ISBN ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_click(object sender, EventArgs e)
        {
            

            DataRow dr = dtbooks.NewRow();
            dr["ISBN"] = textISBN.Text.Trim();
            dr["BookTitle"] = textBookTitle.Text.Trim();
            dr["QOH"] = textBoxQOH.Text.Trim();
            dr["UnitPrice"] = textBoxUnitPrice.Text.Trim();
            dr["CategoryId"] = textBoxCategory.Text.Trim();
            dr["PublisherId"] = textBoxPublisher.Text.Trim();
            
            dtbooks.Rows.Add(dr);
            MessageBox.Show(dr.RowState.ToString());
            textISBN.Text = "";
            textBookTitle.Text = "";
            textBoxQOH.Text = "";
            textBoxUnitPrice.Text = "";
            textBoxCategory.Text = "";
            textBoxPublisher.Text = "";
            
        }


    

        private void Update_click(object sender, EventArgs e)
        {
            DataRow dr = dtbooks.Rows.Find(textISBN.Text.Trim());

            dr["BookTitle"] = textBookTitle.Text.Trim();
            dr["QOH"] = textBoxQOH.Text.Trim();
            dr["UnitPrice"] = textBoxUnitPrice.Text.Trim();
            dr["CategoryId"] = textBoxCategory.Text.Trim();
            dr["PublisherId"] = textBoxPublisher.Text.Trim();
            
            MessageBox.Show(dr.RowState.ToString());
            textISBN.Text = "";
            textBookTitle.Text = "";
            textBoxQOH.Text = "";
            textBoxUnitPrice.Text = "";
            textBoxCategory.Text = "";
            textBoxPublisher.Text = "";

        }

        private void delete_click(object sender, EventArgs e)
        {
            int isbn = Convert.ToInt32(textISBN.Text.Trim());
            DataRow dr = dtbooks.Rows.Find(isbn);
            dr.Delete();
            MessageBox.Show(dr.RowState.ToString());

            textISBN.Text = "";
            textBookTitle.Text = "";
            textBoxQOH.Text = "";
            textBoxUnitPrice.Text = "";
            textBoxCategory.Text = "";
            textBoxPublisher.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            MainMenuForm bks = new MainMenuForm();
            bks.Hide();
            bks.ShowDialog();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            dsbooks = new DataSet("BooksDS");
            dtbooks = new DataTable("Books");
            dsbooks.Tables.Add(dtbooks);
            dtbooks.Columns.Add("ISBN", typeof(Int32));
            dtbooks.Columns.Add("BookTitle", typeof(string));
            dtbooks.Columns.Add("QOH", typeof(int));
            dtbooks.Columns.Add("UnitPrice", typeof(int));
            dtbooks.Columns.Add("CategoryId", typeof(int));
            dtbooks.Columns.Add("PublisherId", typeof(int));
            
            dtbooks.PrimaryKey = new DataColumn[] { dtbooks.Columns["ISBN"] };

            da = new SqlDataAdapter("SELECT * FROM Books", UtilityDB.ConnectDb());
            sqlBuilder = new SqlCommandBuilder(da);
        }
    }
}
