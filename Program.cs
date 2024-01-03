namespace tanulokozpont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student("John Doe", new DateTime(1997, 9, 5));
            Student jane = new Student("Jane Doe", new DateTime(2001, 12, 31));
            Student jack = new Student("Jack Doe", new DateTime(1995, 6, 7));
            Student jill = new Student("Jill Doe", new DateTime(1999, 3, 21));
            Student vanessa = new Student("Vanessa Doe", new DateTime(1994, 10, 14));

            Course math = new Course("Math", "Mathematics");
            Course english = new Course("English", "English language");
            Course physics = new Course("Physics", "Low level physics");

            Instructor mrSmith = new Instructor("Mr. Smith");
            Instructor mrWhite = new Instructor("Mr. White");


            Console.ReadKey();
        }
    }
}