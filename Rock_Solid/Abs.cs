using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Solid
{
	class Abs
	{
		public static Int32 ABS_ID = 0;

		public static string ABS_RETOABDOMEN = "";
		public static string ABS_INFRA = "";
		public static string ABS_OBLIQUO = "";
		public static string ABS_PARALELAFIXA = "";
		public static string ABS_PRANCHAABDOMEN = "";

		public static Int32 ABS_RETOABDOMEN_SERIE = 0;
		public static Int32 ABS_INFRA_SERIE = 0;
		public static Int32 ABS_OBLIQUO_SERIE = 0;
		public static Int32 ABS_PARALELAFIXA_SERIE = 0;
		public static Int32 ABS_PRANCHAABDOMEN_SERIE = 0;

		public static Int32 ABS_RETOABDOMEN_REP = 0;
		public static Int32 ABS_INFRA_REP = 0;
		public static Int32 ABS_OBLIQUO_REP = 0;
		public static Int32 ABS_PARALELAFIXA_REP = 0;
		public static Int32 ABS_PRANCHAABDOMEN_REP = 0;

		public static Int32 ABS_RETOABDOMEN_CARGA = 0;
		public static Int32 ABS_INFRA_CARGA = 0;
		public static Int32 ABS_OBLIQUO_CARGA = 0;
		public static Int32 ABS_PARALELAFIXA_CARGA = 0;
		public static Int32 ABS_PRANCHAABDOMEN_CARGA = 0;

		public static Int32 ABS_WORKOUT = 0;

		public static void Clear()
		{
			ABS_RETOABDOMEN = "";
			ABS_INFRA = "";
			ABS_OBLIQUO = "";
			ABS_PARALELAFIXA = "";
			ABS_PRANCHAABDOMEN = "";

			ABS_RETOABDOMEN_SERIE = 0;
			ABS_INFRA_SERIE = 0;
			ABS_OBLIQUO_SERIE = 0;
			ABS_PARALELAFIXA_SERIE = 0;
			ABS_PRANCHAABDOMEN_SERIE = 0;

			ABS_RETOABDOMEN_REP = 0;
			ABS_INFRA_REP = 0;
			ABS_OBLIQUO_REP = 0;
			ABS_PARALELAFIXA_REP = 0;
			ABS_PRANCHAABDOMEN_REP = 0;

			ABS_RETOABDOMEN_CARGA = 0;
			ABS_INFRA_CARGA = 0;
			ABS_OBLIQUO_CARGA = 0;
			ABS_PARALELAFIXA_CARGA = 0;
			ABS_PRANCHAABDOMEN_CARGA = 0;
		}
	}
}
