using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace github
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (StreamReader rdm = new StreamReader("auto.csv"))
            {
                String line = rdm.ReadToEnd();
                Console.WriteLine(line);
            }
            




                Console.ReadKey();
        }
    }
}
