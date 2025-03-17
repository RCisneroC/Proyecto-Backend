# Proyecto .NET - API Task Manager

Este proyecto es una API RESTful desarrollada con .NET para gestionar una lista de tareas. Permite obtener, crear, actualizar y eliminar tareas.

## Requisitos

* .NET 8 
* Visual Studio 

## Instalación

1.  Clona el repositorio:

 
    git clone https://github.com/RCisneroC/Proyecto-Backend.git


2.  Navega al directorio del proyecto:


   TaskManager
 



## Ejecución local

1.  Ejecuta la API:



2.  La API estará disponible en `http://localhost:7032/api/v1/Task/`.

## Conexión con el Frontend Angular

Esta API se utiliza como backend para un frontend Angular.

1.  Asegúrate de que la API esté en ejecución y accesible desde la aplicación Angular.


2.  Actualiza la URL del backend en el archivo `src/environments/environment.development.ts` del proyecto Angular.


## Estructura del proyecto(patron de diseño DDD)

Capa de Dominio (Core) 

Capa de Aplicación 

Capa de Infraestructura

Capa de Presentación (API) 



## Dependencias principales

* `Microsoft.EntityFrameworkCore.InMemory`: Proveedor de base de datos en memoria para Entity Framework Core.




## Autor

* RICARDO RAFAEL CISNERO CORONADO