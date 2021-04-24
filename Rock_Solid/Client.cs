using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Solid
{
	class Client
	{
		public static Int32 CLIENT_ID = 0;
		public static string CLIENT_NAME = "";
		public static string CLIENT_POSTCODE = "";
		public static string CLIENT_ADDRESS = "";
		public static string CLIENT_NUMBER = "";
		public static string CLIENT_NEIGHBORHOOD = "";
		public static string CLIENT_CITY = "";
		public static string CLIENT_STATE = "";
		public static string CLIENT_RG = "";
		public static string CLIENT_CPF = "";
		public static bool CLIENT_LEGAL = false;
		public static string CLIENT_EMAIL = "";
		public static string CLIENT_PHONE = "";
		public static string CLIENT_CEL = "";
		public static string CLIENT_PROFILEIMGPATH = Global.profilePicturePath + "Default Profile.png";
	
	public static void Clear()
	{
		CLIENT_ID = 0;
		CLIENT_NAME = "";
		CLIENT_POSTCODE = "";
		CLIENT_ADDRESS = "";
		CLIENT_NUMBER = "";
		CLIENT_NEIGHBORHOOD = "";
		CLIENT_CITY = "";
		CLIENT_STATE = "";
		CLIENT_RG = "";
		CLIENT_CPF = "";
		CLIENT_LEGAL = false;
		CLIENT_EMAIL = "";
		CLIENT_PHONE = "";
		CLIENT_CEL = "";
		CLIENT_PROFILEIMGPATH = Global.profilePicturePath + "Default Profile.png";
	}
	}
}
