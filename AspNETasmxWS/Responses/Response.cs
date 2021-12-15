using AspNETasmxWS.Responses.Contracts;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AspNETasmxWS.Responses
{
    public class Response : IResponse {

        public bool Processed { get => Processed; set => Processed = value; }
        public bool HasErrors { get => HasErrors; set => HasErrors = value; }
        public List<object> ResponseList { get => ResponseList; set => ResponseList = value; }
        
    }
}