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
    public partial class Mission : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        public Mission()
        {
            InitializeComponent();
        }

        private void Mission_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(new KeyValuePair<string, string>("voiture", "B"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("marchandise", "C"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("personnelle", "D"));

            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "value";

            villeDepart.Items.Add(new KeyValuePair<string, string>("Rabat", "0"));
            villeDepart.Items.Add(new KeyValuePair<string, string>("Casablanca", "1"));
            villeDepart.Items.Add(new KeyValuePair<string, string>("Fes", "2"));
            villeDepart.Items.Add(new KeyValuePair<string, string>("Tanger", "3"));
            villeDepart.Items.Add(new KeyValuePair<string, string>("Marrakech", "4"));
            villeDepart.Items.Add(new KeyValuePair<string, string>("Sale", "5"));
            villeDepart.Items.Add(new KeyValuePair<string, string>("Meknes", "6"));
            villeDepart.Items.Add(new KeyValuePair<string, string>("Oujda", "7"));
            villeDepart.Items.Add(new KeyValuePair<string, string>("Kenitra", "8"));
            villeDepart.Items.Add(new KeyValuePair<string, string>("Agadir", "9"));
            villeDepart.Items.Add(new KeyValuePair<string, string>("Tetouan", "10"));
            villeDepart.Items.Add(new KeyValuePair<string, string>("Temara", "11"));
            villeDepart.Items.Add(new KeyValuePair<string, string>("Safi", "12"));

            villeDepart.DisplayMember = "key";
            villeDepart.ValueMember = "value";

            villeDestination.Items.Add(new KeyValuePair<string, string>("Rabat", "0"));
            villeDestination.Items.Add(new KeyValuePair<string, string>("Casablanca", "1"));
            villeDestination.Items.Add(new KeyValuePair<string, string>("Fes", "2"));
            villeDestination.Items.Add(new KeyValuePair<string, string>("Tanger", "3"));
            villeDestination.Items.Add(new KeyValuePair<string, string>("Marrakech", "4"));
            villeDestination.Items.Add(new KeyValuePair<string, string>("Sale", "5"));
            villeDestination.Items.Add(new KeyValuePair<string, string>("Meknes", "6"));
            villeDestination.Items.Add(new KeyValuePair<string, string>("Oujda", "7"));
            villeDestination.Items.Add(new KeyValuePair<string, string>("Kenitra", "8"));
            villeDestination.Items.Add(new KeyValuePair<string, string>("Agadir", "9"));
            villeDestination.Items.Add(new KeyValuePair<string, string>("Tetouan", "10"));
            villeDestination.Items.Add(new KeyValuePair<string, string>("Temara", "11"));
            villeDestination.Items.Add(new KeyValuePair<string, string>("Safi", "12"));

            villeDestination.DisplayMember = "key";
            villeDestination.ValueMember = "value";

            miss.Items.Add(new KeyValuePair<string, string>("Livrer marchandise", "0"));
            miss.Items.Add(new KeyValuePair<string, string>("Livrer personne ou groupe de personne", "1"));
            miss.DisplayMember = "key";
            miss.ValueMember = "value";
        }

        private void miss_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void villeDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void villeDepart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateDepart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateArrive_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            KeyValuePair<string, string> kvp = (KeyValuePair<string, string>)comboBox1.SelectedItem;
            string key = kvp.Key.ToString();
            string Rabat = "Rabat";
            string depart = villeDepart.SelectedItem.ToString().Split(',')[0].Split('[')[1];
            string value = kvp.Value.ToString();
            
            string query = "select * from [Vehicule] where type = '" + value + "' and disponible = '" + 1 + "'";
            string query1 = "select * from [User] where profil = '" + 1 + "' and  disponible = '" + 1 + "' and permis = '" + value + "' and ville = '" + depart + "'";
            string query2 = "select * from [User] where profil = '" + 1 + "' and  disponible = '" + 1 + "' and permis = '" + value + "' and ville ='" + Rabat + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, sqlcon);
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, sqlcon);


            DataTable dtbl = new DataTable();
            DataTable dtbl1 = new DataTable();
            DataTable dtbl2 = new DataTable();


            sda.Fill(dtbl);
            sda1.Fill(dtbl1);
            sda2.Fill(dtbl2);


            if (dtbl1.Rows.Count == 0)
            {
                foreach (DataRow dr in dtbl2.Rows)
                {
                    comboBox3.Items.Add(dr["nom"].ToString());
                }
            }
            else
            {
                foreach (DataRow dr in dtbl1.Rows)
                {
                    comboBox3.Items.Add(dr["nom"].ToString());
                }
            }

            foreach (DataRow dr in dtbl.Rows)
            {
                comboBox2.Items.Add(dr["matricule"].ToString());
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string conducteur = comboBox3.SelectedItem.ToString();
            string vehicule = comboBox2.SelectedItem.ToString();
            string depart = villeDepart.SelectedItem.ToString().Split(',')[0].Split('[')[1];
            string destination = villeDestination.SelectedItem.ToString().Split(',')[0].Split('[')[1];


            SqlCommand query = new SqlCommand("insert into [Mission] (dateDepart,dateArrive,vehicule,conducteur,depart,destination,description) values('" + dateDepart.Value.ToString() + "','" + dateArrive.Value.ToString() + "','" + vehicule + "','" + conducteur + "','" + depart + "','" + destination + "','" + description.Text.Trim() + "')", sqlcon);
            query.ExecuteNonQuery();
            SqlCommand query1 = new SqlCommand("update [Vehicule] set disponible='" + 0 + "' where matricule = '" + vehicule + "'", sqlcon);
            query1.ExecuteNonQuery();
            
            SqlCommand query2 = new SqlCommand("update [User] set disponible='" + 0 + "' where nom = '" + conducteur + "'", sqlcon);
            query2.ExecuteNonQuery();
            MessageBox.Show("Mission ajoutée avec succès !");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mission formThis = this;
            Login loginForm = new Login();
            loginForm.Show();
            formThis.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Mission formThis = this;
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            formThis.Hide();
        }

        private void affecter_Click(object sender, EventArgs e)
        {

        }

        private void drivers_Click(object sender, EventArgs e)
        {
            Mission formThis = this;
            Conducteurs driversForm = new Conducteurs();
            driversForm.Show();
            formThis.Hide();
        }

        private void cars_Click(object sender, EventArgs e)
        {
            Mission formThis = this;
            Vehicules carsForm = new Vehicules();
            carsForm.Show();
            formThis.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void driverImage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
