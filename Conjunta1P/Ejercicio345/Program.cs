using System;

namespace Ejercicio345
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos e inicializamos la variable estudiante1
            Estudiante estudiante1 = new Estudiante("Andrés Almeida", 23, 19);

            // Crear objeto de tipo EstudianteGraduado llamado graduado1 e inicializar sus propiedades
            EstudianteGraduado graduado1 = new EstudianteGraduado("Ana López", 25, 9, "Licenciatura en Informática");


            /////////////////////////////////////////////////////////////////////////////////////////////


            // Imprimimos la información del estudiante
            //Console.WriteLine("El nombre del estudiante es {0}, tiene {1} años y su calificación es {2}",
              //estudiante1.Nombre, estudiante1.Edad, estudiante1.Calificacion);

            //Console.ReadKey(); // Para mantener la consola abierta hasta que se presione una tecla

            // DES/COMENTAR LAS LINEAS 20, 21 & 23 PARA PODER ACCEDER AL METODO MostrarInformacion

            // Llamada al método MostrarInformacion para el objeto estudiante1
            //estudiante1.MostrarInformacion();
  
            //Console.ReadKey(); // Para mantener la consola abierta hasta que se presione una tecla

            // DES/COMENTAR LAS LINEAS 20, 21, 23, 28 & 30  PARA PODER ACCEDER AL METODO MostrarInformacion

            // Utilizar el método MostrarInformacion de la clase base para mostrar la información del estudiante graduado
            //graduado1.MostrarInformacion();

            //Console.ReadKey();

            // DESCOMENTAR LAS LINEAS 35 & 37 PARA ACCEDER AL METODO MostrarInformacion DE GRADUADOS
        }
    }
}
