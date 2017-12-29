using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;

namespace OT.RentCoder.Business
{
    partial class RentCoderEntities : DbContext, IDisposeTracker
    {
        public bool IsDisposed { get; set; }

        protected override void Dispose(bool disposing)
        {
            IsDisposed = true;
            base.Dispose(disposing);
        }

        public void OnContextCreated()
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public bool SaveBulkChanges(string destinationTableName, DataTable sourceTable, bool fireTriggers = true)
        {
            try
            {
                SqlBulkCopyOptions _bulkCopyOptions = fireTriggers ? SqlBulkCopyOptions.FireTriggers : SqlBulkCopyOptions.Default;

                var connection = base.Database.Connection.ConnectionString;

                SqlBulkCopy bulkCopy = new SqlBulkCopy(connection, _bulkCopyOptions);
                bulkCopy.DestinationTableName = destinationTableName;
                bulkCopy.WriteToServer(sourceTable);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
