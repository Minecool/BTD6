namespace Firebase;

internal class ExceptionAggregator
{
	[ThreadStatic]
	private static List<Exception> threadLocalExceptions; //Field offset: 0x80000000

	private static List<Exception> Exceptions
	{
		private get { } //Length: 224
	}

	private static ExceptionAggregator() { }

	private static List<Exception> get_Exceptions() { }

	public static Exception GetAndClearPendingExceptions() { }

	public static Exception LogException(Exception exception) { }

	public static void ThrowAndClearPendingExceptions() { }

	public static void Wrap(Action action) { }

}

