using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Week3_Task10
{
    public interface IFormatter
    {
        SerializationBinder binder { get; set; }
        StreamingContext context { get; set; }
        ISurrogateSelector surrogateselector { get; set; }
        object Deserialize(Stream serializationStream);
        void Serialize(Stream serializationStream, object graph);
    }
    class Program
    {

        static void Main(string[] args)
        {
            
        }
    }
}
