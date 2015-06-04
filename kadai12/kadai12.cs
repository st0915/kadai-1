using System; 
using System.IO; 

namespace Kadai
{
	//⑫入出力機能をもつクラスを作成してください。

	//以下のメソッドを実装していること
	
	// ①テキストファイルの内容を読み込み、 引数に指定されたパスが示すクラス内のフィールドに格納するメソッド public void input(String path);

	// ②クラスのフィールドに格納された内容を、 引数に指定されたパスが示すテキストファイルに出力するメソッド public void output(String path);

	class Kadai12
	{
		public static void Main()
		{
			InputOutput kadai12 = new InputOutput();
			kadai12.Input("./test.txt");
			kadai12.Output("./test.txt");
		}
	}

	class InputOutput
	{
		protected string[] values;
		
		public void Input(string path)
		{
			
			values = File.ReadAllLines(path);
			
			for(int i = 0; i < values.Length; i++)
			{
				Console.WriteLine(values[i]);
			}
			
		}
		
		public void Output(string path)
		{
			
			for(int i = 0; i < values.Length; i++)
			{
				File.AppendAllText(path, values[i] + "\r\n");
			}
		}
	}
}
