using System.Collections.Generic;

namespace AspNETasmxWS.Responses.Contracts {
    public interface IMediaInsert {

        bool HasBeingInserted { get; set; }
        int ProtocolNumber { get; set; }        
        List<IMessage> Messages { get; set; }
    }
}
