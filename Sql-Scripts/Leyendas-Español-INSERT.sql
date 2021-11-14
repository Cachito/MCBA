DELETE Leyendas 
WHERE IdIdioma = 1
GO

-- CASTELLANO
-- splash
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Splash', 'CheckIntegridad', 'Comprobando Integridad')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Splash', 'FailIntegridad', 'Hay un problema con la integridad de la base de datos.{0}Por favor contacte al administrador.')

-- login
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'lblUsuario', 'Usuario')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'lblContra', 'Contraseña')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'lblEmail', 'Email')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'lblIdioma', 'Idioma')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'btnOk', 'Ok')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'btnCancel', 'Cancelar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'btnRecuperarContra', 'Recuperar Contraseña')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'UsuarioBloqueado', 'Usuario Bloqueado')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'LoginIncorrecto', 'Usuario o clave incorrecta.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'RestoreWarning', 'Si continúa se restaurará su password y se enviará un mail a {0}.{1}¿Está Seguro?')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'MailWarning', 'El usuario indicado no tiene una dirección de mail asignada.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'RestoreSubject', 'Buongiorno S. A.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'RestoreBody', '{0}: Se le envía la clave nueva: "{1}" (Sin las comillas).{2}No comparta este correo.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'RestoreSent', 'Se ha enviado el correo.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'RestoreSaved', 'Se ha guardado el correo en {0}.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'LoginFail', 'Login Incorrecto.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'Ingreso', 'Ingreso al Sistema.')

-- Menu
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'Menu', '{0} - Usuario: {1} {2}')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiMaestros', 'Maestros')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiCondicionesIva', 'Condiciones de IVA')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiProvincias', 'Provincias')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiLocalidades', 'Localidades')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiBancos', 'Bancos')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiTiposCuenta', 'Tipos de Cuenta Bancaria')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiUnidades', 'Unidades')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiArchivo', 'Archivo')    

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiRemitentes', 'Remitentes')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiVehiculos', 'Vehiculos')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiChoferes', 'Choferes')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiProductos', 'Productos')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiClientes', 'Clientes')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiMovimientos', 'Movimientos')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiStock', 'Stock')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiVentas', 'Ventas')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiLiquidaciones', 'Liquidaciones')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiGestion', 'Gestión')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiUsuarios', 'Usuarios')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiPermisosUsuarios', 'Permisos a Usuarios')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiPermisosFamilias', 'Permisos a Familias')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiFamilias', 'Familias')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiBackup', 'Backup')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiBitacoras', 'Bitácora')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiCambioContra', 'Cambio de Contraseña')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiCambioCns', 'Cambio Cadena de Conexión')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'Salir', 'Salida del Sistema.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'lblBase', '[Servidor] / [Base de Datos]: {0}')

-- Busqueda
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Busqueda', 'Busqueda', 'Búsqueda - {0}')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Busqueda', 'tsbOk', 'Ok')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Busqueda', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Busqueda', 'lblBusqueda', 'Ingrese un texto a buscar en {0}.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Busqueda', 'TextoVacio', 'Debe ingresar un texto a buscar.')

-- Condiciones de IVA
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CondicionesIva', 'CondicionesIva', 'Condiciones de IVA')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CondicionesIva', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CondicionesIva', 'lblDescripcion', 'Descripción')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CondicionesIva', 'lblLetra', 'Letra Factura')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CondicionesIva', 'lblPorcentaje', 'Porcentaje')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CondicionesIva', 'chkDiscrimina', 'Discrimina IVA')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CondicionesIva', 'tsbNew', 'Nuevo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CondicionesIva', 'tsbDelete', 'Eliminar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CondicionesIva', 'tsbEdit', 'Editar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CondicionesIva', 'tsbSave', 'Guardar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CondicionesIva', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CondicionesIva', 'tsbUndo', 'Deshacer')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CondicionesIva', 'tsbPrint', 'Imprimir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CondicionesIva', 'tsbBuscar', 'Buscar')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CondicionesIva', 'tsbPrevious', 'Página Anterior')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CondicionesIva', 'tsbNext', 'Página Siguiente')	
    
-- Bancos
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bancos', 'Bancos', 'Bancos')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bancos', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bancos', 'lblDescripcion', 'Descripción')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bancos', 'tsbNew', 'Nuevo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bancos', 'tsbDelete', 'Eliminar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bancos', 'tsbEdit', 'Editar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bancos', 'tsbSave', 'Guardar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bancos', 'tsbSalir', 'Salir')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bancos', 'tsbBuscar', 'Buscar')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bancos', 'tsbPrint', 'Imprimir')			    

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bancos', 'tsbUndo', 'Deshacer')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bancos', 'tsbPrevious', 'Página Anterior')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bancos', 'tsbNext', 'Página Siguiente')	

