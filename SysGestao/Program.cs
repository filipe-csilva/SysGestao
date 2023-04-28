using Microsoft.Data.SqlClient;
using SysGestao.SystemScreens.PrimaryScreens;

namespace SysGestao
{
    class Program
    {

        const string connectionString = "Server=localhost; Database=dbSysGestao; User ID=sa; Password=leason20; TrustServerCertificate=True";

        static void Main(string[] args)
        {
            DataBase.Connection = new SqlConnection(connectionString);
            DataBase.Connection.Open();

            //MenuPrincipal.Load();
            LoginScreen.Load();

            DataBase.Connection.Close();
            Console.ReadKey();
        }
    }
}