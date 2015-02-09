import BooHoo
import BooHoo.Domain
partial class Rules:
	static def Rule3(customer as Customer):
		if customer.Age < 18:
			return DeclinedResult.WithMessage("Customer is too young")
		if customer.Salary < 1000:
			return DeclinedResult.WithMessage("Customer is too poor")
		else:
			creditCheckResult = CreditCheck.CheckCustomer(customer)
			if creditCheckResult.RuleA==1:
				customer.Product = "Option 1"
			else:
				customer.Product = "Option 2"
			return Result();