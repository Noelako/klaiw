using System;
using Microsoft.Data.Sqlite;
using Dapper;

namespace HelpmePLEASE
{
    internal class deleteweirdos
    {
        public static void deleteness(int ID)
        {


            string path = @"C:\Users\Praktiki3\Git\help.db";

            using var connection =
                new SqliteConnection($"Data Source={path}");

            connection.Open();

            string questioningYou = @"
            SELECT * FROM BIG_JOHN
            WHERE ID=@ID;";
            var result = connection.Query<weirdos>(questioningYou, new { ID });
            if (result.Any())
            {
                
                string deleteQuery = @"
             DELETE FROM BIG_JOHN
             WHERE ID=@ID;";

                connection.Execute(deleteQuery, new { ID });
                Console.WriteLine("there is id="+ID+"so I deleted it");
            }
            else
            {
                Console.WriteLine("the ID you wrote doesnt exist :P");
            }
            ;
                
            
            //connection.Execute(deQuery, new
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

