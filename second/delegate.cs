using System;

public delegate int Nchanger (int x);

namespace  DelegateApplication {
    class FirstDelegate {
        static int num = 10;
        public static int AddNum (int p) {
            num += p;
            return num;
        }
        public static int MultNum (int q) {
            num *= q;
            return num;
        }
        public static int getNum() {
            return num;
        }
        public static void Main(string[] args) {
            Nchanger nc1 = new Nchanger(AddNum);
            Nchanger nc2 = new Nchanger(MultNum);
            nc1(25);
            Console.WriteLine("Value of Num {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num {0}", getNum());
            Console.ReadKey();
        }
    }
}