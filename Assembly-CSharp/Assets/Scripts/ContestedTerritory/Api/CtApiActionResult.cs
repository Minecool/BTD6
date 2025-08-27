namespace Assets.Scripts.ContestedTerritory.Api;

public class CtApiActionResult
{
	public bool isSuccess; //Field offset: 0x10
	public CtApiErrorAction errorAction; //Field offset: 0x14
	public string message; //Field offset: 0x18
	public Exception exception; //Field offset: 0x20

	protected CtApiActionResult() { }

	public static CtApiActionResult FatalError(string message) { }

	public static CtApiActionResult FromException(Exception ex, CtApiErrorAction networkExceptionAction) { }

	public static CtApiActionResult IgnorableError(string message) { }

	private static void LogError(object message) { }

	public static CtApiActionResult NonFatalError(string message) { }

	public static CtApiActionResult Success() { }

}

