using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        double salarioAnual = CalcularSalarioAnual(); // Acá tenemos el valor del resultado del cálculo de salario
        Console.WriteLine($"Nombre: {Nombre}, Salario Mensual: {Salario}, Salario Anual: {salarioAnual}, Departamento Supervisado: {DepartamentoSupervisado}");
    }
}
