using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Carro : Vehiculo
    {
        public int NumeroPuertas { get; set; }
        public string TipoCombustible { get; set; }


        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Numero de Puertas: {NumeroPuertas}");
            Console.WriteLine($"Tipo de Combustible: {TipoCombustible}");
            Console.WriteLine();
        }

    }
}
