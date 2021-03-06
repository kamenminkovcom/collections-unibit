using System;
using System.Collections.Generic;
using System.Linq;

/* 
* The problem description could be found in PEOPLE.md file
* PEOPLE.md is located in the root directory of the project
* Link to the description - https://github.com/kamenminkovcom/collections-unibit/blob/master/PEOPLE.md
*/
namespace People
{
    internal class People
    {
        static void Main()
        {
            string STOP_COMMAND = "STOP";
            int YOUTH_LIMIT = 35;
            List<Person> people = new List<Person>();

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

            string searchOccupation = Console.ReadLine();

            List<string> searchPeopleNames = people
                .Where(person => person.Age <= YOUTH_LIMIT && person.Occupation == searchOccupation)
                .Select(person => person.Name)
                .OrderBy(name => name)
                .ToList();

            Console.WriteLine(string.Join(", ", searchPeopleNames));
        }
    }
}
