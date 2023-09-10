# Autotransportes UNED #
## Temas de Estudio ##
* Particularidades del lenguaje C#
* Manejo de excepciones en C#
* Conceptos de Interfaz Gráfica
* Subprocesamiento múltiple
* Bases de datos y componentes ADO.NET
* Colecciones
* Redes
## Software de Desarrollo ##
Visual Studio Community 2022 (C#, .Net Framework 4.8 o Net 6.0), SQL Server, SQL Management Studio) 
## Desarrollo ##
Debido al éxito que se ha obtenido con la segunda versión del sistema de información entregada para la empresa AUTOTRANSPORTES-UNED, usted ha sido contratado nuevamente para hacer mejoras en su sistema de información, entre las cuales se destaca que la información, sea almacenada de forma permanente en una base de datos SQL Server. A la fecha los conductores no saben cómoestará su rol, hasta que lleguen a las oficinas centrales de le empresa, y los supervisores de forma manual, tienen que estar realizando los respectivos roles. 
Por lo anterior, se requiere incorporar nuevas funcionalidades que permitan a los conductores, conocer cuál será su rol, y los supervisores, realizar los roles correspondientes.
El sistema para desarrollar debe estar compuesto mínimo por dos proyectos; un cliente y un servidor, ambos deben comunicarse a través de la red mediante el protocolo TCP. 
El proyecto cliente será utilizado tanto por los conductores normales como supervisores, con el fin de verificar mis rutas o todas las rutas en el caso de los supervisores, así como crear los respectivos roles, mientras que el proyecto servidor será utilizado por un único administrador en las oficinas centrales para dar mantenimiento a las funcionalidades de Registrar Terminales, Registrar Conductores, Registrar Autobuses y Tarifas. Toda la información debe ser almacenada en una base de datos SQL Server.

![ezgif com-video-to-gif (4)](https://github.com/josuecross/dotnet-autotransportes-UNED/assets/85675115/fdb2e2a0-baf5-45da-99fe-8890a7f9b54a)


## El proyecto servidor debe de cumplir con lo siguiente: ##
- Debe implementar un servidor que escuche y responda las solicitudes de red de múltiples clientes
TCP de forma simultánea utilizando subprocesamiento múltiple.
- Debe utilizar sockets en la dirección 127.0.0.1 y el puerto 14100 para escuchar solicitudes.
- La aplicación cliente debe almacenar toda la información en base de datos SQL Server
- El servidor almacena en la base de datos toda la información indicada desde la aplicación cliente
por los usuarios clientes.
- El servidor consulta y almacena en la base de datos la información solicitada por los clientes.
- Solo la aplicación servidor se comunica con la base de datos, la aplicación cliente no tiene
conexión con la base de datos.
- El servidor debe ser utilizado por un único usuario administrador en las oficinas centrales, el cual
no requiere registrarse, tampoco requiere usuario y contraseña.
- Debe tener una pantalla principal donde muestre en bitácora todos los eventos enviados por
todos los clientes conectados en tiempo real, como, por ejemplo: conexión al servidor,
desconexión, registro de reserva, consulta de reserva.
- Siempre debe ser visible la cantidad de clientes conectados
  
El servidor debe contar con un menú principal con las siguientes opciones
1. Registrar Terminales
2. Registrar Conductores
3. Registrar Autobúses
4. Registrar Tarifas

![clientes-conectados](https://github.com/josuecross/dotnet-autotransportes-UNED/assets/85675115/a6ac1956-69dc-4b16-873e-f896e5f9d214)


## El proyecto cliente debe cumplir con lo siguiente: ##
- Debe ser utilizado por los conductores para conectarse con el servidor central y conocer sus rutas asignadas y en el caso de los supervisores para crear los roles.
- Debe tener una opción para conectarse y desconectarse del servidor.
- Al iniciar el programa cliente debe solicitar el número de identificación del cliente
  * Se debe validar que el conductor exista en base de datos antes de mostrar las funcionalidades de la aplicación cliente.
  * La aplicación cliente envía al servidor la solicitud de verificación de la identificación del conductor que ingresó.
  * El conductor debe haber sido registrado previamente por el administrador en el servidor.
  * Si la identificación existe, es decir, es un conductor registrado y activo se permite el ingreso a la aplicación cliente.

Una vez que el conductor ha sido validado, en la aplicación cliente se debe mostrar el nombre del conductor con los dos apellidos, esta información debe ser siempre visible en la aplicación cliente. Además, una vez que el cliente ha sido validado, en la aplicación cliente se muestran las funcionalidades de la aplicación dependiendo del perfil de la persona que se conectó:
Para un Conductor Supervisor deberá habilitar las siguientes opciones:
- Registrar Roles
- Consultar Roles
Para un Conductor Normal:
- Consultar Roles

![registro-cliente](https://github.com/josuecross/dotnet-autotransportes-UNED/assets/85675115/714e2710-b66f-48d8-afb4-9de2ff3de780)


## Consideraciones técnicas ##
Debe utilizar POO (Programación orientada a objetos) para resolver el problema.
- Las clases de objetos (Terminal, Conductor, Autobús, Tarifa, Roles), no deben contener lógica
para solicitar información al usuario, solo debe tener la estructura de la clase y sus propiedades.
- Las clases no deben tener métodos vacíos
Debe implementar el manejo de excepciones
- Si ocurre una excepción, el sistema no debe cerrarse, se debe mostrar un mensaje al usuario y
manejar la excepción de forma apropiada.
Uso de colecciones
- Se deben usar colecciones genéricas (List<>) cuando se requiera consultar de base de datos y
retornar más de un registro.
- Las colecciones genéricas se usan como DataSource en los controles Combobox y
DataGridView.
- No utilizar DataSet ni DataTable.
Interfaz de usuario
- Debe almacenar y consultar la información en una base de datos SQL Server. No se permite otro
motor de base de datos.
Base de Datos
- Debe almacenar y consultar la información en una base de datos SQL Server. No se permite otro
motor de base de datos.
- Para la cadena de conexión use seguridad integrada de Windows.
- El script de creación de la base de datos se publicará en la plataforma. No de be modificar
el script de base de datos
