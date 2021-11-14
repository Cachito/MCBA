DELETE Leyendas
WHERE IdIdioma = 2
GO

-- ESPERANTO
-- splash
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Splash', 'CheckIntegridad', 'Integreco-Kontrolo.')

-- login
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'lblUsuario', 'Uzanto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'lblContra', 'Pasvorto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'lblEmail', 'Retpoŝto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'lblIdioma', 'Idiomo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'btnOk', 'Bone')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'btnCancel', 'Nuligi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'btnRecuperarContra', 'Rekuperu Pasvorton')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'UsuarioBloqueado', 'Uzanto blokita')
   
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'LoginIncorrecto', 'Malĝusta uzantnomo aŭ pasvorto.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'RestoreWarning', 'Se vi daŭrigos, via pasvorto estos rekomencigita kaj retpoŝto estos sendita al {0}.{1}Ĉu vi certas?')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'MailWarning', 'La indikita uzanto ne havas asignitan retpoŝtadreson.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'RestoreBody', '{0}: La nova pasvorto estas sendita al vi: "{1}" (Sen la citaĵoj).{2}Ne dividu ĉi tiun retpoŝton.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'RestoreSubject', 'Buongiorno S. A.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'RestoreSent', 'La poŝto estis sendita.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'RestoreSaved', 'La poŝto estis konservita en {0}.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'LoginFail', 'Malĝusta ensaluto.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Login', 'Ingreso', 'Ensalutu al la Sistemo.')

-- Menu
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'Menu', '{0} - Uzanto.: {1} {2}')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiMaestros', 'Majstraj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiCondicionesIva', 'Kondiĉoj pri VAT')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiProvincias', 'Provincoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiLocalidades', 'Lokoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiBancos', 'Bankoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiTiposCuenta', 'Bankokontaj Tipoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiUnidades', 'Unuoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiArchivo', 'Dosiero')    

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiRemitentes', 'Sendintoj')    

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiVehiculos', 'Veturiloj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiChoferes', 'Ŝoforoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiProductos', 'Produktoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiClientes', 'Klientoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiMovimientos', 'Movadoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiStock', 'Provizo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiVentas', 'Vendoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiLiquidaciones', 'Likvidiĝoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiGestion', 'Administrado')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiUsuarios', 'Uzantoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiPermisosUsuarios', 'Permesoj al Uzantoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiPermisosFamilias', 'Familiaj Permesoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiFamilias', 'Familioj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiBackup', 'Rezerva')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiBitacoras', 'Binacle')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiCambioContra', 'Ŝanĝo de pasvorto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiCambioCns', 'Konekta Ĉeno Ŝanĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiReparar', 'Ripari Integrecon')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'tsmiSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'Salir', 'Sistemeliro.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Menu', 'lblBase', '[Servilo] / [Datumbazo]: {0}')

-- Busqueda
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Busqueda', 'Busqueda', 'Serĉu - {0}')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Busqueda', 'tsbOk', 'Bone')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Busqueda', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Busqueda', 'lblBusqueda', 'Enigu tekston por serĉi en {0}.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Busqueda', 'TextoVacio', 'Vi devas enigi tekston por serĉi.')

-- Condiciones de IVA
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CondicionesIva', 'CondicionesIva', 'Kondiĉoj pri VAT')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CondicionesIva', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CondicionesIva', 'lblDescripcion', 'Priskribo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CondicionesIva', 'lblLetra', 'Faktura Letero')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CondicionesIva', 'lblPorcentaje', 'Procento')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CondicionesIva', 'chkDiscrimina', 'Diskriminacia VAT')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CondicionesIva', 'tsbNew', 'Nova')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CondicionesIva', 'tsbDelete', 'Forigi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CondicionesIva', 'tsbEdit', 'Redaktu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CondicionesIva', 'tsbSave', 'Konservu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CondicionesIva', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CondicionesIva', 'tsbUndo', 'Malfari')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CondicionesIva', 'tsbPrint', 'Presi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CondicionesIva', 'tsbBuscar', 'Serĉi')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CondicionesIva', 'tsbPrevious', 'Antaŭa paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CondicionesIva', 'tsbNext', 'Sekva paĝo')	
    
