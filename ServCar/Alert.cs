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
using System.Net;
using System.Net.Mail;


namespace ServCar
{
    public partial class Alert : Form
    {
        public Alert(string login)
        {
            InitializeComponent();
            Alert.cin = login;
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;");
        private static string cin;
        private static string nom;
        private static string prenom;
        private static string tel;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into alerte values('" + Alert.cin + "','" + (sender as Button).Text + "')", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MailAddress mailTo = new MailAddress("benkaddourassma@gmail.com");
            MailAddress mailFrom = new MailAddress("sarah.elkf@gmail.com");
            MailMessage msg = new MailMessage(mailFrom, mailTo);
            msg.Subject = "Urgence : Service Wagen";
            msg.Body = Alert.cin + (sender as Button).Text;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            System.Net.NetworkCredential nc = new NetworkCredential("sarah.elkf@gmail.com", "ServiceWagen");
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(msg);
            MessageBox.Show("Message envoyé à l'Admin avec Succès !");
            if (i != 0)
            {
                this.Hide();
            }
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
            sqlcon1.Open();
            SqlCommand cmd1 = new SqlCommand("select * from [User] where profil = '" + 1 + "' and cin = '" + Alert.cin + "'", sqlcon1);
            SqlDataReader row1 = cmd1.ExecuteReader();
            if (row1.Read())
            {
                Alert.nom = row1["nom"].ToString();
                Alert.prenom = row1["prenom"].ToString();
                Alert.tel = row1["telephone"].ToString();
            }
            sqlcon1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into alerte values('" + Alert.cin + "','" + (sender as Button).Text + "')", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MailAddress mailTo = new MailAddress("benkaddourassma@gmail.com");
            MailAddress mailFrom = new MailAddress("sarah.elkf@gmail.com");
            MailMessage msg = new MailMessage(mailFrom, mailTo);
            msg.Subject = "Urgence : Service Wagen";
            msg.Body = Alert.cin + " " + Alert.nom + " " + Alert.prenom + " " + Alert.tel + " " + (sender as Button).Text;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            System.Net.NetworkCredential nc = new NetworkCredential("sarah.elkf@gmail.com", "ServiceWagen");
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(msg);
            MessageBox.Show("Message envoyé à l'Admin avec Succès !");
            if (i != 0)
            {
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into alerte values('" + Alert.cin + "','" + (sender as Button).Text + "')", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MailAddress mailTo = new MailAddress("benkaddourassma@gmail.com");
            MailAddress mailFrom = new MailAddress("sarah.elkf@gmail.com");
            MailMessage msg = new MailMessage(mailFrom, mailTo);
            msg.Subject = "Urgence : Service Wagen";
            msg.Body = Alert.cin + " " + Alert.nom + " " + Alert.prenom + " " + Alert.tel + " " + (sender as Button).Text;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            System.Net.NetworkCredential nc = new NetworkCredential("sarah.elkf@gmail.com", "ServiceWagen");
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(msg);
            MessageBox.Show("Message envoyé à l'Admin avec Succès !");
            if (i != 0)
            {
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into alerte values('" + Alert.cin + "','" + (sender as Button).Text + "')", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MailAddress mailTo = new MailAddress("benkaddourassma@gmail.com");
            MailAddress mailFrom = new MailAddress("sarah.elkf@gmail.com");
            MailMessage msg = new MailMessage(mailFrom, mailTo);
            msg.Subject = "Urgence : Service Wagen";
            msg.Body = Alert.cin + " " + Alert.nom + " " + Alert.prenom + " " + Alert.tel + " " + (sender as Button).Text;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            System.Net.NetworkCredential nc = new NetworkCredential("sarah.elkf@gmail.com", "ServiceWagen");
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(msg);
            MessageBox.Show("Message envoyé à l'Admin avec Succès !");
            if (i != 0)
            {
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into alerte values('" + Alert.cin + "','" + (sender as Button).Text + "')", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MailAddress mailTo = new MailAddress("benkaddourassma@gmail.com");
            MailAddress mailFrom = new MailAddress("sarah.elkf@gmail.com");
            MailMessage msg = new MailMessage(mailFrom, mailTo);
            msg.Subject = "Urgence : Service Wagen";
            msg.Body = Alert.cin + " " + Alert.nom + " " + Alert.prenom + " " + Alert.tel + " " + (sender as Button).Text;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            System.Net.NetworkCredential nc = new NetworkCredential("sarah.elkf@gmail.com", "ServiceWagen");
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(msg);
            MessageBox.Show("Message envoyé à l'Admin avec Succès !");
            if (i != 0)
            {
                this.Hide();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
