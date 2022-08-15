crear por ejemplo el folder code en c:
entra a [git bash]
cd /c/
cd code
git clone https://github.com/rolivas74/rolivas74.git
"apiJuguetes" es el proyecto de la Api, se debe ejecutar primero desde visual studio (antes es necesario cambiar la cadena de conexión en el appsetting con los datos del servidor sql donde se guardaran los datos).
  Crear la base de datos la cual se llamara "juguetes"
  enseguida crear la tabla jugetes con el siguiente script:
      -----------------------
      USE [Juguetes]
      GO

      /****** Objeto: Table [dbo].[Juguetes] Fecha del script: 14/08/2022 10:11:47 p. m. ******/
      SET ANSI_NULLS ON
      GO

      SET QUOTED_IDENTIFIER ON
      GO

      CREATE TABLE [dbo].[Juguetes] (
          [Id]              INT             IDENTITY (1, 1) NOT NULL,
          [Nombre]          VARCHAR (50)    NOT NULL,
          [Descripcion]     VARCHAR (100)   NULL,
          [RestriccionEdad] INT             NULL,
          [Compania]        VARCHAR (50)    NOT NULL,
          [Precio]          DECIMAL (18, 4) NOT NULL
      );
      ----------------
Ejecutar el proyecto apijuguetes, por default mostrar un json con 0 registros [].

desde el explorador de archivos de windows, crear el folder frontjuguetes.
desde [bash]
cd /c/
cd code
cd frontjuguetes
git clone https://github.com/rolivas74/front.git

Abrir visual studio code y abrir el folder frontJuguetes
Abrir la consola con(ctrl+ñ) luego seleccionar Terminal y ejecutar npm start lo cual iniciara el proyecto.
Iniciar a crear nuevos registro de jueguetes
Se deberan de ir agregando a la tabla
Se debe de poder modificar y eliminar registros
