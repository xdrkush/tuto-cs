/*
    Environement
*/ 
using System;

class App
{
    static void Main(string[] args)
    {
        // Ici nous auront un retour à la ligne
        Console.WriteLine("Hello World!");
        // On clear le terminal
        Console.Clear();
        // Ici nous écrirons à la suite
        Console.Write("Hello ");
        Console.Write("World!");
        // et on retourne à la ligne!
        Console.WriteLine("");
        // effet sonore du terminal
        Console.Beep(); 

        // Permet de changer le nom de notre fenêtre
        Console.Title = "My First App :)";
        Console.Read();

        // \n permet le retour à la ligne
        Console.Write("Hello \n");
        // \t permet de faire une tabulation
        Console.Write("\t World!");
    }
}
