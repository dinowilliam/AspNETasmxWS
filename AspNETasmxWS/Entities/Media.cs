using AspNETasmxWS.Entities.Contracts;

namespace AspNETasmxWS.Entities
{
    public class Media : IMedia {
        public string Name { get => Name; set => Name = value; }
        public string Description { get => Description; set => Description = value; }
        public string Extension { get => Extension; set => Extension = value; }
        public string File { get => File; set => File = Name; }
    }
}