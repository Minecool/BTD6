namespace Unity.Services.Analytics.Internal;

internal interface IBufferIds
{

	public string InstallId
	{
		 get { } //Length: 0
	}

	public string PlayerId
	{
		 get { } //Length: 0
	}

	public string SessionId
	{
		 get { } //Length: 0
	}

	public string UserId
	{
		 get { } //Length: 0
	}

	public string get_InstallId() { }

	public string get_PlayerId() { }

	public string get_SessionId() { }

	public string get_UserId() { }

}

