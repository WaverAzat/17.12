using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Tum
{
    [DevInfoAttributeForBank("Azat Saifullin", Organization = "KFU")] //14.1 HW
    public class Bank_Account
    {
        private string owner;
        private byte id;
        private decimal Balance { get; set; }
        public enum Acc_Type : byte
        {
            Сберегательный,
            Накопительный
        }
        private Acc_Type type;
        public byte ID
        {
            get => id;
            set => id = value;
        }
        public Acc_Type Type
        {
            get => type;
            set => type = value;
        }
        public string Owner
        {
            get => owner;
            set => owner = value;
        }
        public Bank_Account() { }
        public Bank_Account(byte iD, decimal balance, Acc_Type type)
        {
            ID = iD;
            Balance = balance;
            Type = type;
        }
        [Conditional("DEBUG_ACCOUNT")] //14.1 CW
        public void DumpToScreen()
        {
            Console.WriteLine($"{Owner}\n{ID}\n{Balance}\n{Type}");
        }
        public void Print() => Console.WriteLine($"Id: {ID}\nBalace: {Balance}\nType: {Type}");
        public void Add(decimal cash)
        {
            Balance += cash;
            Console.WriteLine($"Done! Balance: {Balance}");
        }
        public void Lower(decimal cash)
        {
            if (Balance > 0)
            {
                if (Balance - cash > 0)
                {
                    Balance -= cash;
                    Console.WriteLine($"Done! Balance: {Balance}");
                }
                else
                {
                    Console.WriteLine($"Not enougth money! Balance: {Balance}");
                }
            }
            else
            {
                Console.WriteLine("Something is wrong!");
            }
        }
        public void Transition(Bank_Account acc1, decimal perevod)
        {
            if (acc1.Balance > perevod)
            {
                acc1.Balance -= perevod;
                Balance += perevod;
            }
            else
            {
                Console.WriteLine("Not enought money");
            }
        }

    }
}