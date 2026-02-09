class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double chance = 0.0;
        switch (speed)
        {
            case 0:
                chance = 0.0;
                return chance;
            case int n when n >= 1 && n <= 4:
                chance = 1.0;
                return chance;
            case int n when n >= 5 && n <= 8:
                chance = 0.90;
                return chance;
            case 9:
                chance = 0.8;
                return chance;
            case 10:
                chance = 0.77;
                return chance;
        }
        return chance;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double rate = SuccessRate(speed);
        int baseProduceRate = 221;
        double result = baseProduceRate * speed * rate;
        return result;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double carsPerHour = ProductionRatePerHour(speed);
        int carsPerMinute = (int)carsPerHour / 60;
        return carsPerMinute;
    }
}
