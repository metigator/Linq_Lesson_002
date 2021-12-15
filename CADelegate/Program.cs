using System;

namespace CADelegate
{
    //delegate void MDelegate();
    //Action, Func, Pred
    internal class Program
    {
        static void Main(string[] args)
        {
            // M2(M1);

            Action action = M1;
            M2(action);
            Console.ReadKey();
        }

        static void M1()
        {
            Console.WriteLine("M1");
        }

        static void M2(Action action)
        {
            action();
            Console.WriteLine("M2");
        }
    }


}
