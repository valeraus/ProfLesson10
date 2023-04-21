using System;

namespace AddTask
{
    class DerivedClass : BaseClass
    {
        protected override void DoWork()
        {
            Console.WriteLine("DervedClass");
        }
    }
}