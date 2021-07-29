using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp
{
	public interface IErpService
	{
		List<ErpPlugin> Plugins { get; set; }

		void InitializeSystemEntities();
		void InitializeBackgroundJobs(List<JobType> additionalJobTypes = null);
		void StartBackgroundJobProcess();
		void InitializePlugins(IServiceProvider app);
		void SetAutoMapperConfiguration();
	}
}
