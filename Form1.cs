using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maps_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string street = txt_street.Text;
            string City = txt_City.Text;
            string state = txt_state.Text;
            string zip = txt_zip.Text;
            StringBuilder queryaddress = new StringBuilder();
            queryaddress.Append("http://google.com/maps?q=");

                if(street != string.Empty )
            {
                queryaddress.Append(street + "," + "+");
            }
            if (City  != string.Empty)
            {
                queryaddress.Append(City  + "," + "+");
            }
            if (state  != string.Empty)
            {
                queryaddress.Append( state  + "," + "+");
            }
            if (zip  != string.Empty)
            {
                queryaddress.Append(zip  + "," + "+");
            }
            webBrowser1.Navigate(queryaddress.ToString());














        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
