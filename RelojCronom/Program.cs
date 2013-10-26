/**PROGRAMA EN C# QUE TENGA UN MENU DE DOS OPCIONES:
 * - RELOJ
 * - CRONOMETRO
 * 
 * EN FORMATO 00:00:00
 * 
**/

using System;
using System.Threading; //Esta libreria permite usar Thread.Sleep

namespace RelojCronom
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 horaCron, minCron, segCron;
            

            Console.WriteLine("MENU \n");
            Console.WriteLine("1. Reloj \n2. Cronometro \n3. Salir\n");
            int opc = Int16.Parse(System.Console.ReadLine());

            
            switch (opc)
            {
                case 1:
                    for (; ; ) //Permite hacer un ciclo infinito e irse actualizando cada segundo
                    {
                        Console.Clear();
                        Console.WriteLine("Reloj \n");
                        Console.WriteLine(DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00")) ; //Imprime la fecha y hora actual del sistema 
                        Thread.Sleep(1000);//Genera una pausa en el programa de 1 segundo(1000 milisegundos)

                    }

                   // break;

                case 2:
                    Console.Clear();

                    for (horaCron = 0; horaCron < 1000; horaCron++) // Se inicializa Hora en 0
                    {
                      
                        for (minCron = 0; minCron < 60; minCron++) // Minuto 0
                        {
                            for (segCron = 0; segCron < 60; segCron++) // Segundo 0
                            {
                                    Console.WriteLine("Cronometro  \n\n" + horaCron.ToString("00") + ":" + minCron.ToString("00") + ":" + segCron.ToString("00"));
                                    System.Threading.Thread.Sleep(1000); // Dividirlo entre 1000 milisegundos
                                    Console.Clear();
                                
                            }
                        }
                    }
                   

                    break;
                   

            }
            Console.ReadLine();
            
        }
      }
   }





