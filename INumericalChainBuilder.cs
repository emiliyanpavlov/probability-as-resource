namespace probability_as_resource;

public interface INumericalChainBuilder
{
    public Span<float> CreateCorrelationMatrix(INumericInput input);

    public Span<int> BuildChainOrder(ReadOnlySpan<float> correlatioMatric);
}
