using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1
{
    public class Cliente
    {        

        public string Nome { get; set; }

        private int _idade;
        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value > 0 && value < 150)
                    _idade = value;
                else
                    _idade = 0;
            }
        }

        public override string ToString()
        {
            return $"{Nome} : {Idade}";
        }

    }
}
