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
        Console.WriteLine("5. Materias");
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

                case "5":


                    bool SubMenuActivo = true;
                    while (SubMenuActivo)
                    {
                         Console.WriteLine("   MENU PLATAFORMA MATERIAS  ");
                         Console.WriteLine("1. Agregar Materias");
                         Console.WriteLine("2. Modificar Nota ");
                         Console.WriteLine("3. Mostrar Materias");
                         Console.WriteLine("4. Eliminar Materia");
                         Console.WriteLine("5. Salir");
                         Console.Write("Seleccione una opción: ");

                         string opcionMaterias = Console.ReadLine() ??"";
                            switch (opcionMaterias)
                        {
                            case "1":
                            Console.WriteLine("Ingrese iD de estudinate a asignar materias");
                            int IdBuscarEstObj = int.Parse(Console.ReadLine() ?? "0");
                            Estudiante? encontrado = Colegio.BuscarEstId(IdBuscarEstObj);
                            if(encontrado == null)
                            {
                            Console.WriteLine("Estudinte No encontrado");
                            }
                            else
                            {
                            encontrado.Materias.AgregarMateria(ServicioMateria.CrearNuevaMateria());
                            Console.WriteLine("Materias Del estudiante");
                            encontrado .Materias.MostrarMaterias();
                            } 
                            break;


                            case "2":
                            Console.WriteLine("Ingrese ID de estudiante");
                            int IdDado = int.Parse(Console.ReadLine() ?? "0");
                            Estudiante? EstEncontrado = Colegio.BuscarEstId(IdDado);
                            if(EstEncontrado == null)
                            {
                            Console.WriteLine("Estudinte No encontrado");
                            }
                            else
                            {
                            Console.WriteLine("Materias Del estudiante");
                            EstEncontrado.Materias.MostrarMaterias();
                            Console.WriteLine("Ingrese nombre exacto de la materia");
                            string NombreMat  = Console.ReadLine() ?? "";
                            Materia? materiaEncontrada = EstEncontrado.Materias.BuscarMateria(NombreMat);
                            Console.WriteLine("Ingrese Nota a modificar");
                            double LaNota = double.Parse((Console.ReadLine())??"0");
                            if(materiaEncontrada == null)
                            {
                            Console.WriteLine("Materia no encontrada");
                            }
                            else
                            {
                            EstEncontrado.Materias.ModificarNotaMateria(materiaEncontrada, LaNota);
                            Console.WriteLine("Nota asignada exitosamente");
                            EstEncontrado .Materias.MostrarMaterias();

                            }
                            } 
                            break;


                            case "3":
                            Console.WriteLine("Ingrese ID de estudiante a ver materias");
                            int IdVerMat = int.Parse(Console.ReadLine()??"0");
                            Estudiante? BusqEst = Colegio.BuscarEstId(IdVerMat);
                            BusqEst?.Materias.MostrarMaterias();
                            break;


                           case "4":
                           Console.WriteLine("Ingrese ID de estudiante a Eliminar materia");
                           int MatElim = int.Parse(Console.ReadLine() ?? "0");
                           Estudiante? EstMatElim = Colegio.BuscarEstId(MatElim);
                           if(EstMatElim == null)
                           {
                           Console.ForegroundColor = ConsoleColor.Red;
                           Console.WriteLine("Estudiante no encontrado");
                           Console.ResetColor();
                           }
                           else
                           {
                           Console.WriteLine("Materias del estudiante:");
                           EstMatElim.Materias.MostrarMaterias();
                           Console.WriteLine("Ingresa el nombre exacto de la materia a ELIMINAR");
                           string NomMatElim = Console.ReadLine() ?? "";
                           Materia? matElim = EstMatElim.Materias.BuscarMateria(NomMatElim);
                           if(matElim == null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Materia no encontrada");
                                Console.ResetColor();
                            }
                            else
                            {
                                EstMatElim.Materias.EliminarMateria(matElim);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Materia eliminada exitosamente");
                                Console.ResetColor();
                            }
                            }
                           break;




                            case "5":
                            SubMenuActivo = false;
                            break;


                            default:
                            Console.WriteLine("Opción inválida");
                            break;



                        }
                    }
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
       

    }
    
}