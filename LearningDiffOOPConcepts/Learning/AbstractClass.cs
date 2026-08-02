using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal abstract class AbstractClassFamily // an abstract calss contain everything like a normal class abstract non abstract method properties fields constr destr etc. => only it can't be instantiated X X X
    {
        protected string Address;
        public abstract string Name { get; set; }
        public abstract int NoOfMeal { get; set; }
        public abstract void DailyRoutin();

        protected AbstractClassFamily(string add = null)
        {
            Console.WriteLine("Base Abstract Class Constructor is called and Address Set!!\n\n");
            if (add == null)
            {
                Address = "Ghy-06, Dispur SuperMarket";
            }
            else
            {
                Address = add;
            }

        }

        protected void Eat(int meal)
        {
            NoOfMeal = meal;
        }
    }

    internal abstract class Husband : AbstractClassFamily  // if sub class doesn't provide body it become a abstract class as well
    {
        //public abstract override string Name {get;set;}  // Event tho we won't explicitly override the method and properties here it automatically override when we make the sub class itself as abstract.
        public abstract override void DailyRoutin();
    }

    internal class Son : Husband   // must implement the Body of abstract method using "override" keyword.
    {
        public override int NoOfMeal { get; set; }
        public override string Name { get; set; }
        public Son(string name, int noOfMeal)
        {
            Name = name;
            NoOfMeal = noOfMeal;
        }

        public override void DailyRoutin()
        {
            Console.WriteLine($"Son {this.Name} Bought 2 Jeans, 2 shirts and 1 shoes\n{Name} take {NoOfMeal} Meal/Day\n{Name} Stay at {Address}");
        }
    }

    internal class Wife : AbstractClassFamily
    {
        public override string Name { get; set; } = "Rina";
        public override int NoOfMeal { get; set; } = 2;

        public Wife(string add = null) : base(add) { }  // ctor to set seperate address for wife by calling base class constructor.
        public override void DailyRoutin()
        {
            Console.WriteLine($"Wife {Name} Bought only 3 Pants 2 Shirts and 2 Skirts.\n{Name} take {NoOfMeal} Meal/Day\n{Name} Stay at {Address}");
        }
    }

    //interface
    interface IAnimal
    {
       void Eat();  //by default interface members are public and abstract we don't need to use these keyword explicitly.
    }
    public abstract class Animal :IAnimal  //an abstract class can implement interface as well
    {
        public abstract void Eat();      
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }
    }
}