-- Familia
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'Familias', 'Familias')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'lblNombre', 'Nombre')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'chkActivo', 'Activo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'tsbNew', 'Nuevo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'tsbDelete', 'Eliminar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'tsbEdit', 'Editar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'tsbSave', 'Guardar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'tsbSalir', 'Salir')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'tsbBuscar', 'Buscar')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'tsbPrint', 'Imprimir')			    

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'tsbUndo', 'Deshacer')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'tsbPrevious', 'Página Anterior')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'tsbNext', 'Página Siguiente')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'FaltaNombre', 'Debe ingresar un nombre.{0}')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'ErrorAlGuardar', 'Hubo un error al guardar.{0}Por favor intente más tarde.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'NoEncontrado', 'No se encuentra el registro buscado.{0}Por favor recargue la grilla')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Familias', 'DesactivarWarning', 'Si desactiva la familia se eliminarán las relaciones de usuarios y permisos.{0}¿Está seguro?')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Familias', 'NoSePuedeEliminar', 'No es posible eliminar la familia {0} porque quedan permisos sin asignar.')

-- Bitácora
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacoras', 'Bitacora', 'Bitácora')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacoras', 'lblUsuario', 'Usuario')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacoras', 'lblCriticidad', 'Criticidad')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacoras', 'lblDesde', 'Fecha Desde')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacoras', 'lblHasha', 'Fecha Hasha')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacoras', 'tsbSalir', 'Salir')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacoras', 'tsbBuscar', 'Buscar')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacoras', 'tsbImprimir', 'Imprimir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacoras', 'FaltaCriticidad', 'Debe seleccionar criticidad.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacoras', 'FaltaUsuario', 'Debe seleccionar usuario.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacoras', 'LapsoInvalido', 'El período ingresado no es válido.')

-- ReporteBitacora
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'ReporteBitacora', 'ReporteBitacora', 'Reporte de Bitacora')

-- CambioPassword
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioPassword', 'CambioPassword', 'Cambio de Password')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioPassword', 'lblUsuario', 'Usuario')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioPassword', 'lblContraActual', 'Contraseña Actual')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioPassword', 'lblContraNueva', 'Contraseña Nueva')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioPassword', 'lblRepetir', 'Repetir Contraseña Nueva')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioPassword', 'tsbSalir', 'Salir')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioPassword', 'tsbSave', 'Guardar')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioPassword', 'ClaveActual', 'Debe ingreasr la contraseña actual.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioPassword', 'ClaveNueva', 'Debe ingreasr una contraseña nueva.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioPassword', 'ClaveIncorrecta', 'La contraseña actual ingresada es incorrecta.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioPassword', 'ClaveDistinta', 'Las contraseñas ingresadas no son iguales.')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioPassword', 'ErrorCheckPassword', 'Se produjo un error al comprobar la contraseña.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioPassword', 'UserBlocked', 'El usuario {0} ha sido bloqueado.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioPassword', 'PasswordChanged', 'Se cambió la contraseña de usuario {0}.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioPassword', 'CloseSystem', 'El sistema se cerrará.')	

-- Choferes
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Choferes', 'Choferes', 'Choferes')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Choferes', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Choferes', 'lblNombre', 'Nombre')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Choferes', 'lblApellido', 'Apellido')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Choferes', 'lblDni', 'DNI')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Choferes', 'lblRemitente', 'Remitente')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Choferes', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Choferes', 'tsbNew', 'Nuevo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Choferes', 'tsbDelete', 'Eliminar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Choferes', 'tsbEdit', 'Editar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Choferes', 'tsbSave', 'Guardar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Choferes', 'tsbUndo', 'Deshacer')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Choferes', 'tsbPrevious', 'Página Anterior')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Choferes', 'tsbNext', 'Página Siguiente')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Choferes', 'tsbPrint', 'Imprimir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Choferes', 'tsbBuscar', 'Buscar')
		
