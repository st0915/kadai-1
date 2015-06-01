using System; 

namespace Kadai
{
//⑦Output(機能は②と同様)クラスの作成と、それを呼び出すプログラムの作成(クラスの理解が目的)
	class Kadai7
	{

		public static void Main()
		{
			Output HelloWorld = new Output();
			HelloWorld.SetValue("Hello World");
			HelloWorld.OutPutValuse();
		}
	}
	
	class Output
	{
		private string value;
		
		public string GetValue()
		{
			return value;
		}
		
		public void SetValue(string outPutValue)
		{
			value = outPutValue;
		}
		
		public void OutPutValuse()
		{
			Console.WriteLine(value);
		}
	}
}