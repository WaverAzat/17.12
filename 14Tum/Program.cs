using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace _14Tum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank_Account b = new Bank_Account(123, 1000, Bank_Account.Acc_Type.Сберегательный);
            b.DumpToScreen();//14.1 CW

            System.Reflection.MemberInfo info;//14.2 CW
            info = typeof(RationalDigits);
            object[] attr = info.GetCustomAttributes(false);
            foreach (object o in attr) // получаем информацию из метаданных при помощи Рефлексии
            {
                DeveloperInfoAttribute r = (DeveloperInfoAttribute)o;
                Console.WriteLine("Разработчик: {0}\nДата: {1}", r.Developer, r.Date);
            }

            System.Reflection.MemberInfo info1;//14.1 HW 
            info1 = typeof(Bank_Account);
            object[] attr1 = info1.GetCustomAttributes(false);
            foreach (object o in attr1) // получаем информацию из метаданных при помощи Рефлексии
            {
                DevInfoAttributeForBank r = (DevInfoAttributeForBank)o;
                Console.WriteLine("Разработчик: {0}\nОрганизация: {1}", r.Developer, r.Organization);
            }

            Console.ReadKey();
        }
    }
}
