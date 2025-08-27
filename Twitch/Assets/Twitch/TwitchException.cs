namespace Assets.Twitch;

public class TwitchException : Exception
{
	public string displayMessage; //Field offset: 0x90

	public TwitchException(string displayMessage) { }

	public TwitchException(int errorCode) { }

	public TwitchException(int errorCode, string message) { }

	public TwitchException(int errorCode, string message, Exception innerException) { }

	public TwitchException(string displayMessage, string message, Exception innerException) { }

}

