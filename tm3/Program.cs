using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tum13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank_Account bank_Account = new Bank_Account();
            bank_Account.Add(100);
            bank_Account.Add(1000);
            bank_Account.Lower(200);
            Console.WriteLine(bank_Account[0].ToString());

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("HW 13.1");
            Bank_Account bank_Account1 = new Bank_Account();
            bank_Account1.Type = Bank_Account.Acc_Type.Сберегательный;
            bank_Account1.ID = 123;
            bank_Account1.Owner = "Ilya";
            bank_Account1.Print();

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("HW 13.2");
            BuildingContainer bc = new BuildingContainer(new[]
            {
                new Buiding(1,100,5,10,2),
                new Buiding(2,1000,10,20,3),
                new Buiding(3,200,6,30,4),
                new Buiding(4,250,7,40,5),
                new Buiding(5,300,12,50,6),
                new Buiding(6,500,11,60,7),
                new Buiding(7,600,580,70,7),
                new Buiding(8,666,40,80,9),
                new Buiding(9,123,13,90,10),
                new Buiding(10,420,333,100,12),
            });
            Console.WriteLine("Enter index");
            int index = int.Parse(Console.ReadLine());
            if (index < 0 || index > 9)
            {
                throw new IndexOutOfRangeException();
            }
            bc[index].Print();
            Console.ReadKey();
        }
    }
}