namespace AspNETasmxWS.Infra.DataAccess.Contracts
{
    internal interface IMediaDao {
        int Count { get; }
        bool IsConnected { get; }        

    }
}
