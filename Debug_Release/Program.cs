using System;

namespace Debug_Release_1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
#if DEBUG
			Console.WriteLine("Mode=Debug");
#else
    Console.WriteLine("Mode=Release"); 
#endif
		}
	}
}
