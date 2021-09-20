using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SerialisationExample
{
    [Serializable]
    class SerializeDemo
    {
        public int i = 10;

        public void Print()
        {
            SerializeDemo s = new SerializeDemo();

            var ss = new BinaryFormatter();

            Console.WriteLine("Serialization...");
            FileStream fs = new FileStream(@"C:\Training\Training-Day-6\SerialisationExample\SerialisationExample\temp.txt", FileMode.Create, FileAccess.Write);
            ss.Serialize(fs, s);
            fs.Close();

            FileStream fr = new FileStream(@"C:\Training\Training-Day-6\SerialisationExample\SerialisationExample\temp.txt", FileMode.Open, FileAccess.Read);
            var sd = (SerializeDemo)ss.Deserialize(fr);

            Console.WriteLine("Deserialization...\n" + sd.i);
        }
    }
}
