using System;
using Fahad=StaticWebsite.StaticNested;

namespace NameSpaces.cs
{
    class Program
    {
        static void Main(string[] args)
        {
           Fahad. A.StaticFunction();
        }
    }
}

namespace StaticWebsite
{
    namespace StaticNested
    {
 

        class A
        {
            public static void StaticFunction()
            {
                Console.WriteLine("Here it is StaticFunction");
            }
        }
    }
}