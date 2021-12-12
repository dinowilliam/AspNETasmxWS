using AspNETasmxWS.Entities;
using System;

namespace AspNETasmxWS.Commands.Contracts {
    public interface IMediaRetrieveCommand {

        bool Execute(Media media);

    }
}
