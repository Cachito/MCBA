using Polly;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Mcba.Data
{
    public class DataAccess
    {
        private readonly string connectionString;

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IDbConnection GetOpenConnection()
        {
            var db = new SqlConnection(connectionString);

            var retryPolicy = Policy
                .Handle<InvalidOperationException>()
                .Or<SqlException>()
                .Retry(1);

            retryPolicy.Execute(() => { db.Open(); });

            return db;
        }
    }
}