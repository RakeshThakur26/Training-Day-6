using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace SerialisationExample
{

    class Program
    {
        static void Main()
        {
            SerializeDemo sd = new SerializeDemo();
            sd.Print();
            Console.Read();
        }
    }
}