/*
1.What is an Abstract Class?
An abstract class is a class declared using the abstract keyword.
It acts as a base class (blueprint/template) for other classes.
It represents an incomplete object whose derived classes complete the implementation.
It supports inheritance and code reuse.
It is one of the fundamental OOP concepts in C#.
2.Why do we use an Abstract Class?
To define a common base for related classes.
To share common implementation among derived classes.
To force derived classes to implement specific functionality.
To prevent creation of incomplete objects.
To reduce code duplication.
To achieve partial abstraction.
To establish a common design for an inheritance hierarchy.
3. Main Characteristics
Cannot be instantiated.
Can be inherited.
Can contain implemented (non-abstract) methods.
Can contain abstract methods.
Can contain fields.
Can contain properties.
Can contain constructors.
Can contain destructors (although rarely needed).
Can contain static members.
Can contain constants.
Can contain events and delegates.
Can contain nested types.
Can implement interfaces.
Can inherit from another abstract class or a concrete class (if appropriate).
4.What Members Can an Abstract Class Contain?
Fields
Constants
Readonly fields
Properties
Indexers
Constructors
Destructors (Finalizers)
Static constructors
Abstract methods
Concrete (non-abstract) methods
Virtual methods
Static methods
Events
Delegates
Nested classes
Nested enums
Nested structs
5. What Cannot an Abstract Class Do?
Cannot create objects using new.
Cannot contain abstract fields.
Cannot contain abstract constructors.
Cannot declare abstract static methods.
Cannot declare abstract private methods(because private methods cannot be overridden).
6. Abstract Methods
Declared using the abstract keyword.
Contain only the method signature.
Do not have a method body.
Must be declared inside an abstract class.
Must be overridden in the first concrete (non-abstract) derived class.
Must use the override keyword in the derived class.
Can have any return type.
Can have parameters.
Can use access modifiers like public, protected, internal, etc. (except private).
7.Non - Abstract Methods
Have a complete implementation.
Can be called directly by derived classes.
Used for common functionality.
Derived classes inherit them automatically.
Overriding is only possible if they are declared virtual.
8. Why Mix Abstract and Non-Abstract Methods?
Common logic should be written once in the base class.
Only behavior that differs should be made abstract.
Improves code reuse.
Reduces duplication.
Keeps common functionality centralized.
9. Constructors in Abstract Classes
Abstract classes can have constructors.
Constructors initialize the base part of the object.
Constructors execute whenever a derived object is created.
Constructors are never called directly because objects of abstract classes cannot be created.
The constructor exists only for derived classes.
10. Why is the Constructor Usually Protected?
Prevents unnecessary public access.
Indicates that only derived classes should use it.
Expresses the design intent of the class.
Although public constructors are allowed, they provide no practical benefit because the abstract class still cannot be instantiated.
11. Constructor Execution Order
Base constructor always executes first.
Derived constructor executes afterward.
Every level of inheritance initializes from top to bottom.
Constructor execution order cannot be changed.
The compiler automatically inserts base() if not specified.
12. Calling Base Constructors
Base constructors can be called explicitly using : base(...).
Used when the base class requires initialization parameters.
Only one constructor initializer is allowed (base() or this(), not both).
base() must appear in the constructor declaration, not inside the constructor body.
13. Base Constructor Rules
If the base class has a parameterized constructor only, the derived class must explicitly call it.
If the base class has a parameterless constructor, the compiler calls it automatically.
Base constructors cannot be called like normal methods.
14. Can Derived Constructors Modify Base Members?
Yes.
Once the base constructor finishes, the derived constructor can access accessible base members.
Access depends on the member's access modifier (public, protected, etc.).
15. Access Modifiers in Abstract Classes
Fields
Prefer private.
Use protected only if derived classes require direct access.
Avoid public fields.
Properties
Usually public.
Use protected when only derived classes need access.
Can be abstract, virtual, or concrete.
Constructors
Usually protected.
Can also be public, internal, or private (private constructors prevent inheritance and are therefore uncommon in abstract classes).
Abstract Methods
Usually public or protected.
Cannot be private.
Helper Methods
Usually protected.
Utility Methods
Usually private.
16.Fields vs Properties
Fields store data.
Properties provide controlled access to data.
Prefer properties over public fields.
Fields should usually remain private or protected.
17.Abstract Properties
Allowed.
Contain only get and/or set declarations.
No implementation.
Must be overridden by derived classes.
18. Virtual Methods
Have a default implementation.
Overriding is optional.
Used when the base class provides a reasonable default behavior.
19. Abstract vs Virtual
Abstract
No implementation.
Must override.
Used when no default behavior exists.
Virtual
Has implementation.
Override optional.
Used when default behavior exists but customization is allowed.
20. Static Members
Allowed.
Belong to the class, not the object.
Can be accessed without creating an object.
Cannot be abstract.
21.Constants
Allowed.
Shared across all derived classes.
Compile-time constants.
22. Readonly Fields
Allowed.
Can be assigned only during declaration or inside constructors.
Useful for immutable initialization.
23. Destructors
Allowed.
Execute during garbage collection.
Rarely used.
Normally IDisposable is preferred over destructors.
24. Static Constructors
Allowed.
Execute only once.
Initialize static members.
Cannot have access modifiers or parameters.
25. Interfaces and Abstract Classes
Abstract classes can implement interfaces.
They may implement all interface members.
They may leave interface members abstract for derived classes.
26.Inheritance Rules
An abstract class can inherit another abstract class.
A concrete class inheriting an abstract class must implement every inherited abstract member.
If it doesn't, it must also be declared abstract.
27. Object Creation
Objects of abstract classes cannot be created.
Objects of derived classes can be created.
Abstract class references can point to derived objects (polymorphism).
28. Compiler Requirements
Every abstract member must eventually be implemented.
Missing implementations produce compile-time errors.
The compiler ensures abstract contracts are fulfilled.
29.Relationship with SOLID Principles
Supports Open/Closed Principle (OCP) by allowing extension through derived classes without modifying the base class.
Supports Liskov Substitution Principle (LSP) when derived classes correctly implement the abstract contract.
Encourages good object-oriented design.
30. Advantages
Promotes code reuse.
Reduces duplication.
Enforces a common design.
Improves maintainability.
Supports polymorphism.
Allows partial implementation.
Centralizes shared logic.
Makes large systems easier to extend.
Provides better abstraction than a normal base class when some behavior must remain undefined.
31. Disadvantages
Supports only single inheritance.
Can increase coupling if overused.
Poorly designed abstract classes may violate LSP.
Changing the abstract contract can require updates to all derived classes.
Less flexible than interfaces for unrelated classes.
32. When to Use an Abstract Class
Multiple related classes share common state and behavior.
You want to provide default implementations.
You want to force subclasses to implement specific functionality.
The classes have a strong "is-a" relationship.
You need constructors or instance fields.
33. When NOT to Use an Abstract Class
Classes are unrelated.
Only a contract is needed.
Multiple inheritance of behavior is required.
No shared implementation exists.
Flexibility is more important than shared code.
34. Common Interview Questions
What is an abstract class?
Why can't an abstract class be instantiated?
Can an abstract class have constructors?
Why are constructors usually protected?
Can an abstract class contain implemented methods?
Can it contain fields and properties?
Can it have static members?
Can it have destructors?
Can it implement interfaces?
What is the difference between abstract and virtual methods?
What is the difference between an abstract class and an interface?
Can an abstract class inherit another abstract class?
Can a derived class skip implementing abstract methods?
Why do constructors execute from base to derived?
Why does the compiler automatically insert base()?
Can you explicitly call a base constructor?
Can a derived constructor modify accessible base members?
35. One-Line Definition (Interview)

An abstract class is a partially implemented base class that cannot be instantiated. It allows sharing common state and behavior while enforcing derived classes to implement required functionality through abstract members.

*/