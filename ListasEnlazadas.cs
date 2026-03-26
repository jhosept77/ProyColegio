using System;
using System.Security.Cryptography.X509Certificates;

public class ListasEnlazadas
{
    public Nodo? Cabeza;
    public int ContadorId = 1;


    public void Agregar(Estudiante alumno)
    {
        alumno.Id = ContadorId;
        ContadorId++;

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
        Nodo? actual = Cabeza;
        
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
        Nodo? actual = Cabeza;
        
            while (actual != null)
            {
                  if(actual.Dato.Id == IdBuscado)
                        {
                            Console.WriteLine($"Nombre: {actual.Dato.Nombre} | Apellido: {actual.Dato.Apellido} | Direccion: {actual.Dato.Direccion} | Celular: {actual.Dato.Celular} | Correo: {actual.Dato.Correo}");  
                        }
                 
                        
  actual = actual.NoSiguiente;             
            }
        
    }

    public void EliminarAlumno(int IdAlumno)
    {
        if(Cabeza == null)return;

        if(Cabeza.Dato.Id == IdAlumno)
        {
            Cabeza = Cabeza.NoSiguiente;
            return;
        }

        Nodo actual = Cabeza;

        while(actual.NoSiguiente != null)
        {
            if(actual.NoSiguiente.Dato.Id == IdAlumno)
            {
                actual.NoSiguiente = actual.NoSiguiente.NoSiguiente;
                return;
            }
            actual = actual.NoSiguiente;
        }
    }
    
}


public class ListasEnlazadasMateria
{
    public NodoMateria? Cabeza;
    

    public ListasEnlazadasMateria()
    {
        Cabeza = null;
    }


    public void AgregarMateria(Materia asignatura)
    {
        NodoMateria NuevoNodoMateria = new NodoMateria(asignatura); 

        NuevoNodoMateria.NodoSigiente = Cabeza;
        Cabeza = NuevoNodoMateria;
    }


    public void ModificarNotaMateria(Materia asignatura, int nuevaNota)
    {
        NodoMateria? actual = Cabeza;
        while( actual != null)
        {
            if(actual.Dato.Id == asignatura.Id)
            {
                actual.Dato.Nota = nuevaNota;
                break;
            }
            actual = actual.NodoSigiente;
        }

        
    }

}




