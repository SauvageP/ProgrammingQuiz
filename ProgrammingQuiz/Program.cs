using System;

namespace ProgrammingQuiz
{
	class Problems
	{
		public static void Main (string[] args)
		{
			Console.Write ("What problem # would you want? ");
			String num = Console.ReadLine ().ToString ();
			switch (num) {
			case "1":
				HelloWorld ();
				break;
			case "2":
				ProgramLang ();
				break;
			default:
				StudentInfo ();
				break;
			}
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
			switch (choice.ToUpper ()) 
			{
				case "CS":
					Console.WriteLine ("C #");
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
				case "RUBY":
					Console.WriteLine ("Ruby");
					break;
				case "JSON":
					Console.WriteLine ("JavaScript");
					break;
				case "OBJ-C":
					Console.WriteLine ("Objective-C");
					break;
				default:
					Console.WriteLine ("Wrong Letters");
					break;
			}
		}

		public static void StudentInfo() {
			String name;
			String gradYear;
			String schoolName;

			Console.Write ("What is your name? ");
			name = Console.ReadLine ();
			Console.Write ("What is your graduation year? ");
			gradYear = Console.ReadLine ();
			Console.Write ("What is the name of your school? ");
			schoolName = Console.ReadLine ();

			Console.WriteLine ("Name: " + name);
			Console.WriteLine ("Graduation Year: " + gradYear);
			Console.WriteLine ("School: " + schoolName);
		}

		public static void UserInput() {
			Console.WriteLine ("Give me a string.  ");
			String str = Console.ReadLine ();

			Console.WriteLine ("Output #1");
			Console.WriteLine (str);

		}
	}
}
