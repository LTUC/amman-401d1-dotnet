using System;

namespace Class06_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Child c = new Child(1, 2, 3, 4);
            c.DoSomeThingAbstract();
        }

        // If a class is not abstract, it cannot contain abstract methods
        // But abstract classes are okay not to have abstract methods
        abstract class Parent                       // An abstract class is one that cannot be initianted                        
        {
            protected int ProtectedVarInParent;     // can only be accessed from the same class or children classes  
            public int PublicVarInParent;           // can be accessed from anywhere
            private int PrivateVarInParent;         // can be accessed only from inside the class

            public Parent(int PrivateVarInParent)
            {
                this.PrivateVarInParent = PrivateVarInParent;
            }

            public Parent(int ProtectedVarInParent, int PublicVarInParent, int PrivateVarInParent)
            {
                this.ProtectedVarInParent = ProtectedVarInParent;
                this.PublicVarInParent = PublicVarInParent;
                this.PrivateVarInParent = PrivateVarInParent;
            }

            public virtual void DoSomeThingVirtual()
            {
                Console.WriteLine("This was done by the parent virtual function");
            }

            public void DoSomeThingNormal()
            {
                Console.WriteLine("This was done by the parent noral function");
            }

            public abstract void DoSomeThingAbstract();

        }

        class Child : Parent                        // Child inherits Parent - Child - Sub - Derived          
        {
            private int PrivateVarInChild;

            // As we don't have a parameterless constructor in parent, then we *Have To* call the construcor with parameters 
            public Child(int ProtectedVarInParent, int PublicVarInParent, int PrivateVarInParent, int PrivateVarInChild) : base(ProtectedVarInParent, PublicVarInParent, PrivateVarInParent)
            {
                this.PrivateVarInChild = PrivateVarInChild;
            }

            public Child(int PrivateVarInParent, int PrivateVarInChild) : base(PrivateVarInParent)
            {
                this.PrivateVarInChild = PrivateVarInChild;
            }

            public override void DoSomeThingVirtual()
            {
                Console.WriteLine("This was done by the child class");
            }

            public new void DoSomeThingNormal()
            {
                Console.WriteLine("This was done by the child function");
            }

            public override void DoSomeThingAbstract()
            {
                Console.WriteLine("The abstract function definition in child");
            }
        }
    }


}
