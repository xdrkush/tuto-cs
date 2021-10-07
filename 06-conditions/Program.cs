using System;

/*
    Conditions ternaire:
    (condtion) ? true : false
    condition : (var > 5)
    true      : true // sera affecté
    false     : false // sera affecté
*/
class App
{
    static void Main(string[] args)
    {
        bool isVerified = true;

        // nous repassons la varible à false
        isVerified = false;

        // Pour une seule instruction nous ne sommes pas obliger de metre les {}
        if (!isVerified)
            Console.WriteLine("Is not Verified !");
        else
            Console.WriteLine("Is Verified !");

        // Imbrication des conditions (en une seule ligne)
        int resultat = 6;
        if (resultat < 10)
            if (resultat > 3)
                if (resultat == 5)
                    Console.WriteLine("C'est Gagné :) !");
                else
                    Console.WriteLine("C'est Perdu :( !");
            else
                Console.WriteLine("Résultat est plus petit que 3 !");
        else
            Console.WriteLine("Résultat est plus grand que 10 !");

        // if, else if, else (en une seule ligne)
        if (resultat < 10)
            Console.WriteLine("Résultat est plus petit que 10 !");
        else if (resultat > 3)
            Console.WriteLine("Résultat est plus grand que 3 !");
        else
            Console.WriteLine("Résultat est entre 10 et 3 !");

        // Check les deux parametre sont : true
        if (resultat < 10 && resultat > 0)
        {
            Console.WriteLine("Résultat est entre 10 et 0 !");
        }
        else
        {
            Console.WriteLine("Résultat n'est pas entre 10 et 0");
        }

        // Check si au moins un parametre : true
        if (resultat < 10 || resultat > 0)
            Console.WriteLine("Résultat est soit suppérieur à 0 ou inférieur à 10 !");
        else
            Console.WriteLine("Résultat n'est pas entre 10 et 0");

        // Switch
        switch (resultat)
        {
            case 1:
                Console.WriteLine("Résultat est égale à 1 !");
                break;
            case 5:
                Console.WriteLine("Résultat est égale à 5 !");
                break;
            case 10:
                Console.WriteLine("Résultat est égale à 10 !");
                break;
            default:
                Console.WriteLine("Le switch n'a pas trouver le résultat !");
                break;
        }

        // Condition ternaire
        resultat = 16;
        bool tern;

        tern = (resultat >= 19) ? true : false;
        Console.WriteLine(tern);

        string maVariable;
        maVariable = (resultat >= 19) ? "Its Good :) !" : "Its not Good :( !";
        Console.WriteLine(maVariable);

        // La condition ternaire au dessu est égale à la condition ci-dessous
        // if (resultat >= 19)
        //     maVariable = "Its Good :) !";
        //     Console.WriteLine(maVariable);
        // else
        //     maVariable = "Its not Good :( !";
        //     Console.WriteLine(maVariable);
        

    }
}