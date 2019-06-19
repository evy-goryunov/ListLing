using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Дана коллекция List<T>. Требуется подсчитать, сколько раз каждый элемент встречается в данной коллекции используя Linq.
/// </summary>
namespace ListCollection
{
	
	static class Program
	{
		public delegate void  myD (KeyValuePair<string, int> pair);
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

			/// <summary>
			/// а. Свернуть обращение к OrderBy с использованием лямбда-выражения =>.
			/// b. * Развернуть обращение к OrderBy с использованием делегата .
			/// </summary>
			Console.WriteLine("Сортировка словаря");
			Dictionary<string, int> dict = new Dictionary<string, int>()
			{
				{"four", 4 },
				{"two", 2 },
				{"one", 1 },
				{"three", 3 },
			};

			//var d = dict.OrderBy(delegate (KeyValuePair<string, int> pair) { return pair.Value; });

			//var d = dict.OrderBy((KeyValuePair<string, int> pair) => pair.Value);

			var d = dict.OrderBy(D);

			int D(KeyValuePair<string, int> pair)
			{
				return pair.Value;
			}

			foreach (var pair in d)
			{
				Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
			}




		}
	}
}
