using System;

// Clase Estudiante
public class Estudiante
{
    // Propiedades
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public int Calificacion { get; set; }

    // Constructor
    public Estudiante(string nombre, int edad, int calificacion)
    {
        this.Nombre = nombre;
        this.Edad = edad;
        this.Calificacion = calificacion;
    }

    // Método para mostrar la información del estudiante
    public virtual void MostrarInformacion() // Utilizamos virtual para poder sobreescribir el metodo
    {
        Console.WriteLine("Nombre: {0}", this.Nombre);
        Console.WriteLine("Edad: {0}", this.Edad);
        Console.WriteLine("Calificación: {0}", this.Calificacion);
    }
}

