using ProbarCadena;

Console.WriteLine("╔════════════════════════════════════════════╗");
Console.WriteLine("║  SIMULADOR DE CADENA DE SIMULACIONES      ║");
Console.WriteLine("║  Platzi - Curso de Git y GitHub           ║");
Console.WriteLine("╚════════════════════════════════════════════╝\n");

string stripe_api_key="sk_test_51N8n9sHj5mLh7Xo2qj3Zt1v9u8w5y6z7a8b9c0d1e2f3g4h5i6j7k8l9m0n1o2p3q4r5s6t7u8v9w0x1y2z3a4b5c6d7e8f9g0h1i2j3k4l5m6n7o8p9q0r1s2t3u4v5w6x7y8z9a0b1c2d3e4f5g6h7i8j9k0l1m2n3o4p5q6r7s8t9u0v1w2x3y4z5a6b7c8d9e0f1g2h3i4j5k6l7m8n9o0p1q2r3s4t5u6v7w8x9y0z1a2b3c4d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7a8b9c0d1e2f3g4h5i6j7k8l9m0n1o2p3q4r5s6t7u8v9w0x1y2z3a4b5c6d7e8f9g0h1i2j3k4l5m6n7o8p9q0r1s2t3u4v5w6x7y8z9a0b1c2d3e4f5g6h7i8j9k0l1m2n3o4p5q6r7s8t9u0v1w2x3y4z5a6b7c8d9e0f1g2h3i4j5k6l7m8n9o0p1q2r3s4t5u6v7w8x9y0"

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
