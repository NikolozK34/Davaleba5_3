using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davaleba5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.SetName("Nikora");
            shop.SetAddress("Rustaveli N1");
            shop.SetDescription("Marketi");
            shop.SetNumber("555555555");
            shop.SetEmail("Nikora@nikora.ge");
            shop.ShowShop1();
        }
    }
}
