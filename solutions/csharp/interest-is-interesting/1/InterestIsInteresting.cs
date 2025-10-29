static class SavingsAccount
{
    public static float InterestRate(decimal balance) =>
    balance switch
    {
        decimal n when n < 0 => 3.213f,
        decimal n when n >= 0 && n < 1000 => 0.5f,
        decimal n when n >= 1000 && n < 5000 => 1.621f,
        decimal n when n >= 5000 => 2.475f,
        _ => 0
    };

    public static decimal Interest(decimal balance) =>  balance * (decimal) InterestRate(balance) /100;

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years += 1;
        }
        return years;
    }
}
