# Backend_Proyecto
 
    
INFORME DE GUÍA PRÁCTICA  
   
I. PORTADA  
  
Tema:                                                      Manejo de Matrices 
Unidad de Organización Curricular:  Básica  
Nivel y Paralelo:                                    3ro TI   
Alumnos participantes:                        Yaguachi Coba Andrew Sebastian              Soria Yumbo Jesica Yadira  
Asignatura:                                            Programación Avanzada  
Docente:                                                  Ing. Caiza Caizabuano José Rubén  
  
Objetivo General: 
Introducción 
El presente informe describe el desarrollo del Sistema de Gestión Académica (SGA), una aplicación destinada a la administración eficiente de estudiantes y cursos en un entorno académico. Este sistema integra operaciones básicas como el registro, modificación, visualización y eliminación de datos (CRUD), así como asignaciones entre entidades y validaciones de entrada. La implementación se lleva a cabo mediante tecnologías modernas de desarrollo como ASP.NET Core Web App con C#, el uso de SQL Server Management Studio (SSMS) para el almacenamiento de datos, Visual Studio Code para edición de código y Node.js v22.x LTS para la gestión de tareas y compatibilidad de scripts de desarrollo. 
 
Este proyecto busca consolidar los conocimientos adquiridos en entornos reales de desarrollo, promoviendo las buenas prácticas en programación, diseño de software por capas y separación de responsabilidades a través de una arquitectura organizada. 
Objetivos  
•	Objetivo General 
Desarrollar un Sistema de Gestión Académica (SGA) basado en una arquitectura multicapa que permita realizar operaciones CRUD sobre estudiantes y cursos, incluyendo asignaciones, validaciones, manejo de excepciones y estructuras de control, haciendo uso de C#, ASP.NET Core, SQL Server, Visual Studio Code y Node.js.  
 
•	Objetivos Específicos 
1.	Diseñar y construir una interfaz web amigable con ASP.NET Core que facilite la interacción del usuario con el sistema. 
  
2.	Implementar operaciones CRUD sobre las entidades “Estudiante” y “Curso” utilizando Entity Framework y una base de datos SQL Server. 
 
3.	Separar la lógica de negocio en una biblioteca de clases reutilizable para mantener el principio de responsabilidad única. 
 
4.	Integrar validaciones de entrada y manejo de errores en la interfaz web y la lógica de negocio, mejorando la experiencia y robustez del sistema. 
 
5.	Utilizar estructuras de datos como vectores y matrices para el cálculo de estadísticas (por ejemplo, promedios de calificaciones). 
 
6.	Gestionar el proyecto y tareas complementarias con Node.js v22.x LTS y herramientas como npm scripts o paquetes útiles para el entorno de desarrollo. 
 
7.	Implementar autenticación y autorización en la plataforma, permitiendo el acceso según roles de usuario. 
 
8.	Desarrollar reportes y gráficos estadísticos sobre los datos académicos utilizando estructuras en C# y bibliotecas gráficas. 
Componentes del Proyecto Arquitectura por Capas 
•	Capa de Presentación (ASP.NET Core Web App) 
 
1.	Interfaz web moderna con Razor Pages o MVC. 
 
2.	Validaciones de datos y renderizado dinámico. 
 
3.	Filtros de búsqueda y listados interactivos. 
 
•	Capa de Lógica de Negocio (Librería de Clases) 
 
1.	Clases como EstudianteManager y CursoManager. 
 
2.	Métodos reutilizables para CRUD, validaciones, y cálculos. 
 
•	Capa de Acceso a Datos (Entity Framework + SQL Server) 
 
1.	Mapas de entidades a tablas SQL. 
 
2.	Control de migraciones y conexión con SSMS. 
 
Marco Teórico Backend  
1. Desarrollo de Software y Arquitectura Multicapa 
El desarrollo de software basado en arquitectura multicapa permite dividir la aplicación en componentes claramente diferenciados. Esto promueve una mayor mantenibilidad, escalabilidad y reutilización de código. 
 
En el caso del Sistema de Gestión Académica (SGA), se emplean tres capas fundamentales: 
 
•	Capa de presentación (Frontend): Desarrollada con ASP.NET Core Web App, esta capa permite la interacción directa del usuario con el sistema. Contiene formularios, validaciones en el cliente y vistas para mostrar información. 
 
•	Capa de lógica de negocio: Implementada como una librería de clases en C#, aquí residen las reglas del sistema. Gestiona entidades como estudiantes y cursos, controla validaciones internas y delega tareas a la capa de datos. 
 
•	Capa de acceso a datos: Utiliza Entity Framework Core y SQL Server Management Studio (SSMS) para la persistencia de información. Permite consultas, inserciones, actualizaciones y eliminaciones a través de un modelo relacional. 
 
