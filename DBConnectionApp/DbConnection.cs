using System;

namespace DBConnectionApp
{
    public abstract class DbConnection
    {
        private string connectionString { get; set; }
        public DateTime Timeout { get; set; }

        //Getter and Setters
        public string GetConnectionString()
        {
            return connectionString;
        }

        private void SetConnectionString(string value)
        {
            connectionString = value;
        }

        //Constructor that must have a name for the connection
        public DbConnection(string cnt)
        {
            if (String.IsNullOrWhiteSpace(cnt))
            {
                throw new NullReferenceException("The connect must have a name"); 
            } else
            {
                SetConnectionString(cnt);
                Timeout = DateTime.Now; 
            }    
        }
        //Abstract method that is  call from derived classes. 
        public abstract void Open();
        public abstract void Close();
    }
}
