using AspNETasmxWS.Entities;
using System;

namespace AspNETasmxWS.Commands.Contracts
{
    internal interface IUserLoginCommand
    {

        bool Execute(User user);

    }
}
