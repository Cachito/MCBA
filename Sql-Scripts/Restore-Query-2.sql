            ALTER DATABASE [Mcba]
                SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
            --GO

            -- at this point all the users will be disconnected and the database is in 
            -- single-user mode

            USE [Mcba]  --<-- Grab that single connection 
            --GO

            USE [master]        --<-- Disconnect from database and connect to Master DB for restore
            --GO

            RESTORE DATABASE [Mcba]  --<-- Finally restore database tara
                FROM DISK = 'C:\TMP\Backups\MCBA-Backup-20211108071234.699.bak'
            --GO