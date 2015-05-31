using System; 

namespace Kadai4
{
//④コマンドライン引数の値を判定して出力を変更するプログラムの作成(if文, switch文の理解が目的)
	class Switch
	{

		public static void Main(string[] args)
		{
			double valueA;
			if(double.TryParse(args[0],out valueA))
			{
				Console.WriteLine(args[0] + ":コマンドライン引数は数字です");
				return;
			}
			else
			{
				Console.WriteLine(args[0] + ":コマンドライン引数は文字列です");
				return;
			}
		}
	}
	
}