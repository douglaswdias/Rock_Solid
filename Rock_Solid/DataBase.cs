using System;
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
			connection = new SQLiteConnection("Data Source =" + Global.dbPath + Global.dbName);//Caminho Relativo para o Banco de Dados
			connection.Open();
			return connection;
		}



		//Comandos de Usuário

		//Criação de novo usuário
		public static void NewUser(User user)
		{
			if (user.USER_USERNAME == "")
			{
				MessageBox.Show("Nome Precisa ser Preenchido");
				return;
			}
			if (Global.userID.ToString() == "" || Global.userID == 0)
			{
				try
				{
					var vcon = ConnectionDB();
					var cmd = vcon.CreateCommand();
					cmd.CommandText = @"
						INSERT INTO USER 
							(USER_NAME, USER_USERNAME, USER_PASSWORD, USER_STATUS, USER_LEVEL) 
						VALUES 
							(@NAME, @USERNAME, @PASSWORD, @STATUS, @LEVEL)
					";

					cmd.Parameters.AddWithValue("@NAME", user.USER_NAME);
					cmd.Parameters.AddWithValue("@USERNAME", user.USER_USERNAME);
					cmd.Parameters.AddWithValue("@PASSWORD", user.USER_PASSWORD);
					cmd.Parameters.AddWithValue("@STATUS", user.USER_STATUS);
					cmd.Parameters.AddWithValue("@LEVEL", user.USER_LEVEL);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Usuário Cadastrado Com Sucesso");
					vcon.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao Criar Usuário");

				}
			}
			else
			{
				try
				{
					var vcon = ConnectionDB();
					var cmd = vcon.CreateCommand();
					cmd.CommandText = @"
						UPDATE USER 
						SET 
							USER_NAME = '" + user.USER_NAME + "', " +
							"USER_USERNAME = '" + user.USER_USERNAME + "', " +
							"USER_PASSWORD = '" + user.USER_PASSWORD + "', " +
							"USER_STATUS = '" + user.USER_STATUS + "', " +
							"USER_LEVEL = " + user.USER_LEVEL + " " +
						"WHERE USER_ID = " + Global.userID
					;

					cmd.ExecuteNonQuery();
					MessageBox.Show("Alterações Salvas Com Sucesso");
					vcon.Close();
				}
				catch (Exception ex)
				{
					if (UserTaken(user))
					{
						MessageBox.Show("Usuário Já Cadastrado");
					}
					else
					{
						MessageBox.Show("Erro ao Alterar Usuário");
					}

				}
			}
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
			catch (Exception ex)
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
			cmd.CommandText = @"
				SELECT 
					USER_USERNAME 
				FROM 
					USER 
				WHERE 
					USER_USERNAME = '" + user.USER_USERNAME + "'"
			;

			da = new SQLiteDataAdapter(cmd.CommandText, vcon);
			da.Fill(dt);
			if (dt.Rows.Count > 0)
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



		//Inicio das funções do formulário de Consulta de Usuários

		public static DataTable UserList()
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = @"
					SELECT 
						USER_ID AS CÓDIGO, USER_NAME AS NOME, USER_USERNAME AS USERNAME 
					FROM 
						USER
				";

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
				cmd.CommandText = @"
					SELECT * FROM USER 
					WHERE USER_ID = " + id
				;

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

		public static DataTable DeleteUser(string id)
		{
			SQLiteDataAdapter da = null;
			SQLiteDataAdapter da2 = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				var cmd2 = vcon.CreateCommand();
				cmd.CommandText = @"
					DELETE FROM USER 
					WHERE USER_ID = " + id + ";"
				;

				cmd2.CommandText = @"
					UPDATE SQLITE_SEQUENCE 
					SET SEQ = 0 
					WHERE NAME = 'USER';"
				;

				da = new SQLiteDataAdapter(cmd.CommandText, vcon);
				da2 = new SQLiteDataAdapter(cmd2.CommandText, vcon);
				da.Fill(dt);
				da2.Fill(dt);
				vcon.Close();
				return dt;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public static DataTable SearchUserList(string name)
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = @"
					SELECT 
						USER_ID AS CÓDIGO, USER_NAME AS NOME, USER_USERNAME AS USERNAME 
					FROM 
						USER 
					WHERE 
						USER_NAME LIKE '%" + name + "%'"
				;

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





		//Comandos para Cliente
		public static void NewClient(Client client)
		{
			if (Client.CLIENT_CPF == "")
			{
				MessageBox.Show("Campo Obrigatório");
				return;
			}
			if (Client.CLIENT_ID.ToString() == "" || Client.CLIENT_ID == 0)
			{

				try
				{
					var vcon = ConnectionDB();
					var cmd = vcon.CreateCommand();
					cmd.CommandText = @"
						INSERT INTO CLIENT 
							(CLIENT_NAME, CLIENT_POSTCODE, CLIENT_ADDRESS, CLIENT_NUMBER, CLIENT_NEIGHBORHOOD, CLIENT_CITY, CLIENT_STATE, CLIENT_RG, CLIENT_CPF, CLIENT_EMAIL, CLIENT_PHONE, CLIENT_CEL, CLIENT_PROFILEIMGPATH) 
						VALUES 
							(@NAME, @POSTCODE, @ADDRESS, @NUMBER, @NEIGHBORHOOD, @CITY, @STATE, @RG, @CPF, @EMAIL, @PHONE, @CEL, @PROFILEIMGPATH)
					";

					cmd.Parameters.AddWithValue("@NAME", Client.CLIENT_NAME);
					cmd.Parameters.AddWithValue("@POSTCODE", Client.CLIENT_POSTCODE);
					cmd.Parameters.AddWithValue("@ADDRESS", Client.CLIENT_ADDRESS);
					cmd.Parameters.AddWithValue("@NUMBER", Client.CLIENT_NUMBER);
					cmd.Parameters.AddWithValue("@NEIGHBORHOOD", Client.CLIENT_NEIGHBORHOOD);
					cmd.Parameters.AddWithValue("@CITY", Client.CLIENT_CITY);
					cmd.Parameters.AddWithValue("@STATE", Client.CLIENT_STATE);
					cmd.Parameters.AddWithValue("@RG", Client.CLIENT_RG);
					cmd.Parameters.AddWithValue("@CPF", Client.CLIENT_CPF);
					cmd.Parameters.AddWithValue("@EMAIL", Client.CLIENT_EMAIL);
					cmd.Parameters.AddWithValue("@PHONE", Client.CLIENT_PHONE);
					cmd.Parameters.AddWithValue("@CEL", Client.CLIENT_CEL);
					cmd.Parameters.AddWithValue("@PROFILEIMGPATH", Client.CLIENT_PROFILEIMGPATH);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Cliente Cadastrado Com Sucesso");
					vcon.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao Criar Cliente");
				}
			}
			else
			{
				try
				{
					var vcon = ConnectionDB();
					var cmd = vcon.CreateCommand();
					cmd.CommandText = @"
						UPDATE CLIENT 
						SET 
							CLIENT_NAME = '" + Client.CLIENT_NAME + "', " +
							"CLIENT_POSTCODE = '" + Client.CLIENT_POSTCODE + "', " +
							"CLIENT_ADDRESS = '" + Client.CLIENT_ADDRESS + "', " +
							"CLIENT_NUMBER = '" + Client.CLIENT_NUMBER + "', " +
							"CLIENT_NEIGHBORHOOD = '" + Client.CLIENT_NEIGHBORHOOD + "', " +
							"CLIENT_CITY = '" + Client.CLIENT_CITY + "', " +
							"CLIENT_STATE = '" + Client.CLIENT_STATE + "', " +
							"CLIENT_RG = '" + Client.CLIENT_RG + "', " +
							"CLIENT_CPF = '" + Client.CLIENT_CPF + "', " +
							"CLIENT_EMAIL = '" + Client.CLIENT_EMAIL + "', " +
							"CLIENT_PHONE = '" + Client.CLIENT_PHONE + "', " +
							"CLIENT_CEL = '" + Client.CLIENT_CEL + "', " +
							"CLIENT_PROFILEIMGPATH = '" + Client.CLIENT_PROFILEIMGPATH + "' " +
						"WHERE CLIENT_ID = " + Client.CLIENT_ID
					;

					cmd.ExecuteNonQuery();
					MessageBox.Show("Alterações Salvas Com Sucesso");
					vcon.Close();
				}
				catch (Exception ex)
				{
					if (ClientTaken(client))
					{
						MessageBox.Show("Client Já Cadastrado");
					}
					else
					{
						MessageBox.Show("Erro ao Alterar Cliente");
					}
				}
			}
		}

		public static DataTable DeleteClient(string id)
		{
			SQLiteDataAdapter da = null;
			SQLiteDataAdapter da2 = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				var cmd2 = vcon.CreateCommand();
				cmd.CommandText = @"
					DELETE FROM CLIENT 
					WHERE CLIENT_ID = " + id + ";"
				;

				cmd2.CommandText = @"
					UPDATE SQLITE_SEQUENCE 
					SET SEQ = 0 
					WHERE NAME = 'CLIENT';"
				;

				da = new SQLiteDataAdapter(cmd.CommandText, vcon);
				da2 = new SQLiteDataAdapter(cmd2.CommandText, vcon);
				da.Fill(dt);
				da2.Fill(dt);
				vcon.Close();
				return dt;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public static DataTable GetClient()
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = "SELECT * FROM CLIENT";

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

		public static bool ClientTaken(Client client)
		{
			bool res;

			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();

			var vcon = ConnectionDB();
			var cmd = vcon.CreateCommand();
			cmd.CommandText = @"
				SELECT 
					CLIENT_CPF 
				FROM 
					CLIENT 
				WHERE 
					CLIENT_CPF = '" + Client.CLIENT_CPF + "'"
			;

			da = new SQLiteDataAdapter(cmd.CommandText, vcon);
			da.Fill(dt);
			if (dt.Rows.Count > 0)
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

		public static DataTable ClientList(string id)
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = @"
					SELECT * FROM CLIENT 
					WHERE CLIENT_ID = " + id
				;

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

		public static DataTable ClientListDGV()
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = @"
					SELECT 
						CLIENT_ID AS CÓDIGO, CLIENT_NAME AS NOME, CLIENT_RG AS RG__IE, CLIENT_CPF AS CPF__CNPJ, CLIENT_CITY AS CIDADE, CLIENT_STATE AS ESTADO, CLIENT_PROFILEIMGPATH AS FOTO
					FROM 
						CLIENT
				";

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
		public static DataTable SearchClientName(string name)
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = @"
					SELECT 
						CLIENT_ID AS CÓDIGO, CLIENT_NAME AS NOME, CLIENT_RG AS RG__IE, CLIENT_CPF AS CPF__CNPJ, CLIENT_CITY AS CIDADE, CLIENT_STATE AS ESTADO
					FROM 
						CLIENT 
					WHERE 
						CLIENT_NAME LIKE '%" + name + "%'"
				;

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

		public static DataTable SearchClientCPF(string name)
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = @"
					SELECT 
						CLIENT_ID AS CÓDIGO, CLIENT_NAME AS NOME, CLIENT_RG AS RG__IE, CLIENT_CPF AS CPF__CNPJ, CLIENT_CITY AS CIDADE, CLIENT_STATE AS ESTADO
					FROM 
						CLIENT 
					WHERE 
						CLIENT_CPF LIKE '%" + name + "%'"
				;

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
