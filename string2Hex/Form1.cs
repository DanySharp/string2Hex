using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace string2Hex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = tohex(textBox1.Text);
        }
        public string tohex(string inp)
        {

            string uptp = string.Empty;
            char[] Value = inp.ToCharArray();
            foreach(char L in Value)
            {
                int v = Convert.ToInt32(L);
                uptp += string.Format("{0:x}", v);

            }
            return uptp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }
    }
}
