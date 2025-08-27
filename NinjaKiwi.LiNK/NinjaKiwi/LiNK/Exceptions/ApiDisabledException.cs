namespace NinjaKiwi.LiNK.Exceptions;

public class ApiDisabledException : NetworkException
{
	private const string disabled = "LiNK SDK is disabled"; //Field offset: 0x0

	public virtual string Message
	{
		 get { } //Length: 44
	}

	public ApiDisabledException(string url) { }

	public virtual string get_Message() { }

}

