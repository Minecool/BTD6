namespace NinjaKiwi.NKMulti;

public class LatencyReportMessage : Message
{
	public const string CODE = "ECHR"; //Field offset: 0x0
	public readonly long Latency; //Field offset: 0x20

	public LatencyReportMessage(Byte[] data) { }

	public LatencyReportMessage(long latency) { }

	private static Byte[] CreateBytes(long latency) { }

}

