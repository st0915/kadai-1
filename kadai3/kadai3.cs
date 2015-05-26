using System; 

namespace kadai3
{

	class Keisan
	{

		public static void Main()
		{
			double Anser;
            double DoubleReadA;
            double DoubleReadB;

			while(true)
			{
				while (true)
	            {
	                Console.WriteLine("一つ目の引数");
	                Console.Write("→");
	                var StrReadA = Console.ReadLine();
	                if (double.TryParse(StrReadA, out DoubleReadA) == false)
	                {
	                	Console.WriteLine("数字ではありません");
	                }
	                else
	                {
	                	break;
	                }
		         }

	             Console.WriteLine("演算記号(+ - / *) ");
	             Console.Write("→");
	             var StrKigou = Console.ReadLine();

	             while (true)
	             {
	             	Console.WriteLine("二つ目の引数");
	             	Console.Write("→");
	             	var StrReadB = Console.ReadLine();
	             	if (double.TryParse(StrReadB, out DoubleReadB) == false)
	             	{
	                 	Console.WriteLine("数字ではありません");
	             	}
	             	else
	             	{
	                 	break;
	             	}

	             }

	             switch (StrKigou)
	      		 {
	             	case "+":
	                 	Anser = DoubleReadA + DoubleReadB;
	                 	Console.WriteLine("答え");
	                 	Console.WriteLine(Anser);
			             break;

	        	     case "-":
		               	Anser = DoubleReadA - DoubleReadB;
	                		Console.WriteLine("答え");
	                 	Console.WriteLine(Anser);
			            break;

			         case "*":
	                 	Anser = DoubleReadA * DoubleReadB;
	                		Console.WriteLine("答え");
	                 	Console.WriteLine(Anser);
	                 	break;

	             	 case "/":
	                	if (DoubleReadB == 0)
	                	{
	                		Console.WriteLine("分母が0です");
	                		break;
	                	}
	                	else
	                	{
	                		Anser = DoubleReadA / DoubleReadB;
	                		Console.WriteLine("答え");
	                		Console.WriteLine(Anser);
	                	}
	                	break;

	             	default:
	                	Console.WriteLine("演算記号がおかしいです");
	                	break;
	             }

	             Console.WriteLine("終了しますか？");
	             Console.WriteLine("1:終了　その他:続ける");
	             var StrRead = Console.ReadLine();
	             if (StrRead == "1")
	             {
	             	Console.WriteLine("終了します");
	             	//終了処理
	             	Environment.Exit(0);
	             }
	             else
	             {
	             	Console.WriteLine("続けます");
	             }
				}
		}
	}
}
