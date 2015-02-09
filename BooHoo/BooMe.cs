using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Boo.Lang.Compiler;
using Boo.Lang.Compiler.IO;
using Boo.Lang.Compiler.Pipelines;
using BooHoo.DecisionEngine;
using BooHoo.Domain;

namespace BooHoo
{
    public partial class BooMe : Form
    {
        public BooMe()
        {
            InitializeComponent();
        }

        private static object RunRule(Type scriptModule, Customer customer, string ruleName)
        {
            MethodInfo rule = scriptModule.GetMethod(ruleName);
            var output = rule.Invoke(null, new object[] {customer});
            return output;
        }

        private void btnBoo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAge.Text) || String.IsNullOrEmpty(txtSalary.Text))
            {
                MessageBox.Show("Enter some values");
                return;
            }

            var customer = new Customer
            {
                Age = Int32.Parse(txtAge.Text),
                Salary = double.Parse(txtSalary.Text),
                Product = ""
            };

            var compiler = CreateCompiler();
            CompilerContext context = compiler.Run();

            //Note that the following code might throw an error if the Boo script had bugs.
            //Poke context.Errors to make sure.
            if (context.GeneratedAssembly != null)
            {
                Type scriptModule = context.GeneratedAssembly.GetType("Rules");
                Result output = (Result) RunRule(scriptModule, customer, "Flow");
                if (output.Status == Decision.Decline)
                {
                    MessageBox.Show(string.Format("Failed check with {0}", output.Message));
                    return;
                }
                MessageBox.Show(string.Format("Product for you is {0}", customer.Product));
            }
            else
            {
                foreach (CompilerError error in context.Errors)
                    Console.WriteLine(error);
            }
        }

        private static BooCompiler CreateCompiler()
        {
            var compiler = new BooCompiler();
            AddRules(compiler);
            compiler.Parameters.Pipeline = new CompileToMemory();
            compiler.Parameters.Ducky = true;
            return compiler;
        }

        private static void AddRules(BooCompiler compiler)
        {
            foreach (var file in Directory.GetFiles(@"..\..\BooFiles\Rules\"))
            {
                compiler.Parameters.Input.Add(new FileInput(file));
            }
        }

        private void btnJudgeAgain_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAge.Text) || String.IsNullOrEmpty(txtSalary.Text))
            {
                MessageBox.Show("Enter some values");
                return;
            }

            var customer = new Customer
            {
                Age = Int32.Parse(txtAge.Text),
                Salary = double.Parse(txtSalary.Text),
                Product = ""
            };

            IDecisionEngine decisionEngine = new BooBasedDecisionEngine();
            var decision = decisionEngine.MakeDecision(customer);
            MessageBox.Show(decision.Decision == Decision.Decline
                ? string.Format("Failed check with {0}",decision.Message)
                : string.Format("Product for you is {0}", customer.Product));
        }
    }
}