namespace NinjaKiwi.GUTS.Extensions;

[Extension]
public static class DateTimeExtensions
{
	public static readonly DateTime kUnixEpoch; //Field offset: 0x0

	private static DateTimeExtensions() { }

	[Extension]
	public static DateTime GetStartOfWeek(DateTime date, DayOfWeek firstDayOfTheWeek = 1) { }

	[Extension]
	private static TimeSpan GetTimeSinceUnixEpoch(DateTime date) { }

	[Extension]
	public static double ToUnixTimeDays(DateTime date) { }

	[Extension]
	public static double ToUnixTimeHours(DateTime date) { }

	[Extension]
	public static long ToUnixTimeMilliseconds(DateTime date) { }

	[Extension]
	public static double ToUnixTimeMillisecondsDouble(DateTime date) { }

	[Extension]
	public static double ToUnixTimeMinutes(DateTime date) { }

	[Extension]
	public static long ToUnixTimeSeconds(DateTime date) { }

	[Extension]
	public static double ToUnixTimeSecondsDouble(DateTime date) { }

}

