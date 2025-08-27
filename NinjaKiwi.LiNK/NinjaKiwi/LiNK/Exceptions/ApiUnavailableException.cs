namespace NinjaKiwi.LiNK.Exceptions;

public class ApiUnavailableException : NetworkException
{
	internal const string RESPONSE_MESSAGE = "ERR_API_IS_NOT_AVAILABLE"; //Field offset: 0x0
	private const string NOT_AVAILABLE = "Service not available"; //Field offset: 0x0

	public virtual string Message
	{
		 get { } //Length: 44
	}

	public ApiUnavailableException(string url) { }

	public virtual string get_Message() { }

}

