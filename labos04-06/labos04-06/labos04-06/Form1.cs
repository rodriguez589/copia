using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labos04_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGualterpistola_Click(object sender, EventArgs e)
        {
            using (frmphoto foto = new frmphoto())
            {
                DialogResult respuesta = foto.ShowDialog(); 
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {        
            lblblock.BackColor = Color.Aqua;
                
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblblock.BackColor = Color.Aquamarine;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblblock.BackColor = Color.Azure;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblblock.BackColor = Color.Beige;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            lblblock.BackColor = Color.Bisque;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblblock.BackColor = Color.Black;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblblock.BackColor = Color.Blue;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblblock.BackColor = Color.Brown;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblblock.BackColor = Color.Chartreuse;
        }

        private void btn111_Click(object sender, EventArgs e)
        {
            lblblock.BackColor = Color.Chocolate;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            lblblock.BackColor = Color.Coral;
        }

        private void btn222_Click(object sender, EventArgs e)
        {
            lblblock.BackColor = Color.Cornsilk;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "A");
            MessageBox.Show(text: "E");
            MessageBox.Show(text: "I");
            MessageBox.Show(text: "O");
            MessageBox.Show(text: "U");
        }

        private void btnOla_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Indigo;
            MessageBox.Show(text: "Ola");
            MessageBox.Show(text: "K");
            MessageBox.Show(text: "ase");
        }
    }
}