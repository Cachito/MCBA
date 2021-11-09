using Mcba.Dal;
using Mcba.Infraestruture.Settings;

namespace Mcba.Bll
{
    public class BackupBll
    {
        public void Backup(string filePath)
        {
            var backupDal = new BackupDal(McbaSettings.CnnString);
            backupDal.Backup(filePath);
        }

        public void Restore(string filePath)
        {
            var backupDal = new BackupDal(McbaSettings.MasterCnnString);
            backupDal.Restore(filePath);
        }
    }
}