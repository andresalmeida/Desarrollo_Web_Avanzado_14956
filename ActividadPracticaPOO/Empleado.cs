using System;

// Clase EMPLEADO
public class Empleado : IMostrarInformacion
{
    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    // Atributos de la clase
    public string Nombre { get; set; }
    public double Salario { get; set; }


    // Método para calcular salario anual
    public double CalcularSalarioAnual()
    {
        return Salario * 12; // Calculamos el salario anual
    }

    // Método heredado para mostrar información de IMostrarInformacion
    public void MostrarInformacionGeneral()
    {
        double salarioAnual = CalcularSalarioAnual(); // Acá tenemos el valor del resultado del cálculo de salario
        Console.WriteLine($"Nombre: {Nombre}, Salario Mensual: {Salario}, Salario Anual: {salarioAnual}");
    }

}

