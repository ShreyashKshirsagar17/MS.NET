namespace _03Demo_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath c = new AdMath();
            c.Add();
            c.Sub();
        }
    }

    #region Inheritance,Virtual & Override, new KeyWord
    public class CMath
    {
        public virtual void Add()
        {
            Console.WriteLine(10 + 20);
        }

        public void Sub()
        {
            Console.WriteLine(50 - 20);
        }
    }

    public class AdMath : CMath
    {
        public override void Add()
        {
            Console.WriteLine(10 * 20);
        }

        public new void Sub()
        {
            Console.WriteLine((50 - 10) * 20);
        }
    }
    #endregion
}
