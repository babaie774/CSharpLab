using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    class Person {
        public int id { get; set;}
        public string name { get; set;}
        public string family {get;set;}

        public Person(int id = 0, string name = "", string family = "") {
                this.id = id;
                this.name = name;
                this.family = family;
        }
    }
}