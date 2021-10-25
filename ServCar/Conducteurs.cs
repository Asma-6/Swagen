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
    public partial class Conducteurs : Form
    {
        

        public Conducteurs()
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

        private void Conducteurs_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from [User] where profil = '" + 1 + "' order by nom asc", sqlcon);
            SqlDataReader row = cmd.ExecuteReader();
            while (row.Read())
            {
                ListViewItem item = new ListViewItem(row["cin"].ToString());
                item.SubItems.Add(row["nom"].ToString());
                item.SubItems.Add(row["prenom"].ToString());
                item.SubItems.Add(row["permis"].ToString());
                item.SubItems.Add(row["telephone"].ToString());
                item.SubItems.Add(row["ville"].ToString());

                listView1.Items.Add(item);
            }
            sqlcon.Close();
            
            /*if (searchBox.Text != "")
            {
                SqlConnection sqlcon1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
                sqlcon1.Open();
                SqlCommand cmd2 = new SqlCommand("select * from [User] where profil = '" + 1 + "' and (cin like '%" + searchBox.Text + "%' or nom like '%" + searchBox.Text + "%' or prenom like '%" + searchBox.Text + "%' or permis like '%" + searchBox.Text + "%' or telephone like '%" + searchBox.Text + "%')  order by nom asc", sqlcon1);
                SqlDataReader row2 = cmd2.ExecuteReader();
                SqlConnection sqlconn2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
                sqlconn2.Open();
                SqlCommand cmd3 = new SqlCommand("select * from [User] where profil = '" + 1 + "' order by nom asc", sqlconn2);
                SqlDataReader row3 = cmd3.ExecuteReader();
                listView1.Items.Clear();
                sqlconn2.Close();
                while (row2.Read())
                {
                    ListViewItem item1 = new ListViewItem(row2["cin"].ToString());
                    item1.SubItems.Add(row2["nom"].ToString());
                    item1.SubItems.Add(row2["prenom"].ToString());
                    item1.SubItems.Add(row2["permis"].ToString());
                    item1.SubItems.Add(row2["telephone"].ToString());
                    item1.SubItems.Add(row2["ville"].ToString());


                    listView1.Items.Add(item1);
                }
                sqlcon1.Close();
            }*/

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cars_Click(object sender, EventArgs e)
        {
            Conducteurs formThis = this;
            Vehicules carsForm = new Vehicules();
            carsForm.Show();
            formThis.Hide();
        }

        private void drivers_Click(object sender, EventArgs e)
        {

        }

        private void affecter_Click(object sender, EventArgs e)
        {
            Conducteurs formThis = this;
            Mission affecterForm = new Mission();
            affecterForm.Show();
            formThis.Hide();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Conducteurs formThis = this;
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            formThis.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conducteurs formThis = this;
            Login loginForm = new Login();
            loginForm.Show();
            formThis.Hide();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            Conducteurs formThis = this;
            AjouterConducteur addDriverForm = new AjouterConducteur();
            
            addDriverForm.Show();
            formThis.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = searchBox.Text;
            SqlConnection sqlcon1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            sqlcon1.Open();
            SqlCommand cmd1 = new SqlCommand("select * from [User] where profil = '" + 1 + "' and (cin like '%" + searchBox.Text + "%' or nom like '%" + searchBox.Text + "%' or prenom like '%" + searchBox.Text + "%' or permis like '%" + searchBox.Text + "%' or telephone like '%" + searchBox.Text + "%')  order by nom asc", sqlcon1);
            SqlDataReader row1 = cmd1.ExecuteReader();
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            sqlconn.Open();
            SqlCommand cmd = new SqlCommand("select * from [User] where profil = '" + 1 + "' order by nom asc", sqlconn);
            SqlDataReader row = cmd.ExecuteReader();
            listView1.Items.Clear();
            sqlconn.Close();
            while (row1.Read())
            {
                ListViewItem item1 = new ListViewItem(row1["cin"].ToString());
                item1.SubItems.Add(row1["nom"].ToString());
                item1.SubItems.Add(row1["prenom"].ToString());
                item1.SubItems.Add(row1["permis"].ToString());
                item1.SubItems.Add(row1["telephone"].ToString());
                item1.SubItems.Add(row1["ville"].ToString());


                listView1.Items.Add(item1);
            }
            sqlcon1.Close();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nbSelected = listView1.SelectedItems.Count;
            int i = 0;
            while ( i < nbSelected)
            {
                string cinSelected = listView1.Items[listView1.SelectedIndices[i]].ToString().Split('{')[1].Split('}')[0];
                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
                
                
                con2.Open();
                
                SqlCommand query3 = new SqlCommand("select * from [User] where cin = '" + cinSelected + "' and disponible ='" + 1 + "'", con2);
                SqlDataReader row = query3.ExecuteReader();
                if (!row.HasRows)
                {
                    MessageBox.Show("Conducteur Indisponible! Vous ne pouvez pas le supprimer pour l'instant.");
                    con2.Close();
                    
                }

                else
                {
                    con2.Close();
                    con2.Open();
                    SqlCommand query2 = new SqlCommand("delete from [User] where cin = '" + cinSelected + "'", con2);
                    query2.ExecuteNonQuery();
                    //File.Delete(@"|DataDirectory|\Image\" + cinSelected + "ù.png");
                    MessageBox.Show("Conducteur " + cinSelected + " supprimé avec succès!");
                    con2.Close();
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        item.Remove();
                    }
                }

                i += 1;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
                con.Open();

                string mat = listView1.Items[listView1.SelectedIndices[0]].ToString().Split('{')[1].Split('}')[0];
                SqlCommand query2 = new SqlCommand("select * from [User] where cin = '" + mat + "' and disponible = '" + 1 + "'", con);
                SqlDataReader row = query2.ExecuteReader();
                if (!row.HasRows)
                {
                    MessageBox.Show("Conducteur Indisponible! Vous ne pouvez pas le modifier pour l'instant.");
                    con.Close();
                }
                else
                {
                    Conducteur form2 = new Conducteur(listView1.Items[listView1.SelectedIndices[0]].ToString().Split('{')[1].Split('}')[0]);
                    form2.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Aucun conducteur n'a été séléctionné!");
            }
        }
    }
}
