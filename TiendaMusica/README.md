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
      CREATE DATABASE TiendaMusica;
      USE TiendaMusica;
      
      CREATE TABLE Playlists (
          Id int identity(1,1) PRIMARY KEY,
          Nombre varchar(50),
          Descripcion varchar(100),
          Codigo varchar(5)
      );
      
      CREATE TABLE Artistas (
          Id int identity(1,1) PRIMARY KEY,
          Nombre varchar(50),
          Nacimiento date,
          PlaylistId int,
          CONSTRAINT FK_Artistas_Playlists FOREIGN KEY (PlaylistId) REFERENCES Playlists(Id)
      );
      
      select * from Artistas
      select * from Playlists
     ```
      
   - Instalar los paquetes NuGet `EntityFrameworkCore.SqlServer` y `EntityFrameworkCore.Tools`.
   - En la ventana de comandos de NuGet, ejecutar el comando siguiente (reemplazando `server=SERVER_NAME` con el nombre del servidor de tu PC):

     ```
     Scaffold-DbContext "server=DESKTOP-9QK0T32\\SQLEXPRESS; database=TiendaMusica; Trusted_Connection=True; TrustServerCertificate=True;"
     Microsoft.EntityFrameworkCore.SqlServer -OutPutDir Models
     ```

2. **Ejecución del Proyecto**

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

3. **Explicación Breve**

  - Tanto la pagina `Playlists` como `Artistas` tienen un CRUD, este permite ingresar datos, sin embargo, estas paginas están relacionadas
    pues un artista va a pertenecer a una playlist determinada.
  - Se pueden ingresar, editar y eliminar datos de ambas paginas.
  - Estos cambios se ven reflejados en la Base de Datos.
