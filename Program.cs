using System;

namespace registrar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] discografia = { };
            int cont, disco, dis;
            string nom, x, art;
            Console.WriteLine("Digite tu nombre ");
            nom = Console.ReadLine();
            Console.WriteLine("Bienveid@ " + nom);
            Console.WriteLine("Digite el artista ");
            art = Console.ReadLine();
            Console.WriteLine("Digite el numero de canciones");
            x= Console.ReadLine();
            dis = int.Parse(x);
            for (cont = 0; cont < dis; cont++)
            {
                Console.WriteLine("Introduzca la cancion ");
                discografia[cont]=Console.ReadLine();
               
            }
            for (cont = 0; cont < dis; cont++)
            {
                Console.WriteLine("La cancion que contiene es :");
                Console.WriteLine(discografia[cont]);
            }
            
        }
    }
}
