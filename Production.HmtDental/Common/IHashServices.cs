using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Production.HmtDental.Common
{
    public interface IHashServices
    {
        public string ComputeSha256Hash(string rawData);

        public string ConvertMd5(string code);
    }
}
