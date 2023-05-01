using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mona5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 play = new Form2();  //كده هيخفي الفورم الاولي ويفتح الفورم التانيه//
            play.Show();
            this.Hide(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
