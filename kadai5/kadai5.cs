using System; 

namespace Kadai5
{

	class ForBun
	{

		public static void Main()
		{
			for (int i = 0; i <= 9;i++ )
            		{

                		for (int j = 0; j <= 9;j++ )
                		{
                    			Console.Write((i*10)+j+1);

                    			if (j == 9)
                    			{
                    			}
                    			else
                    			{
                        			Console.Write(",");
                    			}
                		}
                		Console.WriteLine("");
            		}

            		Console.WriteLine("");
		}
	}
	
}