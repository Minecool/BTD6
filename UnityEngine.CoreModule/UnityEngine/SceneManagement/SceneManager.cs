namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
[RequiredByNativeCode]
public class SceneManager
{
	internal static bool s_AllowLoadScene; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static UnityAction<Scene> sceneUnloaded; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static UnityAction<Scene, Scene> activeSceneChanged; //Field offset: 0x18

	public static event UnityAction<Scene, LoadSceneMode> sceneLoaded
	{
		[CompilerGenerated]
		 add { } //Length: 261
		[CompilerGenerated]
		 remove { } //Length: 261
	}

	public static event UnityAction<Scene> sceneUnloaded
	{
		[CompilerGenerated]
		 add { } //Length: 261
		[CompilerGenerated]
		 remove { } //Length: 261
	}

	public static int sceneCount
	{
		[NativeHeader("Runtime/SceneManager/SceneManager.h")]
		[NativeMethod("GetSceneCount")]
		[StaticAccessor("GetSceneManager()", StaticAccessorType::Dot (0))]
		 get { } //Length: 42
	}

	public static int sceneCountInBuildSettings
	{
		 get { } //Length: 97
	}

	private static SceneManager() { }

	[CompilerGenerated]
	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGenerated]
	public static void add_sceneUnloaded(UnityAction<Scene> value) { }

	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	[NativeMethod("GetSceneCount")]
	[StaticAccessor("GetSceneManager()", StaticAccessorType::Dot (0))]
	public static int get_sceneCount() { }

	public static int get_sceneCountInBuildSettings() { }

	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	public static Scene GetActiveScene() { }

	private static void GetActiveScene_Injected(out Scene ret) { }

	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	public static Scene GetSceneAt(int index) { }

	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	public static Scene GetSceneByName(string name) { }

	private static void GetSceneByName_Injected(string name, out Scene ret) { }

	[RequiredByNativeCode]
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	[RequiredByNativeCode]
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCode]
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCode]
	internal static AsyncOperation LoadFirstScene_Internal(bool async) { }

	public static void LoadScene(string sceneName, LoadSceneMode mode) { }

	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[CompilerGenerated]
	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGenerated]
	public static void remove_sceneUnloaded(UnityAction<Scene> value) { }

	public static AsyncOperation UnloadSceneAsync(string sceneName) { }

	public static AsyncOperation UnloadSceneAsync(Scene scene) { }

	public static AsyncOperation UnloadSceneAsync(Scene scene, UnloadSceneOptions options) { }

	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options) { }

	private static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) { }

}

