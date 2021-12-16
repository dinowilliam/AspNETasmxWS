using System.Collections.Generic;

namespace AspNETasmxWS.Responses.Contracts {
    public interface IMediaInsert {

        bool HasBeingInserted { get; set; }
        string Protocol { get; set; }        
        List<IMessage> Messages { get; set; }
    }
}
