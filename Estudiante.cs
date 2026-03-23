using System;
using System.Dynamic;
using System.Text;

public class Estudiante
{
    public string Nombre{get; set;}
    public String Apellido{get; set;}

    public String Direccion{get; set;}
    public long Celular{get; set;}
    public String Correo{get; set;}
    public int Id{get; set;}


    public Estudiante(string nombre, string apellido, string direccion, long celular, string correo, int id)
    {   
        Nombre = nombre;
        Apellido = apellido;
        Direccion = direccion; 
        Celular = celular;     
        Correo = correo;       
        Id = id;
    }


}


