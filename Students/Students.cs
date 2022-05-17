using System;
using System.Collections.Generic;
using System.Linq;

/* 
* The problem description could be found in STUDENTS.md file
* STUDENTS.md is located in the root directory of the project
* Link to the description - https://github.com/kamenminkovcom/collections-unibit/blob/master/STUDENTS.md
*/

namespace Students
{
    internal class Students
    {
        static void Main()
        {
            string stopCommand = "STOP";
            Dictionary<string, Dictionary<string, List<double>>> studentsRecord = new Dictionary<string, Dictionary<string, List<double>>>();

            while(true)
            {
                string input = Console.ReadLine();

                if (input == stopCommand)
                {
                    break;
                }

                string[] studentInfo = input.Split(' ');
                string name = studentInfo[0];
                string subject = studentInfo[1];
                double mark = double.Parse(studentInfo[2]);

                if (!studentsRecord.ContainsKey(studentInfo[0]))
                {
                    studentsRecord.Add(name, new Dictionary<string, List<double>>());
                }

                if (!studentsRecord[name].ContainsKey(subject))
                {
                    studentsRecord[name][subject] = new List<double>();
                }

                studentsRecord[name][subject].Add(mark);
            }

            string searchStudent = Console.ReadLine();

            if (!studentsRecord.ContainsKey(searchStudent))
            {
                return;
            }

            List<string> subjectMarkPairs = studentsRecord[searchStudent]
                .Select(x => new KeyValuePair<string, double>(x.Key, x.Value.Average()))
                .OrderBy(x => x.Value)
                .ThenBy(x => x.Key)
                .Select(x => $"{x.Key} - {x.Value:F2}")
                .ToList();

            Console.WriteLine(string.Join(", ", subjectMarkPairs));
        }
    }
}
