using AspNETasmxWS.Responses.Contracts;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AspNETasmxWS.Responses
{
    public class Response : IResponse {
        public List<object> ResponseList { get => ResponseList; set => ResponseList = value; }

        public void GetObjectData(SerializationInfo info, StreamingContext context){
            throw new System.NotImplementedException();
        }
    }
}