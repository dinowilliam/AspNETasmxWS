using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNETasmxWS.Entities.Contracts {
    interface IRequisition {

        int Number { get; set; }
        DateTime Date { get; set; }
        List<IMedia> medias { get; set; }

    }
}
