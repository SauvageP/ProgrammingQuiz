using System;

namespace ProgrammingQuiz
{
	class Problems
	{
		public static void Main (string[] args)
		{
		//	HelloWorld ();
			ProgramLang ();
		}

		public static void HelloWorld()
		{
			// Write code that will take a user's name and display it on console.
			Console.WriteLine ("What is your name? ");
			String name = Console.ReadLine ();
			Console.WriteLine ("Hello World!! My name is " + name);
		}

		public static void ProgramLang()
		{
			Console.WriteLine ("What is your favorite programming languages? (CS, CPP, JAVA, C, etc.)");
			String choice = Console.ReadLine ();
			switch (choice.ToUpper ()) {
			case "CS":
					Console.Write ("C #");
					break;
			case "CPP":
				Console.WriteLine ("C++");
				break;
			case "JAVA":
				Console.WriteLine ("Java");
				break;
			case "C":
				Console.WriteLine ("C");
				break;
			default:
				Console.Write ("Wrong Letters");
				break;
			}
		}
	}
}
