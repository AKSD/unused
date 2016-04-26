using System;

namespace OpcX
{
    /// <summary>
    /// Node of type: database.
    /// </summary>
    public class NodeDB : Node
    {
        /// <summary>
        /// Gets the server address.
        /// </summary>
        /// <value>The server address.</value>
        public string Server { get; private set; }

        /// <summary>
        /// Gets the table name.
        /// </summary>
        /// <value>The table name.</value>
        public string Table { get; private set; }

        /// <summary>
        /// Gets the type of the database.
        /// </summary>
        /// <value>The type of the database.</value>
        public DBType DatabaseType { get; private set; }

        /// <summary>
        /// The user identifier.
        /// </summary>
        private string UserId = string.Empty;

        /// <summary>
        /// The password.
        /// </summary>
        private string Password = string.Empty;

        /// <summary>
        /// The connection string.
        /// </summary>
        private string ConnectionString = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpcX.NodeDB"/> class.
        /// </summary>
        public NodeDB()
        {
            DefaultSets();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpcX.NodeDB"/> class.
        /// </summary>
        /// <param name="server">Server address.</param>
        /// <param name="table">Table name.</param>
        /// <param name="user">User.</param>
        /// <param name="passwd">Password.</param>
        public NodeDB(string server, string table, string user, string passwd)
        {
            this.Server = server;
            this.Table = table;
            this.UserId = user;
            this.Password = passwd;

            this.ConnectionString = GenerateConnectionString();
        }

        /// <summary>
        /// Defaults the sets.
        /// </summary>
        public void DefaultSets()
        {
            this.DatabaseType = DBType.MySQL;
            this.Server = @"http://mysql.agh.edu.pl";
            this.Table = @"temperature";
            this.UserId = @"adziedzi";
            this.Password = @"8SZniXcf";

            this.ConnectionString = GenerateConnectionString();
        }

        /// <summary>
        /// Generates the connection string.
        /// TODO: Add other databases
        /// </summary>
        /// <returns>The connection string.</returns>
        private string GenerateConnectionString()
        {
            string connStr = string.Empty;

            switch (this.DatabaseType)
            {
                case DBType.MySQL:
                    connStr = string.Format(@"Server={0};Database={1};User ID={2};Password={3};",
                        this.Server,
                        this.Table,
                        this.UserId,
                        this.Password);
                    break;

                default:
                    break;
            }

            return connStr;
        }
    }
}

