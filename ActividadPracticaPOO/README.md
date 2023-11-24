# Aplicación de Gestión de Empleados en Consola

Esta aplicación de consola permite ingresar y gestionar información de empleados y gerentes.
Se pueden ingresar datos para empleados (empleados) o gerentes (gerentes), almacenar la información y mostrarla de manera estructurada.

## Cómo Utilizar

1. **Ejecutar el Programa**
   - Abre el programa en tu entorno de desarrollo de C# preferido o compila el código fuente proporcionado.
   - Ejecuta la aplicación compilada.

2. **Ingresar Información de Empleado o Gerente**
   - Al ejecutar el programa, se te pedirá que ingreses el tipo de empleado ("empleado" o "gerente").
   - Ingresa la información requerida para el empleado o gerente según el tipo seleccionado.
     - Para "empleado":
       - Nombre
       - Salario
     - Para "gerente":
       - Nombre
       - Salario
       - Departamento supervisado

3. **Continuar Agregando Empleados/Gerentes**
   - El programa te permite ingresar información para múltiples empleados o gerentes.
   - Después de ingresar datos para un empleado o gerente, se pregunta si deseas agregar otro. Responde con "S" (sí) o "N" (no).

4. **Mostrar Información**
   - Después de ingresar toda la información deseada de empleados y gerentes, el programa muestra la información almacenada de manera estructurada.
   - Separa la información en dos secciones: Información de Empleados e Información de Gerentes.

## Detalles de Implementación

- El programa utiliza principios de programación orientada a objetos en C#.
- Define dos clases: `Empleado` y `Gerente`.
  - Ambas clases implementan la interfaz `IMostrarInformacion`, asegurando un método común (`MostrarInformacionGeneral()`) para mostrar información.
- La interfaz `IMostrarInformacion` permite el tratamiento uniforme de objetos de empleado y gerente, habilitando un comportamiento polimórfico.

## Dependencias

- El programa utiliza los espacios de nombres `System` y `System.Collections.Generic` en C# para entrada/salida en consola y gestión de colecciones, respectivamente.

## Estructura de Archivos

- `Program.cs`: Contiene la lógica principal del programa.
- `Empleado.cs`: Define la clase `Empleado`.
- `Gerente.cs`: Define la clase `Gerente`.
- `IMostrarInformacion.cs`: Define la interfaz `IMostrarInformacion`.

## Desarrollado en .NET 7.0 y Ejecución con Docker en Linux o MacOS

- Este proyecto está desarrollado en .NET 7.0, lo que garantiza la compatibilidad y el uso de las últimas características y mejoras en el lenguaje de programación C# y la plataforma .NET.

## Ejecución con Docker

- Si estás trabajando en un entorno Linux o MacOS y prefieres ejecutar la aplicación utilizando Docker para C#, puedes hacerlo siguiendo estos pasos:
  
  - Asegúrate de tener Docker instalado en tu sistema.
  - Ejecuta los comandos de Docker para construir y ejecutar la aplicación C#.

## Ejecución de la Aplicación

- Compila el código fuente proporcionado o ábrelo en un entorno de desarrollo de C#.
- Ejecuta la aplicación compilada para utilizar la interfaz de consola y gestionar información de empleados y gerentes.

## Colaboradores

- Andrés Almeida Jara.
