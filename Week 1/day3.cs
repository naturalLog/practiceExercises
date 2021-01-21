using System;
					
public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Up to how many prime numbers would you like? ");
		var input = Console.ReadLine();
		try {
			int n = Int32.Parse(input);
			//goes up to n numbers 
			for (int i = 0; i < n; i++){
				bool isPrime = checkPrime(i);
				if(isPrime){
					Console.Write(i + "\n");
				}
			}
		}catch(FormatException){
			Console.WriteLine("Wrong format");
		}
	}
	
	private static bool checkPrime(int n){
		bool isPrime = true;
		for (int i = 2; i < n; i++){
			if(n%i==0){
			isPrime = false;
				break;
			}
		}
		return isPrime;
	}
}