using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1._1
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }

        public decimal TotalSalary => Salary + Bonus;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = Encoding.UTF8;

            PrintCSharp();
            TestEmployee();
        }

        private static void TestEmployee()
        {
            // Tạo một danh sách các nhân viên
            var employees = new Employee[3];

            // Nhập thông tin cho từng nhân viên
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Nhập thông tin cho nhân viên thứ {i + 1}:");

                var employee = new Employee();

                Console.Write("ID: ");
                employee.Id = int.Parse(Console.ReadLine());

                Console.Write("Họ tên: ");
                employee.Name = Console.ReadLine();

                Console.Write("Địa chỉ: ");
                employee.Address = Console.ReadLine();

                Console.Write("Ngày sinh (dd/mm/yyyy): ");
                employee.Birthday = DateTime.Parse(Console.ReadLine());

                Console.Write("Lương: ");
                employee.Salary = decimal.Parse(Console.ReadLine());

                Console.Write("Thưởng: ");
                employee.Bonus = decimal.Parse(Console.ReadLine());

                employees[i] = employee;

                Console.WriteLine();
            }

            // In ra thông tin của các nhân viên
            Console.WriteLine("Thông tin các nhân viên:");
            Console.WriteLine("-----------------------");

            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.Id}");
                Console.WriteLine($"Họ tên: {employee.Name}");
                Console.WriteLine($"Địa chỉ: {employee.Address}");
                Console.WriteLine($"Ngày sinh: {employee.Birthday:d}");
                Console.WriteLine($"Lương: {employee.Salary:C0}");
                Console.WriteLine($"Thưởng: {employee.Bonus:C0}");
                Console.WriteLine($"Tổng lương: {employee.TotalSalary:C0}");
                Console.WriteLine();
            }
        }

        private static void PrintCSharp()
        {
            Console.WriteLine("   ****         **       ** ");
            Console.WriteLine("  **           **       **  ");
            Console.WriteLine(" **       ******************");
            Console.WriteLine(" **          **       **    ");
            Console.WriteLine(" **       ******************");
            Console.WriteLine("  **       **       **      ");
            Console.WriteLine("   ****   **       **       ");
        }
    }
}
