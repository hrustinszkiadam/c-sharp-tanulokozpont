namespace tanulokozpont
{
   class Student (string name, DateTime birthDate)
   {
      public string Name { get; set; } = name;
      public DateTime BirthDate { get; set; } = birthDate;
      public List<int> Grades { get; set; } = new List<int>();

      public void AddGrade(int grade)
      {
         Grades.Add(grade);
      }

      public double GetAverageGrade()
      {
         double sum = 0;
         foreach (int grade in Grades)
            sum += grade;
         
         return sum / Grades.Count;
      }

      public static void List()
      {
         Console.Clear();
         Console.WriteLine($"{Types.STUDENT_TYPE_PLURAL} listája");
         Console.WriteLine("===============");
         Console.WriteLine();

         foreach (Student student in Database.students)
         {
            Console.WriteLine($"{student.Name} - ({student.BirthDate:yyyy.MM.dd})");
            Console.WriteLine($"Átlag: {student.GetAverageGrade()}");
            Console.WriteLine();
         }

         Console.Write("Nyomj meg egy gombot a folytatáshoz... ");
         Console.ReadKey();
      }

      public static void Add()
      {
         Console.Clear();
         Console.WriteLine($"{Types.STUDENT_TYPE} hozzáadása");
         Console.WriteLine("=================");
         Console.WriteLine();

         Database.students.Add(GetInfo.GetStudentInfo());
      }
   }
}