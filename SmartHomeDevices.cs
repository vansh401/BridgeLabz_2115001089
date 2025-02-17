using System;

class Device
{
    public string DeviceId { get; set; }
    public string Status { get; set; }

    public Device(string deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }

    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device Information:");
        Console.WriteLine("Device ID: " + DeviceId);
        Console.WriteLine("Status: " + Status);
    }
}

class Thermostat : Device
{
    public int TemperatureSetting { get; set; }

    public Thermostat(string deviceId, string status, int temperatureSetting)
        : base(deviceId, status)
    {
        TemperatureSetting = temperatureSetting;
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine("Temperature Setting: " + TemperatureSetting + "°C");
    }
}

class SmartHomeDevices
{
    static void Main()
    {
        Thermostat thermostat = new Thermostat("T123", "Online", 22);
        thermostat.DisplayStatus();
    }
}
