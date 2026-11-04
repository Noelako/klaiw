using System;
using Microsoft.Data.Sqlite;
using Dapper;
using System.Linq;

namespace HelpmePLEASE
{
    internal class selectweirdos
    {
        public static void selectness(int ID)
        {


            string path = @"C:\Users\Praktiki3\Git\help.db";

            using var connection =
                new SqliteConnection($"Data Source={path}");

            connection.Open();

            string selectQuery = @"
            SELECT * 
            FROM BIG_JOHN
            WHERE ID=@ID;";
            
                var result = connection.Query<weirdos>(selectQuery, new { ID });
            if (result.Any())
            {
                foreach (var weirdos in result)
                {
                    Console.WriteLine(weirdos.NAME);
                    Console.WriteLine(weirdos.FAMILYNAME);
                    Console.WriteLine(weirdos.EMAIL);
                    Console.WriteLine(weirdos.PHONE);
                }
            }
            else 
            {
                Console.WriteLine("THERE IS NO ID YOU WROTE");
            }
            

            
            //connection.Execute(selectQuery, new
            //{
            //    NAME,
            //    FAMILYNAME,
            //    EMAIL,
            //    PHONE
            //});

            Console.WriteLine("ididit");
        }

    }


}

