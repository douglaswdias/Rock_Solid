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
			//connection = new SQLiteConnection("Data Source = C:\\Users\\Anna\\Documents\\GitHub\\Rock_Solid\\Rock_Solid\\DataBase\\RockSolid.db"); \\Caminho Local para o Banco de Dados
			connection = new SQLiteConnection("Data Source ="+ Global.dbPath + Global.dbName);//Caminho Relativo para o Banco de Dados
			connection.Open();
			return connection;
		}

//Faz a busca por todos os usuários no banco de dados
		public static DataTable GetUsers()
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = "SELECT * FROM USER";
				da = new SQLiteDataAdapter(cmd.CommandText, vcon);
				da.Fill(dt);
				vcon.Close();
				return dt;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

//Verifica se há um usuário logado
		public static DataTable CheckIn(string sql)
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = sql;
				da = new SQLiteDataAdapter(cmd.CommandText, vcon);
				da.Fill(dt);
				vcon.Close();
				return dt;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

//Verifica se já existe o username já existe no banco de dados
		public static bool UserTaken(User user)
		{
			bool res;

			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();

			var vcon = ConnectionDB();
			var cmd = vcon.CreateCommand();
			cmd.CommandText = "SELECT USER_USERNAME FROM USER WHERE USER_USERNAME = '"+user.USER_USERNAME+"'";
			da = new SQLiteDataAdapter(cmd.CommandText, vcon);
			da.Fill(dt);
			if(dt.Rows.Count > 0)
			{
				res = true;
			}
			else
			{
				res = false;
			}

			vcon.Close();
			return res;
		}

//Inicio das funções do formulário de novo usuário

//Criação de novo usuário
		public static void NewUser(User user)
		{
			if (UserTaken(user))
			{
				MessageBox.Show("Nome de Usuário Já Cadastrado");
				return;
			}
			if(user.USER_NAME == "")
            {
				MessageBox.Show("Nome Precisa ser Preenchido");
				return;
            }
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = "INSERT INTO USER (USER_NAME, USER_USERNAME, USER_PASSWORD, USER_STATUS, USER_LEVEL) VALUES (@NAME, @USERNAME, @PASSWORD, @STATUS, @LEVEL)";
				cmd.Parameters.AddWithValue("@NAME", user.USER_NAME);
				cmd.Parameters.AddWithValue("@USERNAME", user.USER_USERNAME);
				cmd.Parameters.AddWithValue("@PASSWORD", user.USER_PASSWORD);
				cmd.Parameters.AddWithValue("@STATUS", user.USER_STATUS);
				cmd.Parameters.AddWithValue("@LEVEL", user.USER_LEVEL);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Usuário Cadastrado Com Sucesso");
				vcon.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Erro ao Gravar Usuário");
			}
		}

//Fim das funções de novo usuário

//Inicio das funções do formulário de Consulta de Usuários

		public static DataTable UserList()
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = "SELECT USER_ID AS ID, USER_NAME AS NOME, USER_USERNAME AS USERNAME FROM USER";
				da = new SQLiteDataAdapter(cmd.CommandText, vcon);
				da.Fill(dt);
				vcon.Close();
				return dt;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	//Consulta de usuários

		public static DataTable GetUserList(string id)
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = "SELECT * FROM USER WHERE USER_ID = "+id;
				da = new SQLiteDataAdapter(cmd.CommandText, vcon);
				da.Fill(dt);
				vcon.Close();
				return dt;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
