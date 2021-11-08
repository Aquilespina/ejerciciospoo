using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int cont,can;
            string nombre,grup,conv;

            Console.WriteLine("Bienvenido");//Mensaje de bienvenida 
            /*El programa para imprimir una discografia */
            Console.WriteLine("Intoduce tu nombre ");
            nombre = Console.ReadLine();
            Console.WriteLine("Digita el album  del grupo");
            grup = Console.ReadLine();
            Console.WriteLine("Cuantas canciones contiene el album");
            conv = Console.ReadLine();
            can = int.Parse(conv);
            string[] discografia = new string[can];
            
            for (cont = 0; cont < can; cont++)
            {
         
                Console.WriteLine("Introduzca la cancion :",cont);
                discografia[cont] = Console.ReadLine();
            }

            Console.WriteLine(grup);
             for (cont = 0; cont <= can; cont++)
            {
               Console.WriteLine(discografia[can]);
            }
        }
    }
}
