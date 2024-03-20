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
            //tabControl1.SelectedIndex = 2;
            tabControl1.SelectedTab = tabPage2;
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

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = "Vous avez appuyé sur le bouton de l'onglet 1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(tabPage3);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TabPage tp1 = new TabPage("Onglet 4");
            tp1.BackColor = Color.Red;
            tabControl1.Controls.Add(tp1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.Controls.Clear();
        }
    }
}
