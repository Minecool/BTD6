namespace NinjaKiwi.Common;

public static class TimeUtil
{

	public static bool IsUsingServerTime
	{
		 get { } //Length: 138
	}

	public static DateTime OfflineTime
	{
		 get { } //Length: 125
	}

	public static DateTime OnlineTime
	{
		 get { } //Length: 125
	}

	public static DateTime ConvertFromUnixTimestamp(double timestamp) { }

	public static bool get_IsUsingServerTime() { }

	public static DateTime get_OfflineTime() { }

	public static DateTime get_OnlineTime() { }

	public static TimeSpan TimeRemainingOffline(DateTime endTime) { }

	public static TimeSpan TimeRemainingOnline(DateTime endTime) { }

	public static TimeSpan ToUnixTimespan(DateTime time) { }

}

