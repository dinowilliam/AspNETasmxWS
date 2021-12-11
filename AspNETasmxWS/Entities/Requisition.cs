
using System.Collections.Generic;

namespace AspNETasmxWS.Entities {
    public class Requisition {

        public int Number { get => Number; set => Number = value; }
        public List<Media> Medias { get => Medias; set => Medias = value; }

    }
}