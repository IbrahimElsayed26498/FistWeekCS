using System;
class P7
{
	public static void Main(string [] args)
	{
		//7
		string name, gender;
		Console.Write("Enter your name : ");
		name = Console.ReadLine();

		Console.Write("Enter your gender : ");
		gender = Console.ReadLine();

		if(gender == "male")
			Console.WriteLine("Hello Mr / " + name);
		else
			Console.WriteLine("Hello Miss / " + name);
	}
}