using OCP.Log.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to exit.");
            Client.LogWrite();
            Console.ReadKey();
        }
    }
}
