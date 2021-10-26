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
    public partial class Form_Szoveg : Form
    {
        public Form_Szoveg()
        {
            InitializeComponent();
        }

        private void button1_Switch_Click(object sender, EventArgs e)
        {
            Form_Matrix myNewForm = new Form_Matrix();
            myNewForm.Show();
            this.Hide();
        }

        private void button1_Szamol_Click(object sender, EventArgs e)
        {
            int ekezetek = 0;
            string szoveg = richTextBox1.Text;
            if (richTextBox1.Text != string.Empty)
            {
                for (int i = 0; i < szoveg.Length; i++)
                {
                    if (szoveg[i] == 'ö' || szoveg[i] == 'Ö' || szoveg[i] == 'ü' || szoveg[i] == 'Ü' || szoveg[i] == 'ó' || szoveg[i] == 'Ó' || szoveg[i] == 'ő' || szoveg[i] == 'Ő' || szoveg[i] == 'ú' || szoveg[i] == 'Ú' || szoveg[i] == 'é' || szoveg[i] == 'É' || szoveg[i] == 'á' || szoveg[i] == 'Á' || szoveg[i] == 'ű' || szoveg[i] == 'Ű' || szoveg[i] == 'í' || szoveg[i] == 'Í')
                    {
                        ekezetek++;
                    }
                }
                lbl_Ekezetek.Text = "A szövegben " + ekezetek + " ékezetes karakter található.";
            }
            else
            {
                MessageBox.Show("Írj be valamilyen szöveget.");
            }
        }
    }
}
