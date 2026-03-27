using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Estudiante
{
    public string Nombre{get; set;}
    public String Apellido{get; set;}
    public ListasEnlazadasMateria Materias{get; set;}

    public String Direccion{get; set;}
    public long Celular{get; set;}
    public String Correo{get; set;}
    public int Id{get; set;}


    public Estudiante(string nombre, string apellido, string direccion, long celular, string correo, int id)
    {   
        Nombre = nombre;
        Apellido = apellido;
        Materias = new ListasEnlazadasMateria();
        Direccion = direccion; 
        Celular = celular;     
        Correo = correo;       
        Id = id;
    }


}


public class ServicioEstudiante
{
    private static int ContadorId = 1;
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
        long celular = long.Parse(Console.ReadLine() ??"0");

        Console.WriteLine("Ingrese Correo del estudiante");
        string correo = Console.ReadLine() ??"";
        
       Estudiante est = new Estudiante(nombre, apellido, direccion, celular, correo, ContadorId);
       ContadorId++;
       return est;
    }



}


