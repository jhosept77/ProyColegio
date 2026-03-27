using System;

public class Materia
{
    public String Nombre{get; set;}
    public double Nota{get; set;}
    public int Id{get; set;}


    public Materia(string nombre, int id)
    {
        Nombre = nombre;
        Nota = 0;
        Id = id;
    }


}



public class ServicioMateria
{

    private static int ContadorId = 1;
        public static Materia CrearNuevaMateria()
    {
        Console.WriteLine("Ingrese Nombre de materia a resgistrar");
        string Nombre = Console.ReadLine() ?? "";


        Materia materia= new Materia(Nombre, ContadorId);
        ContadorId++;
        return materia;

    }
}