-- Clientes
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'Clientes', 'Clientes')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'lblNombre', 'Nombre')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'lblApellido', 'Apellido')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'lblDomicilio', 'Domicilio')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'lblDni', 'Documento')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'lblCondicion', 'Condicion de IVA')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'lblProvincia', 'Provincia')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'lblLocalidad', 'Localidad')		

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'tsbNew', 'Nuevo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'tsbDelete', 'Eliminar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'tsbEdit', 'Editar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'tsbSave', 'Guardar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'tsbUndo', 'Deshacer')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'tsbPrevious', 'Página Anterior')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'tsbNext', 'Página Siguiente')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'tsbPrint', 'Imprimir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'tsbBuscar', 'Buscar')
		
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'tsbNewTelefono', 'Nuevo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'tsbDeleteTelefono', 'Eliminar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Clientes', 'tsbEditTelefono', 'Editar')

-- Facturas
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'Facturas', 'Facturas')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'lblPtoVenta', 'Pto. de Venta')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'lblCliente', 'Cliente')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'lblRazonSocial', 'Razón Social')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'lblLetra', 'Letra')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'lblNumero', 'Número')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'lblFecha', 'Fecha')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'lblCuit', 'CUTI')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'lblDomicilio', 'Domicilio')		
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'lblTotal', 'Total')			

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'tsbNew', 'Nuevo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'tsbDelete', 'Eliminar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'tsbSave', 'Guardar')
		
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'tsbPrint', 'Imprimir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'tsbBuscar', 'Buscar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'tsbUndo', 'Deshacer')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'tsbPrevious', 'Página Anterior')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'tsbNext', 'Página Siguiente')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'tsbNewItem', 'Nuevo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'tsbDeleteItem', 'Eliminar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Facturas', 'tsbEditItem', 'Editar')

-- FacturasItems
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'FacturasItems', 'FacturasItems', 'Ítem')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'FacturasItems', 'lblLote', 'Lote')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'FacturasItems', 'lblDescripcion', 'Descripción')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'FacturasItems', 'lblUnidad', 'Unidad')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'FacturasItems', 'lblCantidad', 'Cantidad')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'FacturasItems', 'lblUnitario', 'Unitario')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'FacturasItems', 'lblTotal', 'Total')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'FacturasItems', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'FacturasItems', 'tsbOk', 'Ok')

-- FacturasBuscar
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'FacturasBuscar', 'FacturasBuscar', 'Buscar Factura')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'FacturasBuscar', 'lblCliente', 'Cliente')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'FacturasBuscar', 'lblLetra', 'Letra')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'FacturasBuscar', 'lblFecha', 'Fecha')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'FacturasBuscar', 'lblNumero', 'Número')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'FacturasBuscar', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'FacturasBuscar', 'tsbOk', 'Ok')

-- Liquidacion
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'Liquidacion', 'Liquidación')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'lblRemitente', 'Remitente')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'lblPtoducto', 'Producto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'lblVenta', 'Venta')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'lblTotalVentas', 'Total Ventas')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'lblLote', 'Lote')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'gbComisiones', 'Comisión')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'rbComisionProducto', 'Producto')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'rbComisionRemitente', 'Remitente')		
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'lblDecomiso', 'Decomiso')			
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'lblComision', 'Total Comisión')				

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'lblFecha', 'Fecha')				

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'gbPrecios', 'Precio')				

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'rbPrecioPromedio', 'Promedio')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'rbPrecioPlaza', 'Plaza')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'lblActa', 'Acta Decomiso')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'lblAPagar', 'Total a Pagar')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'tsbNew', 'Nuevo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'tsbDelete', 'Eliminar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'tsbEdit', 'Editar')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'tsbSave', 'Guardar')
		
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'tsbPrint', 'Imprimir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Liquidacion', 'tsbBuscar', 'Buscar')

-- Localidades
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Localidades', 'Localidades', 'Localidades')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Localidades', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Localidades', 'lblDescripcion', 'Descripción')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Localidades', 'lblProvincia', 'Provincia')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Localidades', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Localidades', 'tsbNew', 'Nueva')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Localidades', 'tsbDelete', 'Eliminar')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Localidades', 'tsbEdit', 'Editar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Localidades', 'tsbSave', 'Guardar')
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Localidades', 'tsbUndo', 'Deshacer')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Localidades', 'tsbPrevious', 'Página Anterior')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Localidades', 'tsbNext', 'Página Siguiente')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Localidades', 'tsbPrint', 'Imprimir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Localidades', 'tsbBuscar', 'Buscar')    	

