using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace MySQLConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Database Connection Test!");

            Connection con = new Connection();
            Console.WriteLine("Lines found: " + con.Count("SELECT Count(*) FROM sensor_data"));
            var result = con.Select("SELECT * FROM sensor_data");
            foreach(var line in result)
            {
                Console.WriteLine(line);
            }
        }
    }
}
