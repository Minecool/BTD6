namespace Firebase.Platform;

internal sealed class FirebaseEditorDispatcher
{

	private static Type EditorApplicationType
	{
		private get { } //Length: 119
	}

	public static bool EditorIsPlaying
	{
		 get { } //Length: 249
	}

	public static bool EditorIsPlayingOrWillChangePlaymode
	{
		 get { } //Length: 249
	}

	private static void AddRemoveCallbackToField(FieldInfo eventField, Action callback, object target = null, bool add = true, string errorMessage = null) { }

	private static Type get_EditorApplicationType() { }

	public static bool get_EditorIsPlaying() { }

	public static bool get_EditorIsPlayingOrWillChangePlaymode() { }

	public static void ListenToPlayState(bool start = true) { }

	private static void PlayModeStateChanged() { }

	private static void PlayModeStateChangedWithArg(T t) { }

	public static void StartEditorUpdate() { }

	public static void StopEditorUpdate() { }

	public static void Update() { }

}

