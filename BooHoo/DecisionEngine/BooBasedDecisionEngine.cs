using System;
using System.IO;
using System.Reflection;
using Boo.Lang.Compiler;
using Boo.Lang.Compiler.IO;
using Boo.Lang.Compiler.Pipelines;
using BooHoo.Domain;

namespace BooHoo.DecisionEngine
{
    public class BooBasedDecisionEngine:IDecisionEngine
    {
        public DecisionResult MakeDecision(Customer customer)
        {
            var compiler = CreateCompiler();
            CompilerContext context = compiler.Run();

            //Note that the following code might throw an error if the Boo script had bugs.
            //Poke context.Errors to make sure.
            if (context.GeneratedAssembly == null) return new DecisionResult{Decision = Decision.Error};

            var scriptModule = context.GeneratedAssembly.GetType("Flow");
            var result = (Result)RunRule(scriptModule, context, customer, "Flow1");
            return new DecisionResult{Decision = result.Status,Message = result.Message};
        }

        private static BooCompiler CreateCompiler()
        {
            var compiler = new BooCompiler();
            AddRules(compiler);
            compiler.Parameters.Pipeline = new CompileToMemory();
            compiler.Parameters.Ducky = true;
            return compiler;
        }

        private static object RunRule(Type scriptModule, CompilerContext context, Customer customer, string ruleName)
        {
            MethodInfo rule = scriptModule.GetMethod(ruleName);
            var output = rule.Invoke(null, new object[] { context, customer });
            return output;
        }

        private static void AddRules(BooCompiler compiler)
        {
            foreach (var file in Directory.GetFiles(@"..\..\BooFiles\Rules\"))
            {
                compiler.Parameters.Input.Add(new FileInput(file));
            }
        }


    }
}