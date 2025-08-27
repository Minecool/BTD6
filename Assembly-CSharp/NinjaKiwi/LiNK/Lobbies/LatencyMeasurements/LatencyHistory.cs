namespace NinjaKiwi.LiNK.Lobbies.LatencyMeasurements;

public class LatencyHistory : IEnumerable<LatencyMeasurement>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<LatencyMeasurement, Boolean> <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_NonOutliers>b__8_0(LatencyMeasurement m) { }

	}

	private readonly int MaxLength; //Field offset: 0x10
	private readonly Queue<LatencyMeasurement> Queue; //Field offset: 0x18

	public int Count
	{
		 get { } //Length: 60
	}

	public IEnumerable<LatencyMeasurement> NonOutliers
	{
		 get { } //Length: 247
	}

	public LatencyHistory(int maxLength) { }

	public void Add(LatencyMeasurement m) { }

	public void Clear() { }

	public int get_Count() { }

	public IEnumerable<LatencyMeasurement> get_NonOutliers() { }

	public override IEnumerator<LatencyMeasurement> GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

