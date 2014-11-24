using System;

namespace ProgrammingQuiz
{
	class ProblemOne
	{
		public static void Main (string[] args)
		{
			HelloWorld ();
		}
		public static void HelloWorld()
		{
			Console.WriteLine ("What is your name? ");
			String name = Console.ReadLine ();
			Console.WriteLine ("Hello World!! My name is " + name);
		}
	}
}
