using System;

namespace helloworld
{
	class Prog
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("hello world");
			string name;
			if (args.Length > 0)
			{
				name = args[0];
			}
			else
			{
				Console.WriteLine("What's your name?");
				name = Console.ReadLine();
			};
			Console.WriteLine("hello, " + name); 
			Console.ReadKey();
		}

	}
}