using System;
using Microsoft.Data.Sqlite;
using Dapper;

namespace HelpmePLEASE
{
    public class weirdos
    {
        public int ID {  get; set; }
        public string NAME { get; set; }
        public string FAMILYNAME { get; set; }
        public string EMAIL { get; set; }
        public int PHONE { get; set; }

    }
}
