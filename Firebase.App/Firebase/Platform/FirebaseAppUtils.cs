namespace Firebase.Platform;

internal class FirebaseAppUtils : IFirebaseAppUtils
{
	private static FirebaseAppUtils instance; //Field offset: 0x0

	public static FirebaseAppUtils Instance
	{
		 get { } //Length: 78
	}

	private static FirebaseAppUtils() { }

	public FirebaseAppUtils() { }

	public static FirebaseAppUtils get_Instance() { }

	public override PlatformLogLevel GetLogLevel() { }

	public override void PollCallbacks() { }

	public override void TranslateDllNotFoundException(Action action) { }

}

