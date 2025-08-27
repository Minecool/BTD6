namespace NinjaKiwi.Common.ResourceUtils;

[Extension]
public static class ResourceLoader
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public ISpriteRenderer image; //Field offset: 0x10
		public bool fadeIn; //Field offset: 0x18

		public <>c__DisplayClass32_0() { }

		internal void <LoadSpriteFromSpriteReference_Internal>b__0(AsyncOperationHandle<Sprite> h) { }

	}

	[CompilerGenerated]
	private sealed class <AsTasks>d__11 : IEnumerable<Task>, IEnumerable, IEnumerator<Task>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private Task <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private IList<AsyncOperationHandle`1<T>> handles; //Field offset: 0x0
		public IList<AsyncOperationHandle`1<T>> <>3__handles; //Field offset: 0x0
		private IEnumerator<AsyncOperationHandle`1<T>> <>7__wrap1; //Field offset: 0x0

		private override Task System.Collections.Generic.IEnumerator<System.Threading.Tasks.Task>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <AsTasks>d__11`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Task> System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>.GetEnumerator() { }

		[DebuggerHidden]
		private override Task System.Collections.Generic.IEnumerator<System.Threading.Tasks.Task>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <FadeIn>d__34 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ISpriteRenderer image; //Field offset: 0x20
		public float time; //Field offset: 0x28
		private Color <color>5__2; //Field offset: 0x2C

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <FadeIn>d__34(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private abstract class FakeAsyncOp : AsyncOperationBase<T>, IUpdateReceiver
	{
		private double timeStarted; //Field offset: 0x0

		protected abstract string ErrorStr
		{
			 get { } //Length: 0
		}

		protected virtual float Progress
		{
			 get { } //Length: 9
		}

		protected FakeAsyncOp`1() { }

		protected abstract T DoLoad() { }

		protected virtual void Execute() { }

		protected abstract string get_ErrorStr() { }

		protected virtual float get_Progress() { }

		public override void Update(float unscaledDeltaTime) { }

	}

	private class FakeInstantiateAsyncOp_Resources : FakeAsyncOp<GameObject>
	{
		private readonly string path; //Field offset: 0xA0
		private readonly Transform parent; //Field offset: 0xA8

		protected virtual string ErrorStr
		{
			 get { } //Length: 64
		}

		public FakeInstantiateAsyncOp_Resources(string path, Transform parent) { }

		protected virtual GameObject DoLoad() { }

		protected virtual string get_ErrorStr() { }

		private static GameObject InstantiateUsingResources(string path, Transform parent) { }

	}

	private class FakeLoadAsyncOp_Resources : FakeAsyncOp<T>
	{
		private readonly string path; //Field offset: 0x0

		protected virtual string ErrorStr
		{
			 get { } //Length: 64
		}

		public FakeLoadAsyncOp_Resources`1(string path) { }

		protected virtual T DoLoad() { }

		protected virtual string get_ErrorStr() { }

	}

	private class FakeLoadAtlasedSpriteOp_Resources : FakeAsyncOp<Sprite>
	{
		private readonly string address; //Field offset: 0xA0
		private readonly ResourceProviderResources resourceProvider; //Field offset: 0xA8

		protected virtual string ErrorStr
		{
			 get { } //Length: 64
		}

		public FakeLoadAtlasedSpriteOp_Resources(string address, ResourceProviderResources resourceProvider) { }

		protected virtual Sprite DoLoad() { }

		protected virtual string get_ErrorStr() { }

	}

	private class FakeLoadByLabelAsyncOp_Resources : FakeAsyncOp<IList`1<T>>
	{
		private readonly string label; //Field offset: 0x0
		private readonly Action<T> callback; //Field offset: 0x0
		private readonly ResourceProviderResources resourceProvider; //Field offset: 0x0

		protected virtual string ErrorStr
		{
			 get { } //Length: 64
		}

		public FakeLoadByLabelAsyncOp_Resources`1(string label, Action<T> callback, ResourceProviderResources resourceProvider) { }

		protected virtual IList<T> DoLoad() { }

		protected virtual string get_ErrorStr() { }

	}

	private class ImageAdaptor : ISpriteRenderer
	{
		private readonly Image image; //Field offset: 0x10

		public override Color color
		{
			 get { } //Length: 62
			 set { } //Length: 52
		}

		public override GameObject gameObject
		{
			 get { } //Length: 29
		}

		public override Sprite sprite
		{
			 get { } //Length: 30
			 set { } //Length: 30
		}

		public override bool Valid
		{
			 get { } //Length: 80
		}

		public ImageAdaptor(Image img) { }

		public override Color get_color() { }

		public override GameObject get_gameObject() { }

		public override Sprite get_sprite() { }

		public override bool get_Valid() { }

		public override void set_color(Color value) { }

		public override void set_sprite(Sprite value) { }

		public override Coroutine StartCoroutine(IEnumerator enumerator) { }

	}

	private interface IResourceProvider
	{

		public bool UsesAssetBundles
		{
			 get { } //Length: 0
		}

		public bool get_UsesAssetBundles() { }

		public AsyncOperationHandle<GameObject> InstantiateAsync(string address, Transform parent) { }

		public AsyncOperationHandle<T> LoadAsync(string address) { }

		public AsyncOperationHandle<SpriteAtlas> LoadAtlas(string atlasName) { }

		public AsyncOperationHandle<Sprite> LoadAtlasedSprite(string address) { }

		public AsyncOperationHandle<IList`1<T>> LoadByLabelAsync(string label, Action<T> callback) { }

		public AsyncOperationHandle<SceneInstance> LoadSceneAsync(string sceneName, LoadSceneMode loadMode = 0) { }

		public void Release(AsyncOperationHandle<T> handle) { }

		public void ReleaseInstance(AsyncOperationHandle<GameObject> handle) { }

		public bool SceneExists(string sceneName) { }

		public AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene) { }

	}

	private interface ISpriteRenderer
	{

		public Color color
		{
			 get { } //Length: 0
			 set { } //Length: 0
		}

		public GameObject gameObject
		{
			 get { } //Length: 0
		}

		public Sprite sprite
		{
			 get { } //Length: 0
			 set { } //Length: 0
		}

		public bool Valid
		{
			 get { } //Length: 0
		}

		public Color get_color() { }

		public GameObject get_gameObject() { }

		public Sprite get_sprite() { }

		public bool get_Valid() { }

		public void set_color(Color value) { }

		public void set_sprite(Sprite value) { }

		public Coroutine StartCoroutine(IEnumerator enumerator) { }

	}

	private abstract class LoadScene : AsyncOperationBase<SceneInstance>, IUpdateReceiver
	{
		protected readonly string sceneName; //Field offset: 0xA0
		protected readonly LoadSceneMode loadSceneMode; //Field offset: 0xA8
		private AsyncOperation loadOp; //Field offset: 0xB0

		protected virtual float Progress
		{
			 get { } //Length: 32
		}

		protected LoadScene(string sceneName, LoadSceneMode loadSceneMode) { }

		protected abstract AsyncOperation CreateLoadOperation() { }

		protected virtual void Execute() { }

		protected virtual float get_Progress() { }

		public override void Update(float unscaledDeltaTime) { }

	}

	private class LoadSceneBuiltIn : LoadScene
	{

		public LoadSceneBuiltIn(string sceneName, LoadSceneMode loadSceneMode) { }

		protected virtual AsyncOperation CreateLoadOperation() { }

	}

	private class ResourceProviderAddressables : IResourceProvider
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			public Transform parent; //Field offset: 0x10
			public string address; //Field offset: 0x18

			public <>c__DisplayClass10_0() { }

			internal void <NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.InstantiateAsync>b__0(AsyncOperationHandle<GameObject> h) { }

		}

		public class SelfCleanup : MonoBehaviour
		{

			public SelfCleanup() { }

			private void OnDestroy() { }

		}


		public override bool UsesAssetBundles
		{
			 get { } //Length: 3
		}

		public ResourceProviderAddressables() { }

		public override bool get_UsesAssetBundles() { }

		private static void instantiate_Completed(AsyncOperationHandle<GameObject> handle, Transform parent, string address) { }

		private override AsyncOperationHandle<GameObject> NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.InstantiateAsync(string address, Transform parent) { }

		private override AsyncOperationHandle<T> NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.LoadAsync(string address) { }

		private override AsyncOperationHandle<SpriteAtlas> NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.LoadAtlas(string atlasName) { }

		private override AsyncOperationHandle<Sprite> NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.LoadAtlasedSprite(string address) { }

		private override AsyncOperationHandle<IList`1<T>> NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.LoadByLabelAsync(string label, Action<T> callback) { }

		private override AsyncOperationHandle<SceneInstance> NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.LoadSceneAsync(string sceneName, LoadSceneMode loadMode) { }

		private override void NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.Release(AsyncOperationHandle<T> handle) { }

		private override void NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.ReleaseInstance(AsyncOperationHandle<GameObject> handle) { }

		private override bool NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.SceneExists(string sceneName) { }

		private override AsyncOperationHandle<SceneInstance> NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.UnloadSceneAsync(SceneInstance scene) { }

	}

	private class ResourceProviderResources : IResourceProvider
	{
		[CompilerGenerated]
		private sealed class <ResourcePathsForLabel>d__15 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private string <>2__current; //Field offset: 0x18
			private int <>l__initialThreadId; //Field offset: 0x20
			public ResourceProviderResources <>4__this; //Field offset: 0x28
			private string label; //Field offset: 0x30
			public string <>3__label; //Field offset: 0x38
			private Enumerator<String, Resource> <>7__wrap1; //Field offset: 0x40

			private override string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[DebuggerHidden]
				private get { } //Length: 5
			}

			private override object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				private get { } //Length: 5
			}

			[DebuggerHidden]
			public <ResourcePathsForLabel>d__15(int <>1__state) { }

			private void <>m__Finally1() { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

			[DebuggerHidden]
			private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		private readonly AssetManifest manifest; //Field offset: 0x10

		public override bool UsesAssetBundles
		{
			 get { } //Length: 3
		}

		public ResourceProviderResources(AssetManifest manifest) { }

		public string AtlasPath(string atlasName) { }

		public override bool get_UsesAssetBundles() { }

		private override AsyncOperationHandle<GameObject> NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.InstantiateAsync(string address, Transform parent) { }

		private override AsyncOperationHandle<T> NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.LoadAsync(string address) { }

		private override AsyncOperationHandle<SpriteAtlas> NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.LoadAtlas(string atlasName) { }

		private override AsyncOperationHandle<Sprite> NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.LoadAtlasedSprite(string address) { }

		private override AsyncOperationHandle<IList`1<T>> NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.LoadByLabelAsync(string label, Action<T> callback) { }

		private override AsyncOperationHandle<SceneInstance> NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.LoadSceneAsync(string sceneName, LoadSceneMode loadMode) { }

		private override void NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.Release(AsyncOperationHandle<T> handle) { }

		private override void NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.ReleaseInstance(AsyncOperationHandle<GameObject> handle) { }

		private override bool NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.SceneExists(string sceneName) { }

		private override AsyncOperationHandle<SceneInstance> NinjaKiwi.Common.ResourceUtils.ResourceLoader.IResourceProvider.UnloadSceneAsync(SceneInstance scene) { }

		private string ResourcePathForAddress(string address) { }

		[IteratorStateMachine(typeof(<ResourcePathsForLabel>d__15))]
		public IEnumerable<String> ResourcePathsForLabel(string label) { }

	}

	private class SpriteRendererAdaptor : ISpriteRenderer
	{
		private readonly SpriteRenderer spriteRenderer; //Field offset: 0x10

		public override Color color
		{
			 get { } //Length: 51
			 set { } //Length: 44
		}

		public override GameObject gameObject
		{
			 get { } //Length: 29
		}

		public override Sprite sprite
		{
			 get { } //Length: 29
			 set { } //Length: 30
		}

		public override bool Valid
		{
			 get { } //Length: 80
		}

		public SpriteRendererAdaptor(SpriteRenderer sr) { }

		public override Color get_color() { }

		public override GameObject get_gameObject() { }

		public override Sprite get_sprite() { }

		public override bool get_Valid() { }

		public override void set_color(Color value) { }

		public override void set_sprite(Sprite value) { }

		public override Coroutine StartCoroutine(IEnumerator enumerator) { }

	}

	private class UnloadScene : AsyncOperationBase<SceneInstance>, IUpdateReceiver
	{
		private SceneInstance sceneInstance; //Field offset: 0xA0
		private AsyncOperation loadOp; //Field offset: 0xB0

		protected virtual float Progress
		{
			 get { } //Length: 32
		}

		public UnloadScene(SceneInstance sceneInstance) { }

		protected virtual void Execute() { }

		protected virtual float get_Progress() { }

		public override void Update(float unscaledDeltaTime) { }

	}

	private static IResourceProvider resourceProvider; //Field offset: 0x0
	private const string kToggleFakeLoadTimeMenu = "Ninja Kiwi/Fake Load Time"; //Field offset: 0x0
	private const string kFakeLoadTimePref = "FakeLoadTime"; //Field offset: 0x0
	private const int kToggleFakeLoadTimeMenuPriority = 10000; //Field offset: 0x0
	private const float kFakeLoadTime = 0.5; //Field offset: 0x0

	public static bool UsesAssetBundles
	{
		 get { } //Length: 89
	}

	private static bool AddressIsAtlasedSprite(string address) { }

	private static string AddressOf(IAssetReference<T> ar) { }

	[Extension]
	[IteratorStateMachine(typeof(<AsTasks>d__11`1))]
	public static IEnumerable<Task> AsTasks(IList<AsyncOperationHandle`1<T>> handles) { }

	private static AsyncOperationHandle<T> CreateCompletedOperation(T result) { }

	[IteratorStateMachine(typeof(<FadeIn>d__34))]
	private static IEnumerator FadeIn(ISpriteRenderer image, float time) { }

	public static bool get_UsesAssetBundles() { }

	public static AsyncOperationHandle InitializeAsync() { }

	public static AsyncOperationHandle<GameObject> InstantiateAsync(PrefabReference reference, Transform parent = null, Action<AsyncOperationHandle`1<GameObject>> onComplete = null) { }

	[Obsolete("InstantiateAsync<T>(string address) is Obsolete, use InstantiateAsync<T>(PrefabReference reference) instead")]
	public static AsyncOperationHandle<GameObject> InstantiateAsync(string address, Transform parent = null) { }

	private static bool IsSceneBuiltIn(string sceneName) { }

	private static AssetManifest LoadAssetManifest() { }

	public static AsyncOperationHandle<T> LoadAsync(IAssetReference<T> reference) { }

	[Obsolete("LoadAsync<T>(string address) is Obsolete, use LoadAsync<T>(AssetReferenceT<T> reference) instead")]
	public static AsyncOperationHandle<T> LoadAsync(string address) { }

	public static AsyncOperationHandle<SpriteAtlas> LoadAtlas(string atlasName) { }

	public static AsyncOperationHandle<IList`1<T>> LoadByLabelAsync(string label, Action<T> callback) { }

	[Extension]
	public static bool Loading(AsyncOperationHandle h) { }

	[Extension]
	public static bool Loading(AsyncOperationHandle<T> h) { }

	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(string sceneName, LoadSceneMode loadMode = 0) { }

	public static void LoadSpriteFromSpriteReference(SpriteReference reference, Image image, bool forceNoFade = false) { }

	public static void LoadSpriteFromSpriteReference(SpriteReference reference, SpriteRenderer spriteRenderer) { }

	private static Task LoadSpriteFromSpriteReference_Internal(SpriteReference reference, ISpriteRenderer image, bool forceNoFade) { }

	public static Task LoadSpriteFromSpriteReferenceAsync(SpriteReference reference, Image image, bool forceNoFade = false) { }

	public static Task LoadSpriteFromSpriteReferenceAsync(SpriteReference reference, SpriteRenderer spriteRenderer) { }

	private static T LoadUsingResources(string path) { }

	private static void OnSpriteLoaded(AsyncOperationHandle<Sprite> handle, ISpriteRenderer image, bool fadeIn) { }

	[Extension]
	public static void Release(AsyncOperationHandle<T> handle) { }

	[Extension]
	public static void ReleaseAll(IEnumerable<AsyncOperationHandle`1<T>> handles) { }

	[Extension]
	public static void ReleaseAllInstances(IEnumerable<AsyncOperationHandle`1<GameObject>> handles) { }

	[Extension]
	public static void ReleaseInstance(AsyncOperationHandle<GameObject> handle) { }

	[Extension]
	public static void ReleaseOrCancel(AsyncOperationHandle<T> handle) { }

	[Extension]
	public static void ReleaseOrCancelInstance(AsyncOperationHandle<GameObject> handle) { }

	public static bool SceneExists(string sceneName) { }

	private static AsyncOperationHandle<T> StartOperation(AsyncOperationBase<T> operation) { }

	[Extension]
	public static bool Succeeded(AsyncOperationHandle h) { }

	[Extension]
	public static bool Succeeded(AsyncOperationHandle<T> h) { }

	public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene) { }

	public static AsyncOperation UnloadUnusedAssets() { }

}

