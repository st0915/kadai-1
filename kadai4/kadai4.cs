using System; 

namespace kadai4
{

	class Switch
	{

		public static void Main()
		{

			Console.WriteLine("終了しますか？");
                	Console.WriteLine("1:終了　その他:続ける");
                	var StrSelect = Console.ReadLine();
                	if (StrE == "1")
                	{
                    		Console.WriteLine("終了します");
                    		//終了処理
                    		Environment.Exit(0);
                	}
                	else
                	{
                    		Console.WriteLine("kadai3でif文もswitch文も使ったので許してください");
                	}
		}
	}
	
}