using System;

public class RemoteControlCar
{
    int _speed;
    int _batteryDrain;
    int _distanceDriven;
    int _battery;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
        _battery = 100;
        _distanceDriven = 0;
    }
    public bool BatteryDrained()
    {
        if (_battery < _batteryDrain)
            return true;

        return false;
    }

    public int DistanceDriven()
    {
        return _distanceDriven;
    }

    public void Drive()
    {
        if (_battery < _batteryDrain)
            return;

        _distanceDriven += _speed;
        _battery -= _batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

public class RaceTrack
{
    int _distance;

    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool CarCanFinish(RemoteControlCar car)
    {
        do
        {
            if (car.BatteryDrained())
                return false;

            car.Drive();


        } while (car.DistanceDriven() < _distance);

        return true;
    }
}
