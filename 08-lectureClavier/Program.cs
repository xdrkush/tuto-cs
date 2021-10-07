using System;

class App
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World !");
        // Nous allons récupèrer les info depuis le terminal

        // string c = Console.ReadLine();          // Récupère une ligne en entrée
        // string c = Console.Read();              // Récupère une touche
        // ConsoleKeyInfo cki = Console.ReadKey(); // Récupère la clef clavier

        Console.WriteLine("Comment t'appel tu ?");

        // à décommenter
        string name = Console.ReadLine();
        Console.WriteLine($"Bienvenu dans c# { name }");

        /*
            Mini Jeux
        */

        // Console.WriteLine("Entrée un nombre entre 1 et 100 !");

        // // Random
        // Random rnd = new Random();
        // // nombre d'essai max
        // int max_try = 6;
        // // le nombre à trouver
        // int mystery_number = rnd.Next(101);

        // // On commence la boucle avec le nombre
        // for (int i = 0; i < max_try; i++)
        // {
        //     // Ici on récupère le nombre taper par l'utilisateur
        //     string n = Console.ReadLine();
        //     // Ici on converti notre String(n) > Int(number)
        //     int number = Int16.Parse(n);

        //     // Condition pour check si le joueur à gagne
        //     if (mystery_number == number)
        //     {
        //         // On ressort dans le terminal, "", et on clean le tampon
        //         Console.WriteLine("Gagné !");
        //         // Break est utiliser pour sortir de la boucle
        //         break;
        //     }
        //     // Condition pour check si le joueur à entré un nombre trop grand
        //     else if (number > mystery_number)
        //     {
        //         Console.WriteLine("Trop grand !");
        //     }
        //     // Condition pour check si le joueur à entré un nombre trop petit
        //     else
        //     {
        //         Console.WriteLine("Trop petit !");
        //     }
        //     // Condition pour check ne nombre d'essaie
        //     if (i == max_try - 1)
        //     {
        //         Console.WriteLine($"Perdu ! Le nombre à deviner était { mystery_number } ");
        //     }
        // }

    }
}
