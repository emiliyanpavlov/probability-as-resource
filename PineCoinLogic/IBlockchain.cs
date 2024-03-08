namespace PineCoinLogic;

public interface IBlockchain
{
    public IList<IBlock> Chain { get; }

    public IList<object> PendingTransactions { get; }

    public IBlock CreateNeBlock(string previousHash);

    public abstract static string Hash(IBlock block);

    public IBlock LastBlock();

    public void ProofOfWork();

    public void ValidHash();
}
