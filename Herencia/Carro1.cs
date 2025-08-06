using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Carro1 : Vehiculo
    {
        public int NumeroPuertas { get; set; }
        public string Nombre { get; set; }


        public override void MostrarInformacion()
        {
            Console.WriteLine("****Datos del Vehiculo****");
            Console.WriteLine($"Numero de Puertas: {NumeroPuertas}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine();
        }

    }
}
