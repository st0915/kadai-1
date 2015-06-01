using System; 
using System.IO; 

namespace Kadai
{
//⑧Outputクラスを継承したTextOutputクラスの作成(継承の理解が目的) 　・Outputクラス　　　→　outputメソッドで画面出力を行う 　・TextOutputクラス　→　outputメソッドでファイル出力を行う
	class Kadai8
	{

		public static void Main()
		{
			Output HelloWorld = new Output();
			HelloWorld.SetValue("Hello World");
			HelloWorld.OutPut();
			
			TextOutput TextHelloWorld = new TextOutput();
			TextHelloWorld.SetValue("Hello World");
			TextHelloWorld.OutPut();
		}
	}
	
	class Output
	{
		protected string value;
		
		public string GetValue()
		{
			return value;
		}
		
		public void SetValue(string outPutValue)
		{
			value = outPutValue;
		}
		
		virtual public void OutPut()
		{
			Console.WriteLine(value);
		}
	}
	
	class TextOutput:Output
	{
		override public void OutPut()
		{
			File.WriteAllText("./kadai.txt",value);
		}
	}
}