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
    }
}
