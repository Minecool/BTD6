namespace NinjaKiwi.LiNK.Exceptions;

public class SquadException : InternetException
{
	public readonly string reason; //Field offset: 0xA0

	public virtual string Message
	{
		 get { } //Length: 97
	}

	public SquadException(string url, string reason) { }

	public virtual string get_Message() { }

}

