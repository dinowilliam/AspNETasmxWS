using System.Web.Services;

namespace AspNETasmxWS {

    using AspNETasmxWS.Commands;
    using AspNETasmxWS.Entities;

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

        private MediaInsertCommand mediaInsertCommand;
        private UserLoginCommand userLoginCommand;

        public MediaWS() {

            mediaInsertCommand = new MediaInsertCommand();
            userLoginCommand = new UserLoginCommand();
        }

        [WebMethod]
        public string SaveMedia(User user, Requisition requisition) {
            
            bool returnedValue = false;

            if (userLoginCommand.Execute(user)){
                returnedValue = mediaInsertCommand.Execute(requisition);
            }

            return returnedValue.ToString();
        }


        [WebMethod]
        public string GetMedia(User user, Media media) {

            bool returnedValue = false;

            if (userLoginCommand.Execute(user)){
                
            }

            return returnedValue.ToString();
        }

        [WebMethod]
        public string DeleteMedia(User user, Media media) {

            bool returnedValue = false;

            if (userLoginCommand.Execute(user)){

            }

            return returnedValue.ToString();

        }
    }
}
