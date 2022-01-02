using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Core.Services.Interfaces
{
    public interface IPdfConverter
    {
        byte[] Convert(string htmlContent);
    }
}
