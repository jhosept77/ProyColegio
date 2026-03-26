using System;
using Microsoft.VisualBasic;

public class Nodo
{
    public Estudiante Dato;
    public Nodo? NoSiguiente;


    public Nodo(Estudiante dato)
    {
        Dato = dato;
        NoSiguiente = null;
    }
}




public class NodoMateria
{
    public Materia Dato;
    public NodoMateria? NodoSigiente;


    public NodoMateria(Materia dato)
    {
        Dato = dato;
        NodoSigiente = null;
    }
}