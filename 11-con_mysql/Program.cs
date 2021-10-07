using System;
using MySql.Data.MySqlClient;

namespace Version
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = @"server=localhost;userid=tuto;password=tuto$;database=aspsql";

            using var con = new MySqlConnection(cs);
            con.Open();

            Console.WriteLine($"Your MySQL version : {con.ServerVersion}");
        }
    }
}