2.	Programación Orientada a Objetos (POO) 
La POO permite modelar el sistema en base a objetos que representan entidades del mundo real. En este proyecto, clases como Estudiante, Curso y sus respectivos administradores encapsulan atributos y comportamientos, permitiendo: 
 
•	Encapsulamiento: Protección del acceso a los datos. 
 
•	Herencia: Reutilización de código entre clases relacionadas. 
 
•	Polimorfismo: Capacidad de manejar objetos diferentes bajo una misma interfaz. 
 
3.	Base de Datos Relacional con SQL Server 
El sistema utiliza SQL Server como motor de base de datos relacional. La información se almacena en tablas conectadas mediante relaciones (por ejemplo, un estudiante puede estar asignado a múltiples cursos). El acceso a la base de datos se realiza mediante Entity Framework Core, una herramienta ORM que facilita la interacción entre el código C# y la base de datos sin necesidad de escribir SQL directamente. 
 
4.	ASP.NET Core y el Desarrollo Web 
ASP.NET Core es un framework moderno, de código abierto, multiplataforma y altamente escalable para la creación de aplicaciones web. Su integración con C#, soporte para dependencias, seguridad, y plantillas prediseñadas lo convierten en una herramienta ideal para el desarrollo empresarial. 
 
Con este framework, es posible: 
 
•	Crear interfaces web dinámicas y responsivas. 
 
•	Manejar validaciones del lado del servidor y cliente. 
 
•	Usar el patrón MVC (Model-View-Controller) para estructurar el código. 
 
5.	Node.js como Herramienta de Apoyo 
Aunque Node.js no es parte del núcleo del sistema, se utiliza como herramienta auxiliar en el desarrollo: 
•	Gestión de paquetes a través de npm. 
 
•	Automatización de tareas (ej: compilación, bundling). 
 
•	Uso de herramientas de frontend modernas (Webpack, ESLint, etc.) que pueden ejecutarse sobre Node.js. 
Su versión LTS garantiza estabilidad y soporte a largo plazo en entornos productivos. 6. Validaciones, Manejo de Errores y Estructuras de Control El sistema implementa validaciones en múltiples capas: 
•	Cliente: con formularios ASP.NET, validadores, y JavaScript. 
 
•	Servidor: mediante anotaciones ([Required], [EmailAddress]) y lógica en las clases de negocio. 
El uso de estructuras de control (como if, switch, for, foreach) permite tomar decisiones lógicas y recorrer colecciones. Además, el manejo de excepciones (try-catch) previene la caída del sistema ante errores inesperados. 
7. Uso de Estructuras de Datos: Vectores y Matrices 
Para cálculos estadísticos como promedios de calificaciones o análisis de asignaciones, el sistema puede emplear vectores y matrices en C#. Estas estructuras permiten: 
•	Almacenar múltiples datos del mismo tipo. 
 
•	Realizar operaciones matemáticas y reportes. 
 
•	Optimizar el rendimiento en cálculos repetitivos. 
Marco Teorico FrontEnd 
Frontend del Sistema de Gestión Académica (SGA) 1) Desarrollo Web y el Rol del Frontend 
El frontend representa la capa de presentación del sistema, es decir, la interfaz con la que el usuario interactúa directamente. Este componente es crucial para ofrecer una experiencia de usuario amigable, intuitiva y accesible. 
 
En el caso del SGA, la capa frontend permite registrar estudiantes, asignar cursos, filtrar información y visualizar listados. Todo esto se construye sobre tecnologías web modernas y prácticas de usabilidad. 
2) ASP.NET Core como Framework Web 
ASP.NET Core es un framework robusto y multiplataforma de Microsoft para el desarrollo web. Dentro del contexto del frontend, proporciona herramientas como: 
 
•	Razor Pages o MVC Views: permiten generar contenido HTML dinámico desde C#. 
 
•	Tag Helpers: facilitan la creación de formularios y controles HTML con lógica integrada. 
 
•	Validaciones automáticas: mediante anotaciones ([Required], [StringLength], etc.), que se traducen en validadores del lado cliente. 
 
El uso de ASP.NET Core en el frontend facilita la integración directa con la lógica del backend, mejorando el flujo de datos y la validación. 
 
3) HTML, CSS y JavaScript en la Presentación 
Aunque ASP.NET genera gran parte del contenido dinámico, los lenguajes fundamentales del frontend siguen presentes: 
 
•	HTML (HyperText Markup Language): Estructura el contenido. 
 
•	CSS (Cascading Style Sheets): Define estilos visuales (colores, tipografía, espaciado). 
 
