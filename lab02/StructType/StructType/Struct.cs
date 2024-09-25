﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructType
{
    public enum AccountType { Checking, Deposit }
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }
    internal class Struct
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount goldAccount;
                goldAccount.accType = AccountType.Checking;
                goldAccount.accBal = (decimal)3200.00;
                Console.Write("Enter account number: ");
                goldAccount.accNo = long.Parse(Console.ReadLine());

                Console.WriteLine("*** Account Summary ***");
                Console.WriteLine("Acct Number {0}", goldAccount.accNo);
                Console.WriteLine("Acct Type {0}", goldAccount.accType);
                Console.WriteLine("Acct Ballance {0}", goldAccount.accBal);
            }
            catch (Exception e){
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }
        }
    }
}
