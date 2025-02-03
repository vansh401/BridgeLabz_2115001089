using System;

public class DifferentTimeZones{
	public static void Main(String[] args){
		DateTimeOffset utcNow=DateTimeOffset.UtcNow;
		TimeZoneInfo istZone=TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
		TimeZoneInfo pstZone=TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
		
		DateTimeOffset istTime=TimeZoneInfo.ConvertTime(utcNow,istZone);
		DateTimeOffset pstTime=TimeZoneInfo.ConvertTime(utcNow,pstZone);
		
		Console.WriteLine("Current Time in GMT: " + utcNow);
        Console.WriteLine("Current Time in IST: " + istTime);
        Console.WriteLine("Current Time in PST: " + pstTime);
	}
}