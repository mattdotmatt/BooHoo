import BooHoo
import BooHoo.Domain
partial class Rules:
	static def Flow(customer as Customer):
		result = Rule1(customer)
		if result.Status==0:
			return result
		return Rule2(customer);

	static def Rule1(customer as Customer):
		if customer.Age < 18:
			return Result("Customer is too young")
		if customer.Salary < 1000:
			return Result("Customer is too poor")
		else:
			creditCheckResult = CreditCheck.CheckCustomer(customer)
			if creditCheckResult.RuleA==1:
				customer.Product = "Option 1"
			else:
				customer.Product = "Option 2"
			return Result();

	static def Rule2(customer as Customer):
		if customer.Product == "Option 2":
			otherCheckResult = OtherCheck.CheckCustomer(customer)
			if otherCheckResult.RuleA==3:
				customer.Product = "Option 4"
			else:
				customer.Product = "Option 3"
		return Result();