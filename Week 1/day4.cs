using System;
					
public class Program
{
	public static void Main()
	{
		int currentYear = DateTime.Now.Year;
		int count = 0;
		for (int i = currentYear; count < 20; i++){
			if(isLeapYear(i)){
				Console.WriteLine(i);
				count++;
			}
		}
	}
	
	private static bool isLeapYear(int current){
		bool leapYear = false;
			if(current%4==0){
				leapYear = true;
				if (current%100 ==0){
					leapYear = false;
					if (current%400 == 0){
						leapYear = true;
					}
				}
			}
		return leapYear;
	}
}