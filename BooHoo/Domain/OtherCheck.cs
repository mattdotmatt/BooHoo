namespace BooHoo.Domain
{
    public static class OtherCheck
    {
        public static OtherCheckResult CheckCustomer(Customer customer)
        {
            return customer.Salary > 3000 ? new OtherCheckResult {RuleA = 3} : new OtherCheckResult { RuleA = 4 };
        }
    }
}