using System;

public class ServicioEstudiante
{
    public static Estudiante CrearEstudiante()
    {
        Console.WriteLine("Ingrese nombre del estudiante");
        string nombre = Console.ReadLine()!;

        if (String.IsNullOrWhiteSpace(nombre))
        {
            Console.WriteLine("El nombre no puede estar vacio");
        }

        Console.WriteLine("Ingrese apellido del estudiante");
        string apellido = Console.ReadLine()!;

        if (String.IsNullOrWhiteSpace(apellido))
        {
            Console.WriteLine("El apellido no puede estar vacio");
        }

        Console.WriteLine("Ingrese direccion del estudiante");
        string direccion = Console.ReadLine() ??"";

        Console.WriteLine("Ingrese Celular del estudiante");
        long celular = long.Parse(Console.ReadLine() ??"");

        Console.WriteLine("Ingrese Correo del estudiante");
        string correo = Console.ReadLine() ??"";

        return new Estudiante(nombre,apellido,direccion,celular,correo,0);
    }



}