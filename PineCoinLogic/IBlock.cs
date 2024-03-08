namespace PineCoinLogic;

public interface IBlock
{
    public int Index { get; }

    public string Timestamp { get; }

    public IList<object> Transactions { get; }

    public string PreviousHash { get; } 
}