using System;
using Microsoft.Data.Sqlite;
using Dapper;

namespace HelpmePLEASE
{
    internal class insertweirdos
    {
        public static void insertness(string NAME, string FAMILYNAME, string EMAIL, int PHONE)
        {


            string path = @"C:\Users\Praktiki3\Git\help.db";

            using var connection =
                new SqliteConnection($"Data Source={path}");

            connection.Open();

            string insertQuery = @"
        INSERT INTO BIG_JOHN
        (NAME, FAMILYNAME, EMAIL, PHONE)
        VALUES
        (@NAME, @FAMILYNAME, @EMAIL, @PHONE);";

            connection.Execute(insertQuery, new
            {
                NAME,
                FAMILYNAME,
                EMAIL,
                PHONE
            });

            Console.WriteLine("ididit");
        }

    }

}

