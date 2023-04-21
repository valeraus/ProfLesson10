using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    /*
     Реалізуйте шаблон NVI у власній ієрархії наслідування.
     */
    class Program
    {
        static void Main()
        {
            BaseClass instance = new DerivedClass();

            instance.GetWork();
        }
    }
}

