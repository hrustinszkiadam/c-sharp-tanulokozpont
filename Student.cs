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

      public object GetAverageGrade()
      {
         double sum = 0;
         foreach (int grade in Grades)
            sum += grade;
         
         return double.IsNaN(sum / Grades.Count) ? "Nincs jegy" : (sum / Grades.Count);
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
      }

      public static void Add()
      {
         Console.Clear();
         Console.WriteLine($"{Types.STUDENT_TYPE} hozzáadása");
         Console.WriteLine("=================");
         Console.WriteLine();

         Database.students.Add(GetInfo.GetStudentInfo());
      }

      public static void Delete() {
         Console.Clear();
         Console.WriteLine($"{Types.STUDENT_TYPE} törlése");
         Console.WriteLine("===============");
         Console.WriteLine();

         for(int i = 0; i < Database.students.Count; i++)
         {
            Console.WriteLine($"{i + 1}. {Database.students[i].Name} - ({Database.students[i].BirthDate:yyyy.MM.dd})");
         }

         int index = Database.ChooseIndex(Types.STUDENT_TYPE, Database.students.Count);
         Database.students.RemoveAt(index);
      }
   }
}