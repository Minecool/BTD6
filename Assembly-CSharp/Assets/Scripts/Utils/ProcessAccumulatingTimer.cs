namespace Assets.Scripts.Utils;

public static class ProcessAccumulatingTimer
{
	private static Dictionary<String, Stopwatch> timers; //Field offset: 0x0
	private static Dictionary<String, Int64> ticks; //Field offset: 0x8

	private static ProcessAccumulatingTimer() { }

	public static void End(string id) { }

	public static long Final(string id) { }

	public static long GetTotalTicks(string id) { }

	public static void Start(string id) { }

}

