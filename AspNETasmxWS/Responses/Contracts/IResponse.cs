using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AspNETasmxWS.Responses.Contracts
{
    public interface IResponse : ISerializable {

        List<object> ResponseList { get; set; }

    }
}
