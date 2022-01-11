using CashMachine.Model;
using System;

namespace CashMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cashRegister = new CashRegister(1000);
            cashRegister.AddNewSale(150, Currency.Azn, PaymentType.Kart);
            Console.WriteLine(cashRegister.TotalAmount);
            cashRegister.AddNewSale(150, Currency.Azn, PaymentType.Kart);
            Console.WriteLine(cashRegister.TotalAmount);
            cashRegister.AddNewSale(150, Currency.Azn, PaymentType.Kart);
            Console.WriteLine(cashRegister.TotalAmount);
            cashRegister.AddNewSale(150, Currency.Azn, PaymentType.Kart);
            Console.WriteLine(cashRegister.TotalAmount);
            cashRegister.AddNewSale(150, Currency.Azn, PaymentType.Kart);
            Console.WriteLine(cashRegister.TotalAmount);
            cashRegister.AddNewSale(150, Currency.Azn, PaymentType.Kart);
            Console.WriteLine(cashRegister.TotalAmount);
            cashRegister.AddNewSale(150, Currency.Azn, PaymentType.Kart);
            Console.WriteLine(cashRegister.TotalAmount);
            Console.Write("Satislar silindikden sonra son netice:");
            cashRegister.RemoveSale(100, Currency.Azn);
            Console.WriteLine(cashRegister.TotalAmount);
            Console.Write("Emeliiyyatlarin sayi:");
            Console.WriteLine(cashRegister.TotalSalesCount);
        }
    }
}