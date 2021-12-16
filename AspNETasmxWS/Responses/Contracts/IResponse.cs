using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AspNETasmxWS.Responses.Contracts
{
    public interface IResponse {

        bool Processed { get; set; }
        bool HasErrors { get; set; }
        List<Object> ResponseList { get; set; }

    }
}
