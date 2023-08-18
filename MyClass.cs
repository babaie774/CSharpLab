using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    //private - default
    //public
    //protected - just acess in the namespace

   class FullName {
        public static string FullNameGenerator() {
                string FullName = MyClass.FullName("alireza","ahmad");
                return FullName;
        }
   }


    class MyClass {
        public static int Sum(int a ,int b) {
            return a + b;
        }

        public static string FullName(string a, string b) {
            return a + b;
        }
    } 
}