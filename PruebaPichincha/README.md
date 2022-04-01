# Prueba BACK-END
Programacion Back-End C# Net Core 5 Entity Framework Core

# Implementacion y configuracion de Base
Crear base de datos con nombre : BDPichincha
Ejecutar scipt de creacion de tablas : BDPichincha.sql

Se requiere configurar las propiedades de la conexion en la siguiente ruta:

Api/appsettings

"ConnectionStrings": {
    "DefaultConnection": "Server=<server></server>;Database=BDPichincha;Trusted_Connection=True;"
}

# Open Api Swagger
puerto configurado(5000 defecto)

- http://localhost:<port>/swagger/index.html