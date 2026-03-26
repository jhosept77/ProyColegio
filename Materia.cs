using System;

public class Materia
{
    public String Nombre{get; set;}
    public double Nota{get; set;}
    public int Id{get; set;}


    public Materia(string nombre, double nota, int id)
    {
        Nombre = nombre;
        Nota = nota;
        Id = id;
    }

}