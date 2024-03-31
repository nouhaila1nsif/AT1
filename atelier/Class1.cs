using System;

namespace Atelier
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Déclaration d'un tableau de nombres entiers
            int[] nombres = new int[5];

            // Saisie des nombres par l'utilisateur
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Entrez un nombre : ");
                nombres[i] = int.Parse(Console.ReadLine());
            }

            // Affichage du tableau
            Console.WriteLine("Voici les nombres saisis : ");
            foreach (int nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            // Tri du tableau par ordre croissant
            

            // Affichage du tableau trié
            Console.WriteLine("Voici les nombres triés par ordre croissant : ");
            foreach (int nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}
