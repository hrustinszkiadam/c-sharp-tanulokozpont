namespace tanulokozpont
{
   class Instructor
   {
      public string Name { get; set; }
      public List<Course> Courses { get; set; }

      public Instructor(string name)
      {
         Name = name;
         Courses = new List<Course>();
      }

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