namespace Firebase.Platform;

internal interface IFirebaseAppUtils
{

	public PlatformLogLevel GetLogLevel() { }

	public void PollCallbacks() { }

	public void TranslateDllNotFoundException(Action action) { }

}

