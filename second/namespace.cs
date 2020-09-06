using System;

namespace first_space {
    class namespace_c1 {
        public void func() {
            Console.WriteLine("Inside first-space");
        }
    }
    class namespace_c2 {
        public void func() {
            Console.WriteLine("Inside first-space second class");
        }
    }
}

namespace second_space {
    class namespace_c1 {
        public void func() {
            Console.WriteLine("Inside second-space");
        }
    }
}

class TestClass {
    static void Main(string[] args) {
        first_space.namespace_c1 fc = new first_space.namespace_c1();
        first_space.namespace_c2 fsc = new first_space.namespace_c2();
        second_space.namespace_c1 sc = new second_space.namespace_c1();

        fc.func();
        fsc.func();
        sc.func();

        Console.WriteLine("The main method");
        Console.ReadKey();
    }
}