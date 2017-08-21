using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using Week3_Task8;

namespace Week3_Task8
{
    [Serializable]
    class Person:ISerializable
    {
        public Person()
        {

        }

        private string name_value;
        public string Name
        {
            get { return name_value; }
            set { name_value = value; }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("props", name_value, typeof(string));
        }

        public Person(SerializationInfo info, StreamingContext context)
        {
            name_value = (string)info.GetValue("props", typeof(string));
        }



    }
}
