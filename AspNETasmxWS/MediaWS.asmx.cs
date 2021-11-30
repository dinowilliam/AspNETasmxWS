using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AspNETasmxWS {
    /// <summary>
    /// Summary description for DocWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MediaWS : System.Web.Services.WebService  {

        [WebMethod]
        public string SaveMedia()
        {
            return "Hello World";
        }


        [WebMethod]
        public string GetMedia()
        {
            return "Hello World";
        }

        [WebMethod]
        public string DeleteMedia()
        {
            return "Hello World";
        }
    }
}
