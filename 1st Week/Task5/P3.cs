//In the name of Allah, the Gracious, the Merciful
using System;
public class P3
{
	public static void Main(string[] args)
	{
		int size = 0;
		Console.Write("Enter a number : ");
		size = Convert.ToInt32(Console.ReadLine());
		int [] array = new int [size];
		Console.WriteLine("Enter {0} numbers :", size);
		
		//storing data in an array
		for(int i=0; i<size; i++)
		{
			array[i] = Convert.ToInt32(Console.ReadLine());
		}

		Console.WriteLine();
		//getting data from array
		for(int i=0; i<size; i++)
		{
			Console.WriteLine(array[i]);
		}

	}
}