using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class food
    {
        public abstract void showProduct();      
    }

    class fruits: food
    {
        string name;
        int price;

        public fruits ( string _name, int _price)
        {
            name = _name;
            price = _price;
        }

        public override void showProduct()
        {
            Console.WriteLine("Cena wynosi: " + price + "zl" + " a nazwa to: " + name);
        }

    }

    class vegetable: food
    {
        string name;
        int price;

        public vegetable(string _name, int _price)
        {
            name = _name;
            price = _price;
        }

        public override void showProduct()
        {
            Console.WriteLine("Cena wynosi: " + price + "zl" + " a nazwa to: " + name);
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            fruits produkt1 = new fruits("Banan", 5);
            fruits produkt2 = new fruits("Truskawka", 2);
            fruits produkt3 = new fruits("pomarancza", 4);
            fruits produkt4 = new fruits("kiwi", 7);

            vegetable produkt5 = new vegetable("ziemniak", 4);
            vegetable produkt6 = new vegetable("marchewka", 2);
            vegetable produkt7 = new vegetable("cebula", 3);

            food[] jedzenie = new food[7];

            jedzenie[0] = produkt1;
            jedzenie[1] = produkt2;
            jedzenie[2] = produkt3;
            jedzenie[3] = produkt4;
            jedzenie[4] = produkt5;
            jedzenie[5] = produkt6;
            jedzenie[6] = produkt7;

            for(int i = 0; i<=jedzenie.Length-1; i++)
            {
                jedzenie[i].showProduct();
            }
            Console.ReadKey();
        }
    }
}