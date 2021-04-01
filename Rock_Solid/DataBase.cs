using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rock_Solid
{

	class DataBase
	{
		private static SQLiteConnection connection;

		public static SQLiteConnection ConnectionDB()
		{
			//connection = new SQLiteConnection("Data Source = C:\\Users\\Anna\\Documents\\GitHub\\Rock_Solid\\Rock_Solid\\DataBase\\RockSolid.db"); \\Caminho Local para o Banco de Dados
			connection = new SQLiteConnection("Data Source =" + Global.dbPath + Global.dbName);//Caminho Relativo para o Banco de Dados
			connection.Open();
			return connection;
		}

		#region Usuário
		//Criação de novo usuário
		public static void NewUser(User user)
		{
			if (User.USER_USERNAME == "")
			{
				MessageBox.Show("Nome Precisa ser Preenchido");
				return;
			}
			if (User.USER_ID.ToString() == "" || User.USER_ID == 0)
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

					cmd.Parameters.AddWithValue("@NAME", User.USER_NAME);
					cmd.Parameters.AddWithValue("@USERNAME", User.USER_USERNAME);
					cmd.Parameters.AddWithValue("@PASSWORD", User.USER_PASSWORD);
					cmd.Parameters.AddWithValue("@STATUS", User.USER_STATUS);
					cmd.Parameters.AddWithValue("@LEVEL", User.USER_LEVEL);
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
							USER_NAME = '" + User.USER_NAME + "', " +
							"USER_USERNAME = '" + User.USER_USERNAME + "', " +
							"USER_PASSWORD = '" + User.USER_PASSWORD + "', " +
							"USER_STATUS = '" + User.USER_STATUS + "', " +
							"USER_LEVEL = " + User.USER_LEVEL + " " +
						"WHERE USER_ID = " + User.USER_ID
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

		//Verifica se o username já existe no banco de dados
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
					USER_USERNAME = '" + User.USER_USERNAME + "'"
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
		#endregion
		# region Cliente
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
							(CLIENT_NAME, CLIENT_POSTCODE, CLIENT_ADDRESS, CLIENT_NUMBER, CLIENT_NEIGHBORHOOD, CLIENT_CITY, CLIENT_STATE, CLIENT_RG, CLIENT_CPF, CLIENT_LEGAL, CLIENT_EMAIL, CLIENT_PHONE, CLIENT_CEL, CLIENT_PROFILEIMGPATH) 
						VALUES 
							(@NAME, @POSTCODE, @ADDRESS, @NUMBER, @NEIGHBORHOOD, @CITY, @STATE, @RG, @CPF, @LEGAL, @EMAIL, @PHONE, @CEL, @PROFILEIMGPATH)
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
					cmd.Parameters.AddWithValue("@LEGAL", Client.CLIENT_LEGAL);
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
					//MessageBox.Show("Erro ao Criar Cliente");
					throw ex;
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
							"CLIENT_LEGAL = '" + Client.CLIENT_LEGAL + "', " +
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
		#endregion
		#region Produto
		public static void NewProduct(Product product)
		{
			if (Product.PRODUCT_NAME == "" )
			{
				MessageBox.Show("Descrição Precisa ser Preenchida");
				return;
			}
			if (Product.PRODUCT_BARCODE.ToString() == "")
			{
				MessageBox.Show("Código de Barras Precisa ser Preenchido");
				return;
			}
			if (Product.PRODUCT_ID.ToString() == "" || Product.PRODUCT_ID == 0)
			{
				try
				{
					var vcon = ConnectionDB();
					var cmd = vcon.CreateCommand();
					cmd.CommandText = @"
						INSERT INTO PRODUCT 
							(PRODUCT_NAME, PRODUCT_DESCRIPTION, PRODUCT_BARCODE, PRODUCT_TYPE, PRODUCT_SIZE, PRODUCT_COLOR, 
							PRODUCT_WEIGHT, PRODUCT_STOCK, PRODUCT_PURCHASEPRICE, PRODUCT_MARKUPPRICE, PRODUCT_SELLINGPRICE, 
							PRODUCT_PROVIDERID, PRODUCT_IMAGE, PRODUCT_CREATEDAT, PRODUCT_LASTPURCHASE, PRODUCT_UPDATEDAT) 
						VALUES 
							(@NAME, @DESCRIPTION, @BARCODE, @TYPE, @SIZE, @COLOR, @WEIGHT, @STOCK, @PURCHASEPRICE, 
							@MARKUPPRICE, @SELLINGPRICE, @PROVIDERID, @IMAGE, @CREATEDAT, @PRODUCT_LASTPURCHASE, @PRODUCT_UPDATEDAT)
					";

					cmd.Parameters.AddWithValue("@NAME", Product.PRODUCT_NAME);
					cmd.Parameters.AddWithValue("@DESCRIPTION", Product.PRODUCT_DESCRIPTION);
					cmd.Parameters.AddWithValue("@BARCODE", Product.PRODUCT_BARCODE);
					cmd.Parameters.AddWithValue("@TYPE", Product.PRODUCT_TYPE);
					cmd.Parameters.AddWithValue("@SIZE", Product.PRODUCT_SIZE);
					cmd.Parameters.AddWithValue("@COLOR", Product.PRODUCT_COLOR);
					cmd.Parameters.AddWithValue("@WEIGHT", Product.PRODUCT_WEIGHT);
					cmd.Parameters.AddWithValue("@STOCK", Product.PRODUCT_STOCK);
					cmd.Parameters.AddWithValue("@PURCHASEPRICE", Product.PRODUCT_PURCHASEPRICE);
					cmd.Parameters.AddWithValue("@MARKUPPRICE", Product.PRODUCT_MARKUPPRICE);
					cmd.Parameters.AddWithValue("@SELLINGPRICE", Product.PRODUCT_SELLINGPRICE);
					cmd.Parameters.AddWithValue("@PROVIDERID", Product.PRODUCT_PROVIDERID);
					cmd.Parameters.AddWithValue("@IMAGE", Product.PRODUCT_IMAGE);
					cmd.Parameters.AddWithValue("@CREATEDAT", Product.PRODUCT_CREATEDAT);
					cmd.Parameters.AddWithValue("@PRODUCT_LASTPURCHASE", "1990-01-01");
					cmd.Parameters.AddWithValue("@PRODUCT_UPDATEDAT", "1990-01-01");

					cmd.ExecuteNonQuery();
					MessageBox.Show("Produto Cadastrado Com Sucesso");
					vcon.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao Criar Produto");
					throw (ex);
				}
			}
			else
			{
				try
				{
					var vcon = ConnectionDB();
					var cmd = vcon.CreateCommand();
					cmd.CommandText = @"
						UPDATE PRODUCT 
						SET 
							PRODUCT_NAME '" + Product.PRODUCT_NAME + "', " +
							"PRODUCT_DESCRIPTION '" + Product.PRODUCT_DESCRIPTION + "', " +
							"PRODUCT_BARCODE '" + Product.PRODUCT_BARCODE + "', " +
							"PRODUCT_TYPE '" + Product.PRODUCT_TYPE + "', " +
							"PRODUCT_SIZE '" + Product.PRODUCT_SIZE + "', " +
							"PRODUCT_COLOR '" + Product.PRODUCT_COLOR + "', " +
							"PRODUCT_WEIGHT '" + Product.PRODUCT_WEIGHT + "', " +
							"PRODUCT_STOCK '" + Product.PRODUCT_STOCK + "', " +
							"PRODUCT_PURCHASEPRICE '" + Product.PRODUCT_PURCHASEPRICE + "', " +
							"PRODUCT_MARKUPPRICE '" + Product.PRODUCT_MARKUPPRICE + "', " +
							"PRODUCT_SELLINGPRICE '" + Product.PRODUCT_SELLINGPRICE + "', " +
							"PRODUCT_PROVIDERID '" + Product.PRODUCT_PROVIDERID + "', " +
							"PRODUCT_IMAGE '" + Product.PRODUCT_IMAGE + "', " +
							"PRODUCT_UPDATEDAT '" + Product.PRODUCT_UPDATEDAT + "', " +
						"WHERE PRODUCT_ID = " + Product.PRODUCT_ID
					;

					cmd.ExecuteNonQuery();
					MessageBox.Show("Alterações Salvas Com Sucesso");
					vcon.Close();
				}
				catch (Exception ex)
				{
					if (ProductTaken(product))
					{
						MessageBox.Show("Produto Já Cadastrado");
					}
					else
					{
						MessageBox.Show("Erro ao Alterar Produto");
						throw (ex);
					}

				}
			}
		}

		public static bool ProductTaken(Product product)
		{
			bool res;

			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();

			var vcon = ConnectionDB();
			var cmd = vcon.CreateCommand();
			cmd.CommandText = @"
				SELECT 
					PRODUCT_BARCODE 
				FROM 
					PRODUCT 
				WHERE 
					PRODUCT_BARCODE = '" + Product.PRODUCT_BARCODE + "'"
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

		public static DataTable DeleteProduct(string id)
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
					DELETE FROM PRODUCT 
					WHERE PRODUCT_ID = " + id + ";"
				;

				cmd2.CommandText = @"
					UPDATE SQLITE_SEQUENCE 
					SET SEQ = 0 
					WHERE NAME = 'PRODUCT';"
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

		public static DataTable GetProduct()
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = "SELECT * FROM PRODUCT";

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

		public static DataTable ProductList(string id)
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = @"
					SELECT * FROM PRODUCT 
					WHERE PRODUCT_ID = " + id
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

		public static DataTable ProductListDGV()
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = @"
					SELECT 
						PRODUCT_ID AS CÓDIGO, PRODUCT_NAME AS DESCRIÇÃO, PRODUCT_BARCODE AS CÓDIGO_DE_BARRAS, PRODUCT_STOCK AS ESTOQUE
					FROM 
						PRODUCT
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
		public static DataTable SearchProductDescription(string name)
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = @"
					SELECT 
						PRODUCT_ID AS CÓDIGO, PRODUCT_NAME AS DESCRIÇÃO, PRODUCT_BARCODE AS CÓDIGO_DE_BARRAS, PRODUCT_STOCK AS ESTOQUE
					FROM 
						PRODUCT 
					WHERE 
						PRODUCT_NAME LIKE '%" + name + "%'"
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

		public static DataTable SearchProductBarCode(string name)
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConnectionDB();
				var cmd = vcon.CreateCommand();
				cmd.CommandText = @"
					SELECT 
						PRODUCT_ID AS CÓDIGO, PRODUCT_NAME AS DESCRIÇÃO, PRODUCT_BARCODE AS CÓDIGO_DE_BARRAS, PRODUCT_STOCK AS ESTOQUE
					FROM 
						PRODUTO 
					WHERE 
						PRODUCT_BARCODE LIKE '%" + name + "%'"
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
		#endregion
		#region Workout
		public static void NewWorkout(WorkOut workout, Abs abs, Back back, Biceps biceps, Chest chest, Legs legs, Shoulders shoulders, Triceps triceps, WarmUp warmup)
		{
			if (Client.CLIENT_ID.ToString() == "" || Client.CLIENT_ID == 0)
			{
				MessageBox.Show("Nenhum cliente selecionado");
			}
			else{
				try
				{
					var vcon = ConnectionDB();
					var cmd = vcon.CreateCommand();
					#region Insert Workout
					cmd.CommandText = @"
					INSERT INTO WORKOUT 
						(WORKOUT_CLIENT) 
					VALUES 
						(@CLIENT)
					";
					cmd.Parameters.AddWithValue("@CLIENT", Client.CLIENT_ID);
					cmd.ExecuteNonQuery();
					#endregion
					#region Insert Abs
					cmd.CommandText = @"
					INSERT INTO ABS 
						(ABS_RETOABDOMEN, ABS_INFRA, ABS_OBLIQUO, ABS_PARALELAFIXA, ABS_PRANCHAABDOMEN, 
						ABS_RETOABDOMEN_SERIE, ABS_INFRA_SERIE, ABS_OBLIQUO_SERIE, ABS_PARALELAFIXA_SERIE, 
						ABS_PRANCHAABDOMEN_SERIE, ABS_RETOABDOMEN_REP, ABS_INFRA_REP, ABS_OBLIQUO_REP, 
						ABS_PARALELAFIXA_REP, ABS_PRANCHAABDOMEN_REP, ABS_RETOABDOMEN_CARGA, ABS_INFRA_CARGA, 
						ABS_OBLIQUO_CARGA, ABS_PARALELAFIXA_CARGA, ABS_PRANCHAABDOMEN_CARGA, ABS_WORKOUT) 
					VALUES 
						(@RETOABDOMEN, @INFRA, @OBLIQUO, @PARALELAFIXA, @PRANCHAABDOMEN, @RETOABDOMEN_SERIE, 
						@INFRA_SERIE, @OBLIQUO_SERIE, @PARALELAFIXA_SERIE, @PRANCHAABDOMEN_SERIE, 
						@RETOABDOMEN_REP, @INFRA_REP, @OBLIQUO_REP, @PARALELAFIXA_REP, @PRANCHAABDOMEN_REP, 
						@RETOABDOMEN_CARGA, @INFRA_CARGA, @OBLIQUO_CARGA, @PARALELAFIXA_CARGA, 
						@PRANCHAABDOMEN_CARGA, (SELECT WORKOUT_ID FROM WORKOUT ORDER BY WORKOUT_ID DESC LIMIT 1))
					";

					cmd.Parameters.AddWithValue("@RETOABDOMEN", Abs.ABS_RETOABDOMEN);
					cmd.Parameters.AddWithValue("@INFRA", Abs.ABS_INFRA);
					cmd.Parameters.AddWithValue("@OBLIQUO", Abs.ABS_OBLIQUO);
					cmd.Parameters.AddWithValue("@PARALELAFIXA", Abs.ABS_PARALELAFIXA);
					cmd.Parameters.AddWithValue("@PRANCHAABDOMEN", Abs.ABS_PRANCHAABDOMEN);

					cmd.Parameters.AddWithValue("@RETOABDOMEN_SERIE", Abs.ABS_RETOABDOMEN_SERIE);
					cmd.Parameters.AddWithValue("@INFRA_SERIE", Abs.ABS_INFRA_SERIE);
					cmd.Parameters.AddWithValue("@OBLIQUO_SERIE", Abs.ABS_OBLIQUO_SERIE);
					cmd.Parameters.AddWithValue("@PARALELAFIXA_SERIE", Abs.ABS_PARALELAFIXA_SERIE);
					cmd.Parameters.AddWithValue("@PRANCHAABDOMEN_SERIE", Abs.ABS_PRANCHAABDOMEN_SERIE);

					cmd.Parameters.AddWithValue("@RETOABDOMEN_REP", Abs.ABS_RETOABDOMEN_REP);
					cmd.Parameters.AddWithValue("@INFRA_REP", Abs.ABS_INFRA_REP);
					cmd.Parameters.AddWithValue("@OBLIQUO_REP", Abs.ABS_OBLIQUO_REP);
					cmd.Parameters.AddWithValue("@PARALELAFIXA_REP", Abs.ABS_PARALELAFIXA_REP);
					cmd.Parameters.AddWithValue("@PRANCHAABDOMEN_REP", Abs.ABS_PRANCHAABDOMEN_REP);

					cmd.Parameters.AddWithValue("@RETOABDOMEN_CARGA", Abs.ABS_RETOABDOMEN_CARGA);
					cmd.Parameters.AddWithValue("@INFRA_CARGA", Abs.ABS_INFRA_CARGA);
					cmd.Parameters.AddWithValue("@OBLIQUO_CARGA", Abs.ABS_OBLIQUO_CARGA);
					cmd.Parameters.AddWithValue("@PARALELAFIXA_CARGA", Abs.ABS_PARALELAFIXA_CARGA);
					cmd.Parameters.AddWithValue("@PRANCHAABDOMEN_CARGA", Abs.ABS_PRANCHAABDOMEN_CARGA);
					cmd.ExecuteNonQuery();
					#endregion
					#region Insert Back
					cmd.CommandText = @"
					INSERT INTO BACK 
						(BACK_PULLEYCOSTAS, BACK_PULLEYFRENTE, BACK_PULLEYINVERTIDO, BACK_REMADAHORIZONTAL, 
						BACK_REMADAALTERNADA, BACK_REMADACAVALINHO, BACK_PUXADORARTICULADO, BACK_PECKDECK, 
						BACK_PULLOVER, BACK_BARRAFIXA, BACK_VOADORINVERSO, BACK_PULLEYCOSTAS_SERIE, 
						BACK_PULLEYFRENTE_SERIE, BACK_PULLEYINVERTIDO_SERIE, BACK_REMADAHORIZONTAL_SERIE, 
						BACK_REMADAALTERNADA_SERIE, BACK_REMADACAVALINHO_SERIE, BACK_PUXADORARTICULADO_SERIE, 
						BACK_PECKDECK_SERIE, BACK_PULLOVER_SERIE, BACK_BARRAFIXA_SERIE, 
						BACK_VOADORINVERSO_SERIE, BACK_PULLEYCOSTAS_REP, BACK_PULLEYFRENTE_REP, 
						BACK_PULLEYINVERTIDO_REP, BACK_REMADAHORIZONTAL_REP, BACK_REMADAALTERNADA_REP, 
						BACK_REMADACAVALINHO_REP, BACK_PUXADORARTICULADO_REP, BACK_PECKDECK_REP, 
						BACK_PULLOVER_REP, BACK_BARRAFIXA_REP, BACK_VOADORINVERSO_REP, BACK_PULLEYCOSTAS_CARGA, 
						BACK_PULLEYFRENTE_CARGA, BACK_PULLEYINVERTIDO_CARGA, BACK_REMADAHORIZONTAL_CARGA, 
						BACK_REMADAALTERNADA_CARGA, BACK_REMADACAVALINHO_CARGA, BACK_PUXADORARTICULADO_CARGA, 
						BACK_PECKDECK_CARGA, BACK_PULLOVER_CARGA, BACK_BARRAFIXA_CARGA, 
						BACK_VOADORINVERSO_CARGA, BACK_WORKOUT) 
					VALUES 
						(@BACK_PULLEYCOSTAS, @BACK_PULLEYFRENTE, @BACK_PULLEYINVERTIDO, @BACK_REMADAHORIZONTAL, 
						@BACK_REMADAALTERNADA, @BACK_REMADACAVALINHO, @BACK_PUXADORARTICULADO, @BACK_PECKDECK, 
						@BACK_PULLOVER, @BACK_BARRAFIXA, @BACK_VOADORINVERSO, @BACK_PULLEYCOSTAS_SERIE, 
						@BACK_PULLEYFRENTE_SERIE, @BACK_PULLEYINVERTIDO_SERIE, @BACK_REMADAHORIZONTAL_SERIE, 
						@BACK_REMADAALTERNADA_SERIE, @BACK_REMADACAVALINHO_SERIE, @BACK_PUXADORARTICULADO_SERIE, 
						@BACK_PECKDECK_SERIE, @BACK_PULLOVER_SERIE, @BACK_BARRAFIXA_SERIE, 
						@BACK_VOADORINVERSO_SERIE, @BACK_PULLEYCOSTAS_REP, @BACK_PULLEYFRENTE_REP, 
						@BACK_PULLEYINVERTIDO_REP, @BACK_REMADAHORIZONTAL_REP, @BACK_REMADAALTERNADA_REP, 
						@BACK_REMADACAVALINHO_REP, @BACK_PUXADORARTICULADO_REP, @BACK_PECKDECK_REP, 
						@BACK_PULLOVER_REP, @BACK_BARRAFIXA_REP, @BACK_VOADORINVERSO_REP, 
						@BACK_PULLEYCOSTAS_CARGA, @BACK_PULLEYFRENTE_CARGA, @BACK_PULLEYINVERTIDO_CARGA, 
						@BACK_REMADAHORIZONTAL_CARGA, @BACK_REMADAALTERNADA_CARGA, @BACK_REMADACAVALINHO_CARGA, 
						@BACK_PUXADORARTICULADO_CARGA, @BACK_PECKDECK_CARGA, @BACK_PULLOVER_CARGA, 
						@BACK_BARRAFIXA_CARGA, @BACK_VOADORINVERSO_CARGA, 
						(SELECT WORKOUT_ID FROM WORKOUT ORDER BY WORKOUT_ID DESC LIMIT 1))
					";
					cmd.Parameters.AddWithValue("@BACK_PULLEYCOSTAS", Back.BACK_PULLEYCOSTAS);
					cmd.Parameters.AddWithValue("@BACK_PULLEYFRENTE", Back.BACK_PULLEYFRENTE);
					cmd.Parameters.AddWithValue("@BACK_PULLEYINVERTIDO", Back.BACK_PULLEYINVERTIDO);
					cmd.Parameters.AddWithValue("@BACK_REMADAHORIZONTAL", Back.BACK_REMADAHORIZONTAL);
					cmd.Parameters.AddWithValue("@BACK_REMADAALTERNADA", Back.BACK_REMADAALTERNADA);
					cmd.Parameters.AddWithValue("@BACK_REMADACAVALINHO", Back.BACK_REMADACAVALINHO);
					cmd.Parameters.AddWithValue("@BACK_PUXADORARTICULADO", Back.BACK_PUXADORARTICULADO);
					cmd.Parameters.AddWithValue("@BACK_PECKDECK", Back.BACK_PECKDECK);
					cmd.Parameters.AddWithValue("@BACK_PULLOVER", Back.BACK_PULLOVER);
					cmd.Parameters.AddWithValue("@BACK_BARRAFIXA", Back.BACK_BARRAFIXA);
					cmd.Parameters.AddWithValue("@BACK_VOADORINVERSO", Back.BACK_VOADORINVERSO);

					cmd.Parameters.AddWithValue("@BACK_PULLEYCOSTAS_SERIE", Back.BACK_PULLEYCOSTAS_SERIE);
					cmd.Parameters.AddWithValue("@BACK_PULLEYFRENTE_SERIE", Back.BACK_PULLEYFRENTE_SERIE);
					cmd.Parameters.AddWithValue("@BACK_PULLEYINVERTIDO_SERIE", Back.BACK_PULLEYINVERTIDO_SERIE);
					cmd.Parameters.AddWithValue("@BACK_REMADAHORIZONTAL_SERIE", Back.BACK_REMADAHORIZONTAL_SERIE);
					cmd.Parameters.AddWithValue("@BACK_REMADAALTERNADA_SERIE", Back.BACK_REMADAALTERNADA_SERIE);
					cmd.Parameters.AddWithValue("@BACK_REMADACAVALINHO_SERIE", Back.BACK_REMADACAVALINHO_SERIE);
					cmd.Parameters.AddWithValue("@BACK_PUXADORARTICULADO_SERIE", Back.BACK_PUXADORARTICULADO_SERIE);
					cmd.Parameters.AddWithValue("@BACK_PECKDECK_SERIE", Back.BACK_PECKDECK_SERIE);
					cmd.Parameters.AddWithValue("@BACK_PULLOVER_SERIE", Back.BACK_PULLOVER_SERIE);
					cmd.Parameters.AddWithValue("@BACK_BARRAFIXA_SERIE", Back.BACK_BARRAFIXA_SERIE);
					cmd.Parameters.AddWithValue("@BACK_VOADORINVERSO_SERIE", Back.BACK_VOADORINVERSO_SERIE);

					cmd.Parameters.AddWithValue("@BACK_PULLEYCOSTAS_REP", Back.BACK_PULLEYCOSTAS_REP);
					cmd.Parameters.AddWithValue("@BACK_PULLEYFRENTE_REP", Back.BACK_PULLEYFRENTE_REP);
					cmd.Parameters.AddWithValue("@BACK_PULLEYINVERTIDO_REP", Back.BACK_PULLEYINVERTIDO_REP);
					cmd.Parameters.AddWithValue("@BACK_REMADAHORIZONTAL_REP", Back.BACK_REMADAHORIZONTAL_REP);
					cmd.Parameters.AddWithValue("@BACK_REMADAALTERNADA_REP", Back.BACK_REMADAALTERNADA_REP);
					cmd.Parameters.AddWithValue("@BACK_REMADACAVALINHO_REP", Back.BACK_REMADACAVALINHO_REP);
					cmd.Parameters.AddWithValue("@BACK_PUXADORARTICULADO_REP", Back.BACK_PUXADORARTICULADO_REP);
					cmd.Parameters.AddWithValue("@BACK_PECKDECK_REP", Back.BACK_PECKDECK_REP);
					cmd.Parameters.AddWithValue("@BACK_PULLOVER_REP", Back.BACK_PULLOVER_REP);
					cmd.Parameters.AddWithValue("@BACK_BARRAFIXA_REP", Back.BACK_BARRAFIXA_REP);
					cmd.Parameters.AddWithValue("@BACK_VOADORINVERSO_REP", Back.BACK_VOADORINVERSO_REP);

					cmd.Parameters.AddWithValue("@BACK_PULLEYCOSTAS_CARGA", Back.BACK_PULLEYCOSTAS_CARGA);
					cmd.Parameters.AddWithValue("@BACK_PULLEYFRENTE_CARGA", Back.BACK_PULLEYFRENTE_CARGA);
					cmd.Parameters.AddWithValue("@BACK_PULLEYINVERTIDO_CARGA", Back.BACK_PULLEYINVERTIDO_CARGA);
					cmd.Parameters.AddWithValue("@BACK_REMADAHORIZONTAL_CARGA", Back.BACK_REMADAHORIZONTAL_CARGA);
					cmd.Parameters.AddWithValue("@BACK_REMADAALTERNADA_CARGA", Back.BACK_REMADAALTERNADA_CARGA);
					cmd.Parameters.AddWithValue("@BACK_REMADACAVALINHO_CARGA", Back.BACK_REMADACAVALINHO_CARGA);
					cmd.Parameters.AddWithValue("@BACK_PUXADORARTICULADO_CARGA", Back.BACK_PUXADORARTICULADO_CARGA);
					cmd.Parameters.AddWithValue("@BACK_PECKDECK_CARGA", Back.BACK_PECKDECK_CARGA);
					cmd.Parameters.AddWithValue("@BACK_PULLOVER_CARGA", Back.BACK_PULLOVER_CARGA);
					cmd.Parameters.AddWithValue("@BACK_BARRAFIXA_CARGA", Back.BACK_BARRAFIXA_CARGA);
					cmd.Parameters.AddWithValue("@BACK_VOADORINVERSO_CARGA", Back.BACK_VOADORINVERSO_CARGA);
					cmd.ExecuteNonQuery();
					#endregion
					#region Insert Biceps
					cmd.CommandText = @"
					INSERT INTO BICEPS 
						(BICEPS_ROSCADIRETA, BICEPS_ROSCAALTERNADA, BICEPS_ROSCAMARTELO, BICEPS_ROSCACONCENTRADA, BICEPS_ROSCAARTICULADA, 
						BICEPS_ROSCABILATERAL, BICEPS_ROSCAROLDANA, BICEPS_ROSCASIMULTANEA, BICEPS_ROSCADIRETA_SERIE, 
						BICEPS_ROSCAALTERNADA_SERIE, BICEPS_ROSCAMARTELO_SERIE, BICEPS_ROSCACONCENTRADA_SERIE, BICEPS_ROSCAARTICULADA_SERIE, 
						BICEPS_ROSCABILATERAL_SERIE, BICEPS_ROSCAROLDANA_SERIE, BICEPS_ROSCASIMULTANEA_SERIE, BICEPS_ROSCADIRETA_REP, 
						BICEPS_ROSCAALTERNADA_REP, BICEPS_ROSCAMARTELO_REP, BICEPS_ROSCACONCENTRADA_REP, BICEPS_ROSCAARTICULADA_REP, 
						BICEPS_ROSCABILATERAL_REP, BICEPS_ROSCAROLDANA_REP, BICEPS_ROSCASIMULTANEA_REP, BICEPS_ROSCADIRETA_CARGA, 
						BICEPS_ROSCAALTERNADA_CARGA, BICEPS_ROSCAMARTELO_CARGA, BICEPS_ROSCACONCENTRADA_CARGA, BICEPS_ROSCAARTICULADA_CARGA, 
						BICEPS_ROSCABILATERAL_CARGA, BICEPS_ROSCAROLDANA_CARGA, BICEPS_ROSCASIMULTANEA_CARGA, BICEPS_WORKOUT) 
					VALUES 
						(@BICEPS_ROSCADIRETA, @BICEPS_ROSCAALTERNADA, @BICEPS_ROSCAMARTELO, @BICEPS_ROSCACONCENTRADA, 
						@BICEPS_ROSCAARTICULADA, @BICEPS_ROSCABILATERAL, @BICEPS_ROSCAROLDANA, @BICEPS_ROSCASIMULTANEA, 
						@BICEPS_ROSCADIRETA_SERIE, @BICEPS_ROSCAALTERNADA_SERIE, @BICEPS_ROSCAMARTELO_SERIE, @BICEPS_ROSCACONCENTRADA_SERIE, 
						@BICEPS_ROSCAARTICULADA_SERIE, @BICEPS_ROSCABILATERAL_SERIE, @BICEPS_ROSCAROLDANA_SERIE, 
						@BICEPS_ROSCASIMULTANEA_SERIE, @BICEPS_ROSCADIRETA_REP, @BICEPS_ROSCAALTERNADA_REP, @BICEPS_ROSCAMARTELO_REP, 
						@BICEPS_ROSCACONCENTRADA_REP, @BICEPS_ROSCAARTICULADA_REP, @BICEPS_ROSCABILATERAL_REP, @BICEPS_ROSCAROLDANA_REP, 
						@BICEPS_ROSCASIMULTANEA_REP, @BICEPS_ROSCADIRETA_CARGA, @BICEPS_ROSCAALTERNADA_CARGA, @BICEPS_ROSCAMARTELO_CARGA, 
						@BICEPS_ROSCACONCENTRADA_CARGA, @BICEPS_ROSCAARTICULADA_CARGA, @BICEPS_ROSCABILATERAL_CARGA, 
						@BICEPS_ROSCAROLDANA_CARGA, @BICEPS_ROSCASIMULTANEA_CARGA, 
						(SELECT WORKOUT_ID FROM WORKOUT ORDER BY WORKOUT_ID DESC LIMIT 1))
					";

					cmd.Parameters.AddWithValue("@BICEPS_ROSCADIRETA", Biceps.BICEPS_ROSCADIRETA);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCAALTERNADA", Biceps.BICEPS_ROSCAALTERNADA);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCAMARTELO", Biceps.BICEPS_ROSCAMARTELO);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCACONCENTRADA", Biceps.BICEPS_ROSCACONCENTRADA);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCAARTICULADA", Biceps.BICEPS_ROSCAARTICULADA);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCABILATERAL", Biceps.BICEPS_ROSCABILATERAL);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCAROLDANA", Biceps.BICEPS_ROSCAROLDANA);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCASIMULTANEA", Biceps.BICEPS_ROSCASIMULTANEA);

					cmd.Parameters.AddWithValue("@BICEPS_ROSCADIRETA_SERIE", Biceps.BICEPS_ROSCADIRETA_SERIE);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCAALTERNADA_SERIE", Biceps.BICEPS_ROSCAALTERNADA_SERIE);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCAMARTELO_SERIE", Biceps.BICEPS_ROSCAMARTELO_SERIE);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCACONCENTRADA_SERIE", Biceps.BICEPS_ROSCACONCENTRADA_SERIE);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCAARTICULADA_SERIE", Biceps.BICEPS_ROSCAARTICULADA_SERIE);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCABILATERAL_SERIE", Biceps.BICEPS_ROSCABILATERAL_SERIE);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCAROLDANA_SERIE", Biceps.BICEPS_ROSCAROLDANA_SERIE);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCASIMULTANEA_SERIE", Biceps.BICEPS_ROSCASIMULTANEA_SERIE);

					cmd.Parameters.AddWithValue("@BICEPS_ROSCADIRETA_REP", Biceps.BICEPS_ROSCADIRETA_REP);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCAALTERNADA_REP", Biceps.BICEPS_ROSCAALTERNADA_REP);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCAMARTELO_REP", Biceps.BICEPS_ROSCAMARTELO_REP);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCACONCENTRADA_REP", Biceps.BICEPS_ROSCACONCENTRADA_REP);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCAARTICULADA_REP", Biceps.BICEPS_ROSCAARTICULADA_REP);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCABILATERAL_REP", Biceps.BICEPS_ROSCABILATERAL_REP);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCAROLDANA_REP", Biceps.BICEPS_ROSCAROLDANA_REP);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCASIMULTANEA_REP", Biceps.BICEPS_ROSCASIMULTANEA_REP);

					cmd.Parameters.AddWithValue("@BICEPS_ROSCADIRETA_CARGA", Biceps.BICEPS_ROSCADIRETA_CARGA);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCAALTERNADA_CARGA", Biceps.BICEPS_ROSCAALTERNADA_CARGA);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCAMARTELO_CARGA", Biceps.BICEPS_ROSCAMARTELO_CARGA);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCACONCENTRADA_CARGA", Biceps.BICEPS_ROSCACONCENTRADA_CARGA);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCAARTICULADA_CARGA", Biceps.BICEPS_ROSCAARTICULADA_CARGA);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCABILATERAL_CARGA", Biceps.BICEPS_ROSCABILATERAL_CARGA);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCAROLDANA_CARGA", Biceps.BICEPS_ROSCAROLDANA_CARGA);
					cmd.Parameters.AddWithValue("@BICEPS_ROSCASIMULTANEA_CARGA", Biceps.BICEPS_ROSCASIMULTANEA_CARGA);
					cmd.ExecuteNonQuery();
					#endregion
					#region Insert Chest
					cmd.CommandText = @"
					INSERT INTO CHEST 
						(CHEST_SUPINORETO, CHEST_SUPINOINCLINADO, CHEST_SUPINOSENTADO, CHEST_SUPINODUMBELL, CHEST_PECK, CHEST_PECKDECK, 
						CHEST_CRUCIFIXO, CHEST_CROSSOVER, CHEST_SUPINORETO_SERIE, CHEST_SUPINOINCLINADO_SERIE, CHEST_SUPINOSENTADO_SERIE, 
						CHEST_SUPINODUMBELL_SERIE, CHEST_PECK_SERIE, CHEST_PECKDECK_SERIE, CHEST_CRUCIFIXO_SERIE, CHEST_CROSSOVER_SERIE, 
						CHEST_SUPINORETO_REP, CHEST_SUPINOINCLINADO_REP, CHEST_SUPINOSENTADO_REP, CHEST_SUPINODUMBELL_REP, CHEST_PECK_REP, 
						CHEST_PECKDECK_REP, CHEST_CRUCIFIXO_REP, CHEST_CROSSOVER_REP, CHEST_SUPINORETO_CARGA, CHEST_SUPINOINCLINADO_CARGA, 
						CHEST_SUPINOSENTADO_CARGA, CHEST_SUPINODUMBELL_CARGA, CHEST_PECK_CARGA, CHEST_PECKDECK_CARGA, CHEST_CRUCIFIXO_CARGA, 
						CHEST_CROSSOVER_CARGA, CHEST_WORKOUT) 
					VALUES 
						(@CHEST_SUPINORETO, @CHEST_SUPINOINCLINADO, @CHEST_SUPINOSENTADO, @CHEST_SUPINODUMBELL, @CHEST_PECK, 
						@CHEST_PECKDECK, @CHEST_CRUCIFIXO, @CHEST_CROSSOVER, @CHEST_SUPINORETO_SERIE, @CHEST_SUPINOINCLINADO_SERIE, 
						@CHEST_SUPINOSENTADO_SERIE, @CHEST_SUPINODUMBELL_SERIE, @CHEST_PECK_SERIE, @CHEST_PECKDECK_SERIE, 
						@CHEST_CRUCIFIXO_SERIE, @CHEST_CROSSOVER_SERIE, @CHEST_SUPINORETO_REP, @CHEST_SUPINOINCLINADO_REP, 
						@CHEST_SUPINOSENTADO_REP, @CHEST_SUPINODUMBELL_REP, @CHEST_PECK_REP, @CHEST_PECKDECK_REP, @CHEST_CRUCIFIXO_REP, 
						@CHEST_CROSSOVER_REP, @CHEST_SUPINORETO_CARGA, @CHEST_SUPINOINCLINADO_CARGA, @CHEST_SUPINOSENTADO_CARGA, 
						@CHEST_SUPINODUMBELL_CARGA, @CHEST_PECK_CARGA, @CHEST_PECKDECK_CARGA, @CHEST_CRUCIFIXO_CARGA, 
						@CHEST_CROSSOVER_CARGA, (SELECT WORKOUT_ID FROM WORKOUT ORDER BY WORKOUT_ID DESC LIMIT 1))
					";
					cmd.Parameters.AddWithValue("@CHEST_SUPINORETO", Chest.CHEST_SUPINORETO);
					cmd.Parameters.AddWithValue("@CHEST_SUPINOINCLINADO", Chest.CHEST_SUPINOINCLINADO);
					cmd.Parameters.AddWithValue("@CHEST_SUPINOSENTADO", Chest.CHEST_SUPINOSENTADO);
					cmd.Parameters.AddWithValue("@CHEST_SUPINODUMBELL", Chest.CHEST_SUPINODUMBELL);
					cmd.Parameters.AddWithValue("@CHEST_PECK", Chest.CHEST_PECK);
					cmd.Parameters.AddWithValue("@CHEST_PECKDECK", Chest.CHEST_PECKDECK);
					cmd.Parameters.AddWithValue("@CHEST_CRUCIFIXO", Chest.CHEST_CRUCIFIXO);
					cmd.Parameters.AddWithValue("@CHEST_CROSSOVER", Chest.CHEST_CROSSOVER);

					cmd.Parameters.AddWithValue("@CHEST_SUPINORETO_SERIE", Chest.CHEST_SUPINORETO_SERIE);
					cmd.Parameters.AddWithValue("@CHEST_SUPINOINCLINADO_SERIE", Chest.CHEST_SUPINOINCLINADO_SERIE);
					cmd.Parameters.AddWithValue("@CHEST_SUPINOSENTADO_SERIE", Chest.CHEST_SUPINOSENTADO_SERIE);
					cmd.Parameters.AddWithValue("@CHEST_SUPINODUMBELL_SERIE", Chest.CHEST_SUPINODUMBELL_SERIE);
					cmd.Parameters.AddWithValue("@CHEST_PECK_SERIE", Chest.CHEST_PECK_SERIE);
					cmd.Parameters.AddWithValue("@CHEST_PECKDECK_SERIE", Chest.CHEST_PECKDECK_SERIE);
					cmd.Parameters.AddWithValue("@CHEST_CRUCIFIXO_SERIE", Chest.CHEST_CRUCIFIXO_SERIE);
					cmd.Parameters.AddWithValue("@CHEST_CROSSOVER_SERIE", Chest.CHEST_CROSSOVER_SERIE);

					cmd.Parameters.AddWithValue("@CHEST_SUPINORETO_REP", Chest.CHEST_SUPINORETO_REP);
					cmd.Parameters.AddWithValue("@CHEST_SUPINOINCLINADO_REP", Chest.CHEST_SUPINOINCLINADO_REP);
					cmd.Parameters.AddWithValue("@CHEST_SUPINOSENTADO_REP", Chest.CHEST_SUPINOSENTADO_REP);
					cmd.Parameters.AddWithValue("@CHEST_SUPINODUMBELL_REP", Chest.CHEST_SUPINODUMBELL_REP);
					cmd.Parameters.AddWithValue("@CHEST_PECK_REP", Chest.CHEST_PECK_REP);
					cmd.Parameters.AddWithValue("@CHEST_PECKDECK_REP", Chest.CHEST_PECKDECK_REP);
					cmd.Parameters.AddWithValue("@CHEST_CRUCIFIXO_REP", Chest.CHEST_CRUCIFIXO_REP);
					cmd.Parameters.AddWithValue("@CHEST_CROSSOVER_REP", Chest.CHEST_CROSSOVER_REP);

					cmd.Parameters.AddWithValue("@CHEST_SUPINORETO_CARGA", Chest.CHEST_SUPINORETO_CARGA);
					cmd.Parameters.AddWithValue("@CHEST_SUPINOINCLINADO_CARGA", Chest.CHEST_SUPINOINCLINADO_CARGA);
					cmd.Parameters.AddWithValue("@CHEST_SUPINOSENTADO_CARGA", Chest.CHEST_SUPINOSENTADO_CARGA);
					cmd.Parameters.AddWithValue("@CHEST_SUPINODUMBELL_CARGA", Chest.CHEST_SUPINODUMBELL_CARGA);
					cmd.Parameters.AddWithValue("@CHEST_PECK_CARGA", Chest.CHEST_PECK_CARGA);
					cmd.Parameters.AddWithValue("@CHEST_PECKDECK_CARGA", Chest.CHEST_PECKDECK_CARGA);
					cmd.Parameters.AddWithValue("@CHEST_CRUCIFIXO_CARGA", Chest.CHEST_CRUCIFIXO_CARGA);
					cmd.Parameters.AddWithValue("@CHEST_CROSSOVER_CARGA", Chest.CHEST_CROSSOVER_CARGA);
					cmd.ExecuteNonQuery();
					#endregion
					#region Insert Legs
					cmd.CommandText = @"
					INSERT INTO LEGS 
						(LEGS_CADEIRAEXTENSORA, LEGS_CADEIRAFLEXORA, LEGS_ADUTOR, LEGS_ABDUTOR, LEGS_LEGPRESS, LEGS_AGACHAMENTOLIVRE, 
						LEGS_HACK, LEGS_PANTURRILHA, LEGS_STIFF, LEGS_GLUTEO, LEGS_AVANCO, LEGS_CADEIRAEXTENSORA_SERIE, 
						LEGS_CADEIRAFLEXORA_SERIE, LEGS_ADUTOR_SERIE, LEGS_ABDUTOR_SERIE, LEGS_LEGPRESS_SERIE, LEGS_AGACHAMENTOLIVRE_SERIE, 
						LEGS_HACK_SERIE, LEGS_PANTURRILHA_SERIE, LEGS_STIFF_SERIE, LEGS_GLUTEO_SERIE, LEGS_AVANCO_SERIE, 
						LEGS_CADEIRAEXTENSORA_REP, LEGS_CADEIRAFLEXORA_REP, LEGS_ADUTOR_REP, LEGS_ABDUTOR_REP, LEGS_LEGPRESS_REP,	
						LEGS_AGACHAMENTOLIVRE_REP, LEGS_HACK_REP, LEGS_PANTURRILHA_REP, LEGS_STIFF_REP, LEGS_GLUTEO_REP, LEGS_AVANCO_REP, 
						LEGS_CADEIRAEXTENSORA_CARGA, LEGS_CADEIRAFLEXORA_CARGA, LEGS_ADUTOR_CARGA, LEGS_ABDUTOR_CARGA, LEGS_LEGPRESS_CARGA, 
						LEGS_AGACHAMENTOLIVRE_CARGA, LEGS_HACK_CARGA, LEGS_PANTURRILHA_CARGA, LEGS_STIFF_CARGA, LEGS_GLUTEO_CARGA, 
						LEGS_AVANCO_CARGA, LEGS_WORKOUT) 
					VALUES 
						(@LEGS_CADEIRAEXTENSORA, @LEGS_CADEIRAFLEXORA, @LEGS_ADUTOR, @LEGS_ABDUTOR, @LEGS_LEGPRESS, @LEGS_AGACHAMENTOLIVRE, 
						@LEGS_HACK, @LEGS_PANTURRILHA, @LEGS_STIFF, @LEGS_GLUTEO, @LEGS_AVANCO, @LEGS_CADEIRAEXTENSORA_SERIE, 
						@LEGS_CADEIRAFLEXORA_SERIE, @LEGS_ADUTOR_SERIE, @LEGS_ABDUTOR_SERIE, @LEGS_LEGPRESS_SERIE, 
						@LEGS_AGACHAMENTOLIVRE_SERIE, @LEGS_HACK_SERIE, @LEGS_PANTURRILHA_SERIE, @LEGS_STIFF_SERIE, @LEGS_GLUTEO_SERIE, 
						@LEGS_AVANCO_SERIE, @LEGS_CADEIRAEXTENSORA_REP, @LEGS_CADEIRAFLEXORA_REP, @LEGS_ADUTOR_REP, @LEGS_ABDUTOR_REP, 
						@LEGS_LEGPRESS_REP, @LEGS_AGACHAMENTOLIVRE_REP, @LEGS_HACK_REP, @LEGS_PANTURRILHA_REP, @LEGS_STIFF_REP, 
						@LEGS_GLUTEO_REP, @LEGS_AVANCO_REP, @LEGS_CADEIRAEXTENSORA_CARGA, @LEGS_CADEIRAFLEXORA_CARGA, @LEGS_ADUTOR_CARGA, 
						@LEGS_ABDUTOR_CARGA, @LEGS_LEGPRESS_CARGA, @LEGS_AGACHAMENTOLIVRE_CARGA, @LEGS_HACK_CARGA, @LEGS_PANTURRILHA_CARGA, 
						@LEGS_STIFF_CARGA, @LEGS_GLUTEO_CARGA, @LEGS_AVANCO_CARGA, 
						(SELECT WORKOUT_ID FROM WORKOUT ORDER BY WORKOUT_ID DESC LIMIT 1))
					";
					cmd.Parameters.AddWithValue("@LEGS_CADEIRAEXTENSORA", Legs.LEGS_CADEIRAEXTENSORA);
					cmd.Parameters.AddWithValue("@LEGS_CADEIRAFLEXORA", Legs.LEGS_CADEIRAFLEXORA);
					cmd.Parameters.AddWithValue("@LEGS_ADUTOR", Legs.LEGS_ADUTOR);
					cmd.Parameters.AddWithValue("@LEGS_ABDUTOR", Legs.LEGS_ABDUTOR);
					cmd.Parameters.AddWithValue("@LEGS_LEGPRESS", Legs.LEGS_LEGPRESS);
					cmd.Parameters.AddWithValue("@LEGS_AGACHAMENTOLIVRE", Legs.LEGS_AGACHAMENTOLIVRE);
					cmd.Parameters.AddWithValue("@LEGS_HACK", Legs.LEGS_HACK);
					cmd.Parameters.AddWithValue("@LEGS_PANTURRILHA", Legs.LEGS_PANTURRILHA);
					cmd.Parameters.AddWithValue("@LEGS_STIFF", Legs.LEGS_STIFF);
					cmd.Parameters.AddWithValue("@LEGS_GLUTEO", Legs.LEGS_GLUTEO);
					cmd.Parameters.AddWithValue("@LEGS_AVANCO", Legs.LEGS_AVANCO);

					cmd.Parameters.AddWithValue("@LEGS_CADEIRAEXTENSORA_SERIE", Legs.LEGS_CADEIRAEXTENSORA_SERIE);
					cmd.Parameters.AddWithValue("@LEGS_CADEIRAFLEXORA_SERIE", Legs.LEGS_CADEIRAFLEXORA_SERIE);
					cmd.Parameters.AddWithValue("@LEGS_ADUTOR_SERIE", Legs.LEGS_ADUTOR_SERIE);
					cmd.Parameters.AddWithValue("@LEGS_ABDUTOR_SERIE", Legs.LEGS_ABDUTOR_SERIE);
					cmd.Parameters.AddWithValue("@LEGS_LEGPRESS_SERIE", Legs.LEGS_LEGPRESS_SERIE);
					cmd.Parameters.AddWithValue("@LEGS_AGACHAMENTOLIVRE_SERIE", Legs.LEGS_AGACHAMENTOLIVRE_SERIE);
					cmd.Parameters.AddWithValue("@LEGS_HACK_SERIE", Legs.LEGS_HACK_SERIE);
					cmd.Parameters.AddWithValue("@LEGS_PANTURRILHA_SERIE", Legs.LEGS_PANTURRILHA_SERIE);
					cmd.Parameters.AddWithValue("@LEGS_STIFF_SERIE", Legs.LEGS_STIFF_SERIE);
					cmd.Parameters.AddWithValue("@LEGS_GLUTEO_SERIE", Legs.LEGS_GLUTEO_SERIE);
					cmd.Parameters.AddWithValue("@LEGS_AVANCO_SERIE", Legs.LEGS_AVANCO_SERIE);

					cmd.Parameters.AddWithValue("@LEGS_CADEIRAEXTENSORA_REP", Legs.LEGS_CADEIRAEXTENSORA_REP);
					cmd.Parameters.AddWithValue("@LEGS_CADEIRAFLEXORA_REP", Legs.LEGS_CADEIRAFLEXORA_REP);
					cmd.Parameters.AddWithValue("@LEGS_ADUTOR_REP", Legs.LEGS_ADUTOR_REP);
					cmd.Parameters.AddWithValue("@LEGS_ABDUTOR_REP", Legs.LEGS_ABDUTOR_REP);
					cmd.Parameters.AddWithValue("@LEGS_LEGPRESS_REP", Legs.LEGS_LEGPRESS_REP);
					cmd.Parameters.AddWithValue("@LEGS_AGACHAMENTOLIVRE_REP", Legs.LEGS_AGACHAMENTOLIVRE_REP);
					cmd.Parameters.AddWithValue("@LEGS_HACK_REP", Legs.LEGS_HACK_REP);
					cmd.Parameters.AddWithValue("@LEGS_PANTURRILHA_REP", Legs.LEGS_PANTURRILHA_REP);
					cmd.Parameters.AddWithValue("@LEGS_STIFF_REP", Legs.LEGS_STIFF_REP);
					cmd.Parameters.AddWithValue("@LEGS_GLUTEO_REP", Legs.LEGS_GLUTEO_REP);
					cmd.Parameters.AddWithValue("@LEGS_AVANCO_REP", Legs.LEGS_AVANCO_REP);

					cmd.Parameters.AddWithValue("@LEGS_CADEIRAEXTENSORA_CARGA", Legs.LEGS_CADEIRAEXTENSORA_CARGA);
					cmd.Parameters.AddWithValue("@LEGS_CADEIRAFLEXORA_CARGA", Legs.LEGS_CADEIRAFLEXORA_CARGA);
					cmd.Parameters.AddWithValue("@LEGS_ADUTOR_CARGA", Legs.LEGS_ADUTOR_CARGA);
					cmd.Parameters.AddWithValue("@LEGS_ABDUTOR_CARGA", Legs.LEGS_ABDUTOR_CARGA);
					cmd.Parameters.AddWithValue("@LEGS_LEGPRESS_CARGA", Legs.LEGS_LEGPRESS_CARGA);
					cmd.Parameters.AddWithValue("@LEGS_AGACHAMENTOLIVRE_CARGA", Legs.LEGS_AGACHAMENTOLIVRE_CARGA);
					cmd.Parameters.AddWithValue("@LEGS_HACK_CARGA", Legs.LEGS_HACK_CARGA);
					cmd.Parameters.AddWithValue("@LEGS_PANTURRILHA_CARGA", Legs.LEGS_PANTURRILHA_CARGA);
					cmd.Parameters.AddWithValue("@LEGS_STIFF_CARGA", Legs.LEGS_STIFF_CARGA);
					cmd.Parameters.AddWithValue("@LEGS_GLUTEO_CARGA", Legs.LEGS_GLUTEO_CARGA);
					cmd.Parameters.AddWithValue("@LEGS_AVANCO_CARGA", Legs.LEGS_AVANCO_CARGA);
					cmd.ExecuteNonQuery();
					#endregion
					#region Insert Shoulders
					cmd.CommandText = @"
					INSERT INTO SHOULDERS 
						(SHOULDERS_ELEVACAOLATERAL, SHOULDERS_ELEVACAOFRONTAL, SHOULDERS_ELEVACAOOMBRO, SHOULDERS_DEVCOSTAS, 
						SHOULDERS_DEVFRENTE, SHOULDERS_DEVDUMBELL, SHOULDERS_REMADAALTA, SHOULDERS_ELEVACAOLATERAL_SERIE, 
						SHOULDERS_ELEVACAOFRONTAL_SERIE, SHOULDERS_ELEVACAOOMBRO_SERIE, SHOULDERS_DEVCOSTAS_SERIE, SHOULDERS_DEVFRENTE_SERIE, 
						SHOULDERS_DEVDUMBELL_SERIE, SHOULDERS_REMADAALTA_SERIE, SHOULDERS_ELEVACAOLATERAL_REP, 
						SHOULDERS_ELEVACAOFRONTAL_REP, SHOULDERS_ELEVACAOOMBRO_REP, SHOULDERS_DEVCOSTAS_REP, SHOULDERS_DEVFRENTE_REP, 
						SHOULDERS_DEVDUMBELL_REP, SHOULDERS_REMADAALTA_REP, SHOULDERS_ELEVACAOLATERAL_CARGA, SHOULDERS_ELEVACAOFRONTAL_CARGA, 
						SHOULDERS_ELEVACAOOMBRO_CARGA, SHOULDERS_DEVCOSTAS_CARGA, SHOULDERS_DEVFRENTE_CARGA, SHOULDERS_DEVDUMBELL_CARGA, 
						SHOULDERS_REMADAALTA_CARGA, SHOULDERS_WORKOUT) 
					VALUES 
						(@SHOULDERS_ELEVACAOLATERAL, @SHOULDERS_ELEVACAOFRONTAL, @SHOULDERS_ELEVACAOOMBRO, @SHOULDERS_DEVCOSTAS, 
						@SHOULDERS_DEVFRENTE, @SHOULDERS_DEVDUMBELL, @SHOULDERS_REMADAALTA, @SHOULDERS_ELEVACAOLATERAL_SERIE, 
						@SHOULDERS_ELEVACAOFRONTAL_SERIE, @SHOULDERS_ELEVACAOOMBRO_SERIE, @SHOULDERS_DEVCOSTAS_SERIE, 
						@SHOULDERS_DEVFRENTE_SERIE, @SHOULDERS_DEVDUMBELL_SERIE, @SHOULDERS_REMADAALTA_SERIE, @SHOULDERS_ELEVACAOLATERAL_REP, 
						@SHOULDERS_ELEVACAOFRONTAL_REP, @SHOULDERS_ELEVACAOOMBRO_REP, @SHOULDERS_DEVCOSTAS_REP, @SHOULDERS_DEVFRENTE_REP, 
						@SHOULDERS_DEVDUMBELL_REP, @SHOULDERS_REMADAALTA_REP, @SHOULDERS_ELEVACAOLATERAL_CARGA, 
						@SHOULDERS_ELEVACAOFRONTAL_CARGA, @SHOULDERS_ELEVACAOOMBRO_CARGA, @SHOULDERS_DEVCOSTAS_CARGA, 
						@SHOULDERS_DEVFRENTE_CARGA, @SHOULDERS_DEVDUMBELL_CARGA, @SHOULDERS_REMADAALTA_CARGA, 
						(SELECT WORKOUT_ID FROM WORKOUT ORDER BY WORKOUT_ID DESC LIMIT 1))
					";
					cmd.Parameters.AddWithValue("@SHOULDERS_ELEVACAOLATERAL", Shoulders.SHOULDERS_ELEVACAOLATERAL);
					cmd.Parameters.AddWithValue("@SHOULDERS_ELEVACAOFRONTAL", Shoulders.SHOULDERS_ELEVACAOFRONTAL);
					cmd.Parameters.AddWithValue("@SHOULDERS_ELEVACAOOMBRO", Shoulders.SHOULDERS_ELEVACAOOMBRO);
					cmd.Parameters.AddWithValue("@SHOULDERS_DEVCOSTAS", Shoulders.SHOULDERS_DEVCOSTAS);
					cmd.Parameters.AddWithValue("@SHOULDERS_DEVFRENTE", Shoulders.SHOULDERS_DEVFRENTE);
					cmd.Parameters.AddWithValue("@SHOULDERS_DEVDUMBELL", Shoulders.SHOULDERS_DEVDUMBELL);
					cmd.Parameters.AddWithValue("@SHOULDERS_REMADAALTA", Shoulders.SHOULDERS_REMADAALTA);

					cmd.Parameters.AddWithValue("@SHOULDERS_ELEVACAOLATERAL_SERIE", Shoulders.SHOULDERS_ELEVACAOLATERAL_SERIE);
					cmd.Parameters.AddWithValue("@SHOULDERS_ELEVACAOFRONTAL_SERIE", Shoulders.SHOULDERS_ELEVACAOFRONTAL_SERIE);
					cmd.Parameters.AddWithValue("@SHOULDERS_ELEVACAOOMBRO_SERIE", Shoulders.SHOULDERS_ELEVACAOOMBRO_SERIE);
					cmd.Parameters.AddWithValue("@SHOULDERS_DEVCOSTAS_SERIE", Shoulders.SHOULDERS_DEVCOSTAS_SERIE);
					cmd.Parameters.AddWithValue("@SHOULDERS_DEVFRENTE_SERIE", Shoulders.SHOULDERS_DEVFRENTE_SERIE);
					cmd.Parameters.AddWithValue("@SHOULDERS_DEVDUMBELL_SERIE", Shoulders.SHOULDERS_DEVDUMBELL_SERIE);
					cmd.Parameters.AddWithValue("@SHOULDERS_REMADAALTA_SERIE", Shoulders.SHOULDERS_REMADAALTA_SERIE);

					cmd.Parameters.AddWithValue("@SHOULDERS_ELEVACAOLATERAL_REP", Shoulders.SHOULDERS_ELEVACAOLATERAL_REP);
					cmd.Parameters.AddWithValue("@SHOULDERS_ELEVACAOFRONTAL_REP", Shoulders.SHOULDERS_ELEVACAOFRONTAL_REP);
					cmd.Parameters.AddWithValue("@SHOULDERS_ELEVACAOOMBRO_REP", Shoulders.SHOULDERS_ELEVACAOOMBRO_REP);
					cmd.Parameters.AddWithValue("@SHOULDERS_DEVCOSTAS_REP", Shoulders.SHOULDERS_DEVCOSTAS_REP);
					cmd.Parameters.AddWithValue("@SHOULDERS_DEVFRENTE_REP", Shoulders.SHOULDERS_DEVFRENTE_REP);
					cmd.Parameters.AddWithValue("@SHOULDERS_DEVDUMBELL_REP", Shoulders.SHOULDERS_DEVDUMBELL_REP);
					cmd.Parameters.AddWithValue("@SHOULDERS_REMADAALTA_REP", Shoulders.SHOULDERS_REMADAALTA_REP);

					cmd.Parameters.AddWithValue("@SHOULDERS_ELEVACAOLATERAL_CARGA", Shoulders.SHOULDERS_ELEVACAOLATERAL_CARGA);
					cmd.Parameters.AddWithValue("@SHOULDERS_ELEVACAOFRONTAL_CARGA", Shoulders.SHOULDERS_ELEVACAOFRONTAL_CARGA);
					cmd.Parameters.AddWithValue("@SHOULDERS_ELEVACAOOMBRO_CARGA", Shoulders.SHOULDERS_ELEVACAOOMBRO_CARGA);
					cmd.Parameters.AddWithValue("@SHOULDERS_DEVCOSTAS_CARGA", Shoulders.SHOULDERS_DEVCOSTAS_CARGA);
					cmd.Parameters.AddWithValue("@SHOULDERS_DEVFRENTE_CARGA", Shoulders.SHOULDERS_DEVFRENTE_CARGA);
					cmd.Parameters.AddWithValue("@SHOULDERS_DEVDUMBELL_CARGA", Shoulders.SHOULDERS_DEVDUMBELL_CARGA);
					cmd.Parameters.AddWithValue("@SHOULDERS_REMADAALTA_CARGA", Shoulders.SHOULDERS_REMADAALTA_CARGA);
					cmd.ExecuteNonQuery();
					#endregion
					#region Insert Triceps
					cmd.CommandText = @"
					INSERT INTO TRICEPS 
						(TRICEPS_PULLEY, TRICEPS_ROSCATESTA, TRICEPS_PULLEYCORDA, TRICEPS_ROSCAFRANCESA, TRICEPS_ROSCASUPINADA, 
						TRICEPS_COICE, TRICEPS_INVERTIDO, TRICEPS_MERGULHO, TRICEPS_PULLEY_SERIE, TRICEPS_ROSCATESTA_SERIE, 
						TRICEPS_PULLEYCORDA_SERIE, TRICEPS_ROSCAFRANCESA_SERIE, TRICEPS_ROSCASUPINADA_SERIE, TRICEPS_COICE_SERIE, 
						TRICEPS_INVERTIDO_SERIE, TRICEPS_MERGULHO_SERIE, TRICEPS_PULLEY_REP, TRICEPS_ROSCATESTA_REP, TRICEPS_PULLEYCORDA_REP, 
						TRICEPS_ROSCAFRANCESA_REP, TRICEPS_ROSCASUPINADA_REP, TRICEPS_COICE_REP, TRICEPS_INVERTIDO_REP, TRICEPS_MERGULHO_REP, 
						TRICEPS_PULLEY_CARGA, TRICEPS_ROSCATESTA_CARGA, TRICEPS_PULLEYCORDA_CARGA, TRICEPS_ROSCAFRANCESA_CARGA, 
						TRICEPS_ROSCASUPINADA_CARGA, TRICEPS_COICE_CARGA, TRICEPS_INVERTIDO_CARGA, TRICEPS_MERGULHO_CARGA, TRICEPS_WORKOUT) 
					VALUES 
						(@TRICEPS_PULLEY, @TRICEPS_ROSCATESTA, @TRICEPS_PULLEYCORDA, @TRICEPS_ROSCAFRANCESA, @TRICEPS_ROSCASUPINADA, 
						@TRICEPS_COICE, @TRICEPS_INVERTIDO, @TRICEPS_MERGULHO, @TRICEPS_PULLEY_SERIE, @TRICEPS_ROSCATESTA_SERIE, 
						@TRICEPS_PULLEYCORDA_SERIE, @TRICEPS_ROSCAFRANCESA_SERIE, @TRICEPS_ROSCASUPINADA_SERIE, @TRICEPS_COICE_SERIE, 
						@TRICEPS_INVERTIDO_SERIE, @TRICEPS_MERGULHO_SERIE, @TRICEPS_PULLEY_REP, @TRICEPS_ROSCATESTA_REP, 
						@TRICEPS_PULLEYCORDA_REP, @TRICEPS_ROSCAFRANCESA_REP, @TRICEPS_ROSCASUPINADA_REP, @TRICEPS_COICE_REP, 
						@TRICEPS_INVERTIDO_REP, @TRICEPS_MERGULHO_REP, @TRICEPS_PULLEY_CARGA, @TRICEPS_ROSCATESTA_CARGA, 
						@TRICEPS_PULLEYCORDA_CARGA, @TRICEPS_ROSCAFRANCESA_CARGA, @TRICEPS_ROSCASUPINADA_CARGA, @TRICEPS_COICE_CARGA, 
						@TRICEPS_INVERTIDO_CARGA, @TRICEPS_MERGULHO_CARGA, (SELECT WORKOUT_ID FROM WORKOUT ORDER BY WORKOUT_ID DESC LIMIT 1))
					";
					cmd.Parameters.AddWithValue("@TRICEPS_PULLEY", Triceps.TRICEPS_PULLEY);
					cmd.Parameters.AddWithValue("@TRICEPS_ROSCATESTA", Triceps.TRICEPS_ROSCATESTA);
					cmd.Parameters.AddWithValue("@TRICEPS_PULLEYCORDA", Triceps.TRICEPS_PULLEYCORDA);
					cmd.Parameters.AddWithValue("@TRICEPS_ROSCAFRANCESA", Triceps.TRICEPS_ROSCAFRANCESA);
					cmd.Parameters.AddWithValue("@TRICEPS_ROSCASUPINADA", Triceps.TRICEPS_ROSCASUPINADA);
					cmd.Parameters.AddWithValue("@TRICEPS_COICE", Triceps.TRICEPS_COICE);
					cmd.Parameters.AddWithValue("@TRICEPS_INVERTIDO", Triceps.TRICEPS_INVERTIDO);
					cmd.Parameters.AddWithValue("@TRICEPS_MERGULHO", Triceps.TRICEPS_MERGULHO);

					cmd.Parameters.AddWithValue("@TRICEPS_PULLEY_SERIE", Triceps.TRICEPS_PULLEY_SERIE);
					cmd.Parameters.AddWithValue("@TRICEPS_ROSCATESTA_SERIE", Triceps.TRICEPS_ROSCATESTA_SERIE);
					cmd.Parameters.AddWithValue("@TRICEPS_PULLEYCORDA_SERIE", Triceps.TRICEPS_PULLEYCORDA_SERIE);
					cmd.Parameters.AddWithValue("@TRICEPS_ROSCAFRANCESA_SERIE", Triceps.TRICEPS_ROSCAFRANCESA_SERIE);
					cmd.Parameters.AddWithValue("@TRICEPS_ROSCASUPINADA_SERIE", Triceps.TRICEPS_ROSCASUPINADA_SERIE);
					cmd.Parameters.AddWithValue("@TRICEPS_COICE_SERIE", Triceps.TRICEPS_COICE_SERIE);
					cmd.Parameters.AddWithValue("@TRICEPS_INVERTIDO_SERIE", Triceps.TRICEPS_INVERTIDO_SERIE);
					cmd.Parameters.AddWithValue("@TRICEPS_MERGULHO_SERIE", Triceps.TRICEPS_MERGULHO_SERIE);

					cmd.Parameters.AddWithValue("@TRICEPS_PULLEY_REP", Triceps.TRICEPS_PULLEY_REP);
					cmd.Parameters.AddWithValue("@TRICEPS_ROSCATESTA_REP", Triceps.TRICEPS_ROSCATESTA_REP);
					cmd.Parameters.AddWithValue("@TRICEPS_PULLEYCORDA_REP", Triceps.TRICEPS_PULLEYCORDA_REP);
					cmd.Parameters.AddWithValue("@TRICEPS_ROSCAFRANCESA_REP", Triceps.TRICEPS_ROSCAFRANCESA_REP);
					cmd.Parameters.AddWithValue("@TRICEPS_ROSCASUPINADA_REP", Triceps.TRICEPS_ROSCASUPINADA_REP);
					cmd.Parameters.AddWithValue("@TRICEPS_COICE_REP", Triceps.TRICEPS_COICE_REP);
					cmd.Parameters.AddWithValue("@TRICEPS_INVERTIDO_REP", Triceps.TRICEPS_INVERTIDO_REP);
					cmd.Parameters.AddWithValue("@TRICEPS_MERGULHO_REP", Triceps.TRICEPS_MERGULHO_REP);

					cmd.Parameters.AddWithValue("@TRICEPS_PULLEY_CARGA", Triceps.TRICEPS_PULLEY_CARGA);
					cmd.Parameters.AddWithValue("@TRICEPS_ROSCATESTA_CARGA", Triceps.TRICEPS_ROSCATESTA_CARGA);
					cmd.Parameters.AddWithValue("@TRICEPS_PULLEYCORDA_CARGA", Triceps.TRICEPS_PULLEYCORDA_CARGA);
					cmd.Parameters.AddWithValue("@TRICEPS_ROSCAFRANCESA_CARGA", Triceps.TRICEPS_ROSCAFRANCESA_CARGA);
					cmd.Parameters.AddWithValue("@TRICEPS_ROSCASUPINADA_CARGA", Triceps.TRICEPS_ROSCASUPINADA_CARGA);
					cmd.Parameters.AddWithValue("@TRICEPS_COICE_CARGA", Triceps.TRICEPS_COICE_CARGA);
					cmd.Parameters.AddWithValue("@TRICEPS_INVERTIDO_CARGA", Triceps.TRICEPS_INVERTIDO_CARGA);
					cmd.Parameters.AddWithValue("@TRICEPS_MERGULHO_CARGA", Triceps.TRICEPS_MERGULHO_CARGA);
					cmd.ExecuteNonQuery();
					#endregion
					#region WarmUp 
					cmd.CommandText = @"
					INSERT INTO WARMUP 
						(WARMUP_ESTEIRA, WARMUP_BICICLETA, WARMUP_ELIPTICO, WARMUP_CORDA, WARMUP_ESTEIRA_SERIE, WARMUP_BICICLETA_SERIE, 
						WARMUP_ELIPTICO_SERIE, WARMUP_CORDA_SERIE, WARMUP_ESTEIRA_REP, WARMUP_BICICLETA_REP, WARMUP_ELIPTICO_REP, 
						WARMUP_CORDA_REP, WARMUP_ESTEIRA_CARGA, WARMUP_BICICLETA_CARGA, WARMUP_ELIPTICO_CARGA, WARMUP_CORDA_CARGA, 
						WARMUP_WORKOUT) 
					VALUES 
						(@WARMUP_ESTEIRA, @WARMUP_BICICLETA, @WARMUP_ELIPTICO, @WARMUP_CORDA, @WARMUP_ESTEIRA_SERIE, 
						@WARMUP_BICICLETA_SERIE, @WARMUP_ELIPTICO_SERIE, @WARMUP_CORDA_SERIE, @WARMUP_ESTEIRA_REP, @WARMUP_BICICLETA_REP, 
						@WARMUP_ELIPTICO_REP, @WARMUP_CORDA_REP, @WARMUP_ESTEIRA_CARGA, @WARMUP_BICICLETA_CARGA, @WARMUP_ELIPTICO_CARGA, 
						@WARMUP_CORDA_CARGA, (SELECT WORKOUT_ID FROM WORKOUT ORDER BY WORKOUT_ID DESC LIMIT 1))
					";
					cmd.Parameters.AddWithValue("@WARMUP_ESTEIRA", WarmUp.WARMUP_ESTEIRA);
					cmd.Parameters.AddWithValue("@WARMUP_BICICLETA", WarmUp.WARMUP_BICICLETA);
					cmd.Parameters.AddWithValue("@WARMUP_ELIPTICO", WarmUp.WARMUP_ELIPTICO);
					cmd.Parameters.AddWithValue("@WARMUP_CORDA", WarmUp.WARMUP_CORDA);

					cmd.Parameters.AddWithValue("@WARMUP_ESTEIRA_SERIE", WarmUp.WARMUP_ESTEIRA_SERIE);
					cmd.Parameters.AddWithValue("@WARMUP_BICICLETA_SERIE", WarmUp.WARMUP_BICICLETA_SERIE);
					cmd.Parameters.AddWithValue("@WARMUP_ELIPTICO_SERIE", WarmUp.WARMUP_ELIPTICO_SERIE);
					cmd.Parameters.AddWithValue("@WARMUP_CORDA_SERIE", WarmUp.WARMUP_CORDA_SERIE);

					cmd.Parameters.AddWithValue("@WARMUP_ESTEIRA_REP", WarmUp.WARMUP_ESTEIRA_REP);
					cmd.Parameters.AddWithValue("@WARMUP_BICICLETA_REP", WarmUp.WARMUP_BICICLETA_REP);
					cmd.Parameters.AddWithValue("@WARMUP_ELIPTICO_REP", WarmUp.WARMUP_ELIPTICO_REP);
					cmd.Parameters.AddWithValue("@WARMUP_CORDA_REP", WarmUp.WARMUP_CORDA_REP);

					cmd.Parameters.AddWithValue("@WARMUP_ESTEIRA_CARGA", WarmUp.WARMUP_ESTEIRA_CARGA);
					cmd.Parameters.AddWithValue("@WARMUP_BICICLETA_CARGA", WarmUp.WARMUP_BICICLETA_CARGA);
					cmd.Parameters.AddWithValue("@WARMUP_ELIPTICO_CARGA", WarmUp.WARMUP_ELIPTICO_CARGA);
					cmd.Parameters.AddWithValue("@WARMUP_CORDA_CARGA", WarmUp.WARMUP_CORDA_CARGA);
					cmd.ExecuteNonQuery();
					#endregion

					MessageBox.Show("Dados Salvos Com Sucesso");
					vcon.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao Criar Treino");
					throw (ex);
				}
			}
		}

		public static void SelectWorkOut()
		{
			SQLiteConnection sql = new SQLiteConnection();
			sql.ConnectionString = "Data Source =" + Global.dbPath + Global.dbName;
			sql.Open();
			SQLiteCommand cmd = new SQLiteCommand();
			cmd.CommandText = @"
					SELECT ABS_RETOABDOMEN, ABS_INFRA, ABS_OBLIQUO, ABS_PARALELAFIXA, ABS_PRANCHAABDOMEN, ABS_RETOABDOMEN_SERIE, ABS_INFRA_SERIE, 
						ABS_OBLIQUO_SERIE, ABS_PARALELAFIXA_SERIE, ABS_PRANCHAABDOMEN_SERIE, ABS_RETOABDOMEN_REP, ABS_INFRA_REP, ABS_OBLIQUO_REP, 
						ABS_PARALELAFIXA_REP, ABS_PRANCHAABDOMEN_REP, ABS_RETOABDOMEN_CARGA, ABS_INFRA_CARGA, ABS_OBLIQUO_CARGA, ABS_PARALELAFIXA_CARGA, 
						ABS_PRANCHAABDOMEN_CARGA, BACK_PULLEYCOSTAS, BACK_PULLEYFRENTE, BACK_PULLEYINVERTIDO, BACK_REMADAHORIZONTAL, BACK_REMADAALTERNADA, 
						BACK_REMADACAVALINHO, BACK_PUXADORARTICULADO, BACK_PECKDECK, BACK_PULLOVER, BACK_BARRAFIXA, BACK_VOADORINVERSO, 
						BACK_PULLEYCOSTAS_SERIE, BACK_PULLEYFRENTE_SERIE, BACK_PULLEYINVERTIDO_SERIE, BACK_REMADAHORIZONTAL_SERIE, BACK_REMADAALTERNADA_SERIE, 
						BACK_REMADACAVALINHO_SERIE, BACK_PUXADORARTICULADO_SERIE, BACK_PECKDECK_SERIE, BACK_PULLOVER_SERIE, BACK_BARRAFIXA_SERIE, 
						BACK_VOADORINVERSO_SERIE, BACK_PULLEYCOSTAS_REP, BACK_PULLEYFRENTE_REP, BACK_PULLEYINVERTIDO_REP, BACK_REMADAHORIZONTAL_REP, 
						BACK_REMADAALTERNADA_REP, BACK_REMADACAVALINHO_REP, BACK_PUXADORARTICULADO_REP, BACK_PECKDECK_REP, BACK_PULLOVER_REP, BACK_BARRAFIXA_REP, 
						BACK_VOADORINVERSO_REP, BACK_PULLEYCOSTAS_CARGA, BACK_PULLEYFRENTE_CARGA, BACK_PULLEYINVERTIDO_CARGA, BACK_REMADAHORIZONTAL_CARGA, 
						BACK_REMADAALTERNADA_CARGA, BACK_REMADACAVALINHO_CARGA, BACK_PUXADORARTICULADO_CARGA, BACK_PECKDECK_CARGA, BACK_PULLOVER_CARGA, 
						BACK_BARRAFIXA_CARGA, BACK_VOADORINVERSO_CARGA, BICEPS_ROSCADIRETA, BICEPS_ROSCAALTERNADA, BICEPS_ROSCAMARTELO, BICEPS_ROSCACONCENTRADA, 
						BICEPS_ROSCAARTICULADA, BICEPS_ROSCABILATERAL, BICEPS_ROSCAROLDANA, BICEPS_ROSCASIMULTANEA, BICEPS_ROSCADIRETA_SERIE, 
						BICEPS_ROSCAALTERNADA_SERIE, BICEPS_ROSCAMARTELO_SERIE, BICEPS_ROSCACONCENTRADA_SERIE, BICEPS_ROSCAARTICULADA_SERIE, 
						BICEPS_ROSCABILATERAL_SERIE, BICEPS_ROSCAROLDANA_SERIE, BICEPS_ROSCASIMULTANEA_SERIE, BICEPS_ROSCADIRETA_REP, BICEPS_ROSCAALTERNADA_REP, 
						BICEPS_ROSCAMARTELO_REP, BICEPS_ROSCACONCENTRADA_REP, BICEPS_ROSCAARTICULADA_REP, BICEPS_ROSCABILATERAL_REP, BICEPS_ROSCAROLDANA_REP, 
						BICEPS_ROSCASIMULTANEA_REP, BICEPS_ROSCADIRETA_CARGA, BICEPS_ROSCAALTERNADA_CARGA, BICEPS_ROSCAMARTELO_CARGA, BICEPS_ROSCACONCENTRADA_CARGA, 
						BICEPS_ROSCAARTICULADA_CARGA, BICEPS_ROSCABILATERAL_CARGA, BICEPS_ROSCAROLDANA_CARGA, BICEPS_ROSCASIMULTANEA_CARGA, CHEST_SUPINORETO, 
						CHEST_SUPINOINCLINADO, CHEST_SUPINOSENTADO, CHEST_SUPINODUMBELL, CHEST_PECK, CHEST_PECKDECK, CHEST_CRUCIFIXO, CHEST_CROSSOVER, 
						CHEST_SUPINORETO_SERIE, CHEST_SUPINOINCLINADO_SERIE, CHEST_SUPINOSENTADO_SERIE, CHEST_SUPINODUMBELL_SERIE, CHEST_PECK_SERIE, 
						CHEST_PECKDECK_SERIE, CHEST_CRUCIFIXO_SERIE, CHEST_CROSSOVER_SERIE, CHEST_SUPINORETO_REP, CHEST_SUPINOINCLINADO_REP, CHEST_SUPINOSENTADO_REP, 
						CHEST_SUPINODUMBELL_REP, CHEST_PECK_REP, CHEST_PECKDECK_REP, CHEST_CRUCIFIXO_REP, CHEST_CROSSOVER_REP, CHEST_SUPINORETO_CARGA, 
						CHEST_SUPINOINCLINADO_CARGA, CHEST_SUPINOSENTADO_CARGA, CHEST_SUPINODUMBELL_CARGA, CHEST_PECK_CARGA, CHEST_PECKDECK_CARGA, 
						CHEST_CRUCIFIXO_CARGA, CHEST_CROSSOVER_CARGA, LEGS_CADEIRAEXTENSORA, LEGS_CADEIRAFLEXORA, LEGS_ADUTOR, LEGS_ABDUTOR, LEGS_LEGPRESS, 
						LEGS_AGACHAMENTOLIVRE, LEGS_HACK, LEGS_PANTURRILHA, LEGS_STIFF, LEGS_GLUTEO, LEGS_AVANCO, LEGS_CADEIRAEXTENSORA_SERIE, 
						LEGS_CADEIRAFLEXORA_SERIE, LEGS_ADUTOR_SERIE, LEGS_ABDUTOR_SERIE, LEGS_LEGPRESS_SERIE, LEGS_AGACHAMENTOLIVRE_SERIE, LEGS_HACK_SERIE, 
						LEGS_PANTURRILHA_SERIE, LEGS_STIFF_SERIE, LEGS_GLUTEO_SERIE, LEGS_AVANCO_SERIE, LEGS_CADEIRAEXTENSORA_REP, LEGS_CADEIRAFLEXORA_REP, 
						LEGS_ADUTOR_REP, LEGS_ABDUTOR_REP, LEGS_LEGPRESS_REP, LEGS_AGACHAMENTOLIVRE_REP, LEGS_HACK_REP, LEGS_PANTURRILHA_REP, LEGS_STIFF_REP, 
						LEGS_GLUTEO_REP, LEGS_AVANCO_REP, LEGS_CADEIRAEXTENSORA_CARGA, LEGS_CADEIRAFLEXORA_CARGA, LEGS_ADUTOR_CARGA, LEGS_ABDUTOR_CARGA, 
						LEGS_LEGPRESS_CARGA, LEGS_AGACHAMENTOLIVRE_CARGA, LEGS_HACK_CARGA, LEGS_PANTURRILHA_CARGA, LEGS_STIFF_CARGA, LEGS_GLUTEO_CARGA, 
						LEGS_AVANCO_CARGA, SHOULDERS_ELEVACAOLATERAL, SHOULDERS_ELEVACAOFRONTAL, SHOULDERS_ELEVACAOOMBRO, SHOULDERS_DEVCOSTAS, 
						SHOULDERS_DEVFRENTE, SHOULDERS_DEVDUMBELL, SHOULDERS_REMADAALTA, SHOULDERS_ELEVACAOLATERAL_SERIE, SHOULDERS_ELEVACAOFRONTAL_SERIE, 
						SHOULDERS_ELEVACAOOMBRO_SERIE, SHOULDERS_DEVCOSTAS_SERIE, SHOULDERS_DEVFRENTE_SERIE, SHOULDERS_DEVDUMBELL_SERIE, 
						SHOULDERS_REMADAALTA_SERIE, SHOULDERS_ELEVACAOLATERAL_REP, SHOULDERS_ELEVACAOFRONTAL_REP, SHOULDERS_ELEVACAOOMBRO_REP, 
						SHOULDERS_DEVCOSTAS_REP, SHOULDERS_DEVFRENTE_REP, SHOULDERS_DEVDUMBELL_REP, SHOULDERS_REMADAALTA_REP, SHOULDERS_ELEVACAOLATERAL_CARGA, 
						SHOULDERS_ELEVACAOFRONTAL_CARGA, SHOULDERS_ELEVACAOOMBRO_CARGA, SHOULDERS_DEVCOSTAS_CARGA, SHOULDERS_DEVFRENTE_CARGA, 
						SHOULDERS_DEVDUMBELL_CARGA, SHOULDERS_REMADAALTA_CARGA
					FROM WORKOUT 
					INNER JOIN ABS ON ABS_WORKOUT = WORKOUT_ID
					INNER JOIN BACK ON BACK_WORKOUT = WORKOUT_ID
					INNER JOIN BICEPS ON BICEPS_WORKOUT = WORKOUT_ID
					INNER JOIN CHEST ON CHEST_WORKOUT = WORKOUT_ID
					INNER JOIN LEGS ON LEGS_WORKOUT = WORKOUT_ID
					INNER JOIN SHOULDERS ON SHOULDERS_WORKOUT = WORKOUT_ID
					INNER JOIN TRICEPS ON TRICEPS_WORKOUT = WORKOUT_ID
					INNER JOIN WARMUP ON WARMUP_WORKOUT = WORKOUT_ID
					WHERE 
						WORKOUT_CLIENT =" + Client.CLIENT_ID + " and " +
							"WORKOUT_ID = (SELECT WORKOUT_ID FROM WORKOUT ORDER BY WORKOUT_ID DESC LIMIT 1)"
						;
			cmd.Connection = sql;
			SQLiteDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				#region Abs
				Abs.ABS_RETOABDOMEN = reader.GetValue(0).ToString();
				Abs.ABS_INFRA = reader.GetValue(1).ToString();
				Abs.ABS_OBLIQUO = reader.GetValue(2).ToString();
				Abs.ABS_PARALELAFIXA = reader.GetValue(3).ToString();
				Abs.ABS_PRANCHAABDOMEN = reader.GetValue(4).ToString();

				Abs.ABS_RETOABDOMEN_SERIE = Convert.ToInt32(reader.GetValue(5));
				Abs.ABS_INFRA_SERIE = Convert.ToInt32(reader.GetValue(6));
				Abs.ABS_OBLIQUO_SERIE = Convert.ToInt32(reader.GetValue(7));
				Abs.ABS_PARALELAFIXA_SERIE = Convert.ToInt32(reader.GetValue(8));
				Abs.ABS_PRANCHAABDOMEN_SERIE = Convert.ToInt32(reader.GetValue(9));

				Abs.ABS_RETOABDOMEN_REP = Convert.ToInt32(reader.GetValue(10));
				Abs.ABS_INFRA_REP = Convert.ToInt32(reader.GetValue(11));
				Abs.ABS_OBLIQUO_REP = Convert.ToInt32(reader.GetValue(12));
				Abs.ABS_PARALELAFIXA_REP = Convert.ToInt32(reader.GetValue(13));
				Abs.ABS_PRANCHAABDOMEN_REP = Convert.ToInt32(reader.GetValue(14));

				Abs.ABS_RETOABDOMEN_CARGA = Convert.ToInt32(reader.GetValue(15));
				Abs.ABS_INFRA_CARGA = Convert.ToInt32(reader.GetValue(16));
				Abs.ABS_OBLIQUO_CARGA = Convert.ToInt32(reader.GetValue(17));
				Abs.ABS_PARALELAFIXA_CARGA = Convert.ToInt32(reader.GetValue(18));
				Abs.ABS_PRANCHAABDOMEN_CARGA = Convert.ToInt32(reader.GetValue(19));
				#endregion
				#region Back
				Back.BACK_PULLEYCOSTAS = reader.GetValue(20).ToString();
				Back.BACK_PULLEYFRENTE = reader.GetValue(21).ToString();
				Back.BACK_PULLEYINVERTIDO = reader.GetValue(22).ToString();
				Back.BACK_REMADAHORIZONTAL = reader.GetValue(23).ToString();
				Back.BACK_REMADAALTERNADA = reader.GetValue(24).ToString();
				Back.BACK_REMADACAVALINHO = reader.GetValue(25).ToString();
				Back.BACK_PUXADORARTICULADO = reader.GetValue(26).ToString();
				Back.BACK_PECKDECK = reader.GetValue(27).ToString();
				Back.BACK_PULLOVER = reader.GetValue(28).ToString();
				Back.BACK_BARRAFIXA = reader.GetValue(29).ToString();
				Back.BACK_VOADORINVERSO = reader.GetValue(30).ToString();

				Back.BACK_PULLEYCOSTAS_SERIE = Convert.ToInt32(reader.GetValue(31));
				Back.BACK_PULLEYFRENTE_SERIE = Convert.ToInt32(reader.GetValue(32));
				Back.BACK_PULLEYINVERTIDO_SERIE = Convert.ToInt32(reader.GetValue(33));
				Back.BACK_REMADAHORIZONTAL_SERIE = Convert.ToInt32(reader.GetValue(34));
				Back.BACK_REMADAALTERNADA_SERIE = Convert.ToInt32(reader.GetValue(35));
				Back.BACK_REMADACAVALINHO_SERIE = Convert.ToInt32(reader.GetValue(36));
				Back.BACK_PUXADORARTICULADO_SERIE = Convert.ToInt32(reader.GetValue(37));
				Back.BACK_PECKDECK_SERIE = Convert.ToInt32(reader.GetValue(38));
				Back.BACK_PULLOVER_SERIE = Convert.ToInt32(reader.GetValue(39));
				Back.BACK_BARRAFIXA_SERIE = Convert.ToInt32(reader.GetValue(40));
				Back.BACK_VOADORINVERSO_SERIE = Convert.ToInt32(reader.GetValue(41));

				Back.BACK_PULLEYCOSTAS_REP = Convert.ToInt32(reader.GetValue(42));
				Back.BACK_PULLEYFRENTE_REP = Convert.ToInt32(reader.GetValue(43));
				Back.BACK_PULLEYINVERTIDO_REP = Convert.ToInt32(reader.GetValue(44));
				Back.BACK_REMADAHORIZONTAL_REP = Convert.ToInt32(reader.GetValue(45));
				Back.BACK_REMADAALTERNADA_REP = Convert.ToInt32(reader.GetValue(46));
				Back.BACK_REMADACAVALINHO_REP = Convert.ToInt32(reader.GetValue(47));
				Back.BACK_PUXADORARTICULADO_REP = Convert.ToInt32(reader.GetValue(48));
				Back.BACK_PECKDECK_REP = Convert.ToInt32(reader.GetValue(49));
				Back.BACK_PULLOVER_REP = Convert.ToInt32(reader.GetValue(50));
				Back.BACK_BARRAFIXA_REP = Convert.ToInt32(reader.GetValue(51));
				Back.BACK_VOADORINVERSO_REP = Convert.ToInt32(reader.GetValue(52));

				Back.BACK_PULLEYCOSTAS_CARGA = Convert.ToInt32(reader.GetValue(53));
				Back.BACK_PULLEYFRENTE_CARGA = Convert.ToInt32(reader.GetValue(54));
				Back.BACK_PULLEYINVERTIDO_CARGA = Convert.ToInt32(reader.GetValue(55));
				Back.BACK_REMADAHORIZONTAL_CARGA = Convert.ToInt32(reader.GetValue(56));
				Back.BACK_REMADAALTERNADA_CARGA = Convert.ToInt32(reader.GetValue(57));
				Back.BACK_REMADACAVALINHO_CARGA = Convert.ToInt32(reader.GetValue(58));
				Back.BACK_PUXADORARTICULADO_CARGA = Convert.ToInt32(reader.GetValue(59));
				Back.BACK_PECKDECK_CARGA = Convert.ToInt32(reader.GetValue(60));
				Back.BACK_PULLOVER_CARGA = Convert.ToInt32(reader.GetValue(61));
				Back.BACK_BARRAFIXA_CARGA = Convert.ToInt32(reader.GetValue(62));
				Back.BACK_VOADORINVERSO_CARGA = Convert.ToInt32(reader.GetValue(63));
				#endregion
				#region Biceps
				Biceps.BICEPS_ROSCADIRETA = reader.GetValue(64).ToString();
				Biceps.BICEPS_ROSCAALTERNADA = reader.GetValue(65).ToString();
				Biceps.BICEPS_ROSCAMARTELO = reader.GetValue(66).ToString();
				Biceps.BICEPS_ROSCACONCENTRADA = reader.GetValue(67).ToString();
				Biceps.BICEPS_ROSCAARTICULADA = reader.GetValue(68).ToString();
				Biceps.BICEPS_ROSCABILATERAL = reader.GetValue(69).ToString();
				Biceps.BICEPS_ROSCAROLDANA = reader.GetValue(70).ToString();
				Biceps.BICEPS_ROSCASIMULTANEA = reader.GetValue(71).ToString();

				Biceps.BICEPS_ROSCADIRETA_SERIE = Convert.ToInt32(reader.GetValue(72));
				Biceps.BICEPS_ROSCAALTERNADA_SERIE = Convert.ToInt32(reader.GetValue(73));
				Biceps.BICEPS_ROSCAMARTELO_SERIE = Convert.ToInt32(reader.GetValue(74));
				Biceps.BICEPS_ROSCACONCENTRADA_SERIE = Convert.ToInt32(reader.GetValue(75));
				Biceps.BICEPS_ROSCAARTICULADA_SERIE = Convert.ToInt32(reader.GetValue(76));
				Biceps.BICEPS_ROSCABILATERAL_SERIE = Convert.ToInt32(reader.GetValue(77));
				Biceps.BICEPS_ROSCAROLDANA_SERIE = Convert.ToInt32(reader.GetValue(78));
				Biceps.BICEPS_ROSCASIMULTANEA_SERIE = Convert.ToInt32(reader.GetValue(79));

				Biceps.BICEPS_ROSCADIRETA_REP = Convert.ToInt32(reader.GetValue(80));
				Biceps.BICEPS_ROSCAALTERNADA_REP = Convert.ToInt32(reader.GetValue(81));
				Biceps.BICEPS_ROSCAMARTELO_REP = Convert.ToInt32(reader.GetValue(82));
				Biceps.BICEPS_ROSCACONCENTRADA_REP = Convert.ToInt32(reader.GetValue(83));
				Biceps.BICEPS_ROSCAARTICULADA_REP = Convert.ToInt32(reader.GetValue(84));
				Biceps.BICEPS_ROSCABILATERAL_REP = Convert.ToInt32(reader.GetValue(85));
				Biceps.BICEPS_ROSCAROLDANA_REP = Convert.ToInt32(reader.GetValue(86));
				Biceps.BICEPS_ROSCASIMULTANEA_REP = Convert.ToInt32(reader.GetValue(87));

				Biceps.BICEPS_ROSCADIRETA_CARGA = Convert.ToInt32(reader.GetValue(88));
				Biceps.BICEPS_ROSCAALTERNADA_CARGA = Convert.ToInt32(reader.GetValue(89));
				Biceps.BICEPS_ROSCAMARTELO_CARGA = Convert.ToInt32(reader.GetValue(90));
				Biceps.BICEPS_ROSCACONCENTRADA_CARGA = Convert.ToInt32(reader.GetValue(91));
				Biceps.BICEPS_ROSCAARTICULADA_CARGA = Convert.ToInt32(reader.GetValue(92));
				Biceps.BICEPS_ROSCABILATERAL_CARGA = Convert.ToInt32(reader.GetValue(93));
				Biceps.BICEPS_ROSCAROLDANA_CARGA = Convert.ToInt32(reader.GetValue(94));
				Biceps.BICEPS_ROSCASIMULTANEA_CARGA = Convert.ToInt32(reader.GetValue(95));
				#endregion
				#region Chest
				Chest.CHEST_SUPINORETO = reader.GetValue(96).ToString();
				Chest.CHEST_SUPINOINCLINADO = reader.GetValue(97).ToString();
				Chest.CHEST_SUPINOSENTADO = reader.GetValue(98).ToString();
				Chest.CHEST_SUPINODUMBELL = reader.GetValue(99).ToString();
				Chest.CHEST_PECK = reader.GetValue(100).ToString();
				Chest.CHEST_PECKDECK = reader.GetValue(101).ToString();
				Chest.CHEST_CRUCIFIXO = reader.GetValue(102).ToString();
				Chest.CHEST_CROSSOVER = reader.GetValue(103).ToString();

				Chest.CHEST_SUPINORETO_SERIE = Convert.ToInt32(reader.GetValue(104));
				Chest.CHEST_SUPINOINCLINADO_SERIE = Convert.ToInt32(reader.GetValue(105));
				Chest.CHEST_SUPINOSENTADO_SERIE = Convert.ToInt32(reader.GetValue(106));
				Chest.CHEST_SUPINODUMBELL_SERIE = Convert.ToInt32(reader.GetValue(107));
				Chest.CHEST_PECK_SERIE = Convert.ToInt32(reader.GetValue(108));
				Chest.CHEST_PECKDECK_SERIE = Convert.ToInt32(reader.GetValue(109));
				Chest.CHEST_CRUCIFIXO_SERIE = Convert.ToInt32(reader.GetValue(110));
				Chest.CHEST_CROSSOVER_SERIE = Convert.ToInt32(reader.GetValue(111));

				Chest.CHEST_SUPINORETO_REP = Convert.ToInt32(reader.GetValue(112));
				Chest.CHEST_SUPINOINCLINADO_REP = Convert.ToInt32(reader.GetValue(113));
				Chest.CHEST_SUPINOSENTADO_REP = Convert.ToInt32(reader.GetValue(114));
				Chest.CHEST_SUPINODUMBELL_REP = Convert.ToInt32(reader.GetValue(115));
				Chest.CHEST_PECK_REP = Convert.ToInt32(reader.GetValue(116));
				Chest.CHEST_PECKDECK_REP = Convert.ToInt32(reader.GetValue(117));
				Chest.CHEST_CRUCIFIXO_REP = Convert.ToInt32(reader.GetValue(118));
				Chest.CHEST_CROSSOVER_REP = Convert.ToInt32(reader.GetValue(119));

				Chest.CHEST_SUPINORETO_CARGA = Convert.ToInt32(reader.GetValue(120));
				Chest.CHEST_SUPINOINCLINADO_CARGA = Convert.ToInt32(reader.GetValue(121));
				Chest.CHEST_SUPINOSENTADO_CARGA = Convert.ToInt32(reader.GetValue(122));
				Chest.CHEST_SUPINODUMBELL_CARGA = Convert.ToInt32(reader.GetValue(123));
				Chest.CHEST_PECK_CARGA = Convert.ToInt32(reader.GetValue(124));
				Chest.CHEST_PECKDECK_CARGA = Convert.ToInt32(reader.GetValue(125));
				Chest.CHEST_CRUCIFIXO_CARGA = Convert.ToInt32(reader.GetValue(126));
				Chest.CHEST_CROSSOVER_CARGA = Convert.ToInt32(reader.GetValue(127));
				#endregion
				#region Legs
				Legs.LEGS_CADEIRAEXTENSORA = reader.GetValue(128).ToString();
				Legs.LEGS_CADEIRAFLEXORA = reader.GetValue(129).ToString();
				Legs.LEGS_ADUTOR = reader.GetValue(130).ToString();
				Legs.LEGS_ABDUTOR = reader.GetValue(131).ToString();
				Legs.LEGS_LEGPRESS = reader.GetValue(132).ToString();
				Legs.LEGS_AGACHAMENTOLIVRE = reader.GetValue(133).ToString();
				Legs.LEGS_HACK = reader.GetValue(134).ToString();
				Legs.LEGS_PANTURRILHA = reader.GetValue(135).ToString();
				Legs.LEGS_STIFF = reader.GetValue(136).ToString();
				Legs.LEGS_GLUTEO = reader.GetValue(137).ToString();
				Legs.LEGS_AVANCO = reader.GetValue(138).ToString();

				Legs.LEGS_CADEIRAEXTENSORA_SERIE = Convert.ToInt32(reader.GetValue(139));
				Legs.LEGS_CADEIRAFLEXORA_SERIE = Convert.ToInt32(reader.GetValue(140));
				Legs.LEGS_ADUTOR_SERIE = Convert.ToInt32(reader.GetValue(141));
				Legs.LEGS_ABDUTOR_SERIE = Convert.ToInt32(reader.GetValue(142));
				Legs.LEGS_LEGPRESS_SERIE = Convert.ToInt32(reader.GetValue(143));
				Legs.LEGS_AGACHAMENTOLIVRE_SERIE = Convert.ToInt32(reader.GetValue(144));
				Legs.LEGS_HACK_SERIE = Convert.ToInt32(reader.GetValue(145));
				Legs.LEGS_PANTURRILHA_SERIE = Convert.ToInt32(reader.GetValue(146));
				Legs.LEGS_STIFF_SERIE = Convert.ToInt32(reader.GetValue(147));
				Legs.LEGS_GLUTEO_SERIE = Convert.ToInt32(reader.GetValue(148));
				Legs.LEGS_AVANCO_SERIE = Convert.ToInt32(reader.GetValue(149));

				Legs.LEGS_CADEIRAEXTENSORA_REP = Convert.ToInt32(reader.GetValue(150));
				Legs.LEGS_CADEIRAFLEXORA_REP = Convert.ToInt32(reader.GetValue(151));
				Legs.LEGS_ADUTOR_REP = Convert.ToInt32(reader.GetValue(152));
				Legs.LEGS_ABDUTOR_REP = Convert.ToInt32(reader.GetValue(153));
				Legs.LEGS_LEGPRESS_REP = Convert.ToInt32(reader.GetValue(154));
				Legs.LEGS_AGACHAMENTOLIVRE_REP = Convert.ToInt32(reader.GetValue(155));
				Legs.LEGS_HACK_REP = Convert.ToInt32(reader.GetValue(156));
				Legs.LEGS_PANTURRILHA_REP = Convert.ToInt32(reader.GetValue(157));
				Legs.LEGS_STIFF_REP = Convert.ToInt32(reader.GetValue(158));
				Legs.LEGS_GLUTEO_REP = Convert.ToInt32(reader.GetValue(159));
				Legs.LEGS_AVANCO_REP = Convert.ToInt32(reader.GetValue(160));

				Legs.LEGS_CADEIRAEXTENSORA_CARGA = Convert.ToInt32(reader.GetValue(161));
				Legs.LEGS_CADEIRAFLEXORA_CARGA = Convert.ToInt32(reader.GetValue(162));
				Legs.LEGS_ADUTOR_CARGA = Convert.ToInt32(reader.GetValue(163));
				Legs.LEGS_ABDUTOR_CARGA = Convert.ToInt32(reader.GetValue(164));
				Legs.LEGS_LEGPRESS_CARGA = Convert.ToInt32(reader.GetValue(165));
				Legs.LEGS_AGACHAMENTOLIVRE_CARGA = Convert.ToInt32(reader.GetValue(166));
				Legs.LEGS_HACK_CARGA = Convert.ToInt32(reader.GetValue(167));
				Legs.LEGS_PANTURRILHA_CARGA = Convert.ToInt32(reader.GetValue(168));
				Legs.LEGS_STIFF_CARGA = Convert.ToInt32(reader.GetValue(169));
				Legs.LEGS_GLUTEO_CARGA = Convert.ToInt32(reader.GetValue(170));
				Legs.LEGS_AVANCO_CARGA = Convert.ToInt32(reader.GetValue(171));
				#endregion
				#region Shoulders
				Shoulders.SHOULDERS_ELEVACAOLATERAL = reader.GetValue(172).ToString();
				Shoulders.SHOULDERS_ELEVACAOFRONTAL = reader.GetValue(173).ToString();
				Shoulders.SHOULDERS_ELEVACAOOMBRO = reader.GetValue(174).ToString();
				Shoulders.SHOULDERS_DEVCOSTAS = reader.GetValue(175).ToString();
				Shoulders.SHOULDERS_DEVFRENTE = reader.GetValue(176).ToString();
				Shoulders.SHOULDERS_DEVDUMBELL = reader.GetValue(177).ToString();
				Shoulders.SHOULDERS_REMADAALTA = reader.GetValue(178).ToString();

				Shoulders.SHOULDERS_ELEVACAOLATERAL_SERIE = Convert.ToInt32(reader.GetValue(179));
				Shoulders.SHOULDERS_ELEVACAOFRONTAL_SERIE = Convert.ToInt32(reader.GetValue(180));
				Shoulders.SHOULDERS_ELEVACAOOMBRO_SERIE = Convert.ToInt32(reader.GetValue(181));
				Shoulders.SHOULDERS_DEVCOSTAS_SERIE = Convert.ToInt32(reader.GetValue(182));
				Shoulders.SHOULDERS_DEVFRENTE_SERIE = Convert.ToInt32(reader.GetValue(183));
				Shoulders.SHOULDERS_DEVDUMBELL_SERIE = Convert.ToInt32(reader.GetValue(184));
				Shoulders.SHOULDERS_REMADAALTA_SERIE = Convert.ToInt32(reader.GetValue(185));

				Shoulders.SHOULDERS_ELEVACAOLATERAL_REP = Convert.ToInt32(reader.GetValue(186));
				Shoulders.SHOULDERS_ELEVACAOFRONTAL_REP = Convert.ToInt32(reader.GetValue(187));
				Shoulders.SHOULDERS_ELEVACAOOMBRO_REP = Convert.ToInt32(reader.GetValue(188));
				Shoulders.SHOULDERS_DEVCOSTAS_REP = Convert.ToInt32(reader.GetValue(189));
				Shoulders.SHOULDERS_DEVFRENTE_REP = Convert.ToInt32(reader.GetValue(190));
				Shoulders.SHOULDERS_DEVDUMBELL_REP = Convert.ToInt32(reader.GetValue(191));
				Shoulders.SHOULDERS_REMADAALTA_REP = Convert.ToInt32(reader.GetValue(192));

				Shoulders.SHOULDERS_ELEVACAOLATERAL_CARGA = Convert.ToInt32(reader.GetValue(193));
				Shoulders.SHOULDERS_ELEVACAOFRONTAL_CARGA = Convert.ToInt32(reader.GetValue(194));
				Shoulders.SHOULDERS_ELEVACAOOMBRO_CARGA = Convert.ToInt32(reader.GetValue(195));
				Shoulders.SHOULDERS_DEVCOSTAS_CARGA = Convert.ToInt32(reader.GetValue(196));
				Shoulders.SHOULDERS_DEVFRENTE_CARGA = Convert.ToInt32(reader.GetValue(197));
				Shoulders.SHOULDERS_DEVDUMBELL_CARGA = Convert.ToInt32(reader.GetValue(198));
				Shoulders.SHOULDERS_REMADAALTA_CARGA = Convert.ToInt32(reader.GetValue(199));
				#endregion
				#region Triceps

				#endregion
				#region WarmUp

				#endregion
			}
		}
		#endregion
	}
}
