using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Framework.Base
{
    public class Person : Framework.Interface.Iperson
    {
        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get ; set ; }
        public string Surname { get ; set ; }
    }
}
