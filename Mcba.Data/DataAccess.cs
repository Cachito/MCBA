using Polly;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Mcba.Data
{
    public abstract class DataAccess
    {
        private readonly string connectionString;

        protected DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected IDbConnection GetOpenConnection()
        {
            var db = new SqlConnection(connectionString);

            var retryPolicy = Policy
                .Handle<InvalidOperationException>()
                .Or<SqlException>()
                .Retry(3);

            retryPolicy.Execute(() =>
            {
                db.Open();
            });

            return db;
        }
    }
}
