using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1
{
    public class Produto
    {
        public string Nome { get; set; }

        private double _valor;
        public double Valor
        {
            get
            {
                return _valor;
            }
            set
            {
                if (value > 0)
                    _valor = value;
                else
                    _valor = 0;
            }
        }
        private double _desconto;
        public double Desconto
        {
            get { return _desconto; }
            set
            {
                if (value >= 0 && value <= 100)
                    _desconto = value;
                else
                    _desconto = 0;
            }        
        }
        public double ValorDesconto
        {
            get
            {
                return Valor * (Desconto / 100);
            }
        }

        public Produto(string nome, double valor = 0, double desconto = 20)
        {
            Nome = nome;
            Valor = valor;
            Desconto = desconto;
        }
        public override string ToString()
        {
            return $"{Nome} Valor Normal {Valor} Desconto {Desconto} Promoção {Valor-ValorDesconto}";
        }
    }
}
