using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string trat = cboTratamento.SelectedItem.ToString();
            MessageBox.Show($"Olá {trat} {nome}");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show($"oi");
        }
    }
}
