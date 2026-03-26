public class Programa
{
    public static void Main()
    {

       ListasEnlazadas Colegio = new ListasEnlazadas();
       bool Continuar = true;

       while (Continuar)
       {
        Console.WriteLine("   MENU PLATAFORMA  ");
        Console.WriteLine("1. Agregar estudiante");
        Console.WriteLine("2. Mostrar Todos los estudiantes");
        Console.WriteLine("3. Buscar Estudinate por ID");
        Console.WriteLine("4. Eliminar estudiante");
        Console.WriteLine("5. Agregar materias a estudinate");
        Console.WriteLine("6. Salir");
        Console.Write("Seleccione una opción: ");

        String opcion = Console.ReadLine() ??"";
            switch (opcion)
            {
                case "1":
                Estudiante nuevo = ServicioEstudiante.CrearEstudiante();
                

                Colegio.Agregar(nuevo);
                Console.WriteLine("Estudinate guardado con exito");
                break;

                case "2":
                Colegio.MostrarLista();
                break;

                case "3":
                Console.WriteLine("Ingrese ID a buscar");
                int IdaBuscar = int.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine($"El estudiante {IdaBuscar} es:");
                Colegio.BuscarPorId(IdaBuscar);
                break;
                
                case "4":
                Console.WriteLine("Ingrese ID de alumno a eliminar");
                int IdEliminar = int.Parse(Console.ReadLine() ?? "0");
                Colegio.EliminarAlumno(IdEliminar);
                Console.WriteLine($"----- Estudiante con Id {IdEliminar} eliminado correctamente ---- ");
                break;

                case "6":
                Continuar = false;
                Console.WriteLine("Saliendo del programa");
                break;

                default:
                Console.WriteLine("Valor invalido");
                break;

            }
       }


       ListasEnlazadasMateria Rama = new ListasEnlazadasMateria();
       bool Continuar = true;

    
    }
}