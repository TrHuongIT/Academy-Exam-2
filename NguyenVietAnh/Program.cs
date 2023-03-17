using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NguyenVietAnh
{
    internal class Program
    {
        /*
        static Hashtable students = new Hashtable();
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("==================================");
                Console.WriteLine("1. Insert new student...");
                Console.WriteLine("2. Display all the student list...");
                Console.WriteLine("3. Calculator average mark....");
                Console.WriteLine("4. Exit.");
                Console.WriteLine("==================================");
                Console.Write("Option: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InsertNewStudent();
                        break;
                    case 2:
                        DisplayAllStudents();
                        break;
                    case 3:
                        CalculatorAverageMark();
                        break;
                    case 4:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (choice != 4);
        }
    
        static void InsertNewStudent()
        {
            Console.WriteLine("Enter student information:");

            Console.Write("StudID: ");
            int studID = int.Parse(Console.ReadLine());

            Console.Write("StudName: ");
            string studName = Console.ReadLine();

            Console.Write("StudGender: ");
            string studGender = Console.ReadLine();

            Console.Write("StudAge: ");
            int studAge = int.Parse(Console.ReadLine());

            Console.Write("StudClass: ");
            string studClass = Console.ReadLine();

            float[] marks = new float[3];
            Console.WriteLine("Enter marks:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Mark {i + 1}: ");
                marks[i] = float.Parse(Console.ReadLine());
            }

            Student student = new Student(studID, studName, studGender, studAge, studClass);
            student[0] = marks[0];
            student[1] = marks[1];
            student[2] = marks[2];
            student.CalAvg();

            students[studID] = student;
        }

        static void DisplayAllStudents()
        {
            Console.WriteLine("All Students:");
            foreach (DictionaryEntry student in students)
            {
                ((IStudent)student.Value).Print();
            }
        }

        static void CalculatorAverageMark()
        {
            Console.WriteLine("Calculating average marks:");
            foreach (DictionaryEntry student in students)
            {
                Student s = (Student)student.Value;
                s.CalAvg();
                s.Print();
            }
        }
        */
        static Hashtable studentTable = new Hashtable();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("==================================");
                Console.WriteLine("1. Insert new student...");
                Console.WriteLine("2. Display all the student list...");
                Console.WriteLine("3. Calculate average mark....");
                Console.WriteLine("4. Exit");
                Console.WriteLine("==================================");
                Console.Write("Option: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        InsertNewStudent();
                        break;
                    case 2:
                        DisplayAllStudents();
                        break;
                    case 3:
                        CalculateAverageMark();
                        break;
                    case 4:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
                        break;
                }
            }
        }

        static void InsertNewStudent()
        {
            Console.WriteLine("\nInserting new student...");

            Console.Write("StudID: ");
            int studID;
            if (!int.TryParse(Console.ReadLine(), out studID))
            {
                Console.WriteLine("Invalid input for StudID! Please enter an integer.");
                return;
            }

            Console.Write("StudName: ");
            string studName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(studName))
            {
                Console.WriteLine("Student name cannot be empty. Please enter student name:");
                studName = Console.ReadLine();
            }

            Console.Write("StudGender (M for Male/F for Female): ");
            string studGender = Console.ReadLine();
            while (studGender != "M" && studGender != "F")
            {
                Console.WriteLine("Invalid gender. Please enter student gender (M for Male/F for Female):");
                studGender = Console.ReadLine();
            }

            Console.Write("StudAge: ");            
            int studAge;
            if (!int.TryParse(Console.ReadLine(), out studAge))
            {
                Console.WriteLine("Invalid input for StudAge! Please enter an integer.");
                return;
            }

            Console.Write("StudClass: ");
            string studClass = Console.ReadLine();

            float[] markList = new float[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Mark {i + 1}: ");
                if (!float.TryParse(Console.ReadLine(), out markList[i]))
                {
                    Console.WriteLine($"Invalid input for Mark {i + 1}! Please enter an integer.");
                    return;
                }
            }

            Student newStudent = new Student(studID, studName, studGender, studAge, studClass);
            for (int i = 0; i < 3; i++)
            {
                newStudent[i] = markList[i];
            }

            studentTable.Add(studID, newStudent);

            Console.WriteLine("New student added successfully!");
        }

        static void DisplayAllStudents()
        {
            Console.WriteLine("\nDisplaying all the student list...");

            foreach (DictionaryEntry entry in studentTable)
            {
                IStudent student = (IStudent)entry.Value;
                student.Print();
            }
        }

        static void CalculateAverageMark()
        {
            Console.WriteLine("\nCalculating average mark...");

            foreach (DictionaryEntry entry in studentTable)
            {
                Student student = (Student)entry.Value;
                student.CalAvg();
                student.Print();
            }
        }
    }
}



