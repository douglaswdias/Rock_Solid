using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Rock_Solid
{
	class DataBase
	{
		private static SQLiteConnection connection;

		private static SQLiteConnection ConnectionDB()
		{
			//connection = new SQLiteConnection("Data Source = C:\\Users\\Anna\\Documents\\GitHub\\Rock_Solid\\Rock_Solid\\DataBase\\RockSolid.db");
			connection = new SQLiteConnection("Data Source = C:\\Users\\Suporte\\Documents\\GitHub\\Rock_Solid\\Rock_Solid\\DataBase\\RockSolid.db");
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

		public static bool UserTaken(User user)
		{
			bool res;

			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();

			var cmd = ConnectionDB().CreateCommand();
			cmd.CommandText = "SELECT USER_USERNAME FROM USER WHERE USER_USERNAME = '"+user.USER_USERNAME+"'";
			da = new SQLiteDataAdapter(cmd.CommandText, ConnectionDB());
			da.Fill(dt);
			if(dt.Rows.Count > 0)
			{
				res = true;
			}
			else
			{
				res = false;
			}

			return res;
		}

		//Inicio das funções do formulário de novo usuário

		public static void NewUser(User user)
		{
			if (UserTaken(user))
			{
				MessageBox.Show("Nome de Usuário Já Cadastrado");
				return;
			}
			try
			{
				var cmd = ConnectionDB().CreateCommand();
				cmd.CommandText = "INSERT INTO USER (USER_NAME, USER_USERNAME, USER_PASSWORD, USER_STATUS, USER_LEVEL) VALUES (@NAME, @USERNAME, @PASSWORD, @STATUS, @LEVEL)";
				cmd.Parameters.AddWithValue("@NAME", user.USER_NAME);
				cmd.Parameters.AddWithValue("@USERNAME", user.USER_USERNAME);
				cmd.Parameters.AddWithValue("@PASSWORD", user.USER_PASSWORD);
				cmd.Parameters.AddWithValue("@STATUS", user.USER_STATUS);
				cmd.Parameters.AddWithValue("@LEVEL", user.USER_LEVEL);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Usuário Cadastrado Com Sucesso");
				ConnectionDB().Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Erro ao Gravar Usuário");
				ConnectionDB().Close();
			}
		}

		//Fim das funções de novo usuário
	}
}
