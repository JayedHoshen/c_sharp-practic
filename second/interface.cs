using System;

namespace Interface {
    interface A {
        int Plus(int a, int b);
    }
    interface B {
        int Minus(int c, int d);
    }
    class C: A, B {
        public int add;
        public int Plus(int a, int b) {
            return add = a + b;
        }

        public int sub;
        public int Minus(int c, int d) {
            return sub = c - d;
        }
    }
    class  D {
        static void Main(string[] args) {
            C obj = new C();
            
            obj.Plus(15, 20);
            obj.Minus(50, 25);

            Console.WriteLine("Addition Result: " + obj.add);
            Console.WriteLine("Substraction Result: " + obj.sub);
            Console.ReadKey();
        }
    }
}