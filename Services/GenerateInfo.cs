using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03PDMI.Services
{
    public static class GenerateInfo
    {
        public static string GenerateGuid() => Guid.NewGuid().ToString("N").Substring(0, 16);
    }
}
