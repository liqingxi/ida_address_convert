using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ida_address_convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string []a = input.Text.Split('\n');
            string pattern = @"\b([0-9a-fA-F]+)\b";
            output.Text = "";
            foreach (string s in a)
            {
                MatchCollection t = Regex.Matches(s, pattern);
                if(t.Count > 0)
                    output.Text += string.Format("tb *0x{0}+0x{1}\r\n", address.Text, t[0].Value);
            }
            
            
        }
    }
}
