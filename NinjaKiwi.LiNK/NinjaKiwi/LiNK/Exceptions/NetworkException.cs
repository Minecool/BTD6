namespace NinjaKiwi.LiNK.Exceptions;

public class NetworkException : InternetException
{
	public readonly string baseMessage; //Field offset: 0xA0

	public virtual string Message
	{
		 get { } //Length: 97
	}

	public NetworkException(string url, string message) { }

	public virtual string get_Message() { }

}

