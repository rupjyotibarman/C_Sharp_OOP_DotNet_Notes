using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    interface IParent
    {
        string Address { get; set; }
        static string Name = "Rupjyoti";  // can have static members 
        void BuyCloth();  // method signature
        void Eat() // Default Body as well
        {
            Console.WriteLine("Eating Food");
        }
        static void Walking()
        {
            Console.WriteLine($"{Name} is Walking on the Street");
        }
    }
    internal class InterfacePractice : IParent
    {
        public string Address { get; set; } = "Ghy-005";
        public void BuyCloth() {
            Console.WriteLine($"{IParent.Name} is Buying Cloths at {Address}");
        }
        public void Eat()  // it will replace Interface Eat() method.
        {
            Console.WriteLine("Eating Replaced with derived class");
        }
    }
}


/*
 Diff Between Abstract and Interface and When to use whic one 
----------------------------------------------------------------
1. Difference Between an Abstract Class and an Interface

An abstract class is a partially implemented base class that provides both a contract and shared implementation for its derived classes. It can contain constructors, fields, properties, abstract methods, virtual methods, concrete methods, and other members. Since it can store state and provide common functionality, it is ideal for representing objects that share a common identity and behavior. However, a class can inherit from only one abstract class because C# supports only single class inheritance.

An interface, on the other hand, is primarily a contract that defines what a class must do without describing how it should do it. Traditionally, it contains only member declarations that implementing classes must provide, although modern C# allows default interface methods in certain scenarios. An interface cannot have instance fields or constructors because it does not maintain object state. Unlike abstract classes, a class can implement multiple interfaces, allowing C# to support multiple inheritance of behavior contracts. Interfaces promote loose coupling, flexibility, and extensibility by allowing different, even unrelated, classes to expose the same capabilities while implementing them in their own way.

option 2
---------------------------------------
Which One Should You Use?

Use an Abstract Class When:
Classes are closely related.
They share common fields.
They share common methods.
They need constructors.
They need common implementation.
There is a strong "is-a" relationship.

Use an Interface When:
You only need a contract.
Classes may be completely unrelated.
Multiple inheritance of behavior is required.
You want loose coupling.
You are using Dependency Injection.
You want easy unit testing and mocking.
Easy Interview Trick

Ask yourself these two questions:

1. Do these classes share common data and implementation?

Yes → Use an Abstract Class.

2. Do these classes only need to promise they can perform the same action?

Yes → Use an Interface.


2. When Should You Use an Abstract Class and When Should You Use an Interface?

An abstract class should be used when multiple related classes share common characteristics, state, and implementation. It is the right choice when the derived classes have a strong "is-a" relationship and need to inherit common data, constructors, and reusable methods while still being forced to implement certain behaviors. Abstract classes help reduce code duplication by placing shared logic in the base class and allowing derived classes to focus only on the functionality that differs.

An interface should be used when you only need to define a common contract that different classes must follow, regardless of whether they are related by inheritance. It is most appropriate when the focus is on a capability or behavior rather than shared implementation. Interfaces are widely used to achieve loose coupling, dependency injection, polymorphism, and unit testing because they allow implementations to be replaced without affecting the code that depends on them. They are also the preferred choice when a class needs to support multiple behaviors by implementing multiple interfaces, something that is not possible with abstract classes due to C#'s single inheritance restriction. In general, if you need shared implementation and common state, choose an abstract class; if you need only a contract with maximum flexibility and multiple inheritance of behavior, choose an interface.
 */

