using System;

class RemoteControlCar
{
    int distanceDriven = 0;
    int battery = 100;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return @$"Driven {distanceDriven} meters";
    }

    public string BatteryDisplay()
    {       
        return battery > 0 ? @$"Battery at {battery}%" : "Battery empty";
    }

    public void Drive()
    {
       if (battery > 0)
       {
            distanceDriven += 20;
            battery -= 1;
       }
    }
}
