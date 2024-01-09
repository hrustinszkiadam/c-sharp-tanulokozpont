namespace tanulokozpont
{
   static class GetInfo
   {
        public static string GetName(string type)
      {
         Console.Write($"{type} neve: ");
         string name;
         while (true)
         {
               name = Console.ReadLine() ?? "";
               if (name.Length > 0) {
                  if(type == Types.COURSE_TYPE) break;
                  if(name.Split(' ').Length > 1) break;
                  else Console.WriteLine("A névnek legalább két szóból kell állnia!");
               }
               Console.Write($"{type} neve: ");
         }
         return name;
      }

        public static DateTime GetBirthDate()
        {
            DateTime birthDate;
            while (true)
            {
                Console.Write("Születési dátum (éééé.hh.nn): ");
                string input = Console.ReadLine() ?? "";
                if (input.Length == 10)
                {
                    if (DateTime.TryParse(input, out birthDate)) break;
                    else Console.WriteLine("Hibás dátum!");
                }
                else Console.WriteLine("Hibás dátum!");
            }

            return birthDate;
        }
        
        public static string GetDescription()
        {
            Console.Write("Leírás: ");
            string description;
            while (true)
            {
                description = Console.ReadLine() ?? "";
                if (description.Length > 0) break;
                Console.Write("Leírás: ");
            }
            return description;
        }

        public static Student GetStudentInfo()
        {
            string name = GetName(Types.STUDENT_TYPE);
            DateTime birthDate = GetBirthDate();
            return new(name, birthDate);
        }

        public static Instructor GetInstructorInfo()
        {
            return new(GetName(Types.INSTRUCTOR_TYPE));
        }

        public static Course GetCourseInfo()
        {
            string name = GetName(Types.COURSE_TYPE);
            string description = GetDescription();
            return new(name, description);
        }

        public static int GetAction(int numberOfActions)
        {
            Console.Write("Választás: ");
            int action = 0;
            while (true)
            {
                try
                {
                    action = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Választás: ");
                    continue;
                }
                if (action < 1 || action > numberOfActions)
                {
                    Console.Write("Választás: ");
                    continue;
                }
                break;
            }
            return action;
        }
        
        public static int ChooseIndex(string type, int listLength)
        {
            int index = -1;
            while (index < 0 || index >= listLength)
            {
            Console.Write($"Kérem a {type} sorszámát: ");
            index = int.Parse(Console.ReadLine() ?? "0") - 1;
            }

            return index;
        }

        public static int GetGrade()
        {
            int grade = 0;
            while (grade < 1 || grade > 5)
            {
                Console.Write("Kérem a jegyet: ");
                grade = int.Parse(Console.ReadLine() ?? "0");
            }

            return grade;
        }
   }
}