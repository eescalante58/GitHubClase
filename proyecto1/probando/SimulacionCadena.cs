using System;
using System.Collections.Generic;
using System.Linq;

namespace ProbarCadena
{
    /// <summary>
    /// Clase que simula un proceso individual
    /// </summary>
    public class ProcesoSimulado
    {
        public string Nombre { get; set; }
        public int DuracionMs { get; set; }
        public bool Exitoso { get; set; }

        public ProcesoSimulado(string nombre, int duracionMs)
        {
            Nombre = nombre;
            DuracionMs = duracionMs;
            Exitoso = true;
        }

        public void Ejecutar()
        {
            Console.WriteLine($"[▶] Iniciando proceso: {Nombre}");
            System.Threading.Thread.Sleep(DuracionMs);
            Exitoso = true;
            Console.WriteLine($"[✓] Proceso completado: {Nombre} ({DuracionMs}ms)");
        }
    }

    /// <summary>
    /// Clase que gestiona una cadena de simulaciones
    /// </summary>
    public class CadenaSimulaciones
    {
        private List<ProcesoSimulado> procesos = new List<ProcesoSimulado>();
        private DateTime horaInicio;
        private DateTime horaFin;

        public void AgregarProceso(string nombre, int duracionMs)
        {
            procesos.Add(new ProcesoSimulado(nombre, duracionMs));
        }

        public void EjecutarCadena()
        {
            if (procesos.Count == 0)
            {
                Console.WriteLine("No hay procesos en la cadena");
                return;
            }

            horaInicio = DateTime.Now;
            Console.WriteLine($"\n═══════════════════════════════════════════");
            Console.WriteLine($"Iniciando cadena de {procesos.Count} procesos");
            Console.WriteLine($"═══════════════════════════════════════════\n");

            int procesosExitosos = 0;
            foreach (var proceso in procesos)
            {
                proceso.Ejecutar();
                if (proceso.Exitoso)
                    procesosExitosos++;
            }

            horaFin = DateTime.Now;
            MostrarResumen(procesosExitosos);
        }

        private void MostrarResumen(int exitosos)
        {
            var duracionTotal = (horaFin - horaInicio).TotalMilliseconds;
            Console.WriteLine($"\n═══════════════════════════════════════════");
            Console.WriteLine($"RESUMEN DE LA CADENA");
            Console.WriteLine($"═══════════════════════════════════════════");
            Console.WriteLine($"Total de procesos: {procesos.Count}");
            Console.WriteLine($"Procesos exitosos: {exitosos}");
            Console.WriteLine($"Procesos fallidos: {procesos.Count - exitosos}");
            Console.WriteLine($"Duración total: {duracionTotal:F2}ms");
            Console.WriteLine($"═══════════════════════════════════════════\n");
        }

        public void MostrarProcesos()
        {
            Console.WriteLine("\nProcesos en la cadena:");
            for (int i = 0; i < procesos.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {procesos[i].Nombre} - {procesos[i].DuracionMs}ms");
            }
        }
    }
}
