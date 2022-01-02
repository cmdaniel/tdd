namespace FizzBuzz
{
    internal class NumberGenerator : AbsElementGenerator
    {
        public override string GetElement(int i)
        {
            return i.ToString();
        }
    }
}