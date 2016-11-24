using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control1
{
    class Program
    {
        static string[] nombres = new string[10];
        static double[] nota = new double[10];
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese a sus Alumnos y sus Notas de Matematicas");
            Console.WriteLine("");
            Insertar();
            Console.WriteLine("");
            ImprimirDatos();
            Console.WriteLine("");
            promedio();
            Console.WriteLine("");
            Console.WriteLine("La nota mayor es: ");
            Mayor();
            Console.WriteLine("");
            Console.WriteLine("La nota menor es: ");
            menor();


            Console.ReadLine();

        }
        static void Insertar()
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Ingrese Nombre:");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Ingrese Nota:");
                nota[i] = Double.Parse(Console.ReadLine());
            }


        }
        static void ImprimirDatos()
        {
            Console.WriteLine("Nombres          Notas");
            Console.WriteLine("");

            for (int i = 0; i < nombres.Length; i++)
            {
                
                    
                    Console.Write("{0}", nombres[i]);
                     Console.WriteLine(".........{0}", nota[i] + " pts.");
                

            }

        }
        static void promedio() {

           

            Console.WriteLine("El promedio es de:");

          
            double suma = nota.Sum();
            double promedio = suma / nombres.Length;
            Console.WriteLine(promedio);

        }
        static double Mayor()
        {
            
            double mayor = nota[0];
            
            for (int i = 0; i < nota.Length; i++)
               
                if (nota[i] > mayor)
               
                    mayor = nota[i];

                  Console.WriteLine(mayor);
            return mayor;
        }
        static double menor()
        {

            double menor = nota[0];

            for (int i = 0; i < nota.Length; i++)

                if (nota[i] < menor)

                    menor = nota[i];

            Console.WriteLine(menor);
            return menor;
        }
    }
}

