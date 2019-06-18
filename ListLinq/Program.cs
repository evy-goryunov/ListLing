using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
/// <summary>
/// Горюнов Егвений
/// Дана коллекция List<T>. Требуется подсчитать, сколько раз каждый элемент встречается в данной коллекции:
///для целых чисел;
///*для обобщенной коллекции;
///** используя Linq.
/// </summary>
namespace ListLinq
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();
			Random rnd = new Random();
			int r = rnd.Next(1, 10);
			for (int i = 0; i < 10; i++)
			{
				list.Add(rnd.Next(1, 10));
			}
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}

			var num = from n in list where n > 5 select n;
			Console.WriteLine("Числа больше 5");
			foreach (var e in num)
			{
				Console.WriteLine(e);
			}

			list.Gro
		}
	}
}