•	JavaScript: Controla la lógica del lado cliente, como validaciones, interactividad o peticiones asincrónicas. 
Opcionalmente, pueden integrarse frameworks modernos como Bootstrap para diseño responsivo o jQuery para simplificar tareas comunes. 
 
4) Formularios Web e Interacción con el Usuario 
La interacción principal en el SGA ocurre mediante formularios que permiten registrar estudiantes, cursos o realizar búsquedas. ASP.NET Core proporciona componentes como: 
•	form, input, select, button: elementos HTML clásicos. 
 
•	asp-for y asp-validation-for: enlaces directos entre la vista y el modelo de datos. 
 
•	ValidationSummary y span con clases de error para mostrar mensajes claros al usuario. 
Las validaciones pueden ser cliente-servidor, garantizando precisión sin sacrificar fluidez en la experiencia. 
5) Comunicación con el Backend 
La capa frontend se comunica con el backend mediante: 
•	Formularios tradicionales (submit y redirección). 
 
•	Llamadas asincrónicas (AJAX) con JavaScript o bibliotecas como Fetch API, para cargar datos sin recargar la página. 
 
•	JSON como formato estándar para intercambio de datos. 
Estas interacciones permiten enviar datos al servidor (como un nuevo estudiante) o recibir respuestas (como la lista de cursos disponibles). 
 
 
6) Diseño Responsivo y Accesibilidad 
Para garantizar el acceso desde cualquier dispositivo, el sistema puede implementar: 
•	Responsive Design: con herramientas como Bootstrap, que adapta el diseño a diferentes tamaños de pantalla. 
 
•	Buenas prácticas de accesibilidad (A11Y): uso correcto de etiquetas, contraste adecuado y compatibilidad con lectores de pantalla. 
 
7) Organización del Código Frontend 
En proyectos ASP.NET Core bien estructurados, el frontend se organiza así: 
•	Views/: contiene las páginas HTML dinámicas. 
 
•	wwwroot/: alberga archivos estáticos (CSS, JS, imágenes). 
 
•	Layout.cshtml: plantilla base para reutilizar cabeceras, menús, pie de página. 
 
•	Site.css o frameworks externos como Bootstrap para estilos. 
 
8) Herramientas de Apoyo: Node.js y npm En este proyecto, Node.js puede ser útil para: 
•	Instalar librerías frontend modernas (Bootstrap, jQuery, SweetAlert). 
 
•	Automatizar tareas (minificar archivos, compilar SCSS, etc.). 
 
•	Usar herramientas como Webpack, Vite o ESLint en el desarrollo. 
Esto permite mejorar el rendimiento del frontend y mantener el código limpio y modular. 
Desarrollo del Aplicativo en la nube API 
I.	Creamos el nuevo proyecto con la Plantilla del proyecto Aplicación web ASP.net (.net Framework). 
 
  
 
II.	Creamos los controladores dependiendo el proyecto en este caso se crea las 
(Asignaciones, Carreras, Cursos, Estudiantes y Notas) existira una que esta creada predeterminada en la carpeta Controllers que es Home y este no se debe eliminar ya que es el que direcciona a las páginas y tiene controladores del BackEnd. 
 
  
 
  
 
III.	En la Carpeta Models se debe crear lo siguiente (Asignaciones, BaseUta, Carreras, Cursos, Estudiantes y Notas) con sus propios get y set definiendo sin son valores enteros y que virtualiza en la asignaciones. 
Como observamos tenemos un Public BaseUTAContext esto nos permite llamar a la base. 
 
  
 
  
 
IV.	Para este momento llamar a la base de datos debemos tenemos una carpeta en nuestro disco local C llamada backUp dentro debe de estar los datos que se va a necesitar para el BackEnd y El FrontEnd. 
                    
V.	Ejecutamos la aplicación SQL Managentment para ingresar el archivo BaseUta a nuestro BD. 
  
VI.	Lo siguiente será llamar a la BD a nuestro proyecto que tenemos en el C# para poder conectar simultáneamente los datos. 
  
VII.	Damos sus debidos permisos para poder llamar a la BD que creamos. 
  
VIII.	Momento que creamos y llamamos a la base vamos a copiar la ruta de conexión para 
poder llamarle al Web Config. 
  
IX.	En el WebConfig Realizamos la cadena de conexión ya que todo se esta creando apartir de los models y controller creamos la llamada de la base mediante lo que copiamos de la ruta de conexión. 
  
X.	Ahora en la Carpeta APP_Store se realizará los siguientes métodos, Contruir específicamente el origen del https ya que tenemos que dar origen al purto para poder generar la venta y ruteo de las APIS (Da permisos) y generar la configuración del JSON para ignorar la referencias circulares que nos da por defecto C#. 
  
