using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace deep_copy
{
    [Serializable]
    public class Sample
    {
        public string SampleName { get; set; }
        public Persona P = new Persona();
    }
    static class ext
    {
        public static Sample deepCopy<Sample>(this Sample obj)
        {
            using (var memStream = new MemoryStream())
            {
                var bFormatter = new BinaryFormatter();
                bFormatter.Serialize(memStream, obj);
                memStream.Position = 0;

                return (Sample)bFormatter.Deserialize(memStream);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample s1 = new Sample();
            Persona p = new Persona();
            s1.P.Nome = "Pippo";
            s1.SampleName = "Sample number 1";
            Sample s2 = s1.deepCopy();
            s2.SampleName = "Modifica";
            s2.P.Nome = "Pluto";
            Console.WriteLine("Sample 1 = {0}\nPersona: {1}", s1.SampleName,s1.P.Nome);
            Console.WriteLine("Sample 2 = {0}\nPersona: {1}", s2.SampleName,s2.P.Nome);
            Console.ReadKey();
        }
    }
}
