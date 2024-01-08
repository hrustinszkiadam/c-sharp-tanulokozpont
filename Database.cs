namespace tanulokozpont
{
   static class Database
   {
      public static List<Student> students = new();
      public static List<Instructor> instructors = new();
      public static List<Course> courses = new();

      public static int ChooseIndex(string type, int listLength)
      {
         int index = -1;
         while (index < 0 || index >= listLength)
         {
            Console.Write($"Kérem a {type} sorszámát: ");
            index = int.Parse(Console.ReadLine() ?? "0") - 1;
         }

         return index;
      }
   }
}