using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using DataAccessLayer;
using Ninject;

namespace ViewConsole
{
    internal class Program
    {

        static void Main(string[] args)
        {
            IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule());
            Logic logic = ninjectKernel.Get<Logic>();

            //logic.AddStudent("a", "b", "c");


            //Console.WriteLine("test");
            //Console.ReadKey();

            //Console.WriteLine();


            while (true)
            {
                Console.Clear();
                PrintStudents(logic);
                Console.WriteLine("\n---------------\n");
                PrintMenu();

                ConsoleKeyInfo answer = Console.ReadKey(true);


                switch (answer.Key)
                {
                    case ConsoleKey.A:
                        AddStudent(logic);
                        break;

                    case ConsoleKey.R:
                        RemoveStudent(logic);
                        break;

                    case ConsoleKey.H:
                        CreateHistogram(logic);
                        break;

                    default:
                        break;
                }

            }

        }
        private static void PrintMenu()
        {
            Console.WriteLine("A - Add new student");
            //Console.WriteLine("P - Print students");
            Console.WriteLine("R - Remove student");
            Console.WriteLine("H - Create histogram");
        }

        private static void PrintStudents(Logic logic)
        {
            Console.WriteLine("List of students: \n");
            foreach (string str in logic.GetAllStudents())
            {
                Console.WriteLine(str);
            }
        }

        private static void RemoveStudent(Logic logic)
        {
            Console.WriteLine("\nEnter ID of student you want to delete");

            while (true)
            {

                string value = Console.ReadLine();
                if (int.TryParse(value, out var number))
                {
                    int ID = number;
                    {
                        logic.RemoveStudent(ID);
                        break;
                    }
                }
                
            }

        }

        private static void AddStudent(Logic logic)
        {
            Console.WriteLine("\nEnter student's name");
            string n = Console.ReadLine();
            Console.WriteLine("Enter student's speciality");
            string s = Console.ReadLine();
            Console.WriteLine("Enter student's group");
            string g = Console.ReadLine();
            logic.AddStudent(n, s, g);
        }

        private static void CreateHistogram(Logic logic)
        {
            foreach (var item in logic.GetHistogram())
            {
                Console.Write(item.Key + " ");
                for (int i = 0; i < item.Value; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
