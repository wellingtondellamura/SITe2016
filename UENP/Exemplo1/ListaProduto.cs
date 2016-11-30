using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1
{
    public class ListaProduto
    {
        private List<Produto> produtos;
        public List<Produto> Produtos
        {
            get { return produtos; }
        }

        public ListaProduto()
        {
            produtos = new List<Produto>();
        }

        public void Adicionar(Produto p)
        {
            produtos.Add(p);
        }

        public void Remover(Produto p)
        {
            produtos.Remove(p);
        }

        public bool Salvar()
        {
            List<String> lst = new List<string>();
            produtos.ForEach(p =>
            {
                lst.Add($"{p.Nome};{p.Valor};{p.Desconto}");
            });
            try
            {
                File.WriteAllLines("dados.txt", lst);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
           
        }

        public void Abrir()
        {
            produtos.Clear();
            string[] lst = File.ReadAllLines("dados.txt");
            foreach (string s in lst)
            {
                string[] campos = s.Split(';');
                produtos.Add(new Produto(campos[0], double.Parse(campos[1]), double.Parse(campos[2])));
            }
            
        }
    }
}
