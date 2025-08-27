namespace Unity.Services.Analytics;

public class ConsentCheckException : RequestFailedException
{
	[CompilerGenerated]
	private ConsentCheckExceptionReason <Reason>k__BackingField; //Field offset: 0x98

	[Preserve]
	public private ConsentCheckExceptionReason Reason
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public ConsentCheckException(ConsentCheckExceptionReason reason, int errorCode, string message, Exception innerException) { }

	[CompilerGenerated]
	public ConsentCheckExceptionReason get_Reason() { }

	[CompilerGenerated]
	private void set_Reason(ConsentCheckExceptionReason value) { }

}

