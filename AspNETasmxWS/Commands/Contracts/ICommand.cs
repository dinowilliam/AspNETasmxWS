using AspNETasmxWS.Entities;
using System;

namespace AspNETasmxWS.Commands.Contracts
{
    internal interface ICommand {

        Boolean Execute(Requisition requisition);

    }
}
