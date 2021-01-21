using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Input a number greater than one: ");
		var input = Console.ReadLine();
		
		try {
			int n = Int32.Parse(input);
			int sum = 0;
			for(int i = 0; i <= n; i++){
				if (i%3 == 0 || i%5==0) {
					sum+=i;
				}
			}
			Console.WriteLine("The sum is: " + sum);
		}catch(FormatException){
			Console.WriteLine("Wrong format");
		}
	}
}