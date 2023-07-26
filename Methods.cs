using System;

namespace MyMethods

{
    public static class MyMethodsClass
    {
        public static int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

    }

}