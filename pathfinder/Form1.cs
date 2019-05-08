using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pathfinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelclick(object sender, MouseEventArgs e)
        {
            Find.Start(e.Button, (Label)sender);   
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Find.prepare(panel1.Controls, labelclick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Find.clear(panel1.Controls);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Find.go();
        }
    }
}