-- Provincias
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Provincias', 'Provincias', 'Provincias')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Provincias', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Provincias', 'lblDescripcion', 'Descripción')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Provincias', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Provincias', 'tsbNew', 'Nuevo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Provincias', 'tsbDelete', 'Eliminar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Provincias', 'tsbEdit', 'Editar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Provincias', 'tsbSave', 'Guardar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Provincias', 'tsbUndo', 'Deshacer')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Provincias', 'tsbPrevious', 'Página Anterior')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Provincias', 'tsbNext', 'Página Siguiente')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Provincias', 'tsbPrint', 'Imprimir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Provincias', 'tsbBuscar', 'Buscar')

-- Productos
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Productos', 'Productos', 'Productos')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Productos', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Productos', 'lblDescripcion', 'Descripción')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Productos', 'lblVariedad', 'Variedad')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Productos', 'lblComision', 'Comisión (%)')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Productos', 'lblIva', 'IVA (%)')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Productos', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Productos', 'tsbNew', 'Nuevo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Productos', 'tsbDelete', 'Eliminar')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Productos', 'tsbEdit', 'Editar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Productos', 'tsbSave', 'Guardar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Productos', 'tsbUndo', 'Deshacer')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Productos', 'tsbPrevious', 'Página Anterior')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Productos', 'tsbNext', 'Página Siguiente')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Productos', 'tsbPrint', 'Imprimir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Productos', 'tsbBuscar', 'Buscar')

-- RemitenteComisiones
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'RemitenteComisiones', 'RemitenteComisiones', 'Comisiones')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'RemitenteComisiones', 'lblRemitente', 'Remitente')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'RemitenteComisiones', 'lblProducto', 'Producto')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'RemitenteComisiones', 'lblComision', 'Comisión (%)')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'RemitenteComisiones', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'RemitenteComisiones', 'tsbOk', 'Ok')

-- Remitentes
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'Remitentes', 'Remitentes')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'lblNombre', 'Nombre')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'lblApellido', 'Apellido')	
	    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'lblCuit', 'CUIT')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'lblCondicion', 'Condicion de IVA')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'lblBanco', 'Banco')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'lblCuenta', 'Cuenta Banco')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'lblTipoCuenta', 'Tipo de Cuenta')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'lblProvincia', 'Provincia')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'lblDomicilio', 'Domicilio')	
		
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'lblLocalidad', 'Localidad')		

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'tsbNew', 'Nuevo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'tsbDelete', 'Eliminar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'tsbEdit', 'Editar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'tsbSave', 'Guardar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'tsbUndo', 'Deshacer')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'tsbPrevious', 'Página Anterior')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'tsbNext', 'Página Siguiente')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'tsbPrint', 'Imprimir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'tsbBuscar', 'Buscar')
		
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'tsbNewComision', 'Nuevo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'tsbDeleteComision', 'Eliminar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Remitentes', 'tsbEditComision', 'Editar')

-- ReporteCaja
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'ReporteCaja', 'ReporteCaja', 'Reporte de Caja')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'ReporteCaja', 'lblFecha', 'Fecha')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'ReporteCaja', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'ReporteCaja', 'tsbProcesar', 'Procesar')

