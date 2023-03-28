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
            Console.WriteLine("Добавить 7 случайных человек в список?\n");
            var listPeople = new PersonList();
            var rrandom = new Random();

            for (var i = 0; i < 7; i++)
            {
                PersonBase randomPerson = rrandom.Next(2) == 0
                    ? Adult.GetRandomPerson()
                    : Child.GetRandomPerson();
                listPeople.AddPerson(randomPerson);
            }

            _ = Console.ReadKey();

            Console.WriteLine("Информация о сгенерированных людях:\n");
            PrintList(listPeople);

            _ = Console.ReadKey();

            Console.Write("Тип четвертого человека из списка: ");
            var person = listPeople.FindPersonByIndex(3);

            Console.Write(person.GetType());
            _ = Console.ReadKey();
        }

        /// <summary>
        /// Метод, который выводит в консоль информацию о каждом человеке 
        /// в списке людей.
        /// </summary>
        /// <param name="personList">Экземпляр класса PersonList.</param>
        private static void PrintList(PersonList personList)
        {
            if (personList == null)
            {
                throw new NullReferenceException("Пустой список людей");
            }

            if (personList.NumberOfPeople != 0)
            {
                for (int i = 0; i < personList.NumberOfPeople; i++)
                {
                    var tmpPerson = personList.FindPersonByIndex(i);
                    Console.WriteLine(tmpPerson.GetInfo());
                }
            }
            else
            {
                Console.WriteLine("Список пуст");
            }
        }
    }
}