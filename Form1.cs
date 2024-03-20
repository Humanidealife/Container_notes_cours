using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Container_notes_cours
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn1 = new Button();
            btn1.Text = "Bouton test";
            btn1.Width = 100;
            btn1.Height = 100;
            btn1.BackColor = Color.Green;
            flowLayoutPanel1.Controls.Add(btn1);

        }
    }
}
