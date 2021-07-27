using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models
{
    public enum QueryType
    {
        EQ,
        NOT,
        LT,
        LTE,
        GT,
        GTE,
        AND,
        OR,
        CONTAINS,
        STARTSWITH,
        REGEX,
        RELATED,
        NOTRELATED,
        FTS
    }
}
