using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVietAnh
{
    internal class Student : IStudent
    {
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }

        private float[] MarkList = new float[3];
        public float StudAvgMark { get; private set; }

        public Student(int studID, string studName, string studGender, int studAge, string studClass)
        {
            this.StudID = studID;
            this.StudName = studName;
            this.StudGender = studGender;
            this.StudAge = studAge;
            this.StudClass = studClass;
        }

        public float this[int index]
        {
            get { return MarkList[index]; }
            set { MarkList[index] = value; }
        }

        public void CalAvg()
        {
            float sum = 0;
            foreach (int mark in MarkList)
            {
                sum += mark;
            }
            StudAvgMark = sum / MarkList.Length;
        }

        public void Print()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Student ID: " + StudID);
            Console.WriteLine("Name: " + StudName);
            Console.WriteLine("Gender: " + StudGender);
            Console.WriteLine("Age: " + StudAge);
            Console.WriteLine("Class: " + StudClass);
            Console.WriteLine("Average Mark: " + StudAvgMark);
        }
    }
}
