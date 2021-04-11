using System;

namespace wzorzec4
{
    abstract class AbstractClass
    {
        public void TworzenieAlbumu()
        {
            this.Sticker();
            this.WeavingKit();
            this.Poster();
            this.MiniCard();
            this.Album1();
            this.Album2();
            this.Album3();
            this.p1();
            this.p2();
        }

        protected void Sticker()
        {
            Console.WriteLine("Jest naklejka");
        }

        protected void Poster()
        {
            Console.WriteLine("Jest plakacik");
        }

        protected void WeavingKit()
        {
            Console.WriteLine("Jest Weaving Kit");
        }

        protected void MiniCard()
        {
            Console.WriteLine("Jest mini karta");
        }

        protected abstract void Album1();

        protected abstract void Album2();

        protected abstract void Album3();

        protected virtual void p1() { }

        protected virtual void p2() { }
    }

    class Kl1 : AbstractClass
    {
        protected override void Album1()
        {
            Console.WriteLine("Do Albumu1");
        }

        protected override void Album2()
        {
            Console.WriteLine("Do albumu2");
        }

        protected override void Album3()
        {
            Console.WriteLine("Do albumu3");
        }

    }

    class Kl2 : AbstractClass
    {
        protected override void Album1()
        {
            Console.WriteLine("Do albumu1");
        }

        protected override void Album2()
        {
            Console.WriteLine("Do albumu2");
        }

        protected override void Album3()
        {
            Console.WriteLine("Do albumu3");
        }

        protected override void p1()
        {
            Console.WriteLine("1");
        }

    }

    class kl3 : AbstractClass
    {
        protected override void Album1()
        {
            Console.WriteLine("Do albumu1");
        }

        protected override void Album2()
        {
            Console.WriteLine("Do Albumu2");
        }

        protected override void Album3()
        {
            Console.WriteLine("Do albumu3");
        }

        protected override void p2()
        {
            Console.WriteLine("2");
        }
    }

    class Klient
    {

        public static void MojeTworzywo(AbstractClass abstractClass)
        {
            abstractClass.TworzenieAlbumu();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1:");
            Console.Write("\n");
            Klient.MojeTworzywo(new Kl1());
            Console.Write("\n");
            Console.WriteLine("2:");
            Console.Write("\n");
            Klient.MojeTworzywo(new Kl2());
            Console.Write("\n");
            Console.WriteLine("3:");
            Console.Write("\n");
            Klient.MojeTworzywo(new kl3());
        }
    }
}