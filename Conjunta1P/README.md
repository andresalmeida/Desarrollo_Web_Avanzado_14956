# Prueba Conjunta Primer Parcial - Ejercicios de C# en Visual Studio

Este proyecto contiene tress ejercicios de C# diseñados para practicar conceptos básicos y estructuras de control.

## Ejercicio 1: Variables y Operadores en C#

En este ejercicio, se lleva a cabo lo siguiente:

1. Declarar dos variables numéricas, `numero1` y `numero2`.
2. Calcular la suma de las dos variables.
3. Imprimir el resultado en la consola.

#### Código:

```csharp
using System;

// EJERCICIO 1

// Declaramos las variables para los numeros y las inicializamos con valores numericos
int numero1 = 54;
int numero2 = 33;

// Calculamos la suma de las dos variables y la almacenamos en otra 
int resultado = numero1 + numero2;

// Imprimimos el resultado en la consola
Console.WriteLine("La suma de " + numero1 + " y " + numero2 + " da como resultado = " + resultado);
```

## Ejercicio 2: Estructuras de Control en C#

En este ejercicio, se lleva a cabo lo siguiente:

1. Declarar una variables numéricas: `edad`.
2. Utilizamos una estructura de control para ver si es mayor de edad o no.
3. Imprimir el resultado de la validación de estructura de control en la consola.

#### Código:

```csharp
using System;

// EJERCICIO 2

// Declaramos la variable edad y la inicializamos con un valor numerico
int edad = 23;

// Utilizamos una estructura if para determinar si es mayor de edad
if (edad >= 18)
{
  // Condicion: Si la persona es mayor de edad
  Console.WriteLine("La persona es mayor de edad");
}
else
{
  // Condicion: Si la persona no es mayor de edad
  Console.WriteLine("La persona no es mayor de edad");
}
```

## Ejercicio 3, 4 & 5:  Programación Orientada a Objetos - Clases y Objetos, Métodos & Herencia


En este ejercicio, se lleva a cabo lo siguiente:

1. Creamos una clase: `Estudiante` con sus propiedades.
2. Creamos un objeto de la clase: `estudiante1`.
3. Creamos un método `MostrarInformacion`.
4. Creamos una nueva clase llamada `EstudianteGraduado`.
5. Añadimos una nueva propiedad llamada `Titulo`.
6. Creamos un objeto de la clase: `graduado1`.
7. Utilizamos el método `MostrarInformacion`.
8. Imprimir el resultado en la consola.

## Ejecución del código
### Visual Studio
Abre el proyecto en Visual Studio.
Haz clic en el botón Iniciar en la parte superior de la ventana.

### Línea de comandos
Abre una ventana de terminal.
Navega hasta la carpeta donde se encuentra el código.
Escribe el siguiente comando:

```bash
dotnet run
```
### Nota: 
Este proyecto se ha creado con .NET 7.0.
