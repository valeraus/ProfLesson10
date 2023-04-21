namespace Task2
{
    abstract class BaseClass
    {
        protected abstract void Read();
        protected abstract void Write();

        public void ReadWrite()
        {
            Read();
            Write();
        }
    }
}