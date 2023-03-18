using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = Encoding.UTF8;
            // Yêu cầu 1
            Console.WriteLine("Nhập vào năm x tháng y (x/y): ");
            string input = Console.ReadLine();
            string[] parts = input.Split('/');
            int year = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            Console.WriteLine("Số ngày trong tháng {0}/{1}: {2}", month, year, daysInMonth);
            Console.ReadLine();

            // Yêu cầu 2
            Console.WriteLine("Nhập vào số giây: ");
            int seconds = int.Parse(Console.ReadLine());
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            Console.WriteLine("Định dạng hh:mm:ss: {0}", time.ToString("hh\\:mm\\:ss"));
            Console.ReadLine();

            // Yêu cầu 3
            Console.WriteLine("Các số tổng 3 ký số chẵn từ 100 đến 999:");
            for (int i = 100; i <= 999; i++)
            {
                int sum = 0;
                foreach (char c3 in i.ToString())
                {
                    sum += int.Parse(c3.ToString());
                }
                if (sum % 2 == 0)
                {
                    Console.Write(" "+i);
                }
            }
            Console.ReadLine();

            // Yêu cầu 4.1
            Console.WriteLine("Tam giác * vuông cân góc dưới bên trái:");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            // Yêu cầu 4.2
            Console.WriteLine("Tam giác * vuông cân góc trên bên trái:");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            // Yêu cầu 4.3
            Console.WriteLine("Tam giác cân hình *:");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //Yêu cầu 5
            int a, b, c;
            Console.Write("Nhap vao 3 so nguyen: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Day la do dai 3 canh cua tam giac.");
                if (a == b && b == c)
                {
                    Console.WriteLine("Day la tam giac deu.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Day la tam giac can.");
                }
                else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    Console.WriteLine("Day la tam giac vuong.");
                }
                else
                {
                    Console.WriteLine("Day la tam giac thuong.");
                }
            }
            else
            {
                Console.WriteLine("Day khong phai la do dai 3 canh cua tam giac.");
            }
            Console.ReadLine();

            //Yêu cầu 6
            Console.WriteLine("Tam giác số đối xứng:");
            Lab26 lab26 = new Lab26();
            lab26.InTamGiac();
            Console.ReadLine();

            //Yêu cầu 7
            Console.WriteLine("Nhap so tien gui: ");
            decimal tienGui = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Nhap lai suat (tinh theo nam): ");
            decimal laiSuatNam = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so thang gui: ");
            int soThangGui = int.Parse(Console.ReadLine());

            BankDeposit bd = new BankDeposit(tienGui, laiSuatNam, soThangGui);

            decimal tienLai = bd.TinhTienLai();
            Console.WriteLine("Tien lai: {0}", tienLai);

            decimal tongTien = bd.TinhTienGocVaLai();
            Console.WriteLine("Tong so tien: {0}", tongTien);

        }
    }
}
