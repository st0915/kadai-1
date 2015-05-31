using System; 
using System.IO; 

namespace Kadai
{
//⑨Outputクラスのインターフェースへの変更、 　それを実装したTextOutput、ConsoleOutputクラスの作成(抽象化、ポリモフィズムの理解が目的) 　・Output インターフェース　→　outputメソッドを持つインターフェース 　・TestOutput クラス　　　　→　テキストファイルに出力するクラス 　・ConsoleOutputクラス　　　→　コンソール(画面)に出力するクラス
	class Kadai9
	{

		public static void Main()
		{
			ConsoleOutput HelloWorld = new ConsoleOutput();
			HelloWorld.Set("Hello World");
			HelloWorld.Output();
			
			TextOutput TextHelloWorld = new TextOutput();
			TextHelloWorld.Set("Hello World");
			TextHelloWorld.Output();
		}
	}
	
	public interface Output
	{
		void Output();
	}
	
	class ConsoleOutput:Output
	{
		protected string value;
		
		public string GetValue()
		{
			return value;
		}
		
		public void Set(string outPutValue)
		{
			value = outPutValue;
		}
		
		public void Output()
		{
			Console.WriteLine(value);
		}
	}
	
	class TextOutput:Output
	{
		protected string value;
		
		public string GetValue()
		{
			return value;
		}
		
		public void Set(string outPutValue)
		{
			value = outPutValue;
		}
		public void Output()
		{
			File.WriteAllText("./kadai.txt",value);
		}
	}
}