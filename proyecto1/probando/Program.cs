using ProbarCadena;

Console.WriteLine("╔════════════════════════════════════════════╗");
Console.WriteLine("║  SIMULADOR DE CADENA DE SIMULACIONES      ║");
Console.WriteLine("║  Platzi - Curso de Git y GitHub           ║");
Console.WriteLine("╚════════════════════════════════════════════╝\n");

// Crear una cadena de simulaciones
var cadena = new CadenaSimulaciones();

// Agregar procesos a la cadena
cadena.AgregarProceso("Validación de datos", 500);
cadena.AgregarProceso("Conexión a base de datos", 800);
cadena.AgregarProceso("Procesamiento de información", 1000);
cadena.AgregarProceso("Generación de reportes", 600);
cadena.AgregarProceso("Almacenamiento de resultados", 400);

// Mostrar los procesos
cadena.MostrarProcesos();

// Ejecutar la cadena
cadena.EjecutarCadena();
