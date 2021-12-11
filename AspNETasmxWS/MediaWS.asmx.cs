using AspNETasmxWS.Entities;
using System.Web.Services;

namespace AspNETasmxWS {

    /// <summary>
    /// Summary description for We
    /// </summary>
    /// 
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class MediaWS : WebService    {

        [WebMethod]
        public string SaveMedia(User user, Requisition requisition) {

            return "Hello World";
        }


        [WebMethod]
        public string GetMedia(User user, Media media) {

            return "Hello World";
        }

        [WebMethod]
        public string DeleteMedia(User user, Media media) {

            return "Hello World";
        }
    }
}
