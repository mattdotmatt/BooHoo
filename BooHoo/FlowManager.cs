using System;
using System.Reflection;
using Boo.Lang.Compiler;
using BooHoo.Domain;

namespace BooHoo
{
    public class FlowManager
    {
        private CompilerContext _context;
        private Customer _customer;
        private string _rule;

        public FlowManager(CompilerContext context)
        {
            _context = context;
        }

        public Result Execute()
        {
            //Note that the following code might throw an error if the Boo script had bugs.
            //Poke context.Errors to make sure.
            if (_context.GeneratedAssembly != null)
            {
                Type scriptModule = _context.GeneratedAssembly.GetType("Rules");
                return (Result)RunRule(scriptModule, _customer, _rule);
            }
            foreach (CompilerError error in _context.Errors)
                Console.WriteLine(error);
            return null;
        }

        public FlowManager Using(string script)
        {
            _rule = script;
            return this;
        }

        public FlowManager For(Customer customer)
        {
            _customer = customer;
            return this;
        }

        private object RunRule(Type scriptModule, Customer customer, string ruleName)
        {
            MethodInfo rule = scriptModule.GetMethod(ruleName);
            var output = rule.Invoke(null, new object[] { customer });
            return output;
        }
    }
}