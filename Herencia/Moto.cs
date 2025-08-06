using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }
        public bool TieneMaletero { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Cilindrada: {Cilindrada} CC");
            Console.WriteLine($"¿Tiene maletero?");
           
            if (TieneMaletero)
            {
                Console.WriteLine("Si");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine();


        }


    }
}