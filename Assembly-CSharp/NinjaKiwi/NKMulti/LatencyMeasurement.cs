namespace NinjaKiwi.NKMulti;

public class LatencyMeasurement
{
	public readonly uint Counter; //Field offset: 0x10
	public readonly bool IsDelayed; //Field offset: 0x14
	private readonly Task<TimeSpan> Task; //Field offset: 0x18

	public TimeSpan Result
	{
		 get { } //Length: 68
	}

	public bool Success
	{
		 get { } //Length: 36
	}

	public LatencyMeasurement(Task<TimeSpan> task, uint counter, bool isDelayed) { }

	public TimeSpan get_Result() { }

	public bool get_Success() { }

}

