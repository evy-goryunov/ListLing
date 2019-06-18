using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection
{
		class NewWorker
		{
			public NewWorker(String Name, int age)
			{
				this.Name = Name;
				this.age = age;
			}

			string Name { get; set; }
			int age { get; set; }

			public override string ToString()
			{
				return $"{this.Name,10}{this.age,2}";
			}
		}
}
