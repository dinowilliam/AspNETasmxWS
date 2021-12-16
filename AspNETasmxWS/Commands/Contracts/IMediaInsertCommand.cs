using AspNETasmxWS.Entities;
using AspNETasmxWS.Responses.Contracts;
using System;

namespace AspNETasmxWS.Commands.Contracts {
    internal interface IMediaInsertCommand {

        IResponse Execute(Requisition requisition);

    }
}
