using Grpc.Core;
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
    public partial class AjouterConducteur : Form
    {
        public AjouterConducteur()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AjouterConducteur_Load(object sender, EventArgs e)
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

        private void ajouter_Click(object sender, EventArgs e)
        {
            string cin = textBox1.Text;
            string nom = textBox2.Text;
            string prenom = textBox6.Text;
            string tel = textBox5.Text;
            Object combo = comboBox1.SelectedItem;
            string permis = combo.ToString().Split(',')[1].Split(']')[0];
            Object comboVille = comboBox2.SelectedItem;
            string ville = comboVille.ToString().Split(',')[0].Split('[')[1];
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            sqlcon.Open();
            string req = "select * from [User]";
            SqlDataAdapter sda = new SqlDataAdapter(req, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            int nbRows = dtbl.Rows.Count + 1;
            sqlcon.Close();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            con.Open();
            SqlCommand query = new SqlCommand("insert into [User](cin,nom,prenom,permis,telephone,profil,ville) values('" + cin.Trim() + "','" + nom.Trim() + "','" + prenom.Trim() + "','" + permis.Trim() + "','" + tel.Trim() + "'," + 1 + ",'" + ville.Trim() + "')",con);
            query.ExecuteNonQuery();
            MessageBox.Show("Conducteur ajouté avec succès!");
            con.Close();

         
        }

        private void image_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                String imageLocation = "";
                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string cin = textBox1.Text;
                        imageLocation = dialog.FileName;
                        image.ImageLocation = imageLocation;
                        string filename = cin + "o.png";
                        //File.Copy(imageLocation, System.IO.Path.Combine(@"|DataDirectory|\Image\", filename), true);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Champ CIN est vide !");
            }
            
        }

        private void cars_Click(object sender, EventArgs e)
        {
            AjouterConducteur formThis = this;
            Vehicules carsForm = new Vehicules();
            carsForm.Show();
            formThis.Hide();
        }

        private void drivers_Click(object sender, EventArgs e)
        {
            AjouterConducteur formThis = this;
            Conducteurs driversForm = new Conducteurs();
            driversForm.Show();
            formThis.Hide();
        }

        private void affecter_Click(object sender, EventArgs e)
        {
            AjouterConducteur formThis = this;
            Mission affecterForm = new Mission();
            affecterForm.Show();
            formThis.Hide();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            AjouterConducteur formThis = this;
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            formThis.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjouterConducteur formThis = this;
            Login loginForm = new Login();
            loginForm.Show();
            formThis.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
