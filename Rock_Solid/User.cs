﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Solid
{
	class User
	{
		public static Int32 USER_ID = 0;
		public static string USER_NAME = "";
		public static string USER_USERNAME = "";
		public static string USER_PASSWORD = "";
		public static string USER_STATUS = "Ativo";
		public static Int32 USER_LEVEL = 0;

		public static void Clear()
		{
			USER_ID = 0;
			USER_NAME = "";
			USER_USERNAME = "";
			USER_PASSWORD = "";
			USER_STATUS = "Ativo";
			USER_LEVEL = 0;
		}
	}
}
