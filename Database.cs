namespace tanulokozpont
{
   static class Database
   {
      public static List<Student> students;
      public static List<Instructor> instructors;
      public static List<Course> courses;

      public static void Init() {
         students = new List<Student>();
         instructors = new List<Instructor>();
         courses = new List<Course>();
      }
   }
}