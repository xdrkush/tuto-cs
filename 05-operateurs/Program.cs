using System;

/*
    Arithméthique :    +,  -,  *,  /,  %  (binaire)
                       +,  -, ++, --      (unaire)
    Affectation   : =, +=, -=, *=, /=, %=

    Boolean (in)Égalité         : ==, !, <, >, <=, >=
    Boolean binaire conditionel : &&, ||
*/

class App
{
    static void Main(string[] args)
    {
        int result = 0;

        result = result + 5; // result += 5
        Console.WriteLine(result);

        // on incrémente de 1
        result++;
        Console.WriteLine(result);
        // On incrémente de 1 après affichage
        Console.WriteLine(result++);
        Console.WriteLine(result);
        // On incrémente de 1 avant affichage
        Console.WriteLine(++result);

        // Egalité
        bool resultat = (5 == 6);
        Console.WriteLine(resultat);
        resultat = (5 != 6);
        Console.WriteLine(resultat);

        resultat = false;
        Console.WriteLine(resultat);
        
        resultat = !false;
        Console.WriteLine(resultat);

        string name = "drk";
        int age = 21;
        Console.WriteLine("Bonjour, " + name + "! tu as, " + age);
        Console.WriteLine($"Bonjour, { name } ! tu as, { age }");
    }
}