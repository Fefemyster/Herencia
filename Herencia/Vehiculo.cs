using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Vehiculo //Clase Base 
    {
        public string Marca { get; set; }   
        public string Modelo { get; set; }
        public int Año { get; set; }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("****Datos del Vehiculo****");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Año}");
            
        }

    }
}
