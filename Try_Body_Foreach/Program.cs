using System;
using System.Collections.Generic;

namespace Collection_foreach
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			List<int> numbers = new List<int>() { 1,4,67,10};
            numbers.Add(100);
			foreach (int i in numbers)
			{
                
				Console.WriteLine(i);
			}
			Console.ReadKey();
		}
	}
}
