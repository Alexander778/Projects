using System;
using System.Collections.Generic;

namespace Collection_foreach
{
	class MainClass
	{
		public static void Main(string[] args)
		{


			List<int> numbers = new List<int>() { };

			for (int i = 0; i < 10001; i++)
			{
				numbers.Add(i);
			}

			DateTime dold = DateTime.Now;
			foreach (int i in numbers)
			{
				Console.WriteLine(i);
			}
            TimeSpan sp = DateTime.Now - dold;
			Console.WriteLine("Время выполнения кода "+sp);
			Console.ReadKey();
		}
	}
}
