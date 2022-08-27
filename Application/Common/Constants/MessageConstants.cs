using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Application.Common.Constants
{
    public class MessageConstants
    {
        public const string FieldRequired = "Campo requerido '{PropertyName}'";
        public const string FieldDoesntExists = "No existe. '{PropertyName}'";
        public const string FieldInvalid = "Campo inválido. '{PropertyName}'";
        public const string FieldFormatInvalid = "Formato del campo invalido '{PropertyName}'";
        public const string FieldMustBeUnique = "Ya existe un registro con este nombre '{PropertyName}'";
        public const string FieldMaxLength = "'{PropertyName}' Excede la longitud máxima del campo.";
        public const string FullNameFieldMaxLength = "'{PropertyName}' La suma de nombre y apellidos excede la longitud máxima de los campos.";

        public const string ElectricPricesNotFound = "No se han encontrado los precios.";

        public const string InvlaidProcessType = "'{PropertyName}' Este proceso no pertenece al tipo de proceso: UpdateTechnicalAndAdministrativeConditions.";

        public const string HolderPayerNIF = "El Holder y el Payer deben ser distintos si HolderEqualsCustomer es false";
        public const string HolderPayerEmail = "El email del Holder y el Payer deben ser distintos si HolderEqualsCustomer es false";

        public const string PayerIbanNotExist = "El iban del payer no existe";
        public const string CompanyNotExist = "La compañia no existe";
        public const string OcsumNotExist = "ocsum no existe";
        public const string EnergySetupNotExist = "Configuracion de energia no existe";

        public const string UserExistOrInNav = "Usuario no existe o ya está dado de alta en NAV";
        public const string UserInNav = "Ya está dado de alta en NAV";

        public const string UserIDNIFDontMacht = "El userId y el NIF no pertecen al mismo usuario.";

        public const string UserDoesntExistOnAPI = "El usuario no se ha dado de alta en la web.";
        public const string UserDoesntExistOnNAV = "El usuario no se encuentra dado de alta en NAV";

        public const string PostalCodeDontExist = "El código postal no es válido.";

        public const string IsSubscribed = "Ya esta suscrito";
        public const string IsNotSubscribed = "No tiene suscripción";

        //Register sin Process
        public const string RegisterWithOutProcess = "El registro no tiene proceso asociado.";

        public const string AccountExists = "Ya existe una cuenta con este NIF/CIF/NIE";
        public const string AccountNIFExists = "Ya existe una cuenta con este identificador";
        public const string AccountRoleProfileRequired = "Debe asignar mínimo un conjunto de rol/Perfil.";
        public const string AccountRoleProfileInvalid = "Rol o roles incorrectos.";
        public const string AccountProfileInvalid = "Perfil o perfiles incorrectos.";
        public const string AccountDoesntExists = "Usuario no existe";

        public const string PurchInvoiceDoesntExists = "La factura de compra haun no se ha generado";

        public const string GetOpenContract = "Debe informar del código del contrato o del CUPS";

        public const string AccountPasswordIncorrect = "Contraseña incorrecta";
        public const string AccountPasswordMustBeNew = "La nueva contraseña debe ser distinta a la antigua";
        public const string AccountPasswordToken = "Solo se puede mandar: antigua contraseña o token. Pero es obligatorio mandar uno de ellos.";


        public const string RoleDoesntExists = "Rol no existe";
        public const string ProfileDoesntExists = "Perfil no existe";
        public const string PermitDoesntExists = "Permiso no existe";

        public const string ContractDoesntExists = "Contrato no existe.";
        public const string ContractTypeNotAllowedVBat = "Este contrato de suministro aún no tiene asociado un contrato activo de autoconsumo o el tipo de autoconsumo no es compatible con el servicio de batería virtual.";
       
        //public const string DuplicatedInactiveCupsBateriasVirtualesEntries = "El servicio de batería virtual para este contrato no podrá cancelarse hasta el día de mañana.";
        public const string MustNotExistActiveCupsBateriasVirtualesEntry = "El servicio de batería virtual para este contrato ya ha sido activado en las últimas 24h. Hasta mañana no podrá activarse de nuevo.";
        public const string DuplicatedActiveCupsBateriasVirtualesEntries = "El CUPS de este contrato ya aparece asocciado a un servicio de batería virtual activo.";

        public const string MustExistActiveCupsBateriasVirtualesEntry = "Este contrato NO tiene el servicio de batería virtual activo.";

        public const string ContractPendingProcess = "El contrato ya tiene un proceso pendiente.";
        public const string ContractWithOutPendingProcess = "El contrato no tiene un proceso pendiente.";
        public const string PendingProcess = "Ya hay un proceso pendiente de este tipo.";

        public const string InvoiceDoesntExists = "Factura no encontrada";
        public const string ContractInvoiceDoesntExists = "Factura no existe o no perteneciente al contrato.";

        public const string AddressDoesntExists = "La combinación de CP y municipio proporcionados no existe en la tabla de códigos postales de NAV";
        public const string AddressNavDoesntExists = "El cliente NAV no tiene una dirección de envio asociada";
        public const string AddressNotInCommercialArea = "Lo lamentamos, pero actualmente sólo comercializamos en la península. Estamos trabajando para ofrecerte el mejor servicio y pronto daremos cobertura a todo el territorio nacional.";
        public const string AddressValid = "La dirección introducida no parece válida";
        public const string SupplyAddressValidOwner = "La dirección de suministro no pertenece al usuario.";
        public const string FicalAddressValidOwner = "La dirección fiscal no pertenece al usuario.";
        public const string DeliveryAddressValidOwner = "La dirección de envio no pertenece al usuario.";

        public const string RegistrationAlreadyProccessed = "El registro ya ha sido gestionado";
        public const string RegistrationNoContractType = "No se pudo encontrar ningún contract type con los datos provistos";
        public const string MustHavePowerGtZero = "Ninguna de las potencias contratadas puede ser cero";

        public const string RegistrationPotMax450 = "La máxima de tus potencias contratadas supera los 450 kW. Por favor, ponte en contacto con nosotros y te haremos una oferta personalizada más acorde a tus necesidades.";

        public const string RegistrationRate = "Tarifa requerida";
        public const string PowerControlModeNotAllowed = "Modo control de potencia no permitido.";

        //Validate AMIGO Code
        public const string AMIGOValid = "El código amigo introducido parece no válido.";
        public const string AMIGODoesntExists = "El código amigo introducido parece no válido.";

        //Validate ATRPower
        public const string ATRInvalid = "Potencia no válida.";
        public const string ATRMaxPowerAllowed = "La potencia elegida supera la máxima potencia informada en tu boletín de instalación eléctrica. Si necesitás más potencia contáctanos y te atenderemos encantados.";
        public const string ATRTensionLevel = "Tu nivel de tensión no es compatible con la tarifa elegida.";
        public const string ATRPowerCountInvalid = "Número de potencias inválida";
        public const string ATRPowerInvalidRange = "Potencia inválida para el ATR ({0} ~ {1})";
        public const string ATRPowerHighMaxPower = "Ponte en contacto con nosotros para oferta personal";
        public const string ATRLowerThresholdMaxPower = "Para este tipo de suministro, la máxima potencia a contratar debe ser mayor de {0} kW";
        public const string ATRPowerGreaterThan = "Potencia debe ser mayor a {0}";
        public const string ATRPowerInvalid = "Potencia inválida";
        public const string ATRPowerIncreasingMonotonically = "Las potencias deben ser crecientes";
        public const string ATRAssociatedCosts = "Te informamos que cualquier alta de nuevo suministro o aumento de potencia tiene asociados unos costes regulados por parte de la distribuidora, que nosotros te repercutiremos sin ningún margen ni comisión por nuestra parte.";
        public const string ATRNoSipsInformation = "No disponemos actualmente de información sobre tu punto de suministro. Si estas solicitando un aumento de potencia, aparte de los derechos de enganche, es muy probable que tengas que abonar unos derechos de acceso y extensión según el aumento. Si quieres saber más, llámanos y resolveremos todas tus dudas.";
        public const string ATRRecommendedMinPower = "Estas contratando una potencia inferior a 1 kW en alguno de tus periodos. Con una potencia tan baja es probable que te 'salten los plomos' durante ese periodo. Si tienes dudas, contáctanos y te atenderemos encantados.";


        //Validate CUPS
        public const string CupsInNavision = "Este CUPS parece que ya está asociado a un contrato activo en nuestro sistema. Si tienes dudas llámanos y revisaremos tu caso.";
        public const string CupsInApi = "Este CUPS ya está vinculado a un proceso de contratación en curso. Accede a tu área cliente y continúa desde ahí el proceso.";
        public const string CupsInvalid = "El CUPS no parece válido.";
        public const string CupsNotInNavision = "Este CUPS parece que ya está asociado a un contrato existente en nuestro sistema. Por favor, ponte en contacto con nosotros y revisaremos tu caso.";
        public const string CupsIncoherenceInNavision = "El CUPS introducido no corresponde con el contrato que se intentando actualizar.";

        //Validate NIF
        public const string NIFInNavision = "Los datos introducidos corresponden a un cliente activo en nuestro sistema. Si ya tienes usuario puedes dar de alta un nuevo contrato desde tu área cliente. Llámanos al {0} si tienes algún problema.";
        public const string NIFInAPI = "Los datos introducidos estan relacionados con una tramitación en curso. Si aún no tiene un usuario web, llámanos al {0} y te ayudamos a darte de alta.";
        public const string NIFInvalid = "El NIF/NIE o CIF parece no válido.";

        //Validate IBAN
        public const string IBANInvalid = "El IBAN no tiene un formato válido";

        //Get SIPS Information
        public const string GetNIFInformation = "No se pudo obtener la información del SIPS";

        public const string DocHolderChange = "El formato de los ficheros del cambio de titularidad no es correcto";
        public const string DocSupplyBIE = "El formato de los ficheros del BIE no es correcto";
        public const string DocSelfSupplyBIE = "El formato de los ficheros del BIE de autoconsumo no es correcto";

        public const string HolderChangeFalse = "Se ha indicado el Holder pero HolderChange es false";

        // Debounce
        public const string EmailNotValid = "Email no valido";

        // Phone Number
        public const string PhoneNumberNotValid = "Teléfono no valido";

        //UpdateDocValidationValidator
        public const string RegistrationOrProcessRequired = "Se debe seleccionar un registro o un proceso para actualizar";
        //process
        public const string ProcessDone = "Ya estamos trabajando en tu solicitud. En breve nos podremos en contacto contigo";
        public const string ProcessDontExist = "El proceso no esta pendiento o no coinciden el CUPS con el procesId.";
        public const string ProcessCancelled = "Solicitud cancelada por el usuario";
        public const string ProcessError = "Hemos tenido algún problema con tu solicitud pero ya estamos trabajando para solucionarlo. En breve nos pondremos en contacto contigo.";

        public const string ProcessMissingBIEDocumentation = "Necesitamos que nos adjuntes el BIE de suministro para el contrato con dirección en {0}";
        public const string ProcessMissingHolderDocumentation = "Necesitamos que nos adjuntes la documentación acreditativa del cambio de titularidad para el contrato con dirección en {0}";
        //public const string ProcessMissingSelfSupplyDocumentation = "Necesitamos que nos adjuntes el BIE de autoconsumo para el contrato con dirección en {0}";
        public const string ProcessMissingSelfSupplyDocumentationAndalucia = "Para el contrato con dirección en {0}, necesitamos que nos adjuntes el Boletín con el sello RBT y firma de la Consejería de Empleo y Formación + Justificante de Presentación. IMPORTANTE: Puedes adjuntarnos toda la documentación unificada en un único documento o en fichero comprimido.";
        public const string ProcessMissingSelfSupplyDocumentationCatalunia = "Para el contrato con dirección en {0},necesitamos que nos adjuntes el Certificado de Instalación Eléctrica sellado + RAC (Registro Autoconsumo)+ RITSIC (Registro de Seguridad Industrial Cat). IMPORTANTE: Puedes adjuntarnos toda la documentación unificada en un único documento o en fichero comprimido.";
        public const string ProcessMissingSelfSupplyDocumentationMadrid = "Para el contrato con dirección en {0}, necesitamos que nos adjuntes el Boletín + Justificante de Presentación y/o COVE. IMPORTANTE: Puedes adjuntarnos toda la documentación unificada en un único documento o en fichero comprimido.";
        public const string ProcessMissingSelfSupplyDocumentationResto = "Boletín sellado por industria (COVE, firma electrónica o CSV). Ten en cuenta que a veces llevan una hoja con el Justificante de Presentación.";
        public const string ProcessWaitingForFixedDate = "Hemos recibido correctamente tu solicitud de contratación a fecha de {0} para el suministro con dirección en {1}. Llegado el momento nos pondremos en contacto con tu anterior comercializadora para realizar el cambio sin que te penalicen por ello.";
        public const string ProcessWaitingForSignaturit = "{0} aún no ha firmado el contrato con dirección de suministro en {1}";
        public const string ProcessWaitingForCheckDocumentation = "Estamos revisando la documentación que nos has facilitado para el contrato con dirección de suministro en {0}. Pronto tendrás noticias nuestras.";
        public const string ProcessWaitingErrorSignaturit = "No se pudo obtener información de la documentación firmada.";

        public const string ProcessWaitingForSignaturitUpdate = "Necesitamos que {0} firme las nuevas condiciones contractuales para completar tu solicitud";
        public const string ProcessWaitingForCheckDocumentationUpdate = "Ten en cuenta, que una vez nos adjuntes la documentación, procederemos a validarla. Pronto tendrás noticias nuestras.";
        public const string ProcessWaitingForFixedDateUpdate = "Hemos recibido correctamente tu solicitud de cambio de titularidad a fecha de {0} para el suministro con dirección en {1}. Llegado el momento nos pondremos en contacto con tu anterior comercializadora para realizar el cambio sin que te penalicen por ello.";
        
        public const string ProcessPending = "No tienes tareas pendientes y ya estamos trabajando en tu solicitud";
        public const string ProcessPendingTasks = "Para tramitar tu solicitud necesitamos que revises tus tareas pendientes.";


        public const string AltaContratoVirtualBatteryTitle = "Información batería virtual:";
        public const string AltaContratoVirtualBatteryText = "El contrato {0} con código universal de punto de suministro {1} se ha incluido en tu servicio de batería virtual con fecha de activación {2}";

        public const string PromoVirtualBatteryTitle = "Tienes disponible el tutorial para activar la Batería Virtual.";
        public const string PromoVirtualBatteryText = "Descárgate nuestro tutorial y sigue las instrucciones para empezar a disfrutar ya mismo del servicio.";
        public const string PromoVirtualBatteryUrl = "https://www.proximaenergia.com/wp-content/uploads/2022/04/202204-Tutorial-Bateria-Virtual.pdf";

        public const string InfoVirtualBatteryTitle = "Tienes disponible la guía para conocer más sobre la Batería Virtual.";
        public const string InfoVirtualBatteryText = "Descárgate nuestra guía sobre la batería virtual e infórmate de todo lo que necesitas saber sobre este servicio.";
        public const string InfoVirtualBatteryUrl = "https://www.proximaenergia.com/wp-content/uploads/2022/04/20220424-Bateria-Virtual.pdf";


        public const string SelfSupplyTypeNotValid = "Estimado cliente, la modalidad de vertido de excedentes seleccionada no es contratable a través de la web. Por favor, ponte en contacto con nuestro departamento de atención al cliente y te atenderemos encantados. Disculpa las molestias.";

    }
}
