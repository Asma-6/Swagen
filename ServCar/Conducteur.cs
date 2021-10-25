using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServCar
{
    public partial class Conducteur : Form
    {
        private static string cin;

        public Conducteur(string cin)
        {
            InitializeComponent();
            Conducteur.cin = cin;
            label5.Text = cin;
            SqlConnection sqlcon1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            sqlcon1.Open();
            SqlCommand cmd1 = new SqlCommand("select * from [User] where profil = '" + 1 + "' and cin = '" + cin + "'", sqlcon1);
            SqlDataReader row1 = cmd1.ExecuteReader();
            if (row1.Read())
            {
                textBox2.Text = row1["nom"].ToString();
                textBox6.Text = row1["prenom"].ToString();
                comboBox1.Text = row1["permis"].ToString();
                textBox5.Text = row1["telephone"].ToString();
                comboBox2.Text = row1["ville"].ToString();
                if(File.Exists(@"|DataDirectory|\Image\" + cin + "ù.png"))
                {
                    Image pdp = Image.FromFile(@"|DataDirectory|\Image\" + cin + "ù.png");
                    this.image.Image = pdp;
                }

                
            }
            sqlcon1.Close();
        }

        private void Conducteur_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add(new KeyValuePair<string, string>("Permis B", "B"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Permis C", "C"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Permis D", "D"));

            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "value";

            comboBox2.Items.Add(new KeyValuePair<string, string>("Rabat", "0"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Casablanca", "1"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Fes", "2"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Tanger", "3"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Marrakech", "4"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Sale", "5"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Meknes", "6"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Oujda", "7"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Kenitra", "8"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Agadir", "9"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Tetouan", "10"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Temara", "11"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Safi", "12"));

            comboBox2.DisplayMember = "key";
            comboBox2.ValueMember = "value";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void image_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void cars_Click(object sender, EventArgs e)
        {
            Conducteur formThis = this;
            Vehicules carsForm = new Vehicules();
            carsForm.Show();
            formThis.Hide();
        }

        private void drivers_Click(object sender, EventArgs e)
        {
            Conducteur formThis = this;
            Conducteurs driversForm = new Conducteurs();
            driversForm.Show();
            formThis.Hide();
        }

        private void affecter_Click(object sender, EventArgs e)
        {
            Conducteur formThis = this;
            Mission affecterForm = new Mission();
            affecterForm.Show();
            formThis.Hide();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Conducteur formThis = this;
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            formThis.Hide();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            
            string nom = textBox2.Text;
            string prenom = textBox6.Text;
            string tel = textBox5.Text;
            string permis = comboBox1.Text;
            
            if (comboBox1.Text == "Permis B")
            {
                permis = "B";
            }
            if (comboBox1.Text == "Permis C")
            {
                permis = "C";
            }
            if (comboBox1.Text == "Permis D")
            {
                permis = "D";
            }
            string ville = comboBox2.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            con.Open();
            SqlCommand query = new SqlCommand("update [User] set nom = '" + nom + "',prenom = '" + prenom + "',permis = '" + permis + "',telephone = '" + tel + "', ville = '" + ville + "' where cin = '" + cin + "'", con);
            query.ExecuteNonQuery();
            MessageBox.Show("Conducteur modifié avec succès!");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conducteur formThis = this;
            Login loginForm = new Login();
            loginForm.Show();
            formThis.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
