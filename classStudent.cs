using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class classStudent
    {
        public string Name { get; set; }
        public int Rollno { get; set; }
        public string Course { get; set; }
        public int Age { get; set; }

    
        public void Display()
        {
            Console.WriteLine("The student of name : " + Name + " of his age : " + Age + " of rollnumber : " + Rollno + " is enrolled in branch : " + Course);
        }
    }
}
