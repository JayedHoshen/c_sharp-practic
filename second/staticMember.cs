using System;

namespace varApplication {
    class staticVar {
        public static int num;
        public void count() {
            num++;
        }
        public int getNum() {
            return num;
        }
    }
    class staticTester {
        static void Main(string[] args) {
            staticVar s1 = new staticVar();
            staticVar s2 = new staticVar();

            s1.count();
            s1.count();
            s2.count();
            s2.count();

            Console.WriteLine("Fon s1: {0}", s1.getNum());
            Console.WriteLine("Fon s2: {0}", s2.getNum());
            Console.ReadKey();
        }
    }
}