﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BankAccount
/// </summary>
public class BankAccount
{
    protected static double initialBalance;
    protected double deposit;
    protected double withdrawal;
    protected double availableBalance;
    protected double overdraft;
    protected double overdraftLimit = 200;

    public BankAccount(double balance)
    {
        initialBalance = balance;
    }

    public void setDeposit(double amount)
    {
        initialBalance += amount;
        deposit += amount;
    }

    public double getDeposit()
    {
        return deposit;
    }

    public void setWithdraw(double amount)
    {
        initialBalance -= amount;
        withdrawal += amount;
    }

    public double getWithdraw()
    {
        return withdrawal;
    }

    public double getBalance()
    {
        return initialBalance;
    }

    public double getOverdraft() {
    
        return overdraft;
    }

    public double getAvailableBalance() {

        return initialBalance + overdraftLimit;
    }
}