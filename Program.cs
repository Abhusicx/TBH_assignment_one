
using System.Security.Cryptography.X509Certificates;
using Assignment1;
namespace Assignment1 
{
    class Program
    {
        static void Main(string[] args)
        {

            classStudent Parth = new classStudent();
            Parth.Name = "parth Shrivastava";
            Parth.Course = "TBP";
            Parth.Age = 21;
            Parth.Rollno = 134;
            Parth.Display();

            classStudent Abhijeet = new classStudent();
            Abhijeet.Name = "Abhijeet thakur";
            Abhijeet.Course = "TBP";
            Abhijeet.Age = 21;
            Abhijeet.Rollno = 1;
            Abhijeet.Display();

            classStudent Chandragupt = new classStudent();
            Chandragupt.Name = "Chandragupt";
            Chandragupt.Course = "ILP";
            Chandragupt.Age = 21;
            Chandragupt.Rollno = 17;
            Chandragupt.Display();

        }
    }
}