-- Bancos
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bancos', 'Bancos', 'Bankoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bancos', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bancos', 'lblDescripcion', 'Priskribo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bancos', 'tsbNew', 'Nova')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bancos', 'tsbDelete', 'Forigi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bancos', 'tsbEdit', 'Redaktu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bancos', 'tsbSave', 'Konservu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bancos', 'tsbSalir', 'Eliri')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bancos', 'tsbBuscar', 'Serĉi')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bancos', 'tsbPrint', 'Presi')		

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bancos', 'tsbUndo', 'Malfari')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bancos', 'tsbPrevious', 'Antaŭa paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bancos', 'tsbNext', 'Sekva paĝo')

-- Familias
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'Familias', 'Familioj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'lblNombre', 'Nomo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'chkActivo', 'Aktiva')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'tsbNew', 'Nova')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'tsbDelete', 'Forigi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'tsbEdit', 'Redaktu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'tsbSave', 'Konservu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'tsbSalir', 'Eliri')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'tsbBuscar', 'Serĉi')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'tsbPrint', 'Presi')		

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'tsbUndo', 'Malfari')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'tsbPrevious', 'Antaŭa paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'tsbNext', 'Sekva paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'FaltaNombre', 'Vi devas enigi nomon.{0}')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'ErrorAlGuardar', 'Estis eraro konservante.{0}Bonvolu reprovi poste.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'NoEncontrado', 'La serĉita registro ne troveblas.{0}Bonvolu reŝargi la kradon')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Familias', 'DesactivarWarning', 'Malŝalti la familion forigos uzantrilatojn kaj permesojn.{0}Ĉu vi certas?')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Familias', 'NoSePuedeEliminar', 'Familio {0} ne povas esti forigita ĉar permesoj restas neasignitaj.')

-- Bitácora
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bitacoras', 'Bitacora', 'Binacle')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bitacoras', 'lblUsuario', 'Uzanto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bitacoras', 'lblCriticidad', 'Kritiko')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bitacoras', 'lblDesde', 'Dato De')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bitacoras', 'lblHasha', 'Dato Ĝis')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bitacoras', 'tsbSalir', 'Eliri')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bitacoras', 'tsbBuscar', 'Serĉi')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bitacoras', 'tsbImprimir', 'Presi')			

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bitacoras', 'FaltaCriticidad', 'Vi devas elekti kritikecon.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bitacoras', 'FaltaUsuario', 'Vi devas elekti uzanton.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Bitacoras', 'LapsoInvalido', 'La enigita periodo estas nevalida.')

-- ReporteBitacora
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'ReporteBitacora', 'ReporteBitacora', 'Raporto Bitacora')

-- CambioPassword
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioPassword', 'CambioPassword', 'Pasvorta ŝanĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioPassword', 'lblUsuario', 'Uzanto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioPassword', 'lblContraActual', 'Aktuala Pasvorto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioPassword', 'lblContraNueva', 'Nova pasvorto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioPassword', 'lblRepetir', 'Ripetu Novan Pasvorton')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioPassword', 'tsbSalir', 'Eliri')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioPassword', 'tsbSave', 'Konservu')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioPassword', 'ClaveActual', 'Vi devas enigi la nunan pasvorton.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioPassword', 'ClaveNueva', 'Vi devas enigi novan pasvorton.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioPassword', 'ClaveIncorrecta', 'La nuna pasvorto enmetita estas malĝusta.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioPassword', 'ClaveDistinta', 'La eniritaj pasvortoj ne samas.')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioPassword', 'ErrorCheckPassword', 'Eraro okazis dum kontrolado de la pasvorto.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioPassword', 'UserBlocked', 'Uzanto {0} estis blokita.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioPassword', 'PasswordChanged', 'Uzanta pasvorto {0} estis ŝanĝita.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioPassword', 'CloseSystem', 'La sistemo haltos.')	

