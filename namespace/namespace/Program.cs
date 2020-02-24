using System;

namespace first_space {
    class namespace_c1 {
        public void func()
        {
            Console.WriteLine("Inside first space");
        }
    }
}

namespace second_space {
    class namespace_c1 {
        public void func()
        {
            Console.WriteLine("Inside first space");
        }
    }
}



class TestClass
{
    static void Main(string[] args)
    {
        first_space.namespace_c1 fc = new first_space.namespace_c1();
        second_space.namespace_c1 sc = new second_space.namespace_c1();
        fc.func();
        sc.func();
        Console.ReadKey();
    }
}