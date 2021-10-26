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

        }
    }
}
