using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Solid
{
	class Global
	{
		public static string Version = "1.0";
		public static Boolean logged = false;
		public static int level = 0;

		public static string path = System.Environment.CurrentDirectory;
		public static string dbName = "RockSolid.db";
		public static string dbPath = path+@"\DataBase\";

		public static string profilePicturePath = path + @"\Images\Profile\";
		public static string productPicturePath = path + @"\Images\Product\";
		public static string equipmentPicturePath = path + @"\Images\Equipment\";
		//Variáveis de Usuário
		//public static int userID = 0;
		//public static string userName = "";
		//public static string userUsername = "";
		//public static string userPassword = "";
		//public static string userStatus = "Ativo";
		//public static int userLevel = 0;
	}
}
