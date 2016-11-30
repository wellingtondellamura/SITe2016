using Exemplo1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class FrmPrincipal : Form
    {
        private ListaProduto lista = new ListaProduto();
        private Produto selecionado;

        public FrmPrincipal()
        {
            InitializeComponent();
            lista.Abrir();
            carregar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string valor = txtValor.Text;
            string desconto = txtDesconto.Text;
            if (selecionado == null)
            {
                Produto p = new Produto(nome, double.Parse(valor), double.Parse(desconto));
                lista.Adicionar(p);
                MessageBox.Show("Produto Adicionado");
            }
            else
            {
                selecionado.Nome = nome;
                selecionado.Valor = double.Parse(valor);
                selecionado.Desconto = double.Parse(desconto);
                selecionado = null;
                MessageBox.Show("Produto Alterado");
            }
            txtNome.Clear();
            txtValor.Clear();
            txtDesconto.Clear();
            
            carregar();
        }

        public void carregar()
        {
            lstProdutos.Items.Clear();
            lista.Produtos.ForEach(p => lstProdutos.Items.Add(p));
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (lista.Salvar())
            {
                MessageBox.Show("Dados gravados com sucesso");
            }else
            {
                MessageBox.Show("Erro ao gravar dados");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Produto p = (Produto) lstProdutos.SelectedItem;
            if (p == null)
            {
                return;
            }
            var resp = MessageBox.Show($"Deseja realmente remover o produto {p.Nome}?", "Remover",
                MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes)
            {
                lista.Remover(p);
                carregar();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Produto p = (Produto)lstProdutos.SelectedItem;
            if (p == null)
            {
                return;
            }
            txtNome.Text = p.Nome;
            txtValor.Text = p.Valor.ToString();
            txtDesconto.Text = p.Desconto.ToString();
            selecionado = p;
        }
    }
}
