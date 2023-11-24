using System;

// Clase GERENTE
public class Gerente : Empleado, IMostrarInformacion // Hereda de Empleado & IMostrarInformacion
{
    //Atributo de la clase
    public string DepartamentoSupervisado { get; set; }

    // Constructor
    public Gerente(string nombre, double salario, string departamentoSupervisado)
        : base(nombre, salario)
    {
        DepartamentoSupervisado = departamentoSupervisado;
    }

    // Método heredado para mostrar información de IMostrarInformacion
    public void MostrarInformacionGeneral()
    {
        Console.WriteLine($"Nombre: {Nombre}, Salario: {Salario}, Depto. Supervisado: {DepartamentoSupervisado}");
    }
}
