using AspNETasmxWS.Responses.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNETasmxWS.Responses {
    public class MediaInsert : IMediaInsert {
        public bool HasBeingInserted { get; set ; }
        public string Protocol { get; set; }
        public List<IMessage> Messages { get; set ; }
    }
}