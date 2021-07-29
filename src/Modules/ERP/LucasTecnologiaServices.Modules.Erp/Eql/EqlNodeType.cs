using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Eql
{
	internal enum EqlNodeType
	{
		Keyword,
		NumberValue,
		TextValue,
		ArgumentValue,
		Select,
		Field,
		RelationField,
		RelationWildcardField,
		WildcardField,
		From,
		Where,
		BinaryExpression,
		OrderBy,
		OrderByField,
		Page,
		PageSize,
	}
}
