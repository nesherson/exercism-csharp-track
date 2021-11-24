using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0)
            return 3.213f;
        else if (balance < 1000)
            return 0.5f;
        else if (balance >= 1000 && balance < 5000)
            return 1.621f;
        else
            return 2.475f;
    }

    public static decimal Interest(decimal balance)
    {
        return balance * Convert.ToDecimal(InterestRate(balance) / 100);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        decimal tempBalance = balance;
        int yearsRequired = 0;

        while (tempBalance < targetBalance)
        {
            tempBalance += Interest(tempBalance);
            yearsRequired++;
        }

        return yearsRequired;
    }
}
