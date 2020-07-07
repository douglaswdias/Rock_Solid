using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;


namespace Rock_Solid
{
	class DataBase
	{
		private static SQLiteConnection connection;

		private static SQLiteConnection ConnectionDB()
		{
			connection = new SQLiteConnection("Data Source = C:\\Users\\Anna\\Documents\\GitHub\\Rock_Solid\\Rock_Solid\\DataBase\\RockSolid.db");
			connection.Open();
			return connection;
		}

		public static DataTable GetUsers()
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				using(var cmd = ConnectionDB().CreateCommand())
				{
					cmd.CommandText = "SELECT * FROM USER";
					da = new SQLiteDataAdapter(cmd.CommandText, ConnectionDB());
					da.Fill(dt);
					ConnectionDB().Close();
					return dt;
				}
			}
			catch(Exception ex)
			{
				ConnectionDB().Close();
				throw ex;
			}
		}

		public static DataTable CheckIn(string sql)
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				using (var cmd = ConnectionDB().CreateCommand())
				{
					cmd.CommandText = sql;
					da = new SQLiteDataAdapter(cmd.CommandText, ConnectionDB());
					da.Fill(dt);
					ConnectionDB().Close();
					return dt;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