Por lo general los navegadores se debe dar permiso al momento de ejecutarlo para eso se crea una Clase llamada Global.asax que tenemos unos por defecto para generar en un navegador pero que vamos a generar como nuevo método es para tener permisos sin límites en las APIS. 
  
XI.	Ejecutamos el aplicado de C# para ver la ruta del host y el puerto que usamos del direccionamiento IP. 
  
XII.	Como vemos aquí tenemos generadas las APIS tanto los los métodos de limpiar agregar eliminar y actualizar de notas, estudiantes, cursos, asignaciones y carreras. 
  
XIII.	Ingresamos Postman para verificar que este en perfecto funcionamiento las APIS y no devolverá un 200% de que esta en una muy buena conexión y funcionando las APIS y los métodos. 
  
VisualCode FrontEnd 
a)	En Visual Code generaremos en CSS y HTML el diseño de la pagina web. 
  
Como vemos tenemos los estilos específicos para la pagina web y las mejoras que van a tener los farmularios. 
  
b)	Y en HTMLÑ tenemos referenciado todas las asignaciones que realizaría los botones y los métodos que tendríamos en C# con las APIS. 
  
c)	En IMG tenemos subidas los que seria las imágenes para la pagina web tanto el logo de la universidad y el admin logo para una futura actualización. 
  
d)	En el JS tenmemos referenciado los que rea las APIS, URLs, Elementos DOM, Inicializacion de la página, Carga de Listas, Carga de los Estudiantes específicamente todos los métodos y actulizaciones que tendría cada método realizado en C#. 
  
e)	Y por utlimo Tenemos los node_mudules que es hace le trabajo de llamar puertos. 
Para poder llamar al servidor se relizaria desde js.server presionando cont+shift+ñ. 
  
  
f)	Y tenemos como preferencia nuestra primera pagina web con sus respetivos métodos y eventos generados en cada modelo. 
  
Conclusión General 
El desarrollo del Sistema de Gestión Académica (SGA) representa una solución integral para la administración eficiente de estudiantes y cursos en un entorno académico. A lo largo del proyecto se implementaron conceptos fundamentales del desarrollo de software, aplicando una arquitectura por capas que favorece la organización, escalabilidad y mantenibilidad del código. 
 
En el backend, se utilizó ASP.NET Core y C#, estructurando el sistema mediante controladores, modelos y servicios, apoyados por una biblioteca de clases para centralizar la lógica de negocio. El uso de Entity Framework Core facilitó la comunicación con SQL Server, permitiendo realizar operaciones CRUD robustas, con validaciones y manejo adecuado de errores. Además, se incorporaron estructuras de control, excepciones, vectores y matrices para cálculos y análisis de datos. 
 
El frontend, construido con tecnologías web modernas dentro del entorno de ASP.NET Core, brindó una interfaz amigable y funcional, con formularios interactivos, validaciones tanto del lado cliente como del servidor, y una experiencia de usuario fluida. Se integró Visual Studio Code y Node.js v22.x LTS para complementar el flujo de trabajo y optimizar tareas del desarrollo. 
 
Este proyecto no solo demostró la capacidad técnica para construir una solución completa, sino que también fomentó el uso de buenas prácticas de programación, diseño de software y trabajo modular. Como extensión futura, se contemplan funcionalidades como autenticación, roles de usuario, reportes estadísticos, exportación de datos y mejoras visuales en la interfaz. 
 
En conclusión, el SGA constituye una base sólida y escalable que puede evolucionar hacia un sistema académico completo y profesional, integrando tecnología moderna con una estructura clara y eficiente. 
Bibliografías: 
-	Microsoft. (2023). ASP.NET Core Documentation. Recuperado de: 
https://learn.microsoft.com/en-us/aspnet/core/ 
 
-	Esposito, D. (2020). Modern Web Development with ASP.NET Core 3: Building Applications Using ASP.NET Core, Blazor, and EF Core. Apress. 
 
-	Freeman, A. (2021). Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages. Apress. 
 
-	Richter, J. (2012). CLR via C#. Microsoft Press. 
 
-	Albahari, J., & Albahari, B. (2021). C# 10 in a Nutshell: The Definitive Reference. O'Reilly Media. 
 
-	Microsoft. (2023). Entity Framework Core Documentation. Recuperado de: 
https://learn.microsoft.com/en-us/ef/core/ 
 
-	Wenz, C. (2021). HTML5 and CSS3: The Complete Manual. Wiley. 
 
-	Fowler, M. (2002). Patterns of Enterprise Application Architecture. Addison-Wesley. 
Links GitHub: 
- https://github.com/TheBearForce
 
 
 