-- Usuarios
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'Usuarios', 'Usuarios')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'lblNombre', 'Nombre')
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'lblApellido', 'Apellido')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'lblEmail', 'Email')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'lblUsuario', 'Usuario')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'lblIdioma', 'Idioma')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'lblContra1', 'Contraseña')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'lblContra2', 'Contraseña')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'chkActivo', 'Activo')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'tsbNew', 'Nuevo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'tsbDelete', 'Eliminar')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'tsbEdit', 'Editar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'tsbSave', 'Guardar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'tsbPrint', 'Imprimir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'tsbBuscar', 'Buscar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'tsbRestorePass', 'Restaurar Contraseña')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'tsbChangePass', 'Cambiar Contraseña')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'FaltaUsuario', 'Debe ingresar usuario.')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'FaltaNombre', 'Debe ingresar nombre.')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'FaltaApellido', 'Debe ingresar apellido.')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'FaltaEmail', 'Debe ingresar email.')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'FaltaPassword', 'Debe ingresar password.')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'FaltaConfirmar', 'Debe confirmar password.')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'PasswordDistinto', 'Los passwords ingresados son distintos.')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'FaltaIdioma', 'Debe seleccionar idioma.')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'RevisarErrores', 'Por favor, revise los problemas indicados.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'NoEncontrado', 'El usuario no se encuentra.{0}Por favor comuníquese con el administrador.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'ErrorAlGuardar', 'No fue posible guardar los cambios.{0}Por favor contacte al administrador.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'NewUserSubject', 'Buongiorno S. A.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'NewUserBody', 'Se le envían sus credenciales: usuario: {0}; password: {1}.{2}No comparta este correo.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'NewUserSent', 'Se ha enviado el correo.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'NewUserSaved', 'Se ha guardado el correo en {0}.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'MailWarning', 'El usuario no tiene una dirección de mail asignada.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'RestoreWarning', 'Si continúa se restaurará su password y se enviará un mail a {0}.{1}¿Está Seguro?')
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'RestoreSubject', 'Buongiorno S. A.')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'RestoreBody', '{0}: Se le envía la clave nueva: "{1}" (Sin las comillas).{2}No comparta este correo.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'RestoreSent', 'Se ha enviado el correo.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'RestoreSaved', 'Se ha guardado el correo en {0}.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'EmailExistente', 'El email ingresado ya existe.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'Activar', 'Va a volver a activar un usuario inactivo.{0}¿Está Seguro?')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'Desactivar', 'Va a desactivar un usuario.{0}Sus transacciones no se perderán pero no podrá volver a ingresar al sistema. Se eliminarán las relaciones con permisos y familias.{0}¿Está Seguro?')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'EliminarSelf', 'No puede eliminar el usuario con que ingresó al sistema.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'PermisosHuerfanos', 'No puede eliminar el usuario {0} porque quedan permisos sin asignar o sin gestión.')

-- Unidades
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Unidades', 'Unidades', 'Unidades')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Unidades', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Unidades', 'lblDescripcion', 'Descripción')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Unidades', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Unidades', 'tsbNew', 'Nuevo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Unidades', 'tsbDelete', 'Eliminar')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Unidades', 'tsbEdit', 'Editar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Unidades', 'tsbSave', 'Guardar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Unidades', 'tsbUndo', 'Deshacer')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Unidades', 'tsbPrevious', 'Página Anterior')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Unidades', 'tsbNext', 'Página Siguiente')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Unidades', 'tsbPrint', 'Imprimir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Unidades', 'tsbBuscar', 'Buscar')

-- TiposCuenta
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'TiposCuenta', 'TiposCuenta', 'Tipos de Cuenta')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'TiposCuenta', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'TiposCuenta', 'lblDescripcion', 'Descripción')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'TiposCuenta', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'TiposCuenta', 'tsbNew', 'Nuevo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'TiposCuenta', 'tsbDelete', 'Eliminar')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'TiposCuenta', 'tsbEdit', 'Editar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'TiposCuenta', 'tsbSave', 'Guardar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'TiposCuenta', 'tsbUndo', 'Deshacer')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'TiposCuenta', 'tsbPrevious', 'Página Anterior')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'TiposCuenta', 'tsbNext', 'Página Siguiente')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'TiposCuenta', 'tsbPrint', 'Imprimir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'TiposCuenta', 'tsbBuscar', 'Buscar')

-- Stock
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'Stock', 'Stock')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'lblLote', 'Lote')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'lblRemitente', 'Remitente')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'lblProducto', 'Producto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'lblOrigen', 'Origen')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'lblFecha', 'Fecha')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'lblUnidad', 'Unidad')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'lblCantidad', 'Cantidad')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'lblGuia', 'Guía de Transp.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'lblChofer', 'Chofer')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'tsbNew', 'Nuevo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'tsbDelete', 'Eliminar')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'tsbEdit', 'Editar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'tsbSave', 'Guardar')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'tsbBuscar', 'Buscar')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'tsbPrint', 'Imprimir')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'tsbUndo', 'Deshacer')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'tsbPrevious', 'Página Anterior')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Stock', 'tsbNext', 'Página Siguiente')

-- StockBuscar
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'StockBuscar', 'StockBuscar', 'FIltros Stock')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'StockBuscar', 'lblRemitente', 'Remitente')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'StockBuscar', 'lblProducto', 'Producto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'StockBuscar', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'StockBuscar', 'tsbOk', 'Ok')

