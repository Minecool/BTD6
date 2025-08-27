namespace Assets.Scripts.ContestedTerritory.Api;

public class CtApiFunctionResult : CtApiActionResult
{
	public T result; //Field offset: 0x0

	protected CtApiFunctionResult`1(CtApiActionResult actionResult) { }

	public static CtApiFunctionResult<T> FatalError(string message) { }

	public static CtApiFunctionResult<T> FromException(Exception ex, CtApiErrorAction networkExceptionAction) { }

	public static CtApiFunctionResult<T> IgnorableError(string message) { }

	public static CtApiFunctionResult<T> NonFatalError(string message) { }

	public static CtApiFunctionResult<T> Success(T result) { }

}

