using System;

namespace democomposite
{
    class Program
    {
        static void Main(string[] args)
        {
            File f = new File();
            f.Show();

            f =new File("test.txt",150);
            f.Show();

            Directory d =new Directory("C");
            System.Console.WriteLine("----------------------------");
            d.Show();
            d.AddChild(f);
            System.Console.WriteLine("----------------------------");
            d.Show();

            Directory d2 =new Directory("Documents");
            d2.AddChild(new File("test2.txt",200));
            d2.AddChild(new File("test2.txt",250));
            d2.AddChild(new Directory());

            d.AddChild(d2);
        }
    }
}
