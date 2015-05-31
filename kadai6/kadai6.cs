using System; 

namespace Kadai6
{
//FizzBuzzプログラムの作成(�A〜�Cまでのまとめ)
	class FizzBuzz
	{

		public static void Main()
		{
			string value;
			for (int i = 1; i <= 100;i++ )
			{
				if (i % 10 == 0)
				{
					value = FizzBuzzOut(i);
					Console.WriteLine(value);
				}
				else 
				{
					value = FizzBuzzOut(i);
					Console.Write(value + ",");
				}
				
			}
		}
		
		public static string FizzBuzzOut(int i)
		{
			string outValue;
			if(i % 3 == 0 && i % 5 == 0)
			{
				outValue = "FizzBuzz";
			}
			else if(i % 3 == 0)
			{
				outValue = "    Fizz";
			}
			else if(i % 5 == 0)
			{
				outValue = "    Buzz";
			}
			else
			{
				outValue = String.Format("{0, 8}", i);
			}
		return outValue;
		}
	}
	
}