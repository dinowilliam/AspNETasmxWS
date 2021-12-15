using AspNETasmxWS.Responses.Contracts;

namespace AspNETasmxWS.Responses {
    public class Message : IMessage {

        public int Code { get => Code; set => Code = value; }
        public string Name { get => Name; set => Name = value; }
        public string Description { get => Description; set => Description = value; }

    }
}