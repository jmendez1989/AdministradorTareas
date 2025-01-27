# AdministradorTareas
Prueba AdministradorTareas Jorge Méndez Arias

Administrador de Tareas 

Este proyecto consiste en una aplicación para gestionar tareas, diseñada para la creación, edición, visualización y eliminación de tareas. Utiliza SQLite y Dapper para la gestión de datos, junto con Windows Forms para la interfaz gráfica. 

 

Configuración del Entorno de Desarrollo 

Requisitos Previos 

Sistema Operativo: Windows (compatible con .NET Framework o .NET Core). 

Software Necesario:  

Visual Studio (2022 o superior recomendado). 

.NET Framework o .NET Core SDK. 

SQLite (opcional, ya que la base de datos se encuentra en un archivo local). 

Dependencias:  

Paquete NuGet: Dapper. 

Pasos para Configurar 

Clona el repositorio: git clone <URL_DEL_REPOSITORIO> 
  

Abre el proyecto en Visual Studio. 

Restaura las dependencias de NuGet (esto sucede automáticamente al abrir el proyecto). 

Verifica que el archivo Admtareas.db (base de datos SQLite) esté disponible en la raíz del proyecto. Si no existe, crea un archivo SQLite vacío y ejecuta el script correspondiente para inicializar las tablas. 

Configura el proyecto como el proyecto de inicio. 

Ejecuta la aplicación desde Visual Studio. 

 

Ejecución del Proyecto 

Abre Visual Studio. 

Selecciona "Iniciar Depuración" (o presiona F5). 

La interfaz de usuario del administrador de tareas se abrirá automáticamente. 

Opciones principales en la interfaz: 

Agregar: Permite registrar nuevas tareas. 

Editar: Modifica las tareas seleccionadas. 

Eliminar: Elimina una tarea de la base de datos. 

Filtros: Filtra las tareas según criterios como usuario, estado, prioridad y rango de fechas. 

 

Decisiones Técnicas 

Uso de Dapper para la interacción con SQLite: 

Elegido por su ligereza y eficiencia en la ejecución de consultas SQL. 

Proporciona flexibilidad al manejar consultas personalizadas. 

Windows Forms como tecnología de Interface de Usurio: 

Tecnología madura y adecuada para aplicaciones de escritorio. 

Permite un desarrollo rápido y directo de interfaces gráficas. 

Patrones de Diseño Utilizados: 

Singleton: Implementado en la clase TareaLogica para garantizar una única instancia durante la ejecución. 

Separación de Responsabilidades: La lógica de negocio está encapsulada en TareaLogica, mientras que la presentación se gestiona con formularios de Windows Forms. 

Base de Datos SQLite: 

Ideal para aplicaciones locales sin requerir servidores externos. 

 

Guía de Estilo de Código 

Convenciones de Nombres 

Clases: PascalCase (TareaLogica, AdminTareasFormEditable). 

Propiedades y Métodos Públicos: PascalCase (Id, AgregarTarea). 

Variables Privadas: _camelCase (_id, _descripcion). 

Parámetros: camelCase (fechaInicio, usuario). 

 

 

Organización de Código 

Espaciado:  

Se utiliza una indentación de 4 espacios por nivel. 

Estructura:  

Los archivos inician con los using necesarios. 

Cada sección del código está separada por líneas en blanco para mejorar la legibilidad. 

Métodos:  

Se escriben métodos cortos, centrados en una tarea específica. 

Manejo de Errores:  

Se implementa un manejo explícito de excepciones con mensajes descriptivos. 

Comentarios 

Los comentarios son claros y específicos. 

Ejemplo de un comentario en un método: // Método para obtener la lista de tareas filtradas por usuario, estado y rango de fechas. 
  

Buenas Prácticas 

Evitar Repetición de Código: Se reutilizan constantes y métodos cuando es posible. 

Notificaciones de Cambio: Se utiliza INotifyPropertyChanged para reflejar cambios en tiempo real en la interfaz. 

Separación de Lógica: La lógica de negocio y la interfaz están claramente diferenciadas. 

El scrit para la base de datos es el siguiente:

CREATE TABLE TAREAS (
    ID INTEGER PRIMARY KEY AUTOINCREMENT,
    Descripcion TEXT NOT NULL,
    Usuario TEXT NOT NULL,
    Estado TEXT NOT NULL CHECK(Estado IN ('Pendiente', 'En Proceso', 'Completada')),
    Prioridad TEXT NOT NULL CHECK(Prioridad IN ('Alta', 'Media', 'Baja')),
    FechaCompromiso DATE NOT NULL,
    Notas TEXT,
    FechaCreacion DATE DEFAULT (datetime('now'))
);

 

 
