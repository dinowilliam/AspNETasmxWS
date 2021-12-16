using System.Web.Services;

namespace AspNETasmxWS {

    using AspNETasmxWS.Commands;
    using AspNETasmxWS.Entities;
    using AspNETasmxWS.Responses;
    using AspNETasmxWS.Responses.Contracts;

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
        private MediaRetrieveCommand mediaRetrieveCommand;
        private MediaRemoveCommand mediaRemoveCommand;
        private UserLoginCommand userLoginCommand;

        public MediaWS() {

            mediaInsertCommand = new MediaInsertCommand();     
            mediaRetrieveCommand = new MediaRetrieveCommand();
            mediaRemoveCommand = new MediaRemoveCommand();
            userLoginCommand = new UserLoginCommand();
        }

        [WebMethod]
        public Response SaveMedia(User user, Requisition requisition) {

            Response response = new Response();
                       
            if (userLoginCommand.Execute(user)){
                response = (Response) mediaInsertCommand.Execute(requisition);
            }            

            return response;
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
