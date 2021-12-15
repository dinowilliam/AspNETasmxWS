using AspNETasmxWS.Responses.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNETasmxWS.Responses {
    public class MediaInsert : IMediaInsert {
        public bool HasBeingInserted { get => HasBeingInserted; set => HasBeingInserted = value; }
        public int ProtocolNumber { get => ProtocolNumber; set => ProtocolNumber = value; }
        public List<IMessage> Messages { get => Messages; set => Messages = value; }
    }
}