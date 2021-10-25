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

namespace ServCar
{
    public partial class Dashboard : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string query = "select * from [Vehicule] where disponible = '" + 1 + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            int total = dtbl.Rows.Count;
            string disponible = total.ToString();

            string query1 = "select * from [Vehicule] where disponible = '" + 0 + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, sqlcon);
            DataTable dtbl1 = new DataTable();
            sda1.Fill(dtbl1);
            int total1 = dtbl1.Rows.Count;
            string notDisponible = total1.ToString();

            chart1.Series["s1"].IsValueShownAsLabel = true;
            chart1.Series["s1"].Points.AddXY("Disponibles", disponible);
            chart1.Series["s1"].Points.AddXY("Non disponibles", notDisponible);


            string query3 = "select * from [User] where disponible = '" + 1 + "'";
            SqlDataAdapter sda3 = new SqlDataAdapter(query3, sqlcon);
            DataTable dtbl3 = new DataTable();
            sda3.Fill(dtbl3);
            int total3 = dtbl3.Rows.Count;
            string disponible3 = total3.ToString();

            string query4 = "select * from [User] where disponible = '" + 0 + "'";
            SqlDataAdapter sda4 = new SqlDataAdapter(query4, sqlcon);
            DataTable dtbl4 = new DataTable();
            sda4.Fill(dtbl4);
            int total4 = dtbl4.Rows.Count;
            string notDisponible4 = total4.ToString();

            chart2.Series["s1"].IsValueShownAsLabel = true;
            chart2.Series["s1"].Points.AddXY("Disponible", disponible3);
            chart2.Series["s1"].Points.AddXY("Non disponible", notDisponible4);

            sqlcon.Close();
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from [Mission] order by dateArrive desc", sqlcon);
            SqlDataReader row = cmd.ExecuteReader();
            while (row.Read())
            {
                ListViewItem item = new ListViewItem(row["vehicule"].ToString());
                item.SubItems.Add(row["conducteur"].ToString());
                item.SubItems.Add(row["description"].ToString());
                item.SubItems.Add(row["depart"].ToString());
                item.SubItems.Add(row["destination"].ToString());
                item.SubItems.Add(row["dateDepart"].ToString());
                item.SubItems.Add(row["dateArrive"].ToString());

                listView1.Items.Add(item);
            }
            sqlcon.Close();
        }

        private void cars_Click(object sender, EventArgs e)
        {
            Dashboard formThis = this;
            Vehicules carsForm = new Vehicules();
            carsForm.Show();
            formThis.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard formThis = this;
            Login loginForm = new Login();
            loginForm.Show();
            formThis.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void affecter_Click(object sender, EventArgs e)
        {
            Dashboard formThis = this;
            Mission affecterForm = new Mission();
            affecterForm.Show();
            formThis.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void driverImage_Click(object sender, EventArgs e)
        {

        }

        private void drivers_Click(object sender, EventArgs e)
        {
            Dashboard formThis = this;
            Conducteurs driversForm = new Conducteurs();
            driversForm.Show();
            formThis.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