/*
 
Interface in C# – Complete Theory Summary (Bullet Points)
1. What is an Interface?
An interface is a reference type declared using the interface keyword.
It defines a contract that implementing classes or structs must follow.
It specifies what a type must do, not how it should do it.
It provides abstraction by hiding implementation details.
It cannot be instantiated.
2. Why Do We Use Interfaces?
To define a common contract for multiple classes.
To achieve abstraction.
To achieve loose coupling.
To support polymorphism.
To support Dependency Injection (DI).
To make applications easier to test (mocking/unit testing).
To allow multiple inheritance of behavior contracts.
To design extensible and maintainable software.
3. Main Characteristics
Cannot be instantiated.
Contains member declarations.
Classes and structs implement interfaces.
Interfaces can inherit other interfaces.
Multiple interfaces can be implemented by a single class.
Supports polymorphism.
Contains no instance state (fields).
Represents capabilities or behaviors.
4. What Can an Interface Contain?
Allowed
Method declarations
Properties
Indexers
Events
Static members (Modern C#)
Static methods (Modern C#)
Static properties (Modern C#)
Constants
Default interface methods (C# 8+)
Private helper methods for default implementations (C# 8+)
Static abstract members (C# 11+, mainly for generic math)
5. What Cannot an Interface Contain?
Instance fields
Instance constructors
Destructors (Finalizers)
Instance variable initialization
Protected constructors
Private instance members (except helper methods for default implementations)
Non-static instance state
6. Interface Methods
Usually contain only the method signature.
No implementation (traditional interfaces).
Must be implemented by the implementing class.
Are implicitly public.
Cannot be private in the traditional interface model.
7. Default Interface Methods (C# 8+)
Interfaces can provide default implementations.
Implementing classes may use the default implementation or provide their own.
Introduced mainly for backward compatibility in libraries.
Used less frequently than abstract class implementations.
8. Interface Properties
Can declare get, set, or both.
Contain no implementation (unless using modern default implementations).
Must be implemented by the implementing class.
9. Constants
Allowed.
Automatically static.
Automatically compile-time constants.
Shared by all implementations.
10. Static Members
Allowed in modern C#.
Belong to the interface itself.
Do not belong to implementing objects.
Cannot store instance-specific data.
11. Constructors
Not allowed.
Interfaces have no object state.
Nothing exists to initialize.
12. Destructors
Not allowed.
Interfaces do not represent actual objects.
13. Fields
Instance fields are not allowed.
Interfaces cannot store object state.
State belongs to the implementing class.
14. Access Modifiers
Traditional Interface Members
Implicitly public.
No need to write public.
Cannot be private, protected, or internal.
Modern C# (Default Interface Methods)
Interfaces can contain private helper methods.
Static members can use appropriate access modifiers.
15. Implementing an Interface
Use the : operator.
Every required member must be implemented.
Implemented members must be public (unless explicitly implementing the interface).
16. Multiple Interface Implementation
A class can implement multiple interfaces.
C# supports multiple inheritance of interfaces.
One of the biggest advantages over abstract classes.
17. Interface Inheritance
Interfaces can inherit one or more interfaces.
The derived interface inherits all members from parent interfaces.
A class implementing the derived interface must implement all inherited members.
18. Explicit Interface Implementation
Used when multiple interfaces contain members with the same signature.
Allows different implementations for each interface.
Members are accessed only through the interface reference.
Prevents naming conflicts.
19. Interface References
An interface reference can point to any object that implements it.
Enables runtime polymorphism.
Only members declared in the interface are accessible through the interface reference.
20. Polymorphism
Interfaces support runtime polymorphism.
One interface can represent many implementations.
The actual implementation is determined at runtime.
21. Multiple Inheritance
Classes
Not supported.
Interfaces
Fully supported.
A class may implement many interfaces simultaneously.
22. Why No Instance State?
Interfaces describe behavior.
They do not describe implementation details.
Data belongs to implementing classes.
23. Why No Constructors?
Constructors initialize object state.
Interfaces have no object state.
Therefore constructors are unnecessary.
24. Why No Instance Fields?
Interfaces define capabilities.
Fields represent implementation details.
Keeping state out of interfaces promotes loose coupling.
25. Why Can't Interfaces Be Instantiated?
They contain no complete object implementation.
The compiler cannot create an incomplete object.
Only implementing classes can be instantiated.
26. Interfaces and Dependency Injection

Interfaces are heavily used in:

ASP.NET Core
Repository Pattern
Service Layer
Logging
Authentication
Unit Testing
Mocking Frameworks
Factory Pattern

Reason:

Code depends on abstractions rather than concrete implementations.
This follows the Dependency Inversion Principle (DIP).
27. Interfaces and Unit Testing
Interfaces make mocking easy.
Fake implementations can replace real services.
Business logic can be tested independently.
Promotes isolated testing.
28. Relationship with SOLID Principles
S - Single Responsibility Principle
Interfaces encourage separation of responsibilities.
O - Open/Closed Principle
New implementations can be added without modifying existing code.
L - Liskov Substitution Principle
Any implementation should be substitutable wherever the interface is expected.
I - Interface Segregation Principle
Prefer many small, focused interfaces over one large interface.
D - Dependency Inversion Principle
High-level modules depend on interfaces instead of concrete classes.
29. Advantages
Provides abstraction.
Promotes loose coupling.
Enables Dependency Injection.
Supports mocking.
Supports runtime polymorphism.
Supports multiple inheritance of contracts.
Improves maintainability.
Encourages clean architecture.
Makes applications extensible.
Easy to replace implementations.
30. Disadvantages
Cannot store object state.
No constructors.
Limited code reuse compared to abstract classes.
Every implementing class must satisfy the contract.
Poorly designed interfaces can become difficult to maintain.
31. When to Use Interfaces

Use interfaces when:

Only a contract is needed.
Multiple unrelated classes share the same capability.
Multiple inheritance of behavior contracts is required.
Designing APIs.
Using Dependency Injection.
Using Repository Pattern.
Creating service-based architecture.
Supporting unit testing and mocking.
32. When NOT to Use Interfaces

Do not use interfaces when:

Shared implementation is required.
Shared fields or state are required.
Constructors are required.
Classes share significant common behavior.
A strong "is-a" relationship exists (an abstract class is often more suitable).
33. Interface vs Abstract Class (Quick Revision)
Interface
Pure contract.
No instance fields.
No constructors.
Multiple inheritance supported.
Primarily defines behavior.
Best for unrelated classes and loose coupling.
Abstract Class
Partial implementation.
Can contain fields.
Can contain constructors.
Single inheritance only.
Defines both behavior and state.
Best for related classes sharing implementation.
34. Compiler Rules
Every required interface member must be implemented by a concrete class.
Missing implementations produce compile-time errors.
An abstract class may leave interface members unimplemented.
The first non-abstract derived class must implement them.
35. Common Built-in Interfaces
IDisposable
IEnumerable
IEnumerator
IComparable
IComparer
ICloneable
IEquatable<T>
IFormattable
IAsyncDisposable
IObservable<T>
IObserver<T>
36. Common Interview Questions
What is an interface?
Why do we use interfaces?
Why can't interfaces have instance fields?
Why can't interfaces have constructors?
Can interfaces contain properties?
Can interfaces contain static members?
What are default interface methods?
Can interfaces inherit other interfaces?
Can one class implement multiple interfaces?
What is explicit interface implementation?
What is the difference between an interface and an abstract class?
Why are interfaces used in Dependency Injection?
Why are interfaces useful in unit testing?
What is the Interface Segregation Principle?
What is loose coupling, and how do interfaces help achieve it?
37. One-Line Definition (Interview)

An interface is a contract that defines a set of behaviors a class or struct must implement without specifying the implementation. It is primarily used to achieve abstraction, loose coupling, polymorphism, dependency injection, and multiple inheritance of contracts.

 */