using System;

namespace Algorithme
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            string category = "";
            Console.WriteLine("Veux-tu entrer ton age.");
            age = Convert.ToInt32(Console.ReadLine());

            if (age <= 5 || age > 14)
            {
                Console.WriteLine("Tu n'appartient a aucune catégorie");
            }
            else if (age <= 7)
            {
                Console.WriteLine("T'appartient à la categorie Poussin");
            }
            else if (age <= 9)
            {
                Console.WriteLine("T'appartient à la categorie Pupille");
            }
            else if (age <= 11)
            {
                Console.WriteLine("T'appartient à la categorie Minime");
            }
            else
            {
                Console.WriteLine("T'appartient a la categorie Cadet");
            }
        }
    }
}
   
