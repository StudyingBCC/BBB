using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBB2._0
{
    public class Diretor : TemAcesso
    {
        public Diretor(string nome, double dinheiro) : base(nome, dinheiro)
        {

        }

        public override double calcularSalario()
        {
            double valor = this.Dinheiro * 1.55;
            Console.WriteLine(this.Nome + ",  seu salário era de "+ this.Dinheiro + ", agora o seu salário com bonus é de " + valor);
            return valor;
        }
    }
}
