using System; 
//1～100まで出力するプログラムの作成(while文, for文の理解が目的) 　 
namespace Kadai5
{

	class ForBun
	{

		public static void Main()
		{
			//for (int i = 0; i <= 9;i++ )
            		//{

                		//for (int j = 0; j <= 9;j++ )
                		//{
                    			//Console.Write((i*10)+j+1);

                    			//if (j == 9)
                    			//{
                    			//}
                    			//else
                    			//{
                        			//Console.Write(",");
                    			//}
                		//}
                		//Console.WriteLine("");
            		//}

            		//Console.WriteLine("");
            		
            		
            		
            		
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