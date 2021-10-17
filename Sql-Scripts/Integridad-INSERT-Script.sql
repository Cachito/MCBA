/*
    El valor inicial de DV para las tablas es 0 (no hay registros)
    La encriptación del campo DV es asimétrica
    El valor inicia es 0 + el valor del SALT agregado
    En este caso Es el SALT de uso del sistema, no el default: 'LuisCarro'
    Es decir, se encripta "0LuisCarro"
*/

INSERT INTO Integridad(Tabla, DV) VALUES('Bitacora', 'OkgZMhsewUT7srpBQrL9wGs91/c=')
--INSERT INTO Integridad(Tabla, DV) VALUES('Integridad', 'tjjVs/NtxEfY36LFzZlMbB2CXS0=')
INSERT INTO Integridad(Tabla, DV) VALUES('FamiliaPermiso', 'OkgZMhsewUT7srpBQrL9wGs91/c=')
INSERT INTO Integridad(Tabla, DV) VALUES('Usuario', 'OkgZMhsewUT7srpBQrL9wGs91/c=')
INSERT INTO Integridad(Tabla, DV) VALUES('UsuarioPermiso', 'OkgZMhsewUT7srpBQrL9wGs91/c=')
INSERT INTO Integridad(Tabla, DV) VALUES('Factura', 'OkgZMhsewUT7srpBQrL9wGs91/c=')
INSERT INTO Integridad(Tabla, DV) VALUES('FacturaItem', 'OkgZMhsewUT7srpBQrL9wGs91/c=')
INSERT INTO Integridad(Tabla, DV) VALUES('Liquidacion', 'OkgZMhsewUT7srpBQrL9wGs91/c=')
INSERT INTO Integridad(Tabla, DV) VALUES('Stock', 'OkgZMhsewUT7srpBQrL9wGs91/c=')
INSERT INTO Integridad(Tabla, DV) VALUES('UsuarioFamilia', 'OkgZMhsewUT7srpBQrL9wGs91/c=')