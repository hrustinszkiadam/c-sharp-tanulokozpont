using System;   
using System.Collections.Generic;
using System.Linq;  
using System.Threading.Tasks;

namespace tanulokozpont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                PrintMainMenu();

                int mainAction = GetInfo.GetAction(5);
                if(mainAction == 5) return;

                PrintNextMenu();
                int nextAction = GetInfo.GetAction(4);
                if(nextAction == 4) continue;

                switch (mainAction)
                {
                    case 1:
                        switch (nextAction)
                        {
                            case 1:
                                Student.List();
                                break;
                            case 2:
                                Instructor.List();
                                break;
                            case 3:
                                Course.List();
                                break;
                        }
                        break;
                    case 2:
                        switch (nextAction)
                        {
                            case 1:
                                Student.Add();
                                break;
                            case 2:
                                Instructor.Add();
                                break;
                            case 3:
                                Course.Add();
                                break;
                        }
                        break;
                    /*
                    case 3:
                        switch (nextAction)
                        {
                            case 1:
                                Student.Modify();
                                break;
                            case 2:
                                Instructor.Modify();
                                break;
                            case 3:
                                Course.Modify();
                                break;
                        }
                        break;
                    */
                    case 4:
                        switch (nextAction)
                        {
                            case 1:
                                Student.Delete();
                                break;
                            case 2:
                                Instructor.Delete();
                                break;
                            case 3:
                                Course.Delete();
                                break;
                        }
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Nyomj meg egy gombot a folytatáshoz...");
                Console.ReadKey();
            }
        }

        static void PrintMainMenu()
        {
            Console.WriteLine("1. Listázás");
            Console.WriteLine("2. Hozzáadás");
            Console.WriteLine("3. Módosítás");
            Console.WriteLine("4. Törlés");
            Console.WriteLine("5. Kilépés");
            Console.WriteLine();
        }

        static void PrintNextMenu()
        {
            Console.Clear();
            Console.WriteLine($"1. {Types.STUDENT_TYPE}");
            Console.WriteLine($"2. {Types.INSTRUCTOR_TYPE}");
            Console.WriteLine($"3. {Types.COURSE_TYPE}");
            Console.WriteLine("4. Vissza");
            Console.WriteLine();
        }
    }
}