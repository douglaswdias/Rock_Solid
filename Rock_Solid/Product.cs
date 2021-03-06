﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Solid
{
	class Product
	{
		public static Int32 PRODUCT_ID = 0;
		public static string PRODUCT_NAME = "";
		public static string PRODUCT_DESCRIPTION = "";
		public static Int32 PRODUCT_BARCODE = 0;
		public static string PRODUCT_TYPE = "";
		public static string PRODUCT_SIZE = "";
		public static string PRODUCT_COLOR = "";
		public static double PRODUCT_WEIGHT = 0;
		public static string PRODUCT_STOCK = "";
		public static double PRODUCT_PURCHASEPRICE = 0;
		public static double PRODUCT_MARKUPPRICE = 0;
		public static double PRODUCT_SELLINGPRICE = 0;
		public static DateTime PRODUCT_LASTPURCHASE;
		public static Int32 PRODUCT_PROVIDERID = 0;
		public static string PRODUCT_IMAGE = "";
		public static DateTime PRODUCT_CREATEDAT;
		public static DateTime PRODUCT_UPDATEDAT;

		public static void Clear()
		{
			PRODUCT_ID = 0;
			PRODUCT_NAME = "";
			PRODUCT_DESCRIPTION = "";
			PRODUCT_BARCODE = 0;
			PRODUCT_TYPE = "";
			PRODUCT_SIZE = "";
			PRODUCT_COLOR = "";
			PRODUCT_WEIGHT = 0;
			PRODUCT_STOCK = "";
			PRODUCT_PURCHASEPRICE = 0;
			PRODUCT_MARKUPPRICE = 0;
			PRODUCT_SELLINGPRICE = 0;
			PRODUCT_LASTPURCHASE = new DateTime(1900, 1, 1);
			PRODUCT_PROVIDERID = 0;
			PRODUCT_IMAGE = "";
			PRODUCT_CREATEDAT = new DateTime(1900, 1, 1);
			PRODUCT_UPDATEDAT = new DateTime(1900, 1, 1);
		}
	}
}
