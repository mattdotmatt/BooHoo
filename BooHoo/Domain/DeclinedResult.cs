using BooHoo.DecisionEngine;

namespace BooHoo.Domain
{
    public class DeclinedResult : Result
    {
        public static Result WithMessage(string message)
        {
            return new Result{ Status = Decision.Decline,Message = message};
        }
    }
}