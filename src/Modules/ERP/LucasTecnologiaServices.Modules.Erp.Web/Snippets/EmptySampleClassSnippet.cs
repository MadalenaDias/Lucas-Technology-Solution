using LucasTecnologiaServices.Modules.Erp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Web.Snippets
{
	public object Evaluate(BaseErpPageModel pageModel)
	{
		try
		{
			if (pageModel == null)
				return "";

			return "Success DS boz";
		}
		catch (Exception ex)
		{
			return "Error: " + ex.Message;
		}
	}
}
