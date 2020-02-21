using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProductivityFeatures
{
    // Prevent usings inside a namespace code style rule
    // You can now use a new editorconfig code style rule to require or prevent usings inside a namespace
    // This setting will also be exported when you use the “Generate editorconfig” button located in Tools > Options > Text Editor > C# > Code Style
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Update161
    {
        // Split if statements into nested if statements
        // Place cursor by the '&&' and type (Alt + Enter)
        // Select 'Split into nested if statements'
        public void SplitIf()
        {
            if (1 < 2 && 2 > 3)
            {

            }
        }

        // Merge nested if statements
        // Place cursor in 'if' keyword
        // Type (Alt + Enter) and select 'Merge with nested if statement'
        public void MergeIf()
        {
            if (1 < 2)
            {
                if (2 > 3)
                {

                }
            }
        }

        // Regex Completion (no completion-suffix work)
        // Place cursor in the quotation marks in the Regex declaration
        // Type (Ctrl + space) to view the list of Regex completions
        public void RegexCompletion()
        {
            Regex r = new Regex("");
        }

        // Wrapping for binary expression
        public void WrapBinaryExpression()
        {
            if (1 < 3 || 2 > 4 && true || 1 > 0 || false && 1 == 1) { }
        }

        // Place your cusor in the 'createField' parameter and type (Alt + Enter)
        // Select 'Create and initialize field' to create a field from the constructor
        public Update161(int existingField, int createField) { }
        public Update161() { }

        // Toggle single line comment/uncomment is now available through the keyboard shortcut (⌘/)
        // This command will add or remove a single line comment depending on whether your selection is already commented
        public void SingleLineComment()
        {
            Console.WriteLine("comment this line");
        }
    }

    // Code fix to unseal a class
    // Uncomment the MyClass declaration
    // Place cursor in InternalClass
    // Type (Alt + Enter) to open quick fixes and refactorings menu
    internal sealed class InternalClass { }
    //class MyClass : InternalClass { }
}

namespace NewNamespace
{
    // Make readonly struct fields writable
    // Place your cursor in 'MyStruct'
    // Type (Alt + Enter) to trigger the Quik Actions and Refactoings menu
    // Select make readonly fields writable
    struct MyStruct
    {
        readonly int Value;

        public MyStruct(int value)
        {
            Value = value;
        }

        public void Test()
        {
            this = new MyStruct(5);
        }
    }
}
