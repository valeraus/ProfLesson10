using System;

namespace AddTask
{
    class BaseClass
    {
        protected virtual void DoWork()
        {
            Console.WriteLine("BaseClass");
        }

        public void GetWork()
        {
            DoWork();
        }
    }
}