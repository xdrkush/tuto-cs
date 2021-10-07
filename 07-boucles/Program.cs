using System;

class App
{
    static void Main(string[] args)
    {
        string word = "Hello world !";
        int i = 0;

        // tant que i est inférieur à 5
        while (i < 10)
        {
            Console.WriteLine("1: " + word);
            // On incrémente i
            i++;
        }

        // Boucle inverser (on execute et ensuite on check la conditions)
        do
        {
            Console.WriteLine("2: " + word);
            i++;
        } while (i < 5);

        // Condition dans notre boucle
        int j = 0;
        while (j < 10)
        {
            Console.WriteLine("Condition dans notre boucle");
            j++;

            if (j == 2)
            {
                Console.WriteLine("1: Notre conditions est remplit ! " + j);
                continue;
            }

            if (j == 4)
            {
                Console.WriteLine("2: Notre conditions est remplit ! " + j);
                break;
            }
        }

        // For
        for (int k = 0; k < 10; k++)
        {
            Console.WriteLine("For: " + k);
            if (k > 3)
                break;
        }

        // Foreach
        string name = "Bruno";
        foreach (char l in name)
        {
            Console.WriteLine(l);
        }

        string[] arrayName = { "Bruno", "Jack", "Philippe" };
        foreach (string firstname in arrayName)
        {
            Console.WriteLine($"name is { firstname }");
        }

    }
}
