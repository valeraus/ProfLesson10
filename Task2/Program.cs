using System.Collections.Generic;

namespace Task2
{
    /*
    Вивчіть опис шаблону Template method (Шаблонний метод). 
    Зверніть увагу на застосування шаблону, а також на склад його учасників і зв’язки між ними. 
    Напишіть невелику програму мовою C#, яка представлятиме собою абстрактну реалізацію цього шаблону.
     */
    class Program
    {
        static void Main()
        {
            List<BaseClass> collection = new List<BaseClass> { new DerivedClassTXT(), new DerivedClassXML() };

            foreach (var item in collection)
            {
                item.ReadWrite();
            }
        }
    }
}
