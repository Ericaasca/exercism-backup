class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int distanceDriven = 0;
    private int battery = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if (battery < batteryDrain)
        {
            return true;
        }
        return false;
    }

    public int DistanceDriven() => distanceDriven;
    public void Drive()
    {
        if (BatteryDrained() != true)
        {
            distanceDriven += speed;
            battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new(50, 4);
}

class RaceTrack(int distance)
{
    private int distance = distance;

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car.BatteryDrained() != true)
        {
            car.Drive();
        }
        if (car.DistanceDriven() >= distance)
        {
            return true;
        }
        return false;
    }
}
