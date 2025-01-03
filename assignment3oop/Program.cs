namespace assignment3oop
{
    public struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1 part2
            //Person[] people = new Person[3];

            //people[0] = new Person { Name = "Alice", Age = 30 };
            //people[1] = new Person { Name = "Bob", Age = 40 };
            //people[2] = new Person { Name = "Charlie", Age = 25 };

            //foreach (var person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}
            #endregion
            #region q2 part2
            Person[] people = new Person[3];

           
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter name: ");
                people[i].Name = Console.ReadLine();

                Console.Write("Enter age: ");
                people[i].Age = int.Parse(Console.ReadLine());
            }

           
            Person oldestPerson = people[0];

            foreach (var person in people)
            {
                if (person.Age > oldestPerson.Age)
                {
                    oldestPerson = person;
                }
            }

         
            Console.WriteLine($"The oldest person is {oldestPerson.Name} with age {oldestPerson.Age}");
        }
        #endregion
    }
    }
