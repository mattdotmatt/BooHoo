import Boo.Lang.Compiler
import BooHoo
import BooHoo.Domain
class Flow:
	static def Flow1(context as CompilerContext, customer as Customer):
		_Flow = FlowManager(context)

		result = _Flow.For(customer).Using("Rule3").Execute()

		if result.Status==0:
			return result
		else:
			result = _Flow.For(customer).Using("Rule4").Execute()
			return result;

