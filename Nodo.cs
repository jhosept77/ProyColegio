using System;
using Microsoft.VisualBasic;

public class Nodo
{
    public Estudiante Dato;
    public Nodo NoSiguiente;


    public Nodo(Estudiante dato)
    {
        Dato = dato;
        NoSiguiente = null;
    }
}


public class ListasEnlazadas
{
    public Nodo Cabeza;

    public void Agregar(Estudiante alumno)
    {
        Nodo nuevoNodo = new Nodo(alumno);

        if(Cabeza == null)
        {
            Cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = Cabeza;
            while(actual.NoSiguiente != null)
            {
                actual = actual.NoSiguiente;
            }
            
            actual.NoSiguiente = nuevoNodo;
        }
    }

    public void MostrarLista()
    {
        Nodo actual = Cabeza;
        
        if(actual == null)
        {
            Console.WriteLine("No hay estudinates guardados");
            return;
        }
        
        while(actual != null)
        {
            Console.WriteLine($"Nombre: {actual.Dato.Nombre} | Apellido: {actual.Dato.Apellido} | Direccion: {actual.Dato.Direccion} | Celular: {actual.Dato.Celular} | Correo: {actual.Dato.Correo} | Id: {actual.Dato.Id}");
            actual = actual.NoSiguiente;

        }

        Console.WriteLine("-------------------------------------");
    }


    public void BuscarPorId(int IdBuscado)
    {
        Nodo actual = Cabeza;
        
            while (actual != null)
            {
                  if(actual.Dato.Id == IdBuscado)
                        {
                            Console.WriteLine($"Nombre: {actual.Dato.Nombre} | Apellido: {actual.Dato.Apellido} | Direccion: {actual.Dato.Direccion} | Celular: {actual.Dato.Celular} | Correo: {actual.Dato.Correo}");  
                        }
                 
                        
  actual = actual.NoSiguiente;             
            }
        
    }
    
}