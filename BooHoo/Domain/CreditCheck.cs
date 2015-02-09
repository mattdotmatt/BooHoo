namespace BooHoo.Domain
{
    public static class CreditCheck
    {
        public static CreditCheckResult CheckCustomer(Customer customer)
        {
            if (customer.Salary < 2000)
            {
                return new CreditCheckResult {RuleA = 1};
            }
            return new CreditCheckResult { RuleA = 2 };
        }
    }
}