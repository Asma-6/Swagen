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
    public partial class AjouterVehicule : Form
    {
        public AjouterVehicule()
        {
            InitializeComponent();
            cars.FlatAppearance.MouseOverBackColor = cars.BackColor;
            cars.BackColorChanged += (s, e) => {
                cars.FlatAppearance.MouseOverBackColor = cars.BackColor;
            };
            drivers.FlatAppearance.MouseOverBackColor = drivers.BackColor;
            drivers.BackColorChanged += (s, e) => {
                drivers.FlatAppearance.MouseOverBackColor = drivers.BackColor;
            };
            affecter.FlatAppearance.MouseOverBackColor = affecter.BackColor;
            affecter.BackColorChanged += (s, e) => {
                affecter.FlatAppearance.MouseOverBackColor = affecter.BackColor;
            };
        }

        private void AjouterVehicule_Load(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cars_Click(object sender, EventArgs e)
        {
            AjouterVehicule formThis = this;
            Vehicules carsForm = new Vehicules();
            carsForm.Show();
            formThis.Hide();
        }

        private void drivers_Click(object sender, EventArgs e)
        {
            AjouterVehicule formThis = this;
            Conducteurs driversForm = new Conducteurs();
            driversForm.Show();
            formThis.Hide();
        }

        private void affecter_Click(object sender, EventArgs e)
        {
            AjouterVehicule formThis = this;
            Mission affecterForm = new Mission();
            affecterForm.Show();
            formThis.Hide();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            AjouterVehicule formThis = this;
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            formThis.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjouterVehicule formThis = this;
            Login loginForm = new Login();
            loginForm.Show();
            formThis.Hide();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            string matricule = textBox1.Text;
            string puissance = textBox6.Text;
            string km = textBox3.Text;
            Object comboMarque = comboBox2.SelectedItem;
            Object comboCouleur = comboBox3.SelectedItem;
            Object comboCarburant = comboBox1.SelectedItem;
            Object combo = comboBox4.SelectedItem;
            string marque = comboMarque.ToString().Split(',')[0].Split('[')[1];
            string couleur = comboCouleur.ToString().Split(',')[0].Split('[')[1];
            string carburant = comboCarburant.ToString().Split(',')[0].Split('[')[1];
            SqlConnection sqlcon1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            sqlcon1.Open();
            string req1 = "select * from [Vehicule]";
            SqlDataAdapter sda1 = new SqlDataAdapter(req1, sqlcon1);
            DataTable dtbl1 = new DataTable();
            sda1.Fill(dtbl1);
            int nbRows1 = dtbl1.Rows.Count + 1;
            sqlcon1.Close();
            SqlConnection sqlcon2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            sqlcon2.Open();
            string type = combo.ToString().Split(',')[1].Split(']')[0].Trim();
            SqlCommand query2 = new SqlCommand("insert into [Vehicule](matricule,marque,couleur,carburant,puissance,kilometrage,type) values('" + matricule.Trim() + "','" + marque.Trim() + "','" + couleur.Trim() + "','" + carburant.Trim() + "','" + puissance.Trim() + "','" + km.Trim() + "','" + type + "')", sqlcon2);
            query2.ExecuteNonQuery();
            MessageBox.Show("Véhicule ajoutée avec succès!");
            sqlcon2.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
                    }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
