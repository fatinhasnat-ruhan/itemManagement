using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;




namespace WinFormsApp9



{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Fatin Hasnat\\Documents\\ItemManagement.mdf\";Integrated Security=True;Connect Timeout=30");

        private void Reset()
        {
            NameTb.Text = "";
            CatCb.SelectedIndex = -1;
            QuaTb.Text = "";
            PriceTb.Text = "";
            ManTb.Text = "";

        }

        private void populate()
        {
            con.Open();
            string query = "select * from ItemManagement";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || CatCb.SelectedIndex == -1 || QuaTb.Text == "" || PriceTb.Text == "" || ManTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    string query = "insert into ItemManagement values('" + NameTb.Text + "', '" + CatCb.SelectedItem.ToString() + "', '" + QuaTb.Text + "', '" + PriceTb.Text + "', '" + ManTb.Text + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Successfully Inserted");
                    con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update ItemManagement set ItName=@Name,ItCategory=@cat, ItQuantity=@quan, ItPrice=@price, ItDescription=@des", con);
            cmd.Parameters.AddWithValue("@Name", NameTb.Text);
            cmd.Parameters.AddWithValue("cat", CatCb.Text);
            cmd.Parameters.AddWithValue("@quan", QuaTb.Text);
            cmd.Parameters.AddWithValue("@price", PriceTb.Text);
            cmd.Parameters.AddWithValue("@des", ManTb.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Item Successfully Updated");
            populate();
            Reset();
        }

        private void Dltbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from ItemManagement where ItName=@name", con);
            cmd.Parameters.AddWithValue("@name", NameTb.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Item Successfully Deleted");
            populate();
            Reset();
        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
