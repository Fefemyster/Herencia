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

            if (TieneMaletero = true)
            {
                Console.WriteLine("La moto tiene maletero");
            }
            else {
                Console.WriteLine("No tiene Maletero");
            }
            

            
        }


    }
}
