using BooHoo.DecisionEngine;

namespace BooHoo.Domain
{
    public class ErrorResult : Result
    {
        public static Result WithMessage(string message)
        {
            return new Result{ Status = Decision.Error,Message = message};
        }
    }
}