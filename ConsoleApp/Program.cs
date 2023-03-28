using Model;
using System;

namespace Model
{
    /// <summary>
    /// Класс Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Класс Main
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Let's create a list and add 7 people.");
            Console.WriteLine();
            var listOfPeople = new PersonList();
            var rnd = new Random();

            for (var i = 0; i < 8; i++)
            {
                PersonBase rndPerson = rnd.Next(2) == 0
                    ? Adult.GetRandomPerson()
                    : Adult.GetRandomPerson();
                listOfPeople.AddPerson(rndPerson);
            }

            _ = Console.ReadKey();

            Console.WriteLine("Let's print all people from the list.");
            Console.WriteLine();
            PrintList(listOfPeople);

            _ = Console.ReadKey();

            Console.WriteLine
                ("Let's find out type of the forth person from the list.");
            Console.WriteLine();
            var person = listOfPeople.FindPersonByIndex(3);

            _ = Console.ReadKey();
        }

        /// <summary>
        /// Function which allows to print a certain list of people.
        /// </summary>
        /// <param name="personList">An instance of class PersonList.</param>
        private static void PrintList(PersonList personList)
        {
            if (personList == null)
            {
                throw new NullReferenceException("Null reference list.");
            }

            if (personList.NumberOfPeople != 0)
            {
                for (int i = 0; i < personList.NumberOfPeople; i++)
                {
                    var tmpPerson = personList.FindPersonByIndex(i);
                    Console.WriteLine(tmpPerson.GetInfoAdult());
                }
            }
            else
            {
                Console.WriteLine("List is empty.");
            }
        }
    }
}