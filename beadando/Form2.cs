using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando
{
    public partial class Form_Matrix : Form
    {
        public Form_Matrix()
        {
            InitializeComponent();
        }

        private void button1_Switch_Click(object sender, EventArgs e)
        {
            Form_Szoveg myNewForm = new Form_Szoveg();
            myNewForm.Show();
            this.Hide();
        }

        private void button2_Szamol_Click(object sender, EventArgs e)
        {
            lbl_Oszlop1.Text = "";
            lbl_Oszlop2.Text = "";
            lbl_Oszlop3.Text = "";
            lbl_Oszlop4.Text = "";
            Random rnd = new Random();
            int oszlopszam = Decimal.ToInt32(numericUpDown_oszlopok.Value);
            int i = 1;
            while (i <= oszlopszam)
            {
                // kétszámjegyű számokat írtattam ki, hogy jól nézzen ki a mátrix
                lbl_Oszlop1.Text += $" {rnd.Next(10 , 100)}";
                lbl_Oszlop2.Text += $" {rnd.Next(10 , 100)}";
                lbl_Oszlop3.Text += $" {rnd.Next(10 , 100)}";
                lbl_Oszlop4.Text += $" {rnd.Next(10 , 100)}";
                i++;
            }
        }
    }
}
