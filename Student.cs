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
   }
}