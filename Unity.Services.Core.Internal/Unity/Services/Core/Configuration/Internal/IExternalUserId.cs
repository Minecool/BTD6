namespace Unity.Services.Core.Configuration.Internal;

public interface IExternalUserId : IServiceComponent
{

	public string UserId
	{
		 get { } //Length: 0
	}

	public string get_UserId() { }

}

