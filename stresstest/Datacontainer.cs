using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace stresstest
{
    class Datacontainer
    {
        public static string connectionString;
        public static string anvandarnamn;
        public static string losen;
        public static string connectsource;
        public static string connectstring;
        public static SqlConnection cnn;
        public static SqlCommand command;
        public static SqlDataReader dataReader;
        public static string personnummer;
        public static string Familyname;
        public static string fornamn;
        public static int personnummerindex;
        //  public Form1 f1 = new Form1();
        // public Form2 f2 = new Form2();
    }
}
