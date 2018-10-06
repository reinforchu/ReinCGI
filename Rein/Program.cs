using System;
using System.IO;
using System.Text;

namespace Rein
{
    class Rein
    {
        static void Main(string[] args)
        {
            System.Console.Write("Content-type: text/html\n");
            System.Console.Write("X-Powered-By: ReinCGI 1.0\n");
            System.Console.Write("\n"); // Close header
            StreamReader ScriptFile = new StreamReader(args[0], Encoding.GetEncoding("utf-8"));
            string body = ScriptFile.ReadToEnd();
            ScriptFile.Close();
            System.Console.Write(body);
        }
    }
}