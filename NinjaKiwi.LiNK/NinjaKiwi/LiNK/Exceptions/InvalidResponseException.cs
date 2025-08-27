namespace NinjaKiwi.LiNK.Exceptions;

public class InvalidResponseException : InternetException
{
	public readonly Exception exception; //Field offset: 0xA0

	public virtual string Message
	{
		 get { } //Length: 141
	}

	public virtual string StackTrace
	{
		 get { } //Length: 45
	}

	public InvalidResponseException(string url, Exception exception) { }

	public virtual string get_Message() { }

	public virtual string get_StackTrace() { }

}

