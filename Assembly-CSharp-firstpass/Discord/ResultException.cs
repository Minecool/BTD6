namespace Discord;

public class ResultException : Exception
{
	public readonly Result Result; //Field offset: 0x90

	public ResultException(Result result) { }

}

