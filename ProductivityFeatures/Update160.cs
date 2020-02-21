using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProductivityFeatures
{
    class Update160
    {
        // Place cursor in foreach keyword and type (Alt + Enter)
        // Select 'Convert to Linq' to convert to a query
        public void ForeachLoopToLinqQuery()
        {
            var greetings = new List<string>()
                { "hi", "yo", "hello", "howdy" };

            IEnumerable<string> enumerable()
            {
                foreach (var greet in greetings)
                {
                    if (greet.Length < 3)
                    {
                        yield return greet;
                    }
                }

                yield break;
            }

            var shortGreeting = enumerable();
        }

        // Place cursor in foreach keyword and type (Alt + Enter)
        // Select 'Convert to Linq(call form)' to convert to a method
        public void ForeachLoopToLinqMethod()
        {
            var greetings = new List<string>()
                { "hi", "yo", "hello", "howdy" };

            IEnumerable<string> enumerable()
            {
                foreach (var greet in greetings)
                {
                    if (greet.Length < 3)
                    {
                        yield return greet;
                    }
                }

                yield break;
            }

            var shortGreeting = enumerable();
        }

        // A codefix for adding the needed "using" will appear on copy/pasted code
        // Uncomment the text into the method below: string json = JsonConvert.SerializeObject(greetings);
        // With your cursor in "JsonConvert" type (Alt + Enter)
        // Select to add the Using Newtonsoft.Json
        public void UsingRefAddedCopyPaste()
        {
            //string json = JsonConvert.SerializeObject("some json");
        }

        // Place cursor before the opening parenthesis in (3, "string");
        // Type (Alt + Enter)
        // Select Convert to struct
        public void ConvertTupleToNamedStruct()
        {
            var tuple = (3, "string");

            Console.WriteLine(tuple.Item2);
        }

        // Dead code analysis has improved to more accurately detect and remove unused code.
        // Place your cursor in the method name below and type (Alt + Enter)
        // Select remove unused member and it will delete the entire method and comment
        private void DeadCodeAnalysOnPrivateMembers()
        {
            Console.WriteLine("Never run.");
        }

        // Place cursor in the GetNumberAsync() in var x declaration.
        // Type (Alt + Enter) and select Add await.
        public async Task ForgotImpliedAwaitAsync()
        {
            var x = GetNumberAsync();

            await GetNumberAsync();
        }
        private Task<object> GetNumberAsync()
        {
            throw new NotImplementedException();
        }

        // Place cursor in local HelloWorld method.
        // Type (Alt + Enter) and select Convert to method
        public void ConvertLocalFunctionToMethod()
        {
            string HelloWorld()
            {
                return "HelloWorld!";
            }
            Console.WriteLine(HelloWorld());
        }

        // Uncomment the text in the method below to cause an error.
        // To fix the error in the method below
        // Place your cursor in MyInternalClass and Type (Alt + Enter) 
        // Select Generate method MyInternalClass.Deconstruct.
        public void GenerateDeconstructMethod()
        {
            //(int x, int y) = new MyInternalClass();
        }
        private class MyInternalClass
        {
            public MyInternalClass()
            {
            }
        }

        // Place cursor in new and type (Alt + Enter)
        // Select Convert to tuple
        public void ConvertAnonymousTypetoTuple()
        {
            var myTuple = new { a = 1, b = 2 };
            var t2 = (3, "string");

            Console.WriteLine(t2.Item2, myTuple);
        }

        // Place cursor in 'new' keyword and type (Alt + Enter)
        // Select Convert to class
        public void ConvertAnonymousTypetoClass()
        {
            var myClass = new { str = "Hi" };

            Console.WriteLine(myClass.str);
        }

        // This codefix will wrap/indent/align lists of parameters/arguments
        // Place cursor in a parameter and type (Alt + Enter)
        // There are several wrapping options provided
        // Select the option to wrap every individual parameter to the same column
        public void WrapIndentAlignParameters(int a, int b, int c, int d, string e, string f, string g, string h, DateTime i, DateTime j, DateTime k)
        { }

        // Use expression/block body for lambda
        // Place cursor after "=>" and type (Alt + Enter)
        // Select use block body for lambda expressions
        public void UseExpressionBlockBodyForLambda()
        {
            del myDelegate = x => x * x;
            int j = myDelegate(5); //j = 25 
        }
        delegate int del(int i);

        // Invert conditional expressions and logical operations
        // Place your cursor in "true"
        // Type (Alt + Enter) and select invert conditional.
        public int InvertConditionalExpressionsAndLogicalOperations()
        {
            int zeroIfTrue = true ? 0 : 1;
            return zeroIfTrue;
        }

        // Convert to compound assignment
        // Place cursor in "10" and type (Alt + Enter)
        // Select use compound assignment
        public void ConvertToCompoundAssignment()
        {
            int x = 1;
            x = x + 10;

            Console.WriteLine(x);
        }

        // Fix Implicitly-typed variables cannot be constant
        // Uncomment the const line to cause an error
        // Place cursor in "var" and type (Alt + Enter)
        // Select use explicit type instead of var
        public void ImplicitlyTypedVariablesCannotBeConstant()
        {
            //const var v = "";
        }

        // Replace `@$"` with `$@"` when typing interpolated verbatim string
        // When you type an interpolated string it's easy to type the '$@' out of order.
        // This command fixes it as you type.
        // Try typing "string myString = @$" below and watch the fix apply automatically!
        public void CorrectTypingInterpolatedVerbatimString()
        {
            int x = 7;
            string myInterpolatedString = $@"This is my favorite number: {x}";
        }

        // Automatically close block comment on "/"
        // Typing "/" after "* " in a multi-line comment used to not end 
        // the comment because of the space between "*" and "/".
        // Now when typing "/" the space is automatically deleted so that it ends your comment block.
        public void AutoCloseMultiLineComment()
        {
            ///*
            // * Uncomment this block and type "/" after the "* " below to end the comment block
            // * 
        }

        // Fix for identified unused expression values and parameters
        // Place cursor in by "x" to read the diagnostic. (no codefix)
        // Place cursor in x1 and type (Alt + Enter) to remove the unused variable.
        public string UnusedParameter(string x)
        {
            string x1 = "x";
            return "x";
        }

        // Place cursor in "x" and type (Alt + Enter)
        // Select "Remove redundant assignment" to eliminate the unused value assignment
        public int UnusedValueAssigmentAndUnusedParameterDiagnostic(string s)
        {
            int x = 1;
            x = 2;
            return x;
        }
    }
}

// Pull members up refactoring with dialog options
// A dialog will appear to pull the Method up into the interface
// Place your cursor in PullUpMethod and type (Alt + Enter)
// Select 'Pull members up to base type'
namespace PullUp
{
    public interface IMyInterface
    {

    }
    public class MyClass : IMyInterface
    {

        public void PullUpMethod()
        {
            System.Console.WriteLine("Hello World");
        }

        // You can pull up properties as well.
        // Place your cursor in PullUpString and type (Alt + Enter)
        // Select 'Pull members up to base type'
        public string PullUpString { get; set; }
    }
}
