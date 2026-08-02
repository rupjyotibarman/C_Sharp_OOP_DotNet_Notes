using System.ComponentModel;
using Learning;
public class Program
{
    public static void Main(string[] args)
    {

        //9. Method Overriding
        MethodOverriding ov = new SecDerivedClass();
        //DerivedClass d = (DerivedClass)ov;
        ov.Show();
        ov.BaseOnly();
        //ov.Working(); // XX not accessible Derived class members at compile time coz it dependes on Reference of Parent at compile time.

        DerivedClass d = (DerivedClass)ov;  // we need to typecast to access the derive members.
        d.Working();


        //8. Mehod Hinding
        //MethodHiding sb = new SubClass();
        ////SubClass sb = new SubClass();
        //sb.Show();

        //7. Operator Overloading
        //OperatorOverloading loan1 = new OperatorOverloading(10000, 8);
        //OperatorOverloading loan2 = new OperatorOverloading(20000, 7);
        //OperatorOverloading total = loan1+loan2;
        //Console.WriteLine($"Total Loan Amnt : {total.Total} and Interest : {total.Interest}");

        //6. Interface Practices
        //InterfacePractice iPrac = new InterfacePractice();
        //iPrac.BuyCloth();
        ////iPrac.Eat()//XX - Not accessible
        //IParent iPrac2 = new InterfacePractice();
        //iPrac2.Eat();

        //IParent.Name = "Prerana";  // no override name will take default if any
        //IParent.Walking();

        //5. Abstract class
        //Husband son = new Son("Rupjyoti", 3);
        //son.DailyRoutin();
        //Console.WriteLine("\n\n");
        //AbstractClassFamily wife = new Wife("Gamarimuri-306, Nalbari Assam");
        //wife.DailyRoutin();

        //4. Static Class
        //Console.WriteLine($"College Name : {StaticClass.Name}");

        //1. VarDynamic.PracticeVarDynamic();
        //2. RefOut.PracticeRefOut();

        //3. ***Practicing Static
        //StaticPracticeCreateAcc u1 = new StaticPracticeCreateAcc("Rupjyoti");
        //StaticPracticeCreateAcc u2 = new StaticPracticeCreateAcc("Prerana");
        //StaticPracticeCreateAcc user = u2.GetUser();
        //Console.WriteLine($"User Name : { user.Name} \t and id is : { user.UserId}");
        //Console.WriteLine($"Total User : { StaticPracticeCreateAcc.TotalUser}");

    }

}