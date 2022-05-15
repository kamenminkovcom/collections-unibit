using System;
using System.Collections.Generic;
using System.Linq;

namespace People
{
    internal class People
    {
        static void Main()
        {
            string STOP_COMMAND = "STOP";
            int YOUTH_LIMIT = 35;
            List<Person> people = new List<Person>();

            string searchOccupation = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == STOP_COMMAND)
                {
                    break;
                }

                string[] personInfo = input.Split(' ');
                people.Add(new Person(personInfo[0], int.Parse(personInfo[1]), personInfo[2]));
            }

            List<string> searchPeopleNames = people
                .Where(person => person.Age <= YOUTH_LIMIT && person.Occupation == searchOccupation)
                .Select(person => person.Name)
                .OrderBy(name => name)
                .ToList();

            Console.WriteLine(string.Join(", ", searchPeopleNames));
        }
    }
}
