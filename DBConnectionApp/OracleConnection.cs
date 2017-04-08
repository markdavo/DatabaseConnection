using System;

namespace DBConnectionApp
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string cnt) : base(cnt)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle connection");
        }

        public override void Open()
        {
            Console.WriteLine("Opening Oracle connection");
        }
    }
}
