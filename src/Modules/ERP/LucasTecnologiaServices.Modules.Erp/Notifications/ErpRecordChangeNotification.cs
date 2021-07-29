using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Notifications
{
	public class ErpRecordChangeNotification
	{
		public Guid EntityId { get; set; }
		public string EntityName { get; set; }
		public Guid RecordId { get; set; }
	}
}
