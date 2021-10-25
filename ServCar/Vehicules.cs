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
    public partial class Vehicules : Form
    {
        public Vehicules()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from [Vehicule] order by matricule asc", sqlcon);
            SqlDataReader row = cmd.ExecuteReader();
            while (row.Read())
            {
                ListViewItem item = new ListViewItem(row["matricule"].ToString());
                item.SubItems.Add(row["marque"].ToString());
                item.SubItems.Add(row["couleur"].ToString());
                item.SubItems.Add(row["carburant"].ToString());
                item.SubItems.Add(row["puissance"].ToString());
                item.SubItems.Add(row["kilometrage"].ToString());

                listView1.Items.Add(item);
            }
            sqlcon.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cars_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Vehicules formThis = this;
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            formThis.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Vehicules formThis = this;
            Login loginForm = new Login();
            loginForm.Show();
            formThis.Hide();
        }

        private void driverImage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void affecter_Click(object sender, EventArgs e)
        {
            Vehicules formThis = this;
            Mission affecterForm = new Mission();
            affecterForm.Show();
            formThis.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            Vehicules formThis = this;
            AjouterVehicule addCarForm = new AjouterVehicule();
            addCarForm.Show();
            formThis.Hide();
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void drivers_Click(object sender, EventArgs e)
        {
            Vehicules formThis = this;
            Conducteurs driversForm = new Conducteurs();
            driversForm.Show();
            formThis.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
                con.Open();

                string mat = listView1.Items[listView1.SelectedIndices[0]].ToString().Split('{')[1].Split('}')[0];
                SqlCommand query2 = new SqlCommand("select * from [Vehicule] where matricule = '" + mat + "' and disponible = '" + 1 + "'", con);
                SqlDataReader row = query2.ExecuteReader();
                if (!row.HasRows)
                {
                    MessageBox.Show("Véhicule Indisponible! Vous ne pouvez pas la modifier pour l'instant.");
                    con.Close();
                }
                else {
                    Vehicule form2 = new Vehicule(listView1.Items[listView1.SelectedIndices[0]].ToString().Split('{')[1].Split('}')[0]);
                    form2.Show();
                    this.Hide();
                }
                
                
            }
            else
            {
                MessageBox.Show("Aucune véhicule n'a été sélectionnée !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nbSelected = listView1.SelectedItems.Count;
            int i = 0;
            while (i < nbSelected)
            {
                string matSelected = listView1.Items[listView1.SelectedIndices[i]].ToString().Split('{')[1].Split('}')[0];
                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
                con2.Open();
                SqlCommand query3 = new SqlCommand("select * from [Vehicule] where matricule = '" + matSelected + "' and disponible = '" + 1 + "'", con2);
                SqlDataReader row = query3.ExecuteReader();
                if (!row.HasRows)
                {
                    MessageBox.Show("Véhicule Indisponible! Vous ne pouvez pas la supprimer pour l'instant.");
                    con2.Close();

                }
                else
                {
                    con2.Close();
                    con2.Open();
                    SqlCommand query2 = new SqlCommand("delete from [Vehicule] where matricule = '" + matSelected + "' and disponible = '" + 1 + "'", con2);
                    query2.ExecuteNonQuery();
                    MessageBox.Show("Véhicule " + matSelected + " supprimée avec succès!");
                    con2.Close();
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        item.Remove();
                    }
                }
                
                i += 1;
            

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = searchBox.Text;
            SqlConnection sqlcon1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            sqlcon1.Open();
            SqlCommand cmd1 = new SqlCommand("select * from [Vehicule] where matricule like '%" + searchBox.Text + "%' or marque like '%" + searchBox.Text + "%' or couleur like '%" + searchBox.Text + "%' or  carburant like '%" + searchBox.Text + "%' or puissance like '%" + searchBox.Text + "%' or kilometrage like '%" + searchBox.Text + "%'  order by matricule asc", sqlcon1);
            SqlDataReader row1 = cmd1.ExecuteReader();
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            sqlconn.Open();
            SqlCommand cmd = new SqlCommand("select * from [Vehicule] order by matricule asc", sqlconn);
            SqlDataReader row = cmd.ExecuteReader();
            listView1.Items.Clear();
            sqlconn.Close();
            while (row1.Read())
            {
                ListViewItem item1 = new ListViewItem(row1["matricule"].ToString());
                item1.SubItems.Add(row1["marque"].ToString());
                item1.SubItems.Add(row1["couleur"].ToString());
                item1.SubItems.Add(row1["carburant"].ToString());
                item1.SubItems.Add(row1["puissance"].ToString());
                item1.SubItems.Add(row1["kilometrage"].ToString());


                listView1.Items.Add(item1);
            }
            sqlcon1.Close();
        }
    }
}
