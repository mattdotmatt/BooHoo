import BooHoo
import BooHoo.Domain
partial class Rules:
	static def Rule4(customer as Customer):
		if customer.Product == "Option 2":
			otherCheckResult = OtherCheck.CheckCustomer(customer)
			if otherCheckResult.RuleA==3:
				customer.Product = "Option 4"
			else:
				customer.Product = "Option 3"
		return Result();