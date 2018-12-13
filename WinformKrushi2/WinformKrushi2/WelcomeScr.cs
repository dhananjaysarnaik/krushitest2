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
    public partial class WelcomeScr : Form
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public WelcomeScr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WelcomeScr_Load(object sender, EventArgs e)
        {

        }
        public void mycustomer(string _name, int _number)
        {
            Name = _name;
            Number = _number;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Welcome " + Name + " and your number is " + Number;
        }
    }
}
