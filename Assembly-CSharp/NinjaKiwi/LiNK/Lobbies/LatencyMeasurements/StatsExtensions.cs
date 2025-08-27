namespace NinjaKiwi.LiNK.Lobbies.LatencyMeasurements;

[Extension]
public static class StatsExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<LatencyMeasurement, TimeSpan> <>9__0_0; //Field offset: 0x8
		public static Func<TimeSpan, Int64> <>9__1_0; //Field offset: 0x10
		public static Func<DateTime, Int64> <>9__2_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal TimeSpan <Quartiles>b__0_0(LatencyMeasurement m) { }

		internal long <Quartiles>b__1_0(TimeSpan ts) { }

		internal long <Quartiles>b__2_0(DateTime dt) { }

	}


	[Extension]
	public static Quartiles<TimeSpan> Quartiles(IEnumerable<LatencyMeasurement> measurements) { }

	[Extension]
	public static Quartiles<TimeSpan> Quartiles(IEnumerable<TimeSpan> timeSpans) { }

	[Extension]
	public static Quartiles<DateTime> Quartiles(IEnumerable<DateTime> dateTimes) { }

	[Extension]
	public static Quartiles<Int64> Quartiles(IEnumerable<Int64> longs) { }

}

