# TiendaMusicaApp

## Descripción

TiendaMusicaApp es una aplicación ASP .NET Core con Modelo Vista Controlador (MVC) que permite gestionar artistas y listas de reproducción de música. La aplicación implementa un CRUD (Crear, Leer, Actualizar, Eliminar) para interactuar con la base de datos.

## Características

- Implementación de tres páginas Razor: "Home", "Playlists", "Artistas".
- Configuración de Entity Framework Core para la persistencia de datos.
- Implementación de un CRUD para la gestión de artistas y listas de reproducción.
- Estilos CSS aplicados para un diseño responsivo y atractivo.

## Instrucciones de Uso

### Requisitos

- Visual Studio 2022
- SQL Server (última versión)

### Pasos para Ejecutar

1. **Configuración de la Base de Datos**

   - Crear una nueva base de datos en SQL Server:

      ```
      CREATE DATABASE TiendaMusicaApp
      USE TiendaMusicaApp

      CREATE TABLE Artistas(
      Id int identity(1,1) primary key,
      Nombre varchar(50),
      Nacimiento date,
      Codigo varchar(5)
      )

      select * from Artistas
     ```
      
   - Instalar los paquetes NuGet `EntityFrameworkCore.SqlServer` y `EntityFrameworkCore.Tools`.
   - En la ventana de comandos de NuGet, ejecutar el comando siguiente (reemplazando `server=SERVER_NAME` con el nombre del servidor de tu PC):

     ```
     Add-Migration InitialCreate
     Update-Database -Connection "server=SERVER_NAME; database=TiendaMusicaApp; Trusted_Connection=True; TrustServerCertificate=True;"
     ```

1. **Ejecución del Proyecto**

   - Abrir el proyecto en Visual Studio 2022.
   - Configurar la conexión a la base de datos en el archivo `appsettings.json`, añadimos esta línea en nuestro código (reemplazando `server=SERVER_NAME` con el nombre del servidor de tu PC):
  
     ```
     "conexion": "server=SERVER_NAME; database=TiendaMusicaApp; Trusted_Connection=True; TrustServerCertificate=True;"
     ```
   - Copiamos esta parte de código en nuestro `Programa.cs`:

    ```
     // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
      {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }
     ```
   - Ejecutamos la solución.

## Contribución

¡Las contribuciones son bienvenidas! Si tienes sugerencias o mejoras para la aplicación, no dudes en crear un pull request o abrir un issue.

# IMPORTANTE
ESTA VERSION DEL PROGRAMA ESTÁ DESACTUALIZADA, PUES PERTENECE A LA PRIMERA ENTREGA QUE FUE EL LUNES, 27 DE NOVIEMBRE A LAS 00:00. PARA ACCEDER A LA VERSIÓN FINAL DEL PROGRAMA:

<a href="https://github.com/andresalmeida/Desarrollo Web Avanzado 14956/tree/main/TiendaMusica">TiendaMusica</a>


[TiendaMusica](https://github.com/andresalmeida/Desarrollo_Web_Avanzado_14956/tree/main/TiendaMusica) - Contiene los últimos cambios.

