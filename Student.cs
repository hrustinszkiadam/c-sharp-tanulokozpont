namespace tanulokozpont
{
   class Student 
   {
      public string Name { get; set; }
      public DateTime BirthDate { get; set; }
      public List<int> Grades { get; set; }

      public Student(string name, DateTime birthDate)
      {
         Name = name;
         BirthDate = birthDate;
         Grades = new List<int>();
      }

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
   }
}