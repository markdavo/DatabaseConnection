using System;

namespace DBConnectionApp
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string cnt) : base(cnt)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Closing SQL connection");
        }

        public override void Open()
        {
            Console.WriteLine("Opening SQL connection");
        }
    }
}
