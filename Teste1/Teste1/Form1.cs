using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Cliente> lst = new List<Cliente>();
            lst.Add(new Cliente() { Nome = "José", Idade = 10 });
            lst.Add(new Cliente() { Nome = "Maria", Idade = 90 });
            lst.Add(new Cliente() { Nome = "Josue", Idade = 180 });
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(lst.ToArray());

            BindingSource src = new BindingSource();
            lst.ForEach(i => src.Add(i));
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName ="Nome", Name = "Nome", Width = 500 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Idade", Name = "Idade", Width = 80 });
            dataGridView1.DataSource = src;

            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Cliente c = (Cliente)comboBox1.SelectedItem;
            MessageBox.Show(c.Nome);
        }
    }
}
