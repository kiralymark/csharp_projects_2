// C# Testing.
// Usage of base keyword and abstract classes.
//


abstract class A
{
    protected abstract void DoSomething();
    protected abstract void DoSomethingAnotherName();
}

abstract class SuperA : A
{
    private new void DoSomething()
    {
        //base.DoSomething();       // I can't do this. It will throw an error.
        DoSomethingAnotherName();   // BUT I can do this.
    }
}


/*
sealed class FinalA : SuperA
{
    protected override void DoSomething() { ... }
    protected override void DoSomethingAnotherName() { ... }
}
*/

sealed class FinalA : SuperA
{

    public FinalA() 
    {

        DoSomething();
        DoSomethingAnotherName();

    }

    protected override void DoSomething() 
    {

        //base.DoSomething();         // This will throw an error.

        Console.WriteLine("... protected override void DoSomething() method run.");

    }
    protected override void DoSomethingAnotherName() 
    {

        //base.DoSomethingAnotherName();        // This will throw an error.

        Console.WriteLine("... protected override void DoSomethingAnotherName() method run.");

    }
}




public abstract class B
{
    protected void DoSomething()
    {

        Console.WriteLine("... public abstract class B");
        Console.WriteLine("... protected void DoSomething() method run.");

    }

}

public class SuperB : B
{
    public new void DoSomething()
    {
        Console.WriteLine("... public class SuperB : B");
        Console.WriteLine("... public new void DoSomething() method run.");
        
    }

    public new void newDoSomething()
    {

        base.DoSomething();
        Console.WriteLine("... public new void newDoSomething() method run.");

    }

}


namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            FinalA finalA = new FinalA();


            Console.WriteLine("");
            SuperB superB = new SuperB();

            superB.DoSomething();

            Console.WriteLine("");
            superB.newDoSomething();

        }

    }


}
