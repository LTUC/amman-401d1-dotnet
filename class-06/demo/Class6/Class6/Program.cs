using System;

namespace Class6
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Parent p = new Parent(8, 5, 1);
            Child c = new Child(9, 5, 1, 2);
            SecondChild sc = new SecondChild();

            //p.DoSomeThingVirtual();
            //c.DoSomeThingVirtual();
            //sc.DoSomeThingVirtual();

            //// The magic begins here ...  (the logic)
            //Parent parentTypeChildInstance = new Child(8, 7, 4, 5);
            //parentTypeChildInstance.DoSomeThingVirtual();

            DoSomething(p);
            DoSomething(c);
            DoSomething(sc);

        }

        static void DoSomething(Parent P)
        {
            P.DoSomeThingVirtual();
        }
    }


    class Parent                                // Parent - Super - Base class                       
    {
        protected int ProtectedVarInParent;     // can only be accessed from the same class or children classes  
        public int PublicVarInParent;           // can be accessed from anywhere
        private int PrivateVarInParent;         // can be accessed only from inside the class

        public Parent(int PrivateVarInParent)
        {
            this.PrivateVarInParent = PrivateVarInParent;
        }

        public Parent(int ProtectedVarInParent, int PublicVarInParent, int PrivateVarInParent) {
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

        public void ThisIsOnlyInFirstChild()
        {
            Console.WriteLine("This is the child's own function");
        }
    }

    class SecondChild : Parent
    {
        public SecondChild() : base(5)
        {

        }

        public override void DoSomeThingVirtual()
        {
            Console.WriteLine("This was done by the second child class");
        }

    }


}
