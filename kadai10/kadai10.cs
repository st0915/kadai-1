using System; 
using System.IO; 

namespace Kadai
{
//�IInputインターフェースの作成 　及び実装クラスTextInputクラスの作成 　・Inputインターフェース　　→　inputメソッドを持つインターフェース 　・TextInputクラス　　　　　→　inputメソッドでテキストファイルから文字列を取り込むクラス。
	class Kadai10
	{

		public static void Main()
		{
			ConsoleOutput HelloWorld = new ConsoleOutput();
			HelloWorld.SetValue("Hello World");
			HelloWorld.Output();
			
			TextOutput TextHelloWorld = new TextOutput();
			TextHelloWorld.SetValue("Hello World");
			TextHelloWorld.Output();
			
			TextInput FileContents = new TextInput();
			FileContents.Input();
			Console.WriteLine(FileContents.GetValue());
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
		
		public void SetValue(string outPutValue)
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
		
		public void SetValue(string outPutValue)
		{
			value = outPutValue;
		}
		public void Output()
		{
			File.WriteAllText("./kadai.txt",value);
		}
	}
	
	public interface Input
	{
		void Input();
	}
	
	class TextInput:Input
	{
		protected string value;
		protected string[] values;
		
		public string GetValue()
		{
			return value;
		}
		
		public void Input()
		{
			values = File.ReadAllLines("./kadai.txt");
			value = values[0];
		}
	}
	
}