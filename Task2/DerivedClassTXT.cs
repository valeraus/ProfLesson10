using System;

namespace Task2
{
    class DerivedClassTXT : BaseClass
    {
        protected override void Read()
        {
            Console.WriteLine("Чтение из файла TXT");
        }

        protected override void Write()
        {
            Console.WriteLine("Запись в файл TXT");
        }
    }
}