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

      private static void PrintStudentWithIndex()
      {
         for (int i = 0; i < Database.students.Count; i++)
         {
            Console.WriteLine($"{i + 1}. {Database.students[i].Name} - ({Database.students[i].BirthDate:yyyy.MM.dd})");
         }
      }

      public static void Delete()
      {
         Console.Clear();
         Console.WriteLine($"{Types.STUDENT_TYPE} törlése");
         Console.WriteLine("===============");
         Console.WriteLine();

         PrintStudentWithIndex();

         int index = GetInfo.ChooseIndex(Types.STUDENT_TYPE, Database.students.Count);
         Database.students.RemoveAt(index);
      }

      public static void Modify()
      {
         Console.Clear();
         Console.WriteLine($"{Types.STUDENT_TYPE} módosítása");
         Console.WriteLine("=================");
         Console.WriteLine();

         PrintStudentWithIndex();
         int index = GetInfo.ChooseIndex(Types.STUDENT_TYPE, Database.students.Count);

         Console.Clear();
         Console.WriteLine("Mit szeretnél módosítani?");
         Console.WriteLine("1. Jegy hozzáadása");
         Console.WriteLine("2. Tanuló adatainak módosítása");
         Console.WriteLine("3. Vissza");


         int modifyType = GetInfo.GetAction(3);

         switch (modifyType) 
         {
            case 1:
               Database.students[index].AddGrade(GetInfo.GetGrade());
               break;
            case 2:
               Console.Clear();
               Console.WriteLine("Mit szeretnél módosítani?");
               Console.WriteLine("1. Név");
               Console.WriteLine("2. Születési dátum");
               Console.WriteLine("3. Mindkettő");
               Console.WriteLine("4. Vissza");

               int modifyDataType = GetInfo.GetAction(4);

               switch (modifyDataType)
               {
                  case 1:
                     Database.students[index].Name = GetInfo.GetName(Types.STUDENT_TYPE);
                     break;
                  case 2:
                     Database.students[index].BirthDate = GetInfo.GetBirthDate();
                     break;
                  case 3:
                     Database.students[index] = GetInfo.GetStudentInfo();
                     break;
                  default:
                     break;
               }
               break;
            default:
               break;
         }
      }
   }
}