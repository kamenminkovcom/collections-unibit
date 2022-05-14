
namespace People
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Occupation { get; set; }

        public Person(string name, int age, string occupation)
        {
            Age = age;
            Name = name;
            Occupation = occupation;
        }
    }
}