-- Choferes
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Choferes', 'Choferes', 'Ŝoforoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Choferes', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Choferes', 'lblNombre', 'Nomo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Choferes', 'lblApellido', 'Familia Nomo')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Choferes', 'lblDni', 'NID')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Choferes', 'lblRemitente', 'Sendinto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Choferes', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Choferes', 'tsbNew', 'Nova')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Choferes', 'tsbDelete', 'Forigi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Choferes', 'tsbEdit', 'Redaktu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Choferes', 'tsbSave', 'Konservu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Choferes', 'tsbUndo', 'Malfari')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Choferes', 'tsbPrevious', 'Antaŭa paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Choferes', 'tsbNext', 'Sekva paĝo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Choferes', 'tsbPrint', 'Presi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Choferes', 'tsbBuscar', 'Serĉi')	
		
-- Clientes
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'Clientes', 'Klientoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'lblNombre', 'Nomo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'lblApellido', 'Familia Nomo')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'lblDomicilio', 'Adreso')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'lblDni', 'Dokumento')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'lblCondicion', 'VAT-kondiĉo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'lblProvincia', 'Provinco')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'lblLocalidad', 'Loko')		

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'tsbNew', 'Nova')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'tsbDelete', 'Forigi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'tsbEdit', 'Redaktu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'tsbSave', 'Konservu')
		
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'tsbUndo', 'Malfari')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'tsbPrevious', 'Antaŭa paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'tsbNext', 'Sekva paĝo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'tsbPrint', 'Presi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'tsbBuscar', 'Serĉi')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'tsbNewTelefono', 'Nova')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'tsbDeleteTelefono', 'Forigi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Clientes', 'tsbEditTelefono', 'Redaktu')

-- Facturas
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'Facturas', 'Fakturoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'lblPtoVenta', 'Vendloko')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'lblCliente', 'Kliento')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'lblRazonSocial', 'Komerca nomo')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'lblLetra', 'Letero')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'lblNumero', 'Numero')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'lblFecha', 'Dato')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'lblCuit', 'UIIK')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'lblDomicilio', 'Adreso')		
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'lblTotal', 'Entute')			

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'tsbNew', 'Nova')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'tsbDelete', 'Forigi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'tsbSave', 'Konservu')
		
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'tsbPrint', 'Presi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'tsbBuscar', 'Serĉi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'tsbUndo', 'Malfari')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'tsbPrevious', 'Antaŭa paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'tsbNext', 'Sekva paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'tsbNewItem', 'Nova')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'tsbDeleteItem', 'Forigi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Facturas', 'tsbEditItem', 'Redaktu')

-- FacturasItems
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'FacturasItems', 'FacturasItems', 'Ero')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'FacturasItems', 'lblLote', 'Lot')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'FacturasItems', 'lblDescripcion', 'Priskribo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'FacturasItems', 'lblUnidad', 'Unueco')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'FacturasItems', 'lblCantidad', 'Kvanto')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'FacturasItems', 'lblUnitario', 'Unueca')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'FacturasItems', 'lblTotal', 'Entute')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'FacturasItems', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'FacturasItems', 'tsbOk', 'Bone')

-- FacturasBuscar
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'FacturasBuscar', 'FacturasBuscar', 'Serĉu Fakturon')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'FacturasBuscar', 'lblCliente', 'Kliento')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'FacturasBuscar', 'lblLetra', 'Letero')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'FacturasBuscar', 'lblFecha', 'Dato')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'FacturasBuscar', 'lblNumero', 'Numero')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'FacturasBuscar', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'FacturasBuscar', 'tsbOk', 'Bone')

-- Liquidacion
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'Liquidacion', 'Kompromiso')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'lblRemitente', 'Sendinto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'lblPtoducto', 'Produkto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'lblVenta', 'Vendo')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'lblTotalVentas', 'Totalaj vendoj')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'lblLote', 'Lot')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'gbComisiones', 'Komisiono')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'rbComisionProducto', 'Produkto')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'rbComisionRemitente', 'Sendinto')		
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'lblDecomiso', 'Konfisko')			
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'lblComision', 'Totala Komisiono')				

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'lblFecha', 'Fecha')				

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'gbPrecios', 'Prezo')				

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'rbPrecioPromedio', 'Averaĝa')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'rbPrecioPlaza', 'Kvadrato')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'lblActa', 'Kapto-Leĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'lblAPagar', 'Sumo Pagenda')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'tsbNew', 'Nova')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'tsbDelete', 'Forigi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'tsbEdit', 'Redaktu')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'tsbSave', 'Konservu')
		
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'tsbPrint', 'Presi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Liquidacion', 'tsbBuscar', 'Serĉi')

