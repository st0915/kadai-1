using System; 

namespace Kadai6
{
//FizzBuzzƒvƒƒOƒ‰ƒ€‚Ìì¬(‡A`‡C‚Ü‚Å‚Ì‚Ü‚Æ‚ß)
	class FizzBuzz
	{

		public static void Main()
		{
			string value;
			for (int i = 1; i <= 100;i++ )
			{
				if (i % 10 == 0)
				{
					value = CreateOutData(i);
					Console.WriteLine(value);
				}
				else 
				{
					value = CreateOutData(i);
					Console.Write(value + ",");
				}
				
			}
		}
		
		public static string CreateOutData(int i)
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