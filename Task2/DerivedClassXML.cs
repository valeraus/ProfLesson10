using System;

namespace Task2
{
    class DerivedClassXML : BaseClass
    {
        protected override void Read()
        {
            Console.WriteLine("Чтение из файла XML");
        }

        protected override void Write()
        {
            Console.WriteLine("Запись в файл XML");
        }
    }
}