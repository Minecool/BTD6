namespace Assets.Scripts.Unity;

[Extension]
public static class ServerEventExtensions
{

	private static DateTime Now
	{
		private get { } //Length: 7
	}

	private static DateTime get_Now() { }

	[Extension]
	public static bool IsActive(T serverEvent) { }

	[Extension]
	public static bool IsActive(T serverEvent, DateTime currentDate) { }

	[Extension]
	public static bool IsEnded(T serverEvent, DateTime currentDate, TimeSpan cooldown = null) { }

	[Extension]
	public static bool IsEndingWithin(ServerEvent<T> serverEvent, TimeSpan within) { }

	[Extension]
	public static bool IsValid(HeroSaleEvent heroSaleEvent) { }

}

