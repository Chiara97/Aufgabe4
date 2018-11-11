using System;

namespace Aufgabe4
{
    class Program
    {

        public class Person
        {
            public string FirstName;
            public string LastName;
            public int Age;


            public override string ToString()
            {
                return "Person:" + FirstName + LastName + Age;
            }

        }
        static void Main(string[] args)
        {
            Person[] Personen = new Person[5];
            Personen[0] = new Person {FirstName = "Ana ", LastName = "Müller ", Age = 25};
            Personen[1] = new Person {FirstName = "Lena ", LastName = "Meiler ", Age = 45};
            Personen[2] = new Person {FirstName = "Lukas ", LastName = "Meyer ", Age = 52};
            Personen[3] = new Person {FirstName = "Alexander ", LastName = "Groß ", Age = 11};
            Personen[4] = new Person {FirstName = "Gerda ", LastName = "Klein ", Age = 9};

            int i = 0;
            while (i<Personen.Length)
            {
                if (Personen[i].Age > 20)
                {
                    Console.WriteLine(Personen[i].FirstName + Personen[i].LastName + Personen[i].Age);
                }
                i++;
            }
        }
    }
}
