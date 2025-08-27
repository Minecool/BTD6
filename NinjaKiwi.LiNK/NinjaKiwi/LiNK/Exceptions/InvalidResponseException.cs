namespace NinjaKiwi.LiNK.Exceptions;

public class InvalidResponseException : InternetException
{
	public readonly Exception exception; //Field offset: 0xA0

	public virtual string Message
	{
		 get { } //Length: 71
	}

	public InvalidResponseException(string url, Exception exception) { }

	public virtual string get_Message() { }

}

