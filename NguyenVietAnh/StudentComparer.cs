using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVietAnh
{
	internal class StudentComparer : IComparer
	{
		public int Compare(object x, object y)
		{
			Student s1 = (Student)x;
			Student s2 = (Student)y;
			return String.Compare(s1.StudName, s2.StudName);
		}
	}

}
