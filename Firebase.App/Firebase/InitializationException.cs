namespace Firebase;

public sealed class InitializationException : Exception
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private InitResult <InitResult>k__BackingField; //Field offset: 0x90

	private InitResult InitResult
	{
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public InitializationException(InitResult result, string message) { }

	public InitializationException(InitResult result, string message, Exception inner) { }

	[CompilerGenerated]
	private void set_InitResult(InitResult value) { }

}

