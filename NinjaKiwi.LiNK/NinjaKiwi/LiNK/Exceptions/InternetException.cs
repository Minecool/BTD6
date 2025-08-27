namespace NinjaKiwi.LiNK.Exceptions;

public class InternetException : Exception
{
	internal enum ErrorLevel
	{
		Network = 0,
		InvalidRequest = 1,
		InvalidResponse = 2,
	}

	public string url; //Field offset: 0x90
	[CompilerGenerated]
	private readonly ErrorLevel <Level>k__BackingField; //Field offset: 0x98

	public ErrorLevel Level
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	public InternetException(string url, ErrorLevel level) { }

	[CompilerGenerated]
	public ErrorLevel get_Level() { }

}

