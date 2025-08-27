namespace Unity.Burst;

public static class BurstRuntime
{
	public class PreserveAttribute : Attribute
	{

		public PreserveAttribute() { }

	}


	[Preserve]
	internal static void Log(Byte* message, int logType, Byte* fileName, int lineNumber) { }

	[Preserve]
	internal static void PreventRequiredAttributeStrip() { }

	[Preserve]
	internal static void RuntimeLog(Byte* message, int logType, Byte* fileName, int lineNumber) { }

}

