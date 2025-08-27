namespace Firebase.Platform;

internal class FirebaseAppUtilsStub : IFirebaseAppUtils
{
	private static FirebaseAppUtilsStub _instance; //Field offset: 0x0

	public static FirebaseAppUtilsStub Instance
	{
		 get { } //Length: 78
	}

	private static FirebaseAppUtilsStub() { }

	public FirebaseAppUtilsStub() { }

	public static FirebaseAppUtilsStub get_Instance() { }

	public override PlatformLogLevel GetLogLevel() { }

	public override void PollCallbacks() { }

	public override void TranslateDllNotFoundException(Action action) { }

}

