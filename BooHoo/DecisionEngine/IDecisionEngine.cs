using BooHoo.Domain;

namespace BooHoo.DecisionEngine
{
    public enum Decision
    {
        Decline,
        Refer,
        Accept,
        Error
    }

    public interface IDecisionEngine
    {
        DecisionResult MakeDecision(Customer customer);
    }
}