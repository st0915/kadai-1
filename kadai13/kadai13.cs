using System; 
using System.IO; 
using System.Data.SQLite;


namespace Kadai
{
	//�Lodbc�h���C�o���g�p���āATEST�e�[�u����������擾����N���X���쐬���Ă��������B

	class Kadai13
	{
		public static void Main()
		{
			SQLiteConnection connection = new SQLiteConnection();
			connection.ConnectionString = "Data Source=kadaiDb.db;";
			connection.Open();
			
			SQLiteCommand command = connection.CreateCommand();
			command.CommandText = "SELECT * FROM TEST";
			SQLiteDataReader reader = command.ExecuteReader();
			
			while(reader.Read())
			{
    			Console.WriteLine("index:{0}  id:{1}  content:{2}", reader["indexno"], reader["id"], reader["content"]);
			}
			connection.Close();
		}
	}
}
