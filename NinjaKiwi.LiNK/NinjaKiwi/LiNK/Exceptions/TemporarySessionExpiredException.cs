namespace NinjaKiwi.LiNK.Exceptions;

public class TemporarySessionExpiredException : InternetException
{
	internal const string RESPONSE_MESSAGE = "XXXXXXXXXXXXXXXXXXXXXXXXX"; //Field offset: 0x0

	public virtual string Message
	{
		 get { } //Length: 64
	}

	public TemporarySessionExpiredException(string url) { }

	public virtual string get_Message() { }

}