-- Localidades
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Localidades', 'Localidades', 'Lokoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Localidades', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Localidades', 'lblDescripcion', 'Priskribo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Localidades', 'lblProvincia', 'Provinco')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Localidades', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Localidades', 'tsbNew', 'Nova')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Localidades', 'tsbDelete', 'Forigi')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Localidades', 'tsbEdit', 'Redaktu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Localidades', 'tsbSave', 'Konservu')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Localidades', 'tsbUndo', 'Malfari')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Localidades', 'tsbPrevious', 'Antaŭa paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Localidades', 'tsbNext', 'Sekva paĝo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Localidades', 'tsbPrint', 'Presi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Localidades', 'tsbBuscar', 'Serĉi')	

-- Provincias
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Provincias', 'Provincias', 'Provincoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Provincias', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Provincias', 'lblDescripcion', 'Priskribo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Provincias', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Provincias', 'tsbNew', 'Nova')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Provincias', 'tsbDelete', 'Forigi')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Provincias', 'tsbEdit', 'Redaktu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Provincias', 'tsbSave', 'Konservu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Provincias', 'tsbUndo', 'Malfari')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Provincias', 'tsbPrevious', 'Antaŭa paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Provincias', 'tsbNext', 'Sekva paĝo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Provincias', 'tsbPrint', 'Presi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Provincias', 'tsbBuscar', 'Serĉi')	

-- Productos
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Productos', 'Productos', 'Produktoj')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Productos', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Productos', 'lblDescripcion', 'Priskribo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Productos', 'lblVariedad', 'Vario')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Productos', 'lblComision', 'Komisiono (%)')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Productos', 'lblIva', 'VAT (%)')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Productos', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Productos', 'tsbNew', 'Nova')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Productos', 'tsbDelete', 'Forigi')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Productos', 'tsbEdit', 'Redaktu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Productos', 'tsbSave', 'Konservu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Productos', 'tsbUndo', 'Malfari')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Productos', 'tsbPrevious', 'Antaŭa paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Productos', 'tsbNext', 'Sekva paĝo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Productos', 'tsbPrint', 'Presi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Productos', 'tsbBuscar', 'Serĉi')

-- RemitenteComisiones
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'RemitenteComisiones', 'RemitenteComisiones', 'Komisionoj')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'RemitenteComisiones', 'lblRemitente', 'Sendinto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'RemitenteComisiones', 'lblProducto', 'Produkto')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'RemitenteComisiones', 'lblComision', 'Komisiono (%)')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'RemitenteComisiones', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'RemitenteComisiones', 'tsbOk', 'Bone')

-- Remitentes
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'Remitentes', 'Sendintoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'lblNombre', 'Nomo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'lblApellido', 'Familia nomo')	
	    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'lblCuit', 'UIIK')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'lblCondicion', 'VAT-kondiĉo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'lblBanco', 'Banko')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'lblCuenta', 'Bankokonto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'lblTipoCuenta', 'Kontospeco')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'lblProvincia', 'Provinco')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'lblDomicilio', 'Adreso')	
		
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'lblLocalidad', 'Loko')		

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'tsbNew', 'Nova')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'tsbDelete', 'Forigi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'tsbEdit', 'Redaktu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'tsbSave', 'Konservu')
		
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'tsbNewComision', 'Nova')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'tsbDeleteComision', 'Forigi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'tsbEditComision', 'Redaktu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'tsbUndo', 'Malfari')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'tsbPrevious', 'Antaŭa paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'tsbNext', 'Sekva paĝo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'tsbPrint', 'Presi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Remitentes', 'tsbBuscar', 'Serĉi')	

