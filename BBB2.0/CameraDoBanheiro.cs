using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBB2._0
{
    class CameraDoBanheiro : Camera
    {
       public CameraDoBanheiro(string nome) : base(nome)
        {

        }

        public override void MostrarCamera(Funcionario funcionario)
        {
            Console.WriteLine("Desculpe, " + funcionario.Nome + " você não tem acesso a essa camera"); 
        }

        public void MostrarCamera(TemAcesso temAcesso)
        {
            Console.WriteLine(temAcesso.Nome + " está acessando a camera " + this.Nome);
        }

    }
}
