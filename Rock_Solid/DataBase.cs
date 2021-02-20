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
		public static void NewWorkout(WorkOut workout, Abs abs)
		{
			if (Client.CLIENT_ID.ToString() != "" || Client.CLIENT_ID != 0)
			{
				try
				{
					var vcon = ConnectionDB();
					var cmd = vcon.CreateCommand();

					cmd.CommandText = @"
					INSERT INTO WORKOUT 
						(WORKOUT_ID, WORKOUT_BICEPS, WORKOUT_TRICEPS, WORKOUT_SHOULDERS, WORKOUT_LEGS, WORKOUT_CHEST, WORKOUT_BACK, 
						WORKOUT_ABS, WORKOUT_WARMUP) 
					VALUES 
						(@ID, @BICEPS, @TRICEPS, @SHOULDERS, @LEGS, @CHEST, @BACK, @ABS, @WARMUP)
				";

					cmd.Parameters.AddWithValue("@ID", WorkOut.WORKOUT_ID);
					cmd.Parameters.AddWithValue("@BICEPS", WorkOut.WORKOUT_BICEPS);
					cmd.Parameters.AddWithValue("@TRICEPS", WorkOut.WORKOUT_TRICEPS);
					cmd.Parameters.AddWithValue("@SHOULDERS", WorkOut.WORKOUT_SHOULDERS);
					cmd.Parameters.AddWithValue("@LEGS", WorkOut.WORKOUT_LEGS);
					cmd.Parameters.AddWithValue("@CHEST", WorkOut.WORKOUT_CHEST);
					cmd.Parameters.AddWithValue("@BACK", WorkOut.WORKOUT_BACK);
					cmd.Parameters.AddWithValue("@ABS", Abs.ABS_ID);
					cmd.Parameters.AddWithValue("@WARMUP", WorkOut.WORKOUT_WARMUP);

					cmd.ExecuteNonQuery();

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
						@PRANCHAABDOMEN_CARGA, @ABS)
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

					cmd.Parameters.AddWithValue("@ABS", WorkOut.WORKOUT_ID);

					cmd.ExecuteNonQuery();

					MessageBox.Show("Dados Salvos Com Sucesso");
					vcon.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao Criar Treino");
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
					UPDATE WORKOUT 
					SET 
						WORKOUT_BICEPS '" + WorkOut.WORKOUT_BICEPS + "', " +
						"WORKOUT_TRICEPS '" + WorkOut.WORKOUT_TRICEPS + "', " +
						"WORKOUT_SHOULDERS '" + WorkOut.WORKOUT_SHOULDERS + "', " +
						"WORKOUT_LEGS '" + WorkOut.WORKOUT_LEGS + "', " +
						"WORKOUT_CHEST '" + WorkOut.WORKOUT_CHEST + "', " +
						"WORKOUT_BACK '" + WorkOut.WORKOUT_BACK + "', " +
						"WORKOUT_ABS '" + WorkOut.WORKOUT_ABS + "', " +
					"WHERE WORKOUT_ID = " + WorkOut.WORKOUT_ID
					;

					cmd.ExecuteNonQuery();
					MessageBox.Show("Alterações Salvas Com Sucesso");
					vcon.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao Alterar Treino");
					throw (ex);
				}
			}
		}
		#endregion
	}
}
