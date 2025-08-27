namespace NinjaKiwi.LiNK.Exceptions;

public class NotFoundException : InternetException
{
	private readonly int statusCode; //Field offset: 0xA0

	public virtual string Message
	{
		 get { } //Length: 107
	}

	public NotFoundException(string url, int statusCode) { }

	public virtual string get_Message() { }

}

