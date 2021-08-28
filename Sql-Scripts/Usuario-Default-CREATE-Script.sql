/*
    Ojo con este script que inserta el mismo usuari ocon otra clave
    
    Se parte de que la tabla Usuario no tiene registros.
    
    Login, password y DV van encriptados de manera asimétrica
    Login: 'Administrador'
    Password: '1234'
    DV: calculado (ver DvTest en el sistema)

    Se actualiza también tabla integridad teniendo en cuenta este unico usuario
*/

DECLARE @newId INT

INSERT INTO Usuario(Nombre, Apellido, [Login], [Password], Email, IdIdioma, Activo, Intentos, DV)
    VALUES('Usuario', 'Default', '9RGoqeqxziG1QmrXnePmBxfQL+U=', 'YLqNsppxFqjUuOYkEimMUBoFgZw=', 'luis.carro@gmail.com', 1, 1, 0, '')

SET @newId = SCOPE_IDENTITY()

UPDATE Usuario SET 
    DV = '000102030405060708090a0b0c0d0e0f'
WHERE Id = @newId


UPDATE Integridad SET
    DV = '000102030405060708090a0b0c0d0e0f'
WHERE Tabla = 'Usuario'
GO