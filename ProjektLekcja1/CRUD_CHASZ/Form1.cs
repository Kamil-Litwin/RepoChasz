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

namespace CRUD_CHASZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=KLITWIN2\\ENOVA;Initial Catalog=ChaszCRUD;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //sprawdzanie czy dane id już jest na bazie, jeśli select potwierdzi że występuje już taki rekord otrzymujemy informacje aby użyć innego
                SqlCommand check = new SqlCommand("select * from ProduktInfo_Tab where IDProduktu ='" + int.Parse(textBox1.Text) + "'", con);
                using (SqlDataReader reader = check.ExecuteReader())
                {
                    if (reader.HasRows  == false)
                    {
                        reader.Close();
                        SqlCommand command = new SqlCommand("insert into ProduktInfo_Tab values ('" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "', getdate(),getdate()) ", con);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Succesfully Inserted.");
                        
                        con.Close();
                        BindData();
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("This ID exists.");
                    }
                }
            }
            catch(Exception ee)
            {
                con.Close();
                MessageBox.Show(ee.Message);
            }
        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from ProduktInfo_Tab", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("Update ProduktInfo_Tab set NazwaProdukt = '" + textBox2.Text + "',Projekt = '" + textBox3.Text + "',Kolor = '" + comboBox1.Text + "',UpdateData = '" + DateTime.Parse(dateTimePicker1.Text) + "' where IDProduktu= '" + int.Parse(textBox1.Text) + "' ", con);
                int result = command.ExecuteNonQuery();
                con.Close();
                if (result != 0)
                {
                    MessageBox.Show("Succesfuly updated.");
                }
                else
                {
                    MessageBox.Show("Nothing updated. Try again.");
                }
                BindData();
            }
            catch(Exception ee)
            {
                con.Close();
                MessageBox.Show(ee.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    //upewnianie się przy kasowaniu rekordu
                    if (MessageBox.Show("Are you sure to delete this record?", "delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("Delete ProduktInfo_Tab where IDProduktu = '" + int.Parse(textBox1.Text) + "' ", con);
                        int result = command.ExecuteNonQuery();
                        con.Close();
                        //prosta weryfikacja czy usunięto jakiś rekord jeśli executenonquery zwróci inną wartość od 0 czyli coś się zmieni.
                        if (result != 0)
                        {
                            MessageBox.Show("Succesfully deleted.");
                        }
                        else
                        {
                            MessageBox.Show("Nothing deleted. Try again.");
                        }
                        BindData();
                    }
                }
                else
                {
                    MessageBox.Show("Put product ID");
                }
            }
            catch(Exception ee)
            {
                con.Close();
                MessageBox.Show(ee.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //dodałem sprawdzanie czy wartość w polu z id jest pusta jeśli tak wyświetl wszystko
            //update - skorzystałem z gotowej funkcji wywołującej pełną listę z selecta
            //string tekst;
            try
            {
                if (textBox1.Text == (""))
                {
                    //tekst = "select * from ProduktInfo_Tab";
                    BindData();
                }
                else
                {
                    //tekst = "select * from ProduktInfo_Tab where IDProduktu = '" + int.Parse(textBox1.Text) + "' ";

                    //SqlCommand command = new SqlCommand(tekst, con);
                    SqlCommand command = new SqlCommand("select * from ProduktInfo_Tab where IDProduktu = '" + int.Parse(textBox1.Text) + "' ", con);
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
                    dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
                }
            }
            catch (Exception ee)
            {
                con.Close();
                MessageBox.Show(ee.Message);
            }
        }
    }
}
