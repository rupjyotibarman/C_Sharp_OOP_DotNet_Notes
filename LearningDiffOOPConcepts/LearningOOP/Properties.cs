using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    internal class Properties
    {
        public string Name { get; set; }
        public int Age { get; private set; } = 20;
        private string _address = "Default Ghy";
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        // Static
        //public static string? PinCode { get; set; }   // or the traditional approach
        private static string _pinCode = "781000";
        public static string PinCode
        {
            get { return _pinCode; }
            set { _pinCode = value; }
        }

        //public abstract string LandMark { get; set; }   // XX can't class need to be abstract

        public int Add(int a, int b) => a + b;
        public string ToUpper(string str) => str.ToUpper();
        }
    }


/*
 
📌 Core Concept: What is a Property?Definition: A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field.The Goal: Properties expose data to the outside world while maintaining Encapsulation (protecting the internal state of an object).The Mechanics: Under the hood, properties act as specialized methods called Accessors (get and set).get: Executes when you read the property value.set: Executes when you write/assign a new value to the property.value: A built-in keyword used exclusively inside the set block to represent the incoming data.

🚀 Auto-Implemented Properties ({ get; set; })Syntax: public string Address { get; set; }When to use: Use this by default whenever you don't need any custom validation or data transformation logic.Compiler Secret: Even though you don't see it, a field always exists. The C# compiler automatically generates a hidden, private backing field in the machine code (e.g., <Address>k__BackingField).Property Access Restrictions: You can restrict access by changing modifiers, such as public int Age { get; private set; } = 20;. This allows anyone to read the value, but only the class itself can change it.

🛠️ Full Properties (Manual Form)Syntax: Requires manually declaring a separate variable called a Backing Field to hold the actual data in memory.When to use: Use only when you need to execute custom code during a read or write operation.Common Use Cases:Data Validation: Rejecting bad inputs (e.g., throwing an error if a string is null or empty).Data Transformation: Altering data on the fly (e.g., returning text in ToUpper() format or trimming whitespaces).UI Notifications: Alerting frontend frameworks (like WPF or MAUI) to redraw the screen when a backend value updates.

⚠️ The Infinite Recursion Danger (StackOverflowException)The Mistake: Writing code where a property calls itself inside its own body:csharp// ❌ WRONG: Causes runtime crash
public string Address {
    get { return Address; } 
    set { Address = value; }
}
Use code with caution.Why it fails: Because the compiler stops generating the hidden field when you take full control. Address = value; tells the property to call its own setter, creating an infinite loop that crashes your computer's memory stack.The Fix: You must create a explicit, separate backing field to hold the value.

🛡️ Access Modifiers & Coding StandardsBacking Field Rules: A manually written backing field should always be private and typically follows camelCase with an underscore prefix (e.g., private string _address;).Why not public fields?: Making a backing field public allows outside code to bypass your property's get or set gates entirely. This breaks encapsulation and ruins your validation logic.

 */