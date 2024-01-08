namespace tanulokozpont
{
   class Course(string name, string description)
   {
      public string Name { get; set; } = name;
      public string Description { get; set; } = description;
      public List<Student> Students { get; set; } = new List<Student>();

      public void AddStudent(Student student)
      {
         Students.Add(student);
      }

      public void ListStudents()
      {
         Console.WriteLine($"{Types.STUDENT_TYPE_PLURAL}: ", (", ", Students.Select(student => student.Name)));
      }

      public static void List()
      {
         Console.Clear();
         Console.WriteLine($"{Types.COURSE_TYPE_PLURAL} listája");
         Console.WriteLine("================");
         Console.WriteLine();

         foreach (Course course in Database.courses)
         {
            Console.WriteLine($"{course.Name}");
            Console.WriteLine($"Leírás: {course.Description}");
            Console.WriteLine("Résztvevők: ");
            course.ListStudents();
            Console.WriteLine();
         }
      }

      public static void Add()
      {
         Console.Clear();
         Console.WriteLine($"{Types.COURSE_TYPE} hozzáadása");
         Console.WriteLine("=================");
         Console.WriteLine();

         Database.courses.Add(GetInfo.GetCourseInfo());
      }

      public static void Delete()
      {
         Console.Clear();
         Console.WriteLine($"{Types.COURSE_TYPE} törlése");
         Console.WriteLine("===============");
         Console.WriteLine();

         for(int i = 0; i < Database.courses.Count; i++)
         {
            Console.WriteLine($"{i + 1}. {Database.courses[i].Name}");
         }

         int index = Database.ChooseIndex(Types.COURSE_TYPE, Database.courses.Count);
         Database.courses.RemoveAt(index);
      }
   }
}