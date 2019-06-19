using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection
{
	class Program
	{
		static void Main(string[] args)
		{

			List<int> list = new List<int>();
			Random rnd = new Random();
			Console.WriteLine("Заданный массив данных");
			for (int i = 0; i < 10; i++)
			{
				list.Add(rnd.Next(1, 10));
			}
			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("кол-во вхождений");

			foreach (int item in list.Distinct())
			{
				Console.WriteLine(item + " --- " + list.Where(n => n == item).Count() + " шт.");
			}
		}
	}
}
