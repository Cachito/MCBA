using Dapper;
using Mcba.Data;

namespace Mcba.Dal
{
    public class BackupDal
    {
        private const string QRY_BACKUP = @"
            BACKUP DATABASE Mcba TO DISK = '{0}'
            ";

        private readonly string connectionString;

        public BackupDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Backup(string filePath)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                db.Execute(string.Format(QRY_BACKUP, filePath));
            }
        }
    }
}
