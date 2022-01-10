using CashMachine.Model;
using System;

namespace CashMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cashRegister = new CashRegister(1000);
            Console.WriteLine(cashRegister);
        cashRegister.AddNewSale(150, Currency.Sterling);
            Console.WriteLine(cashRegister.TotalAmount);
        }
    }
}
