using BooHoo.DecisionEngine;

namespace BooHoo.Domain
{
    public class Result
    {
        public Result()
        {
            Status = Decision.Accept;
        }

        public Result(string message)
        {
            Message = message;
        }

        public Decision Status { get; set; }
        public string Message { get; set; }
    }
}