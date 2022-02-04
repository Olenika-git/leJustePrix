using System;

namespace LeJustePrix
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rejouer = true;

            while (rejouer)
            {
                string entry;
                int level, number = 0, compteur = 1;
                Random random = new Random();

                //Introduction
                Console.WriteLine("Bienvenue dans le juste prix !");
                Console.Write("Veuillez choisir un niveau de difficulté - Entre 0 à 5 : ");

                // Récupération entrée Utilisateur
                entry = Console.ReadLine();

                // Sécurisation de l'Entrée utilisateur
                while (entry != "0" && entry != "1" && entry != "2" && entry != "3" && entry != "4" && entry != "5")
                {
                    Console.Write("Saisie Invalide !");
                    entry = Console.ReadLine();
                }

                level = int.Parse(entry);

                // Mise en place de la Difficulté
                switch (level)
                {
                    case 0:
                        Console.WriteLine("Niveau 0 : le chiffre sera compris entre 1 et 100 !");
                        number = random.Next(0, 100);
                        break;
                    case 1: 
                        Console.WriteLine("Niveau 1 : le chiffre sera compris entre 1 et 150 !"); 
                        number = random.Next(0, 150); 
                        break;
                    case 2: 
                        Console.WriteLine("Niveau 2 : le chiffre sera compris entre 1 et 200 !"); 
                        number = random.Next(0, 200); 
                        break;
                    case 3: 
                        Console.WriteLine("Niveau 3 : le chiffre sera compris entre 1 et 300 !"); 
                        number = random.Next(0, 300); 
                        break;
                    case 4: 
                        Console.WriteLine("Niveau 4 : le chiffre sera compris entre 1 et 400 !"); 
                        number = random.Next(0, 400); 
                        break;
                    case 5: 
                        Console.WriteLine("Niveau 5 : le chiffre sera compris entre 1 et 500 !"); 
                        number = random.Next(0, 500); 
                        break;
                }

                // Compteur et Jeu
                string nbr = number.ToString();
                Console.WriteLine("Tentez votre chance saisissez un chiffre : ");
                entry = Console.ReadLine();
                int entryNb = int.Parse(entry);

                while (entry != nbr)
                {
                    if (entryNb < number) //overleaf 
                    {
                        Console.WriteLine("Ces plus grand Magle");
                        entry = Console.ReadLine();
                        entryNb = int.Parse(entry);
                    }
                    else if (entryNb > number)
                    {
                        Console.WriteLine("Ces plus petit Magle");
                        entry = Console.ReadLine();
                        entryNb = int.Parse(entry);
                    }
                    else if (entry == nbr)
                    {
                        Console.WriteLine("Tu as Gagné !");
                        Console.WriteLine("Le Numéro à trouvé étais le : " + number);
                        break;
                    }
                    compteur++;
                }
                Console.WriteLine("Tu as terminé en : " + compteur + " tours \n Bien joué ! Veux tu Rejouer ? Oui ou Non ? ");
                entry = Console.ReadLine();

                if (entry == "oui" || entry == "Oui")
                {
                    Console.WriteLine("Relancement du Jeux en cours ...");
                    Console.WriteLine("Nettoyage de la Console ...");
                    Console.Clear();
                    rejouer = true;
                }
                else
                {
                    Console.WriteLine("Merci d'avoir Joué !\n Aurevoir");
                    rejouer = false;
                    System.Environment.Exit(1);
                }
            }
        }
    }
}
