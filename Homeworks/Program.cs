using Homeworks;

Data data = new Data();
List<Person> people = new List<Person>();

using (StreamReader sr = new StreamReader(data.path))
{
    while (!sr.EndOfStream)
    {
        Person person = new Person
        {
            Name = sr.ReadLine(),
            Surname = sr.ReadLine(),
            Age = Convert.ToInt32(sr.ReadLine()),
            MyAddress = new Address
            {
                Country = sr.ReadLine(),
                City = sr.ReadLine(),
                Street = sr.ReadLine(),
                Apartment = sr.ReadLine()
            }
        };

        people.Add(person);

        if (!sr.EndOfStream)
        {
            sr.ReadLine();
        }
    }
}
foreach (var person in people)
{
    Console.WriteLine(person.Name);
    Console.WriteLine(person.Surname);
    Console.WriteLine(person.Age);
    Console.WriteLine(person.MyAddress.Country);
    Console.WriteLine(person.MyAddress.City);
    Console.WriteLine(person.MyAddress.Street);
    Console.WriteLine(person.MyAddress.Apartment);
    Console.WriteLine();
}

