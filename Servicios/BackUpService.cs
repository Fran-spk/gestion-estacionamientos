using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Servicios
{
    public static class BackupService
    {
        private static readonly string BackupPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "backup", "backup.bak"
        );

        public static void GenerarBackup(string connectionString)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(BackupPath));

            using var connection = new SqlConnection(connectionString);
            connection.Open();

            string dbName = connection.Database;
            string query = $"BACKUP DATABASE [{dbName}] TO DISK = '{BackupPath}' WITH INIT, FORMAT";

            using var cmd = new SqlCommand(query, connection);
            cmd.CommandTimeout = 120;
            cmd.ExecuteNonQuery();
        }

        public static void RestaurarBackup(string connectionString)
        {
            if (!File.Exists(BackupPath))
                throw new FileNotFoundException("No existe un backup previo para restaurar.");


            var builder = new SqlConnectionStringBuilder(connectionString);
            string dbName = builder.InitialCatalog;
            builder.InitialCatalog = "master";

            using var connection = new SqlConnection(builder.ConnectionString);
            connection.Open();

            // Cerrar conexiones activas antes de restaurar
            string killQuery = $@"
            ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
            RESTORE DATABASE [{dbName}] FROM DISK = '{BackupPath}' WITH REPLACE;
            ALTER DATABASE [{dbName}] SET MULTI_USER;";

            using var cmd = new SqlCommand(killQuery, connection);
            cmd.CommandTimeout = 120;
            cmd.ExecuteNonQuery();
        }

        public static bool ExisteBackup() => File.Exists(BackupPath);

        public static DateTime? FechaUltimoBackup() =>
            ExisteBackup() ? File.GetLastWriteTime(BackupPath) : null;
    }
}
