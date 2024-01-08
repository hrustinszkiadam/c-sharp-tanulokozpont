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
         Console.WriteLine($"{Types.COURSE_TYPE_PLURAL}: ", (", ", Courses.Select(course => course.Name)));
      }

      public static void List()
      {
         Console.Clear();
         Console.WriteLine($"{Types.INSTRUCTOR_TYPE_PLURAL} listája");
         Console.WriteLine("===============");
         Console.WriteLine();

         foreach (Instructor instructor in Database.instructors)
         {
            Console.WriteLine($"{instructor.Name}");
            instructor.ListCourses();

         }
         Console.Write("Nyomj meg egy gombot a folytatáshoz... ");
         Console.ReadKey();
      }

      public static void Add()
      {
         Console.Clear();
         Console.WriteLine($"{Types.INSTRUCTOR_TYPE} hozzáadása");
         Console.WriteLine("=================");
         Console.WriteLine();

         Database.instructors.Add(GetInfo.GetInstructorInfo());
      }
   }
}