using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformKrushi2
{
    public partial class ContactInfo : Form
    {
        public ContactInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomeScr wc = new WelcomeScr();
            wc.mycustomer(textBox1.Text, int.Parse(textBox2.Text));
            wc.Show();
            this.Close();
        }
    }
}
