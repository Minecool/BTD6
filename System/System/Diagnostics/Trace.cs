namespace System.Diagnostics;

public sealed class Trace
{
	private static CorrelationManager correlationManager; //Field offset: 0x0

	public static CorrelationManager CorrelationManager
	{
		 get { } //Length: 151
	}

	public static CorrelationManager get_CorrelationManager() { }

	[Conditional("TRACE")]
	public static void TraceInformation(string message) { }

}

