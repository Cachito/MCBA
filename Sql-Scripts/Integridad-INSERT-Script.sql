/*
    El valor inicial de DV para las tablas es 0 (no hay registros)
    La encriptación del campo DV es asimétrica
    El valor inicia es 0 + el valor del SALT agregado
    En este caso Es el SALT de uso del sistema, no el default: 'LuisCarro'
    Es decir, se encripta "0LuisCarro"
*/

INSERT INTO Integridad(Tabla, DV) VALUES('Bitacora', '000102030405060708090a0b0c0d0e0f')
INSERT INTO Integridad(Tabla, DV) VALUES('Integridad', '000102030405060708090a0b0c0d0e0f')
INSERT INTO Integridad(Tabla, DV) VALUES('FamiliaPatente', '000102030405060708090a0b0c0d0e0f')
INSERT INTO Integridad(Tabla, DV) VALUES('Permiso', '000102030405060708090a0b0c0d0e0f')
INSERT INTO Integridad(Tabla, DV) VALUES('Usuario', '000102030405060708090a0b0c0d0e0f')
INSERT INTO Integridad(Tabla, DV) VALUES('UsuarioPermiso', '000102030405060708090a0b0c0d0e0f')
INSERT INTO Integridad(Tabla, DV) VALUES('Factura', '000102030405060708090a0b0c0d0e0f')
INSERT INTO Integridad(Tabla, DV) VALUES('FacturaItem', '000102030405060708090a0b0c0d0e0f')
INSERT INTO Integridad(Tabla, DV) VALUES('Liquidacion', '000102030405060708090a0b0c0d0e0f')
INSERT INTO Integridad(Tabla, DV) VALUES('Stock', '000102030405060708090a0b0c0d0e0f')