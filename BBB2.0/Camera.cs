using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBB2._0
{
    public class Camera 
    {
        public string Nome { get; private set; }

        public Camera(string nome)
        {
            this.Nome = nome;
        }


        public virtual void MostrarCamera(Funcionario funcionario)
        {
            Console.WriteLine(funcionario.Nome + " está acessando a camera " + this.Nome); 
        }

    }
}
