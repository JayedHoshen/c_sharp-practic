using System;

public class Cricket {
    public int a;
    public string b;
    public string c;
    public Cricket (int d, string e, string f) {
        a = d;
        b = e;
        c = f;
    }
    public void Show() {
        Console.WriteLine(a + " " + b + " " + c);
    }
}

class Footbal {
    public static void Main(string[] args) {
        Cricket obj1 = new Cricket(52, "Mushfiqur Rahim", "\tBogura District");
        Cricket obj2 = new Cricket(53, "Nasir Hossain", "\tRangpur District");
        obj1.Show();
        obj2.Show();
        Console.ReadKey();
    }
}