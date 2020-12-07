using System;

class class1 {
    static void Main(string[] args) {
        sealedClass sealedC1 = new sealedClass();
        int total = sealedC1 Add(4, 5);
        Console.WriteLine("Total = ", total.ToString());
    }
}

sealed class sealedClass {
    public int Add(int x, int y) {
        return x + y;
    }
}