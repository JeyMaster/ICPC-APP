using System;
using System.Collections.Generic;
using System.Text;


namespace Modelo
{
	public class Strings
	{
		public static String ADMIN = "admin@admin.com";
		public static String PASS = "admin";
		public static String validarCorreo = @"\A(\w+\.?\w*\@\w+\.)(com)\Z";
		public static String alfaNumerico = @"\A[\w]+\Z";
        public static String Nombres = @"\A[a-z ,.'-áéíóúA-Z]+\Z";
    }
}
