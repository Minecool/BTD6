namespace NinjaKiwi.LiNK.Exceptions;

public class InvalidSessionException : InternetException
{
	public const string RESPONSE_MESSAGE = "ERR_SESSION_INVALID"; //Field offset: 0x0

	public virtual string Message
	{
		 get { } //Length: 64
	}

	public InvalidSessionException(string url) { }

	public virtual string get_Message() { }

}

