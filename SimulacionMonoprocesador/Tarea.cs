using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionMonoprocesador
{
    public class Tarea
    {
        public string Nombre { get;}
        public int Duracion { get;}

        public Tarea(string nombre, int duracion)
        {
            Nombre = nombre;
            Duracion = duracion;
        }

        public void Ejecutar() 
        {
            Console.WriteLine($"{DateTime.Now:HH:mm:ss} - Iniciando una tarea: {Nombre} . \n - Duracion: {Duracion}");
            Thread.Sleep(Duracion * 1000);
            Console.WriteLine($"{DateTime.Now:HH:mm:ss} - Tarea finalizada: {Nombre} . \n");
        }

    }
}
