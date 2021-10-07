using System;

class App
{
    static void Main(string[] args)
    {
        int numberOfUsers = 0;

        Console.WriteLine(numberOfUsers);

        numberOfUsers = 2 ;
        Console.WriteLine(numberOfUsers);

        
        numberOfUsers = numberOfUsers + 20 ;
        Console.WriteLine(numberOfUsers);

        string userName = "drk";
        Console.WriteLine(userName);
        userName = "krd";
        Console.WriteLine(userName);

        string userName2 = "kush";
        Console.WriteLine(userName2);

        userName = userName2;
        Console.WriteLine(userName);

        float myNumber = 3.14f;
        int myNb = 0;

        Console.WriteLine(myNumber);

        // ic on réaffect notre nombre float en int ce qui enlevera les décimals
        myNb = (int)myNumber;

        Console.WriteLine(myNb);

        // 1_000_000 = 1000000 <-- c'est juste plus lisible et la machine le comprend très bien
        int million = 1_000_000;
        Console.WriteLine(million);

        /* 
        Préfixe

        0b pour les binaire
        0b_0110_1101_1100

        0x pour les hexadecimal
        0x_C6F3FF
        */

        /*
        Suffixe
        Long number = 156_588l ou 156_588L;
        long    -> l ou L
        float   -> f ou F;
        double  -> d ou D;
        decimal -> m ou M;

        decimal bigNumber = 155_255_366_566_988m;

        les puissances 10e6 ou 10E6;

        */


    }
}