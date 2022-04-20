using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBB2._0
{
    
    public abstract class Funcionario
    {
        public string Nome { get; private set; }

        public double Dinheiro { get; private set; }

        public Funcionario(string nome, double dinheiro)
        {
            this.Nome = nome;
            this.Dinheiro = dinheiro;
        }

        abstract public double calcularSalario();
    }
}
