using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3_Task10;
namespace Week3_Task10
{
    [Serializable]
    class Human
    {
       public string Name { get; set; }

        public Human(string name)
        {
            Name = name;
        }
    }
}
