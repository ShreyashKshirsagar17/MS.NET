


using System.Security.Cryptography.X509Certificates;

namespace _01Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //Console.WriteLine("Hello, Shrey..!!");
            #region DataTypes, Read WriteLine, GetType, 
            int x;
            int y;

            Console.WriteLine("Enter the value of x ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x);

            Console.WriteLine("Enter the value of y ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(y);

            

            //it reads the whole line and returns the string value
            Console.WriteLine("Enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine($"your name is {name}");

            int sum = x + y;

            Console.WriteLine($"The value of x is ={x} the value of y is ={y}");
            Console.WriteLine($"Sum of x and y is {sum}");

            Console.WriteLine(x.GetType());
            Console.WriteLine(y.GetType());
            Console.WriteLine(name.GetType());

            // it reads only one character and returns the ascii value of that character 
            Console.WriteLine("Using Read method only");
            Console.WriteLine("Enter any Charater and get ASCI value");
            int ch = Console.Read();
            Console.WriteLine(ch);

            // it reads only one character and returns the ascii value of that character
            Console.WriteLine("This Is Useing ReadKey Method");
            Console.WriteLine("Enter any Key");
            Console.ReadKey();
            Console.WriteLine("Key is Pressed");
            #endregion


            Demo demo = new Demo();

            demo.show();




        }
    }
}
