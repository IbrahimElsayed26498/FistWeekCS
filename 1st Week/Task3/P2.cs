using System;
public class P2
{
	public static void Main(string[] args)
	{		
		//2
		int lines = 5, stars;
		for(int i=1; i<=lines; i++)
		{
			for(stars=0; stars<i; stars++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}

	}
}