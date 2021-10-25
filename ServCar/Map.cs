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
    public partial class Map : Form
    {
        private static string cin;

        public Map(string cinn)
        {
            InitializeComponent();
            Map.cin = cinn;
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_state_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_zip_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string street = txt_street.Text;
            string city = txt_city.Text;
            string state = txt_state.Text;
            string zip = txt_zip.Text;
            StringBuilder queryAddress = new StringBuilder();
            queryAddress.Append("http://google.com/maps?q=");

            if (street != string.Empty)
            {
                queryAddress.Append(street + "," + "+");

            }
            if (state != string.Empty)
            {
                queryAddress.Append(state + "," + "+");

            }
            if (city != string.Empty)
            {
                queryAddress.Append(city + "," + "+");

            }
            if (zip != string.Empty)
            {
                queryAddress.Append(zip + "," + "+");

            }
            webBrowser1.Navigate(queryAddress.ToString());
        }

        private void txt_city_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_street_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Suivi fr = new Suivi(Map.cin);
            fr.Show();
        }

        private void Map_Load(object sender, EventArgs e)
        {

        }
    }
}
