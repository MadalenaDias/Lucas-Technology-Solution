using LucasTechnologyService.Infrastructure.Models;

namespace LucasTechnologyServices.Module.Audit.Models
{
    internal class LoggedAction : EntityBase
    {
        public long EventId { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string Relid { get; set; }
        public string SessionUserName { get; set; }
        public string ApplicationUserName { get; set; }
        public DateTime ActionTstampTx { get; set; }
        public DateTime ActionTstampStm { get; set; }
        public DateTime ActionTstampClk { get; set; }

        public long? TransactionId { get; set; }

        public string ApplicationName { get; set; }

        public string ClientAddr { get; set; }

        public int? ClientPort { get; set; }

        public string ClientQuery { get; set; }

        public string Action { get; set; }

        public string RowData { get; set; }


        public string ChangedFields { get; set; }

        public bool StatementOnly { get; set; }
    }
}
