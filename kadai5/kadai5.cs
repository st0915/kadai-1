using System; 
//1～100まで出力するプログラムの作成(while文, for文の理解が目的) 　 
namespace Kadai5
{

	class ForBun
	{

		public static void Main()
		{
			for (int i = 1; i <= 100;i++ )
			{
				if (i % 10 == 0)
				{
					Console.WriteLine(i);
				}
				else 
				{
					Console.Write(i + ",");
				}
				
			}
		}
	}

}
