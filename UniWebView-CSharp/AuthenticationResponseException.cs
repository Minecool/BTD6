//Type is in global namespace

public class AuthenticationResponseException : Exception
{
	public static AuthenticationResponseException UnexpectedAuthCallbackUrl; //Field offset: 0x0
	public static AuthenticationResponseException InvalidState; //Field offset: 0x8
	[CompilerGenerated]
	private readonly int <Code>k__BackingField; //Field offset: 0x90

	public int Code
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	private static AuthenticationResponseException() { }

	public AuthenticationResponseException(int code, string message) { }

	[CompilerGenerated]
	public int get_Code() { }

	public static AuthenticationResponseException InvalidResponse(string query) { }

}

