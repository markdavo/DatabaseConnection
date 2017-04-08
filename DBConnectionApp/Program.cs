using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlconnection = new SqlConnection("Go");
            sqlconnection.Open();
            sqlconnection.Close();

            OracleConnection oracleConnection = new OracleConnection("Start");
            oracleConnection.Open();
            oracleConnection.Close(); 

        }
    }
}
