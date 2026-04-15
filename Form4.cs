using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace icecream123
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string iec = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\csharp\\ice cream\\ice cream\\icecream.mdf\";Integrated Security=True";
            SqlConnection con = new SqlConnection(iec);
            string sql = "update  icecream set Name=@Name,Price=@Price where Id=@Id ";
            SqlCommand comm = new SqlCommand(sql, con);
            comm.Parameters.Add("@Name", SqlDbType.VarChar).Value = textBox2.Text;
            comm.Parameters.Add("@Price", SqlDbType.NChar).Value = textBox3.Text;
            comm.Parameters.Add("@Id", SqlDbType.Int).Value = textBox1.Text;
            con.Open();
            comm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تمت عملية التعديلات بنجاح");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string iec = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\csharp\\ice cream\\ice cream\\icecream.mdf\";Integrated Security=True";
            SqlConnection con = new SqlConnection(iec);
            SqlCommand comm = new SqlCommand("Select * from icecream", con);
            con.Open();
            SqlDataReader dr = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string iec = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\csharp\\ice cream\\ice cream\\icecream.mdf\";Integrated Security=True";
            SqlConnection con = new SqlConnection(iec);
            string sql = "insert into icecream(Id,Name,Price) values(@Id,@Name,@Price)";
            SqlCommand comm = new SqlCommand(sql, con);

            comm.Parameters.Add("@Id", SqlDbType.Int).Value = textBox1.Text;
            comm.Parameters.Add("@Name", SqlDbType.VarChar).Value = textBox2.Text;

            comm.Parameters.Add("@Price", SqlDbType.NChar).Value = textBox3.Text;

            con.Open();
            comm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تمت الاضافة بنجاح");
            button1_Click(null, null);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string iec = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\csharp\\ice cream\\ice cream\\icecream.mdf\";Integrated Security=True";
            SqlConnection con = new SqlConnection(iec);
            string sql = "delete from icecream where Id=@Id ";
            SqlCommand comm = new SqlCommand(sql, con);
            comm.Parameters.Add("@Id", SqlDbType.Int).Value = textBox1.Text;
            con.Open();
            comm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تمت عملية الحدف بنجاح");
            button1_Click(null, null);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           /* var con = new SqlConnection( "Data Source=.;Initial Catalog=YourDatabaseName;Integrated Security=True");
            var comm = new SqlCommand("SELECT ItemName, Price FROM icecream ", con);
            con.Open();

            var reader = comm.ExecuteReader();
           ListBox.Items.Clear();
            while (reader.Read())
                ListBox.Items.Add($"{reader["ItemName"]}-{Convert.ToDouble(reader["Price"]):0.00}$");
            reader.Close();
            con.Close();*/
 
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
