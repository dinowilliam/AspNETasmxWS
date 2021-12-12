using AspNETasmxWS.Entities;
using System;

namespace AspNETasmxWS.Commands.Contracts {
    internal interface IMediaInsertCommand {

        bool Execute(Requisition requisition);

    }
}
