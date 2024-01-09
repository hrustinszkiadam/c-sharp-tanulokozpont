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

      private static void PrintCourseWithIndex()
      {
         for (int i = 0; i < Database.courses.Count; i++)
         {
            Console.WriteLine($"{i + 1}. {Database.courses[i].Name}");
         }
      }

      public static void Delete()
      {
         Console.Clear();
         Console.WriteLine($"{Types.COURSE_TYPE} törlése");
         Console.WriteLine("===============");
         Console.WriteLine();

         PrintCourseWithIndex();

         int index = GetInfo.ChooseIndex(Types.COURSE_TYPE, Database.courses.Count);
         Database.courses.RemoveAt(index);
      }

      public static void Modify()
      {
         Console.Clear();
         Console.WriteLine($"{Types.COURSE_TYPE} módosítása");
         Console.WriteLine("=================");
         Console.WriteLine();

         PrintCourseWithIndex();
         int index = GetInfo.ChooseIndex(Types.COURSE_TYPE, Database.courses.Count);

         Console.Clear();
         Console.WriteLine("Mit szeretnél módosítani?");
         Console.WriteLine("1. Név");
         Console.WriteLine("2. Leírás");
         Console.WriteLine("3. Mindkettő");
         Console.WriteLine("4. Vissza");

         int modifyType = GetInfo.GetAction(4);

         switch (modifyType)
         {
            case 1:
               Database.courses[index].Name = GetInfo.GetName(Types.COURSE_TYPE);
               break;
            case 2:
               Database.courses[index].Description = GetInfo.GetDescription();
               break;
            case 3:
               Database.courses[index] = GetInfo.GetCourseInfo();
               break;
            default:
               break;
         }

         Database.courses[index] = GetInfo.GetCourseInfo();
      }
   }
}