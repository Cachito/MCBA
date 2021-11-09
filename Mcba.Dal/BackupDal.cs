using System.Data;
using Dapper;
using Mcba.Data;

namespace Mcba.Dal
{
    public class BackupDal
    {
        private const string QRY_BACKUP = @"
            BACKUP DATABASE Mcba TO DISK = '{0}'
            ";

        private const string QRY_RESTORE = @"
            ALTER DATABASE [Mcba]
                SET SINGLE_USER WITH ROLLBACK IMMEDIATE

            USE [Mcba]
            
            USE [master]
            
            RESTORE DATABASE [Mcba]
                FROM DISK = '{0}'
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

        public void Restore(string filePath)
        {
            using (var db = new DataAccess(connectionString).GetOpenConnection())
            {
                db.Execute(string.Format(QRY_RESTORE, filePath), commandType: CommandType.Text);
            }
        }
    }
}
