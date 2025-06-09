using SimulacionMonoprocesador;

var cpu = new Monoprocesador();

Console.WriteLine("Simulacion de Monoprocesador (modo no multitarea)\n");
Console.Write("Cuantas tareas deseas agregar manualmente? (0 = usar tareas predeterminadas): ");
int cantidadTareas = int.Parse(Console.ReadLine());

if (cantidadTareas > 0)
{
    for(int i = 1; i <= cantidadTareas; i++)
    {
        Console.Write($"Nombre de la tarea {i}: ");
        string nombre = Console.ReadLine();
        Console.Write($"Duracion de la tarea {i} (en segundos): ");
        int duracion = int.Parse(Console.ReadLine());

        var tarea = new Tarea(nombre, duracion);
        cpu.AgregarTarea(tarea);
    }
    
}
else
{
    // tareas predeterminadas
    var predeterminadas = new List<Tarea>
    {
        new Tarea("Actualizar la mesa de servicios", 5),
        new Tarea("Revisar el correo", 3),
        new Tarea("Realizar copias de seguridad", 10)
    };
    foreach (var tarea in predeterminadas)
    {
        cpu.AgregarTarea(tarea);
    }
    Console.WriteLine("\nPresiona ENTER para comenzar la simulación...");
    Console.ReadLine();

    cpu.EjecutarTodas();

    Console.WriteLine("\nPresiona ENTER para salir.");
    Console.ReadLine();
}