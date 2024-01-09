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
      }

      public static void Add()
      {
         Console.Clear();
         Console.WriteLine($"{Types.INSTRUCTOR_TYPE} hozzáadása");
         Console.WriteLine("=================");
         Console.WriteLine();

         Database.instructors.Add(GetInfo.GetInstructorInfo());
      }

      private static void PrintInstructorWithIndex()
      {
         for (int i = 0; i < Database.instructors.Count; i++)
         {
            Console.WriteLine($"{i + 1}. {Database.instructors[i].Name}");
         }
      }

      public static void Delete()
      {
         Console.Clear();
         Console.WriteLine($"{Types.INSTRUCTOR_TYPE} törlése");
         Console.WriteLine("===============");
         Console.WriteLine();

         PrintInstructorWithIndex();

         int index = GetInfo.ChooseIndex(Types.INSTRUCTOR_TYPE, Database.instructors.Count);
         Database.instructors.RemoveAt(index);
      }

      public static void Modify()
      {
         Console.Clear();
         Console.WriteLine($"{Types.INSTRUCTOR_TYPE} módosítása");
         Console.WriteLine("=================");
         Console.WriteLine();

         PrintInstructorWithIndex();

         int index = GetInfo.ChooseIndex(Types.INSTRUCTOR_TYPE, Database.instructors.Count);
         Database.instructors[index] = GetInfo.GetInstructorInfo();
      }
   }
}