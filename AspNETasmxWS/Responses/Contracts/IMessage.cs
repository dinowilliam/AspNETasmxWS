using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNETasmxWS.Responses.Contracts
{
    public interface IMessage {
        int Code { get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }
}
