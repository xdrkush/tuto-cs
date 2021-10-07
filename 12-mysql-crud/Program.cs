using System;
using MySql.Data.MySqlClient;

namespace Version
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connexion
            string cs = @"server=localhost;userid=tuto;password=tuto$;database=aspsql";
            using var con = new MySqlConnection(cs);
            con.Open();
            Console.WriteLine($"Your Connexion MySQL version : {con.ServerVersion}");

            // Select
            var stm = "SELECT VERSION()";
            var cmd = new MySqlCommand(stm, con);
            var version = cmd.ExecuteScalar().ToString();
            Console.WriteLine($"First Select SQL MySQL version: {version}");

            // Drop Table
            cmd.CommandText = "DROP TABLE IF EXISTS cars";
            cmd.ExecuteNonQuery();

            // Création de la table
            cmd.CommandText = @"CREATE TABLE cars(id INTEGER PRIMARY KEY AUTO_INCREMENT,
                    name TEXT, price INT)";
            cmd.ExecuteNonQuery();

            // Insert Into
            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Audi',52642)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Mercedes',57127)";
            cmd.ExecuteNonQuery();
            Console.WriteLine("Table cars created");

            // Préparation d'une requète
            var sql = "INSERT INTO cars(name, price) VALUES(@name, @price)";
            cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@name", "BMW");
            cmd.Parameters.AddWithValue("@price", 36600);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            // Read 1
            sql = "SELECT * FROM cars";
            cmd = new MySqlCommand(sql, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine("{0} {1} {2}", rdr.GetInt32(0), rdr.GetString(1),
                        rdr.GetInt32(2));
            }

            // // Read 2
            // sql = "SELECT * FROM cars";
            // cmd = new MySqlCommand(sql, con);
            // using MySqlDataReader rdr = cmd.ExecuteReader();
            // Console.WriteLine($"{rdr.GetName(0),-4} {rdr.GetName(1),-10} {rdr.GetName(2),10}");
            // while (rdr.Read())
            // {
            //     Console.WriteLine($"{rdr.GetInt32(0),-4} {rdr.GetString(1),-10} {rdr.GetInt32(2),10}");
            // }

        }
    }
}