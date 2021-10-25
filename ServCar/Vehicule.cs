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
    public partial class Vehicule : Form
    {
        private static string mat;

        public Vehicule(string matricule)
        {
            InitializeComponent();
            Vehicule.mat = matricule;
            SqlConnection sqlcon1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            sqlcon1.Open();
            SqlCommand cmd1 = new SqlCommand("select * from [Vehicule] where matricule = '" + matricule + "'", sqlcon1);
            SqlDataReader row1 = cmd1.ExecuteReader();
            if (row1.Read())
            {
                textBox1.Text = row1["matricule"].ToString();
                comboBox2.Text = row1["marque"].ToString();
                comboBox3.Text = row1["couleur"].ToString();
                comboBox1.Text = row1["carburant"].ToString();
                comboBox4.Text = row1["type"].ToString();
                textBox6.Text = row1["puissance"].ToString();
                textBox3.Text = row1["kilometrage"].ToString();

               

            }
            sqlcon1.Close();
        }

        private void Vehicule_Load(object sender, EventArgs e)
        {
            comboBox3.Items.Add(new KeyValuePair<string, string>("Blanc", "0"));
            comboBox3.Items.Add(new KeyValuePair<string, string>("Noir", "1"));
            comboBox3.Items.Add(new KeyValuePair<string, string>("Gris", "2"));
            comboBox3.Items.Add(new KeyValuePair<string, string>("Rouge", "3"));
            comboBox3.Items.Add(new KeyValuePair<string, string>("Bleu", "4"));

            comboBox3.DisplayMember = "key";
            comboBox3.ValueMember = "value";

            comboBox1.Items.Add(new KeyValuePair<string, string>("Essence", "0"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Gasoil", "1"));


            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "value";

            comboBox2.Items.Add(new KeyValuePair<string, string>("Citroen", "0"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Dacia", "1"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Fiat", "2"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Ford", "3"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Honda", "4"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Hyundai", "5"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Isuzu", "6"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("KIA", "7"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Mitsubishi", "8"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Nissan", "9"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Peugeot", "10"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Renault", "11"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Seat", "12"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Skoda", "13"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Suzuki", "14"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Toyota", "15"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Volkswagen", "16"));
            comboBox2.Items.Add(new KeyValuePair<string, string>("Volvo", "17"));

            comboBox2.DisplayMember = "key";
            comboBox2.ValueMember = "value";

            comboBox4.Items.Add(new KeyValuePair<string, string>("Voiture", "B"));
            comboBox4.Items.Add(new KeyValuePair<string, string>("Marchandises", "C"));
            comboBox4.Items.Add(new KeyValuePair<string, string>("Personnel", "D"));


            comboBox4.DisplayMember = "key";
            comboBox4.ValueMember = "value";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void upload_Click(object sender, EventArgs e)
        {

        }

        private void ajouter_Click(object sender, EventArgs e)
        {

            string matricule = textBox1.Text;
            string marque = comboBox2.Text;
            string couleur  = comboBox3.Text;
            string carburant = comboBox1.Text;
            string puissance = textBox6.Text;
            string kilometrage = textBox3.Text;
            string combo = comboBox4.Text;
            
            string type = "";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            con.Open();
            if(combo.ToString() != "Voiture" && combo.ToString() != "Personnel" && combo.ToString() != "Marchandises")
            {
                type = combo.ToString().Trim();
            }
            if (combo.ToString() == "Voiture")
            {
                type = "B";
            }
            if (combo.ToString() == "Personnel")
            {
                type = "D";
            }
            if (combo.ToString() == "Marchandises")
            {
                type = "C";
            }
            
            SqlCommand query = new SqlCommand("update [Vehicule] set matricule = '" + matricule.Trim() + "',marque = '" + marque.Trim() + "',couleur = '" + couleur.Trim() + "',carburant = '" + carburant.Trim() + "', puissance = '" + puissance.Trim() + "', kilometrage = '" + kilometrage + "', type = '" + type + "' where matricule = '" + Vehicule.mat + "' and disponible = '" + 1 + "'", con);
            query.ExecuteNonQuery();
            MessageBox.Show("Véhicule modifiée avec succès!");
            con.Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void image_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cars_Click(object sender, EventArgs e)
        {
            Vehicule formThis = this;
            Vehicules carsForm = new Vehicules();
            carsForm.Show();
            formThis.Hide();
        }

        private void drivers_Click(object sender, EventArgs e)
        {
            Vehicule formThis = this;
            Conducteurs driversForm = new Conducteurs();
            driversForm.Show();
            formThis.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicule formThis = this;
            Login loginForm = new Login();
            loginForm.Show();
            formThis.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void affecter_Click(object sender, EventArgs e)
        {
            Vehicule formThis = this;
            Mission affecterForm = new Mission();
            affecterForm.Show();
            formThis.Hide();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Vehicule formThis = this;
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            formThis.Hide();
        }
    }
}
