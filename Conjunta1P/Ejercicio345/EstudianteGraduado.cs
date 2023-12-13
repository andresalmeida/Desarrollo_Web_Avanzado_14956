using System;

// Clase EstudianteGraduado que hereda de Estudiante
public class EstudianteGraduado : Estudiante
{
    // Propiedades
    public string Titulo { get; set; }

    // Constructor
    public EstudianteGraduado(string nombre, int edad, int calificacion, string titulo)
        : base(nombre, edad, calificacion)
    {
        this.Titulo = titulo;
    }

    // Anular el método MostrarInformacion para incluir el título
    public override void MostrarInformacion() // Sobreescribimos el metodo base para añadir informacion sobre el titulo
    {
        base.MostrarInformacion(); // Llamada al método de la clase base

        // Mostrar el título del estudiante graduado
        Console.WriteLine("Título obtenido: {0}", this.Titulo);
    }
}
