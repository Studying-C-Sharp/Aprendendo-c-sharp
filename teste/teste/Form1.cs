using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Fm_teste : Form
    {
        public Fm_teste()
        {
            InitializeComponent();
        }

        private void bt_teste_Click(object sender, EventArgs e)
        {
            txt_teste.Text="Se fudeu mesmo";
            MessageBox.Show("se fudeu mesmo;");

            
        }

        private void Fm_teste_Activated(object sender, EventArgs e)
        {
            txt_teste.Text = "sera que deu";
        }
    }
}
