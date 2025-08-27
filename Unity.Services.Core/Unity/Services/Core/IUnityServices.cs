namespace Unity.Services.Core;

public interface IUnityServices
{

	public ServicesInitializationState State
	{
		 get { } //Length: 0
	}

	public ServicesInitializationState get_State() { }

	public Task InitializeAsync(InitializationOptions options = null) { }

}

