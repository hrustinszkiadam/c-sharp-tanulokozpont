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
         foreach (Student student in Students)
         {
            Console.WriteLine(student.Name);
         }
      }
   }
}