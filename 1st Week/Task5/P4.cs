//In the name of Allah, the Gracious, the Merciful
using System;
public class P4
{
	public static void Main(string[] args)
	{
		int row = 3, column = 3;
		int [,] array = new int[row, column];
		
		Console.WriteLine("Enterr the array[3,3]");
		
		for(int r=0; r<row; r++)
		{
			for(int c=0; c<column; c++)
			{
				array[r,c] = Convert.ToInt32(Console.ReadLine());
			}
		}
		Console.WriteLine("\n");
		for(int r=0; r<row; r++)
		{
			for(int c=0; c<column; c++)
			{
				if(r == c)
					Console.WriteLine(array[r,c]);
			}
		}		
	}
}