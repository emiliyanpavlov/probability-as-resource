namespace probability_as_resource;

public interface IProbabilityDispatcher
{
    public ulong GetJointProbabilityFingerPrint(
        INumericInput input,
        int labelIndex,
    );
}
