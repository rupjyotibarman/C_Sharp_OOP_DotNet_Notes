using LearningOOP;

public class Program
{
    public static void Main()
    {
        //2. Generic Practice
        Console.WriteLine("Comparing Int 10 and 30 : " + GenericPractice.IsEqual(10, 30));
        Console.WriteLine("Comparing string Hello and hello :" + GenericPractice.IsEqual("Hello", "hello"));  //IsEqual<T>(T a, T b)
        Console.WriteLine("Comparing string Hello and int 10 :" + GenericPractice.IsEqual("Hello", 10)); //IsEqual<T, R>(T a, R b)  for diff data types
        Console.WriteLine("Comparing string \"10\" and int 10 :" + GenericPractice.IsEqual("10", 10)); //IsEqual<T, R>(T a, R b)  for diff data types



        //1. Properties
        //Properties prop = new Properties();
        //prop.Name = "Rup";
        //int age = prop.Age;  // this is possible 
        ////prop.Age= 22; // this is not coz set property is private not accessible.
        //prop.Address = "Nalbari Assam";
        //Properties.PinCode = "781005";
        //Console.WriteLine($"{prop.Name} is {prop.Age} years old and from {prop.Address} and PinCode is {Properties.PinCode}");  // age is default 0 if not set.
    }
}
