using System;
using System.IO;
using System.Text;

namespace Rein
{
    class Rein
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            System.Console.Write("Content-type: text/html\n");
            System.Console.Write("X-Powered-By: ReinCGI 1.0\n");
=======
            System.Console.Write("HTTP/1.1 200 OK\n");
            System.Console.Write("Server: Rein\n");
            System.Console.Write("Date: " + "\n");
            System.Console.Write("Content-type: text/html\n");
>>>>>>> 3985574edd71f75f78b0c9fe422c3713bdcd4768
            System.Console.Write("\n"); // Close header
            StreamReader ScriptFile = new StreamReader(args[0], Encoding.GetEncoding("utf-8"));
            string body = ScriptFile.ReadToEnd();
            ScriptFile.Close();
            System.Console.Write(body);
        }
    }
}