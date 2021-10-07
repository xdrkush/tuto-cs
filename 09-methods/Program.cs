using System;

/*
    - Nom de la methods
    - Paramètres

    Accès       : public, protected, private
    modificateur: abstract, sealed, virtual, unsafe

    ref: référence + lecture et écriture
    in : référence + lecture seule
    out: référence + déclaration de l'extérieur
*/

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"// First // method");
            // First Method (Hello)
            
            Hello();

            Console.WriteLine($"// SECOND // method");
            // Second Method (Somme)

            int a = 5;
            int b = 6;
            int result = Somme(a, b);

            Somme(a, b);

            Console.WriteLine($"MAIN: Le resutlat est { result } ");
            Console.WriteLine($"MAIN: Le resutlat est { Somme(72, 24) } ");

            Console.WriteLine($"// Third // method");
            // Third Method (Say)

            Say("Bonjour !", "Bruno");
            Say("Comment ca vas-tu ?", "John");
            Say("Salut à tous !");
            Say(name: "Chris", message: "Je te vois !");

            Console.WriteLine($"// Foorty // method");
            // Foorty Method (ResetNumber) (ref)

            int number = 10;
            int number2 = 25;

            Console.WriteLine("Number: " + number);
            Console.WriteLine("Number2: " + number2);

            ResetNumber(ref number, ref number2);

            Console.WriteLine("Number: " + number);
            Console.WriteLine("Number2: " + number2);

            Console.WriteLine($"// Fifty // method");
            // Fifty Methods (ChangeValue) (out)

            int valeur = 15;
            Console.WriteLine("Value: " + valeur);
            ChangeValue(out valeur);
            Console.WriteLine("Value: " + valeur);

        }

        // First Method (function flecher sans accolade pour les functions écrite en une seule ligne)
        public static void Hello() => Console.WriteLine("Hello World!");
        // Second Method
        public static int Somme(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"SOMME: Le resutlat est { result } ");
            return result;
        }
        // Third Method
        public static string Say(string message, string name = "Anonyme")
        {
            Console.WriteLine(name + " : " + message);
            return name + " : " + message;
        }
        // foorty Method
        public static void ResetNumber(ref int nb, ref int nb2)
        {
            nb = 0;
            nb2 = 0;
        }
        // Fifty Method
        public static void ChangeValue(out int val) => val = 5;

    }
}
