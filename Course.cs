namespace tanulokozpont
{
   class Course
   {
      public string Name { get; set; }
      public string Description { get; set; }
      public List<Student> Students { get; set; }


      public Course(string name, string description)
      {
         Name = name;
         Description = description;
         Students = new List<Student>();
      }

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