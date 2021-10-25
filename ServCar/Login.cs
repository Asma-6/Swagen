using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ServCar
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            textBox1.Clear();
            txtUsername.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            string query = "select * from [User] where cin = '" + txtUsername.Text.Trim() + "' and nom = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                if (dtbl.Rows[0]["profil"].ToString() == "False") 
                {
                    Vehicules carsForm = new Vehicules();
                    Login formThis = this;
                    carsForm.Show();
                    formThis.Hide();
                }
                if (dtbl.Rows[0]["profil"].ToString() == "True")
                {
                    Suivi mapForm = new Suivi(txtUsername.Text.Trim());
                    Login formThis = this;
                    mapForm.Show();
                    formThis.Hide();
                }
          
                
                

            }
            else
            {
                MessageBox.Show("Invalid login or password");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Hide();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtPassword.Text = textBox1.Text;
        }
    }
}