-- ReporteCaja
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'ReporteCaja', 'ReporteCaja', 'Monraporto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'ReporteCaja', 'lblFecha', 'Dato')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'ReporteCaja', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'ReporteCaja', 'tsbProcesar', 'Procezo')

-- Usuarios
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'Usuarios', 'Uzantoj')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'lblNombre', 'Nomo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'lblApellido', 'Fam. nomo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'lblEmail', 'Retpoŝto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'lblUsuario', 'Uzanto')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'lblIdioma', 'Idiomo')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'lblContra1', 'Pasvorto')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'lblContra2', 'Pasvorto')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'chkActivo', 'Aktiva')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'tsbUndo', 'Malfari')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'tsbNew', 'Nova')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'tsbDelete', 'Forigi')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'tsbEdit', 'Redaktu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'tsbSave', 'Konservu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'tsbPrint', 'Presi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'tsbBuscar', 'Serĉi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'tsbPrevious', 'Antaŭa paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'tsbNext', 'Sekva paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'tsbRestorePass', 'Restarigi Pasvorton')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'tsbChangePass', 'Ŝanĝi Pasvorton')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'FaltaUsuario', 'Vi devas eniri uzanton.')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'FaltaNombre', 'Vi devas enigi nomon.')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'FaltaApellido', 'Vi devas enigi familian nomon.')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'FaltaEmail', 'Vi devas enigi retpoŝton.')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'FaltaPassword', 'Vi devas enigi pasvorton.')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'FaltaConfirmar', 'Vi devas konfirmi pasvorton.')	
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'PasswordDistinto', 'La eniritaj pasvortoj estas malsamaj.')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'FaltaIdioma', 'Vi devas elekti lingvon.')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'RevisarErrores', 'Bonvolu revizii la indikitajn numerojn.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'NoEncontrado', 'La uzanto ne estas trovita.{0}Bonvolu kontakti la administranton.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'ErrorAlGuardar', 'La ŝanĝoj ne povis esti konservitaj.{0}Bonvolu kontakti la administranton.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'NewUserSubject', 'Buongiorno S. A.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'NewUserBody', 'Viaj atestiloj estas senditaj al vi: uzanto: {0}; pasvorto: {1}.{2} Ne dividu ĉi tiun retpoŝton.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'NewUserSent', 'La poŝto estis sendita.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'NewUserSaved', 'La poŝto estis konservita en {0}.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'MailWarning', 'La uzanto ne havas asignitan retpoŝtan adreson.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'RestoreWarning', 'Se vi daŭrigos, via pasvorto estos restarigita kaj retpoŝto estos sendita al {0}.{1} Ĉu vi certas? ')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'RestoreSubject', 'Buongiorno S. A.')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'RestoreBody', '{0}: La nova ŝlosilo estas sendita al vi: "{1}" (Sen citiloj).{2}Ne dividu ĉi tiun retpoŝton.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'RestoreSent', 'La poŝto estis sendita.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'RestoreSaved', 'La poŝto estis konservita en {0}.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'EmailExistente', 'La retpoŝto enigita jam ekzistas.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'Activar', 'Vi reaktivigos neaktivan uzanton.{0}Ĉu vi certas?')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'Desactivar', 'Vi malaktivigas uzanton. {0} Iliaj transakcioj ne estos perditaj sed ili ne povos reeniri la sistemon. Rilatoj kun permesoj kaj familioj estos forigitaj. {0} Ĉu vi certas?')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'EliminarSelf', 'Vi ne povas forigi la uzanton, kun kiu vi eniris la sistemon.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'PermisosHuerfanos', 'Vi ne povas forigi la uzanton {0} ĉar estas neasignitaj aŭ neadministrataj permesoj.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Usuarios', 'EmailNoValido', 'Nevalida retadreso.')

-- Unidades
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Unidades', 'Unidades', 'Unuoj')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Unidades', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Unidades', 'lblDescripcion', 'Priskribo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Unidades', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Unidades', 'tsbNew', 'Nova')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Unidades', 'tsbDelete', 'Forigi')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Unidades', 'tsbEdit', 'Redaktu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Unidades', 'tsbSave', 'Konservu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Unidades', 'tsbUndo', 'Malfari')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Unidades', 'tsbPrevious', 'Antaŭa paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Unidades', 'tsbNext', 'Sekva paĝo')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Unidades', 'tsbPrint', 'Presi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Unidades', 'tsbBuscar', 'Serĉi')

