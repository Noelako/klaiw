
using Microsoft.Data.Sqlite;

class Program
{
    static void Main()
    {
        string path = @"C:\Users\Praktiki3\Git\help.db";

        using var connection = new SqliteConnection($"Data Source={path}");

        connection.Open();

        Console.WriteLine("CONNECTED SUCCESSFULLY!");

        string[] tables =
        {
            "BIG_JOHN",
            "MONSTER_JACK",
            "QUEEN_MARIA"
        };

        foreach (string table in tables)
        {
            Console.WriteLine("\n=== " + table + " ===");

            string sql = $"SELECT * FROM \"{table}\"";

            using var command =
                new SqliteCommand(sql, connection);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string column = reader.GetName(i);

                    string value = reader.IsDBNull(i)
                        ? "NULL"
                        : reader.GetValue(i).ToString()!;

                    Console.WriteLine($"{column}: {value}");
                }

                Console.WriteLine("----------------");
            }
        }
    }
}