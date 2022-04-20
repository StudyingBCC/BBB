using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBB2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Diretor boninho = new Diretor("boninho", 2000);
            Apresentador tadeu = new Apresentador("tadeu", 1000);
            Camera camera = new Camera("Camera Sala de Estar");
            CameraDoBanheiro cameraDoBanheiro = new CameraDoBanheiro("Camera do Banheiro");
            boninho.calcularSalario();
            tadeu.calcularSalario();
            camera.MostrarCamera(tadeu);
            cameraDoBanheiro.MostrarCamera(tadeu);
            cameraDoBanheiro.MostrarCamera(boninho);
            camera.MostrarCamera(boninho);

        }
    }
}