-- TiposCuenta
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'TiposCuenta', 'TiposCuenta', 'Kontaj Tipoj')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'TiposCuenta', 'lblId', 'Id')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'TiposCuenta', 'lblDescripcion', 'Priskribo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'TiposCuenta', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'TiposCuenta', 'tsbNew', 'Nova')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'TiposCuenta', 'tsbDelete', 'Forigi')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'TiposCuenta', 'tsbEdit', 'Redaktu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'TiposCuenta', 'tsbSave', 'Konservu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'TiposCuenta', 'tsbUndo', 'Malfari')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'TiposCuenta', 'tsbPrevious', 'Antaŭa paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'TiposCuenta', 'tsbNext', 'Sekva paĝo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'TiposCuenta', 'tsbPrint', 'Presi')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'TiposCuenta', 'tsbBuscar', 'Serĉi')	

-- Stock
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'Stock', 'Provizo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'lblLote', 'Lot')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'lblRemitente', 'Sendinto')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'lblProducto', 'Produkto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'lblOrigen', 'Origino')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'lblFecha', 'Dato')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'lblUnidad', 'Unueco')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'lblCantidad', 'Kvanto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'lblGuia', 'Transp. Gvidilo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'lblChofer', 'Ŝoforo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'tsbNew', 'Nova')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'tsbDelete', 'Forigi')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'tsbEdit', 'Redaktu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'tsbSave', 'Konservu')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'tsbBuscar', 'Serĉi')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'tsbPrint', 'Presi')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'tsbUndo', 'Malfari')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'tsbPrevious', 'Antaŭa paĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Stock', 'tsbNext', 'Sekva paĝo')

-- StockBuscar
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'StockBuscar', 'StockBuscar', 'Akciaj Filtriloj')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'StockBuscar', 'lblRemitente', 'Sendinto')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'StockBuscar', 'lblProducto', 'Produkto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'StockBuscar', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'StockBuscar', 'tsbOk', 'Bone')

-- PermisosUsuarios
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'PermisosUsuarios', 'PermisosUsuarios', 'Permesoj al Uzantoj')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'tsbSave', 'Konservu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'lblUsuario', 'Uzanto')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'gbFamilias', 'Familioj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'lblDisponiblesF', 'Haveblaj Familioj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'lblAsignadasF', 'Asignitaj Familioj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'btnAddFamilia', '')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'btnRemoveFamilia', '')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'gbPermisos', 'Permesoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'lblDisponiblesP', 'Haveblaj Permesoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'lblAsignadasP', 'Atribuitaj Permesoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'SinUsuario', 'Vi devas elekti uzanton.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'SinSeleccion', 'Vi devas elekti iun familion aŭ iun permeson.')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'FaltaPermiso', 'Vi devas elekti tajpi ĉiujn asignitajn permesojn.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'ErrorAlGuardar', 'La ŝanĝoj ne estis konservitaj.{0}{1}')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'NoSePuedeQuitarPermiso', 'Ne eblas forigi la permeson(j)n {0} ĉar aliaj uzantoj ne havas ĝin.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'ErrorCargaGrillas', 'Eraro dum ŝarĝo de kradoj. {0} {1}')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosUsuarios', 'NoSePuedeQuitarFamilia', 'Ne eblas forigi la familio(j)n {0} ĉar estas neasignitaj permesoj.')

