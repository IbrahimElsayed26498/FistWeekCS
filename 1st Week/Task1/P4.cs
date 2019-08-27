using System;
class P4
{
	public static void Main(string [] args)
	{
		//4
		string name;
		int age;

		Console.Write("Enter your name : ");
		name = Console.ReadLine();
		Console.Write("Enter your age  : ");
		age = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("\nHello : " + name + "\nYour age is : " + age);
	}
}