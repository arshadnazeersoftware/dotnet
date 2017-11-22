using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(123 is String)
            Console.WriteLine(String.Format("Hello to my World.","Hello") as String);
            else
            {
                Console.WriteLine("if not printed");
            }
            Mammal z = returnZebra();
        z.drink();
         eat(new Zebra());
        }
        public void eat(Mammal m)
    {
        System.Console.WriteLine("Eat");
    }

    public Zebra returnZebra()
    {
        return new Zebra();
    }
    }

    public class Mammal
    {
public virtual void drink()
{
System.Console.WriteLine("drink");
}
    }

    public class Zebra : Mammal
    {
       
        
        public override void drink()
        {
        System.Console.WriteLine("drink zebra");
        }
        
    }


    
}
