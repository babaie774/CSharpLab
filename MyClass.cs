using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
        public class Person {
            public Person(string name,string lastName)
            {
                Name = name;
                LastName = lastName;
            }
            public string Name { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string FullName { 
                get{
                return Name + LastName;
                }
            }
            public override string ToString()
            {
                return FullName;
            }
        }

}