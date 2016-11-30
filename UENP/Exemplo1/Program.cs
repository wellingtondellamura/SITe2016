using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1
{
    class Program
    { 

        static void Main(string[] args)
        {
            //ListaProduto lista = new ListaProduto();
            //lista.Adicionar(new Produto("iPhone", 1500, 3));
            //lista.Adicionar(new Produto("XBox One", 1500, 10));
            //lista.Adicionar(new Produto("PlayStation 4", 1999, 5));
            //lista.Adicionar(new Produto("iPad", 3500, 50));
            //lista.Adicionar(new Produto("Pipa", 10, 1));
            //lista.Adicionar(new Produto("Paçoca", 5, 0));
            //lista.Salvar();

            ListaProduto lista2 = new ListaProduto();
            lista2.Abrir();
            lista2.Produtos.ForEach(p => Console.WriteLine(p));

            Console.ReadKey();
        }
    }
}
