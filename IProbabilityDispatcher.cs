namespace probability_as_resource;

public interface IProbabilityDispatcher
{
    public IJointProbability GetJointProbabilityFingerprint(
        INumericInput input
    );

    public IProbability GetConditionalProbability(
        INumericInput input,
        int targetIndex);

    public IJointProbability GetProbability(
        INumericInput input);
}