-- PermisosUsuarios
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'PermisosUsuarios', 'PermisosUsuarios', 'Permisos a Usuarios')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'tsbSave', 'Guardar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'lblUsuario', 'Usuario')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'gbFamilias', 'Familias')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'lblDisponiblesF', 'Familias Disponmibles')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'lblAsignadasF', 'Familias Asignadas')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'btnAddFamilia', '')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'btnRemoveFamilia', '')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'gbPermisos', 'Permisos')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'lblDisponiblesP', 'Permisos Disponibles')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'lblAsignadasP', 'Permisos Asignados')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'SinUsuario', 'Debe seleccionar un usuario.')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'SinSeleccion', 'Debe seleccionar alguna familia o algún permiso.')
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'FaltaPermiso', 'Debe seleccionar tipo a todos los permisos asignados.')
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'ErrorAlGuardar', 'No se guardaron los cambios.{0}{1}')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'NoSePuedeQuitarPermiso', 'No es posible quitar el/los permiso/s {0} porque no lo tiene/n otros usuarios.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'ErrorCargaGrillas', 'Error al cargar grillas.{0}{1}')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosUsuarios', 'NoSePuedeQuitarFamilia', 'No es posible quitar la/las familia/s {0} porque quedan permisos sin asignar.')

-- PermisosFamilias
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'PermisosFamilias', 'PermisosFamilias', 'Permisos a Familias')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'tsbSave', 'Guardar')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'lblFamilia', 'Familia')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'gbUsuarios', 'Usuarios')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'lblDisponiblesU', 'Usuarios Disponmibles')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'lblAsignadosU', 'Usuarios Asignados')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'btnAddUsuario', '')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'btnRemoveUsuario', '')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'gbPermisos', 'Permisos')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'lblDisponiblesP', 'Permisos Disponibles')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'lblAsignadasP', 'Permisos Asignados')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'SinFamilia', 'Debe seleccionar una familia.')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'SinSeleccion', 'Debe seleccionar alguna usuario o algún permiso.')
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'FaltaPermiso', 'Debe seleccionar tipo a todos los permisos asignados.')
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'ErrorAlGuardar', 'No se guardaron los cambios.{0}{1}')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'NoSePuedeQuitarPermiso', 'No es posible quitar el/los permiso/s {0} porque no lo tiene/n otras familias.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'PermisosFamilias', 'NoSePuedeQuitarUsuario', 'No es posible quitar el/los usuarios/s {0} porque quedan permisos sin asignar.')

-- Backup
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Backup', 'Backup', 'Backup')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'tsbProcesar', 'Backup')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'tsbRestore', 'Restore')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'lblDestino', 'Carpeta Backups')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'lblAvance', 'Avance')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'lblVolumen', 'Volumen en Proceso')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'FaltaCarpeta', 'Debe Seleccionar una carpeta de backups.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'CarpetaNoExiste', 'La carpeta indicada no existe o no se tiene acceso.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'GenerandoBackup', 'Generando backup.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'ErrorBackupFile', 'No se puede encontrar el archivo {0}.{1}No se puede continuar.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'SelectFolder', 'Seleccione una carpeta para el backup.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'GenerandoVolumenes', 'Generando {0} volumenes comprimidos.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'BackupGenerado', 'Backup {0} generado y comprimido en {1}.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'FaltaSeleccion', 'Debe seleccionar un backup de la lista.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'RestoreWarning', 'Si continúa se eliminarán (kill) todos los procesos en ejecución en la base de datos.{0}Además se cerrarán todas las conexiones abiertas{0}¿Está seguro?')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'ErrorCarpeta', 'No se puede encontrar la carpeta {0}.{1}No se puede continuar.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'DescomprimiendoVolumenes', 'Descomprimiendo {0} volúmenes.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(1, 'Backup', 'RestoreCompleto', 'Restore completado desde {0}.{1}El sistema se cerrará.')

-- CambioCns
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioCns', 'CambioCns', 'Cambio Cadena de Conexión')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioCns', 'tsbOk', 'Ok')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioCns', 'tsbSalir', 'Salir')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioCns', 'lblServer', 'Servidor')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioCns', 'lblBase', 'Base de Datos')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioCns', 'TextoVacio', 'Debe completar todos los campos.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioCns', 'SinCambios', 'No ha hecho ningún cambio.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1 , 'CambioCns', 'CambioCnsWarning', 'Si acepta cambiará la base de datos a la que se conecta el sistema.{0}¿Está seguro?')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1 , 'CambioCns', 'StringNoValida', 'No es posible establecer una conexión con los datos ingresados.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1 , 'CambioCns', 'Error', 'Se generó la excepción: {0}')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'CambioCns', 'MenuLblBase', '[Servidor] / [Base de Datos]: {0} / {1}')