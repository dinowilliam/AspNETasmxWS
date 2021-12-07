using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNETasmxWS.Entities.Contracts {
    public interface IMedia {

        string Name { get; set; }
        string Description { get; set; }
        string Extension { get; set; }
        string File { get; set; }

    }
}
