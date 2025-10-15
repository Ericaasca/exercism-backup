class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        return speed switch
        {
            0 => 0.0,
            int n when n >= 1 && n <= 4 => 1.0,
            int n when n >= 5 && n <= 8 => 0.90,
            9 => 0.8,
            10 => 0.77,
            _ => 0.0,
        };
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
