namespace tanulokozpont
{
   class Instructor(string name)
   {
      public string Name { get; set; } = name;
      public List<Course> Courses { get; set; } = new List<Course>();

      public void AddCourse(Course course)
      {
         Courses.Add(course);
      }

      public void ListCourses()
      {
         foreach (Course course in Courses)
         {
            Console.WriteLine(course.Name);
         }
      }
   }
}