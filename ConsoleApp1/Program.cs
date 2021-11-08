using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*El programa es para imprimir datos al usuario*/
            int cont, aux,disco,aux2;
            string dis;
            string[]discografia = {"Sin miedo","Love paraiso","Todo rico" };
            string[] discografia2 = { "Remote","Outsidein","HYBRID" };
            string nom, dato;
            Console.WriteLine(" Digite su nombre ");
            nom = Console.ReadLine();
            Console.WriteLine("Bienvenid@" + nom);
            Console.WriteLine("Seleccione la discografia");
            Console.WriteLine("[1]Discografia de la  garfield");
            Console.WriteLine("[2]Discografia de  swingrowers");
            dis = Console.ReadLine();
            disco = int.Parse(dis);
            aux = discografia.Length;
            aux2 = discografia2.Length;
            switch (disco)
            {
                case 1:
                    Console.WriteLine("La discografia es :");
                    for (cont=0;cont<aux;cont++)
                    {
                        Console.WriteLine(discografia[cont]);
                    }
                break;
                case 2:
                    Console.WriteLine("La discografia es :");
                    for (cont = 0; cont < aux2; cont++)
                    {
                        Console.WriteLine(discografia2[cont]);
                    }
                    break;
            }
            
        }
    }
}
