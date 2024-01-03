namespace tanulokozpont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student john = new("John Doe", new DateTime(1997, 9, 5));
            Student jane = new("Jane Doe", new DateTime(2001, 12, 31));
            Student jack = new("Jack Doe", new DateTime(1995, 6, 7));
            Student jill = new("Jill Doe", new DateTime(1999, 3, 21));
            Student vanessa = new("Vanessa Doe", new DateTime(1994, 10, 14));

            Course math = new("Math", "Mathematics");
            Course english = new("English", "English language");
            Course physics = new("Physics", "Low level physics");

            Instructor mrSmith = new("Mr. Smith");
            Instructor mrWhite = new("Mr. White");


            Console.ReadKey();
        }
    }
}