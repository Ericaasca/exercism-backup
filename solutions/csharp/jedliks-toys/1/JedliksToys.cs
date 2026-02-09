class RemoteControlCar
{
    private int DistanceDriven;
    private int BatteryPercentage = 100;
    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() => $"Driven {DistanceDriven} meters";

    public string BatteryDisplay()
    {
        if (BatteryPercentage == 0)
        {
            return "Battery empty";
        }
        return $"Battery at {BatteryPercentage}%";
    } 

    public void Drive()
    {
        if (BatteryPercentage == 0)
        {
            BatteryDisplay();
        }
        else
        {
            DistanceDriven += 20;
            BatteryPercentage -= 1;
        }
    }
}
