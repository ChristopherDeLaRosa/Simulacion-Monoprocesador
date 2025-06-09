using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionMonoprocesador
{
    public class Monoprocesador
    {
        private readonly Queue<Tarea> cola_tareas = new Queue<Tarea>();

        public void AgregarTarea(Tarea tarea)
        {
            cola_tareas.Enqueue(tarea);
            Console.WriteLine($"Tarea agregada a la cola: {tarea.Nombre}");
        }

        public void EjecutarTodas()
        {
            Console.WriteLine("\n *** Inicio de ejecucion de la cola de tareas *** \n ");
            while(cola_tareas.Count > 0)
            {
                var tarea = cola_tareas.Dequeue();
                tarea.Ejecutar();
            }

            Console.WriteLine("\n *** Fin de ejecucion de la cola de tareas *** \n ");
        }

    }
}
