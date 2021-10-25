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
    public partial class Suivi : Form
    {
        private static string cin;
        System.Timers.Timer t;
        int h, m, s;
        private static string mat;
        private static string nom;

        public Suivi(string login)
        {
            InitializeComponent();
            Suivi.cin = login;
           
        }

        private void Suivi_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            label1.Text = Suivi.cin;
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            sqlcon.Open();
            string cin = Suivi.cin;
            SqlCommand cmd = new SqlCommand("select * from [User] where cin = '" + cin + "'", sqlcon);
            SqlDataReader row = cmd.ExecuteReader();
            if (row.Read())
            {
                label2.Text = "Permis " + row["permis"].ToString();
                
                string nom = row["nom"].ToString();
                Suivi.nom = nom;
                if (File.Exists(@"|DataDirectory|\Image\" + Suivi.cin + "ù.png"))
                {
                    Image pdp = Image.FromFile(@"|DataDirectory|\Image\" + cin + "ù.png");
                    this.pictureBox3.Image = pdp;
                }
                sqlcon.Close();
                sqlcon.Open();
                SqlCommand cmd1 = new SqlCommand("select * from [Mission] where conducteur = '" + nom + "'", sqlcon);
                SqlDataReader row1 = cmd1.ExecuteReader();
                if (row1.Read())
                {
                    textBox1.Text = row1["depart"].ToString();
                    textBox2.Text = row1["destination"].ToString();
                    textBox3.Text = row1["dateDepart"].ToString();
                    textBox4.Text = row1["dateArrive"].ToString();
                    textBox5.Text = row1["description"].ToString();
                    Suivi.mat = row1["vehicule"].ToString();
                }
                else
                {
                    MessageBox.Show("Vous n'avez aucune Mission !");
                }
            }
            
            
            sqlcon.Close();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Suivi formThis = this;
            Vitesse loginForm = new Vitesse(Suivi.cin);
            loginForm.Show();
            formThis.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            if(checkBox7.Checked)
            { label11.Text = "10/60"; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void compteur_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rst_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            int c6 = 0;
            if (checkBox6.Checked)
                c6 = 5;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int c5 = 0;
            if (checkBox5.Checked)
                c5 = 5;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int c4 = 0;
            if (checkBox4.Checked)
                c4 = 10;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int c2 = 0;
            if (checkBox2.Checked)
                c2 = 10;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int c1 = 0;
            if (checkBox1.Checked)
                c1 = 10;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            sqlcon.Open();
            SqlCommand query4 = new SqlCommand("update [Vehicule] set disponible = '" + 1 + "' where matricule = '" + Suivi.mat + "'", sqlcon);
            query4.ExecuteNonQuery();
            sqlcon.Close();
            sqlcon.Open();
            
            SqlCommand query2 = new SqlCommand("delete from [Mission] where conducteur = '" + Suivi.nom + "'", sqlcon);
            query2.ExecuteNonQuery();
            sqlcon.Close();
            sqlcon.Open();
            SqlCommand query3 = new SqlCommand("update [User] set disponible = '" + 1 + "' where cin = '" + Suivi.cin + "'", sqlcon);
            query3.ExecuteNonQuery();
            sqlcon.Close();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Alert a = new Alert(Suivi.cin);
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Map f = new Map(Suivi.cin);
            f.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            t.Stop();
            if ((m + s + h) > 900 && (m + s + h) < 2700)
            {
                MessageBox.Show("Vous avez dépassé la limite du repos");
                rst.Text = "00:00:00";

            }
            else
            {
                MessageBox.Show("Bonne Reprise");
                rst.Text = "00:00:00";

            }
            if ((m + s + h) > 2700)
            {
                MessageBox.Show("Vous n'avez plus le droit d'un autre repos");
                rst.Text = "00:00:00";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            /*skinManager = MaterialSkinManager.Instance;
            //inManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey600, Primary.Grey600, Accent.LightBlue200, TextShade.WHITE);
            */

            if ((checkBox1.Checked) && (checkBox2.Checked) && (checkBox7.Checked))
                MessageBox.Show("Vous  pouvez  démarrer votre mission");

            else
                MessageBox.Show("Vous ne pouvez pas démarrer votre mission!!");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Suivi formThis = this;
            Login loginForm = new Login();
            loginForm.Show();
            formThis.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void affecter_Click(object sender, EventArgs e)
        {
            
            Alert loginForm = new Alert(Suivi.cin);
            loginForm.Show();
            
        }

        private void driverImage_Click(object sender, EventArgs e)
        {

        }

        private void drivers_Click(object sender, EventArgs e)
        {
            Suivi formThis = this;
            Map loginForm = new Map(Suivi.cin);
            loginForm.Show();
            formThis.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void cars_Click(object sender, EventArgs e)
        {

        }
        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 0)
                {
                    s = 0;
                    m += 1;
                }

                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                rst.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));

            }));

        }
    }
}
