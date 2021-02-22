using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CALIFICACIONES_DE_UN_GRUPO_DE_ESTUDIANTES
{
    class Program
    {
        static void Main(string[] args)
        {
            byte CAN, K;
            double NOTA1, NOTA2, PROM, SUM;
            string NOM, linea;
            Console.Write("CUANTOS ESTUDIANTES: "); linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            SUM = 0;
            for (K = 1; K <= CAN; K++)
            {
                Console.Write("NOMBRE: "); NOM = Console.ReadLine();
                Console.Write("NOTA 1: "); linea = Console.ReadLine();
                NOTA1 = double.Parse(linea);
                Console.Write("NOTA 2: "); linea = Console.ReadLine();
                NOTA2 = double.Parse(linea);
                PROM = (NOTA1 + NOTA2) / 2;
                Console.WriteLine("PROMEDIO: " + PROM);
                SUM += PROM;
            }
            Console.WriteLine();
            Console.WriteLine("SUMA TOTAL ES : " + SUM);
            Console.WriteLine("MEDIA ARITMÉTICA: " + SUM / CAN);
            Console.WriteLine("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}
