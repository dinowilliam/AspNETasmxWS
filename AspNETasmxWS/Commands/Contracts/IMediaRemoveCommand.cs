using AspNETasmxWS.Entities;
using System;

namespace AspNETasmxWS.Commands.Contracts {
    public interface IMediaRemoveCommand {

        bool Execute(Media media);

    }
}
