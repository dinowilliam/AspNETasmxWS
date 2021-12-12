using AspNETasmxWS.Commands.Contracts;
using AspNETasmxWS.Entities;

namespace AspNETasmxWS.Commands {
    public class MediaRemoveCommand : IMediaRemoveCommand {
        public MediaRemoveCommand()
        {
        }

        public bool Execute(Media media)
        {
            return false;
        }
    }
}