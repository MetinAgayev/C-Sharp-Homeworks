using System;
using System.Collections.Generic;
using System.Text;

namespace CashMachine.Model
{
    class CashRegister
    {

        public double TotalAmount { get; set; }
        public  Currency Currency { get; set; }
        public int TotalSalesCount;
        public string PaymentType { get; set; }
        public CashRegister(double totalamount)
        {
            TotalSalesCount++;
            TotalAmount = totalamount;
            
        }
  public void AddNewSale(double value,Currency currency)
        {
            if (currency == Currency)
            {
                TotalAmount += value;
            }
            else
            {
                switch (Currency)
                {
                    case Currency.Sterling:
                        TotalAmount = value * 2;
                        break;
                    case Currency.Dollar:
                        TotalAmount += value * 1.7;


                        break;
                    default:

                        break;
                }
            }
        }

        public override string ToString()
        {
            return $" {TotalAmount}";
            
        }

    }
 
}
