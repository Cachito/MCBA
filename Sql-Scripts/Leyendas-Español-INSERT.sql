DELETE Leyendas 
WHERE IdIdioma = 1
GO

-- CASTELLANO
-- splash
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Splash', 'CheckIntegridad', 'Comprobando Integridad')

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
    VALUES(1, 'Login', 'RestoreBody', 'Se le envía la clave nueva: "{0}" (Sin las comillas).{1}No comparta este correo.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'RestoreSent', 'Se ha enviado el correo.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Login', 'RestoreSaved', 'Se ha guardado el correo en {0}.')

-- Menu
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
    VALUES(1, 'Menu', 'tsmiPermisos', 'Permisos')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiBackup', 'Backup')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiBitacora', 'Bitácora')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiCambioContra', 'Cambio de Contraseña')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Menu', 'tsmiSalir', 'Salir')

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
    VALUES(1, 'Bancos', 'tsbImprimir', 'Imprimir')			    

-- Bitácora
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacora', 'Bitacora', 'Bitácora')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacora', 'lblUsuario', 'Usuario')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacora', 'lblCriticidad', 'Criticidad')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacora', 'lblDesde', 'Fecha Desde')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacora', 'lblHasha', 'Fecha Hasha')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacora', 'tsbSalir', 'Salir')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacora', 'tsbBuscar', 'Buscar')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Bitacora', 'tsbImprimir', 'Imprimir')			

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
    VALUES(1, 'CambioPassword', 'tsbRestaurar', 'Restaurar')			

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
    VALUES(1, 'Usuarios', 'tsbFiltro', 'Filtro')

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
    VALUES(1, 'Usuarios', 'NewUserBody', 'Se le envían sus credenciales de usuario: {0}/{1}.{2}No comparta este correo.')

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
    VALUES(1, 'Usuarios', 'RestoreBody', 'Se le envía la clave nueva: "{0}" (Sin las comillas).{1}No comparta este correo.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'RestoreSent', 'Se ha enviado el correo.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(1, 'Usuarios', 'RestoreSaved', 'Se ha guardado el correo en {0}.')

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