//using NguyenVietAnh;
//using System;
//using System.Collections;

//namespace StudentManagementSystem
//{
//    class Program
//    {
//        static Hashtable studentTable = new Hashtable();

//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.WriteLine("\nStudent Management System");
//                Console.WriteLine("==========================");
//                Console.WriteLine("1. Insert new student");
//                Console.WriteLine("2. Display all the student list");
//                Console.WriteLine("3. Calculate average mark");
//                Console.WriteLine("4. Exit");
//                Console.Write("Enter your choice: ");

//                int choice;
//                if (!int.TryParse(Console.ReadLine(), out choice))
//                {
//                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
//                    continue;
//                }

//                switch (choice)
//                {
//                    case 1:
//                        InsertNewStudent();
//                        break;
//                    case 2:
//                        DisplayAllStudents();
//                        break;
//                    case 3:
//                        CalculateAverageMark();
//                        break;
//                    case 4:
//                        Console.WriteLine("Exiting program...");
//                        return;
//                    default:
//                        Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
//                        break;
//                }
//            }
//        }

//        static void InsertNewStudent()
//        {
//            Console.WriteLine("\nInserting new student...");

//            Console.Write("StudID: ");
//            int studID;
//            if (!int.TryParse(Console.ReadLine(), out studID))
//            {
//                Console.WriteLine("Invalid input for StudID! Please enter an integer.");
//                return;
//            }

//            Console.Write("StudName: ");
//            string studName = Console.ReadLine();

//            Console.Write("StudGender: ");
//            string studGender = Console.ReadLine();

//            Console.Write("StudAge: ");
//            int studAge;
//            if (!int.TryParse(Console.ReadLine(), out studAge))
//            {
//                Console.WriteLine("Invalid input for StudAge! Please enter an integer.");
//                return;
//            }

//            Console.Write("StudClass: ");
//            string studClass = Console.ReadLine();

//            int[] markList = new int[3];
//            for (int i = 0; i < 3; i++)
//            {
//                Console.Write($"Mark {i + 1}: ");
//                if (!int.TryParse(Console.ReadLine(), out markList[i]))
//                {
//                    Console.WriteLine($"Invalid input for Mark {i + 1}! Please enter an integer.");
//                    return;
//                }
//            }

//            Student newStudent = new Student(studID, studName, studGender, studAge, studClass);
//            for (int i = 0; i < 3; i++)
//            {
//                newStudent[i] = markList[i];
//            }

//            studentTable.Add(studID, newStudent);

//            Console.WriteLine("New student added successfully!");
//        }

//        static void DisplayAllStudents()
//        {
//            Console.WriteLine("\nDisplaying all the student list...");

//            foreach (DictionaryEntry entry in studentTable)
//            {
//                IStudent student = (IStudent)entry.Value;
//                student.Print();
//            }
//        }

//        static void CalculateAverageMark()
//        {
//            Console.WriteLine("\nCalculating average mark...");

//            foreach (DictionaryEntry entry in studentTable)
//            {
//                Student student = (Student)entry.Value;
//                student.CalAvg();
//                student.Print();
//            }
//        }
//    }
//}