-- PermisosFamilias
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'PermisosFamilias', 'PermisosFamilias', 'Familiaj Permesiloj')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'tsbSave', 'Konservu')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'lblFamilia', 'Familio')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'gbUsuarios', 'Uzantoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'lblDisponiblesU', 'Haveblaj Uzantoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'lblAsignadosU', 'Asignitaj Uzantoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'btnAddUsuario', '')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'btnRemoveUsuario', '')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'gbPermisos', 'Permesoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'lblDisponiblesP', 'Haveblaj Permesoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'lblAsignadasP', 'Atribuitaj Permesoj')	

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'SinFamilia', 'Vi devas elekti familion.')	
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'SinSeleccion', 'Vi devas elekti iun uzanton aŭ iun permeson.')
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'FaltaPermiso', 'Vi devas elekti tajpi ĉiujn asignitajn permesojn.')
    
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'ErrorAlGuardar', 'Ŝanĝoj ne estis konservitaj.{0}{2}')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'NoSePuedeQuitarPermiso', 'Ne eblas forigi la permeson(j)n {0} ĉar aliaj familioj ne havas ĝin.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'PermisosFamilias', 'NoSePuedeQuitarUsuario', 'Ne eblas forigi la uzanto(j)n {0} ĉar estas neasignitaj permesoj.')

-- Backup
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'Backup', 'Backup', 'Rezervo')
	
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'tsbProcesar', 'Rezervo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'tsbRestore', 'Restaŭri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'lblDestino', 'Sekurkopioj dosierujo.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'lblAvance', 'Progresoj')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'lblVolumen', 'Volumo en Procezo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'FaltaCarpeta', 'Vi devas elekti rezervan dosierujon.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'CarpetaNoExiste', 'La indikita dosierujo ne ekzistas aŭ ne estas alirebla.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'GenerandoBackup', 'Generando sekurkopio.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'ErrorBackupFile', 'Ne povas trovi la dosieron {0}.{1}Ne povas daŭrigi.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'SelectFolder', 'Elektu dosierujon por la sekurkopio.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'GenerandoVolumenes', 'Generando {0} volumenoj komprimitaj.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'BackupGenerado', 'Rezerva {0} generita kaj komprimita en {1}.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'FaltaSeleccion', 'Vi devas elekti sekurkopion el la listo.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'RestoreWarning', 'Se vi daŭrigos, ĉiuj procezoj kurantaj en la datumbazo estos ĉesigitaj (kill).{0}Ankaŭ ĉiuj malfermitaj konektoj estos fermitaj{0}Ĉu vi certas?')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'ErrorCarpeta', 'Ne povas trovi dosierujon{0}.{1}Ne povas daŭrigi.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'DescomprimiendoVolumenes', 'Malfermi {0} volumojn.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
	VALUES(2, 'Backup', 'RestoreCompleto', 'Restarigo finiĝis de {0}.{1}La sistemo malŝaltos.')

-- CambioCns
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioCns', 'CambioCns', 'Konekta Ĉeno Ŝanĝo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioCns', 'tsbOk', 'Bone')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioCns', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioCns', 'lblServer', 'Servilo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioCns', 'lblBase', 'Datumbazo')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioCns', 'TextoVacio', 'Vi devas plenigi ĉiujn kampojn.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioCns', 'SinCambios', 'Vi faris neniujn ŝanĝojn.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioCns', 'CambioCnsWarning', 'Akceptante ŝanĝos la datumbazon al kiu la sistemo konektiĝas.{0}Ĉu vi certas?')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioCns', 'StringNoValida', 'Ne eblas establi konekton kun la enmetitaj datumoj.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioCns', 'Error', 'La escepto estis ĵetita: {0}')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'CambioCns', 'MenuLblBase', '[Servidor] / [Base de Datos]: {0}')

-- RepararIntegridad
INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'RepararIntegridad', 'RepararIntegridad', 'Ripari Integrecon')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'RepararIntegridad', 'btnOk', 'Bone')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'RepararIntegridad', 'tsbSalir', 'Eliri')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'RepararIntegridad', 'lblWarning', 'Premante la butonon malsupre regeneros ĉiujn kontrolciferojn (vertikala kaj horizontala).')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'RepararIntegridad', 'Warning', 'Ĉu vi certas?')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'RepararIntegridad', 'Exito', 'Integreco riparita sukcese.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'RepararIntegridad', 'Error', 'Oni provis ripari la integrecon sed eraro okazis.')

INSERT INTO Leyendas(IdIdioma, Modulo, Tag, Leyenda)
    VALUES(2, 'RepararIntegridad', 'Excepcion', 'Oni provis ripari la integrecon sed la escepto {0} estis ĵetita')