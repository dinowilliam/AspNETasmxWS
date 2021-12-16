using AspNETasmxWS.Responses.Contracts;
using System;
using System.Collections.Generic;

namespace AspNETasmxWS.Responses
{
    public class Response : IResponse {

        public bool Processed { get; set; }
        public bool HasErrors { get; set; }
        public List<Object> ResponseList { get; set; }
        
    }
}