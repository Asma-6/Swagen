using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServCar
{
    public partial class Vitesse : Form
    {
        int vitesse, route = 1;
        Random aleatoire = new Random();
        private static string cin;

        public Vitesse(string login)
        {
            InitializeComponent();
            Vitesse.cin = login;
            pictureBox9.Hide();
            label10.Hide();
            pictureBox10.Hide();
            label11.Hide();
            radioButton3.Checked = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Vitesse_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cars_Click(object sender, EventArgs e)
        {
            Vitesse formThis = this;
            Suivi loginForm = new Suivi(Vitesse.cin);
            loginForm.Show();
            formThis.Hide();
        }

        private void drivers_Click(object sender, EventArgs e)
        {
            Vitesse formThis = this;
            Map loginForm = new Map(Vitesse.cin);
            loginForm.Show();
            formThis.Hide();
        }

        private void affecter_Click(object sender, EventArgs e)
        {
            Alert loginForm = new Alert(Vitesse.cin);
            loginForm.Show();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vitesse formThis = this;
            Login loginForm = new Login();
            loginForm.Show();
            formThis.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            radioButton3_MouseClick(sender, e);
            radioButton4_MouseClick(sender, e);
            radioButton5_MouseClick(sender, e);
        }


        

        private void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
            vitesse = aleatoire.Next(0, 241);
            if (route == 0)
            {
                if (vitesse > 130)
                {
                    label8.Text = Convert.ToString(vitesse);
                    pictureBox9.Hide();
                    label10.Hide();
                    pictureBox10.Show();
                    label11.Show();
                }
                else
                {
                    label8.Text = Convert.ToString(vitesse);
                    pictureBox10.Hide();
                    label11.Hide();
                    pictureBox9.Show();
                    label10.Show();
                }
            }
            else if (route == 1)
            {
                if (vitesse > 110)
                {
                    label8.Text = Convert.ToString(vitesse);
                    pictureBox9.Hide();
                    label10.Hide();
                    pictureBox10.Show();
                    label11.Show();
                }
                else
                {
                    label8.Text = Convert.ToString(vitesse);
                    pictureBox10.Hide();
                    label11.Hide();
                    pictureBox9.Show();
                    label10.Show();
                }
            }
        }

        private void radioButton4_MouseClick(object sender, MouseEventArgs e)
        {
            vitesse = aleatoire.Next(0, 241);
            if (route == 0)
            {
                if (vitesse > 110)
                {
                    label8.Text = Convert.ToString(vitesse);
                    pictureBox9.Hide();
                    label10.Hide();
                    pictureBox10.Show();
                    label11.Show();
                }
                else
                {
                    label8.Text = Convert.ToString(vitesse);
                    pictureBox10.Hide();
                    label11.Hide();
                    pictureBox9.Show();
                    label10.Show();
                }
            }
            else if (route == 1)
            {
                if (vitesse > 100)
                {
                    label8.Text = Convert.ToString(vitesse);
                    pictureBox9.Hide();
                    label10.Hide();
                    pictureBox10.Show();
                    label11.Show();
                }
                else
                {
                    label8.Text = Convert.ToString(vitesse);
                    pictureBox10.Hide();
                    label11.Hide();
                    pictureBox9.Show();
                    label10.Show();
                }
            }
        }

        private void radioButton5_MouseClick(object sender, MouseEventArgs e)
        {
            vitesse = aleatoire.Next(0, 241);
            if (vitesse > 50)
            {
                label8.Text = Convert.ToString(vitesse);
                pictureBox9.Hide();
                label10.Hide();
                pictureBox10.Show();
                label11.Show();
            }
            else
            {
                label8.Text = Convert.ToString(vitesse);
                pictureBox10.Hide();
                label11.Hide();
                pictureBox9.Show();
                label10.Show();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            route = 0;
            radioButton3_MouseClick(sender, e);
            radioButton4_MouseClick(sender, e);
            radioButton5_MouseClick(sender, e);
        }



    }
}
