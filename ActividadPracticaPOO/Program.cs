using System;
using System.Collections.Generic; //Se usa para crear y gestionar colecciones de objetos

// PROGRAMA PRINCIPAL
class Program
{
    static void Main()
    {
        List<Empleado> empleados = new List<Empleado>();
        List<Gerente> gerentes = new List<Gerente>();

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Ingrese el tipo de empleado ('empleado' o 'gerente'):");
            string tipoEmpleado = Console.ReadLine();

            if (tipoEmpleado.ToLower() == "empleado")
            {
                Console.WriteLine("Ingrese el nombre del empleado:");
                string nombreEmpleado = Console.ReadLine();

                Console.WriteLine("Ingrese el salario del empleado:");
                double salarioEmpleado;
                while (!double.TryParse(Console.ReadLine(), out salarioEmpleado))
                {
                    Console.WriteLine("Entrada inválida. Ingrese un salario válido:");
                }

                Empleado empleado = new Empleado(nombreEmpleado, salarioEmpleado);
                empleados.Add(empleado);
            }
            else if (tipoEmpleado.ToLower() == "gerente")
            {
                Console.WriteLine("Ingrese el nombre del gerente:");
                string nombreGerente = Console.ReadLine();

                Console.WriteLine("Ingrese el salario del gerente:");
                double salarioGerente;
                while (!double.TryParse(Console.ReadLine(), out salarioGerente))
                {
                    Console.WriteLine("Entrada inválida. Ingrese un salario válido:");
                }

                Console.WriteLine("Ingrese el departamento supervisado por el gerente:");
                string departamentoGerente = Console.ReadLine();

                Gerente gerente = new Gerente(nombreGerente, salarioGerente, departamentoGerente);
                gerentes.Add(gerente);
            }
            else
            {
                Console.WriteLine("Tipo de empleado no válido.");
            }

            Console.WriteLine("¿Desea ingresar otro empleado? (S/N)");
            string respuesta = Console.ReadLine();

            continuar = (respuesta.ToLower() == "s");
        }

        // Se muestra la información de empleados y gerentes 

        Console.WriteLine("\nInformación de Empleados:");
        foreach (Empleado empleado in empleados)
        {
            IMostrarInformacion infoEmpleado = empleado;
            infoEmpleado.MostrarInformacionGeneral();
        }

        Console.WriteLine("\nInformación de Gerentes:");
        foreach (Gerente gerente in gerentes)
        {
            IMostrarInformacion infoGerente = gerente;
            infoGerente.MostrarInformacionGeneral();
        }
    }
}
