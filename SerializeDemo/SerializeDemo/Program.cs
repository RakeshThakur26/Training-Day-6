using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
namespace SerializeDemo
{
    [Serializable]
    class Program
    {

        static void Main(string[] args)
        {
            Person obj = new Person();
            obj.city = new City();
            obj.name = "Rakesh";
            obj.age = 22;
            obj.city.name = "Bangalore";
            obj.city.population = 3000;

            //var binaryformat = new BinaryFormatter();
            //Stream sh = new FileStream(@"C:\Training\Training-Day-6\SerialisationExample\SerialisationExample\Sample.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //binaryformat.Serialize(sh, obj);
            //sh.Close();
            //Console.WriteLine("Object serialized");


            //sh = new FileStream(@"C:\Training\Training-Day-6\SerialisationExample\SerialisationExample\Sample.txt", FileMode.Open, FileAccess.Read);
            //Person person = (Person)binaryformat.Deserialize(sh);
            //Console.WriteLine("object deserialized");
            //Console.WriteLine(person.name);
            //Console.WriteLine(person.age);
            //Console.WriteLine(person.city.name);
            //Console.WriteLine(person.city.population);

            XmlSerializer sr = new XmlSerializer(typeof(Person));
            FileStream fl = File.Create(@"C:\Training\SerializeDemo\SerializeDemo\sample.txt");

            sr.Serialize(fl, obj);
            fl.Close();

            XmlSerializer reader = new XmlSerializer(typeof(Person));
            FileStream fs = File.OpenRead(@"C:\Training\SerializeDemo\SerializeDemo\sample.txt");

            Person p = (Person)reader.Deserialize(fs);

            Console.WriteLine("object deserialized");
            Console.WriteLine(p.name);
            Console.WriteLine(p.age);
            Console.WriteLine(p.city.name);
            Console.WriteLine(p.city.population);

            Console.Read();


        }

    }
    [Serializable]
    public class City
    {
        public string name { get; set; }
        public int population { get; set; }

    }

    [Serializable]
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public City city { get; set; }
    }
}
