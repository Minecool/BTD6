namespace NinjaKiwi.LiNK.Lobbies.LatencyMeasurements;

public class LatencyMeasurement
{
	public readonly TimeSpan TimeReceived; //Field offset: 0x10
	public readonly TimeSpan Value; //Field offset: 0x18
	public readonly uint Counter; //Field offset: 0x20
	public bool IsOutlier; //Field offset: 0x24

	public LatencyMeasurement(TimeSpan timeReceived, TimeSpan value, uint counter, bool isOutlier) { }

}

