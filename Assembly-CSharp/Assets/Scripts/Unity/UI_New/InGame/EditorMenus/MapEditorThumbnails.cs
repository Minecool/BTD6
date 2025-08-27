namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public static class MapEditorThumbnails
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MapEditorAreaData, Boolean> <>9__20_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GenerateMapThumbnailAsync>b__20_0(MapEditorAreaData a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public MapEditorPropData prop; //Field offset: 0x10

		public <>c__DisplayClass23_0() { }

		internal void <LoadMapProp>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private struct <GenerateMapThumbnailAsync>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public Options renderOpts; //Field offset: 0x28
		public CustomMapModel customMapModel; //Field offset: 0x30
		public int height; //Field offset: 0x38
		private int <genId>5__2; //Field offset: 0x3C
		private string <timerId>5__3; //Field offset: 0x40
		private AsyncOperationHandle<GameObject> <thumbnailHandle>5__4; //Field offset: 0x48
		private GameObject <thumbNailObj>5__5; //Field offset: 0x60
		private Transform <propsTransform>5__6; //Field offset: 0x68
		private List<MapEditorAreaData> <removableAreas>5__7; //Field offset: 0x70
		private CustomMapManagers <customMapManagers>5__8; //Field offset: 0x78
		private AsyncOperationHandle<GameObject>[] <propHandles>5__9; //Field offset: 0x80
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x88
		private TaskAwaiter <>u__2; //Field offset: 0x90
		private YieldAwaiter <>u__3; //Field offset: 0x98

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadMapThumbnailAsync>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder; //Field offset: 0x8
		public string cacheId; //Field offset: 0x20
		public Size size; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public CustomMapModel customMapModel; //Field offset: 0x38
		public Options renderOpts; //Field offset: 0x40
		private bool <useCache>5__2; //Field offset: 0x44
		private Texture2D <thumbnail>5__3; //Field offset: 0x48
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x50
		private TaskAwaiter<Texture2D> <>u__2; //Field offset: 0x58
		private TaskAwaiter <>u__3; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum ImageCompression
	{
		PNG = 0,
		JPEG = 1,
	}

	internal enum Size
	{
		Small = 0,
		Large = 1,
		ExtraLarge = 2,
	}

	private class SmallIdPool
	{
		private ulong mask; //Field offset: 0x10

		public SmallIdPool() { }

		public bool GetId(out int id) { }

		public void ReturnId(int id) { }

	}

	private const int kSmallThumbnailHeight = 64; //Field offset: 0x0
	private const int kLargeThumbnailHeight = 375; //Field offset: 0x0
	private const int kExtraLargeThumbnailHeight = 640; //Field offset: 0x0
	private const int kMaxConcurrentGen = 64; //Field offset: 0x0
	private const int kJPGQuality = 85; //Field offset: 0x0
	private static readonly Byte[] kEncodedImageFooter; //Field offset: 0x0
	private static readonly int kRenderLayer; //Field offset: 0x8
	private static readonly StorageManager storageManager; //Field offset: 0x10
	private static readonly SmallIdPool idPool; //Field offset: 0x18

	private static MapEditorData MapEditorData
	{
		private get { } //Length: 71
	}

	private static MapEditorThumbnails() { }

	private static Texture2D DecodeImage(Byte[] bytes) { }

	private static Byte[] DeShuffle(Byte[] source) { }

	private static void DeShuffleInPlace(Span<Byte> bytes) { }

	private static Byte[] EncodeImage(Texture2D image, ImageCompression imageCompression) { }

	[AsyncStateMachine(typeof(<GenerateMapThumbnailAsync>d__20))]
	private static Task<Texture2D> GenerateMapThumbnailAsync(CustomMapModel customMapModel, Options renderOpts, int height, CancellationToken cancellationToken) { }

	private static void GenerateMapThumbnailCleanup(string timerId, int genId, AsyncOperationHandle<GameObject> thumbnailHandle, CustomMapManagers customMapManagers, AsyncOperationHandle<GameObject>[] propHandles, bool completed) { }

	private static MapEditorData get_MapEditorData() { }

	private static AsyncOperationHandle<GameObject>[] GetPropHandles(IList<MapEditorPropData> propData, Transform propParent) { }

	private static Int32[] GetShuffleExchanges(int arrayLength) { }

	public static void InvalidateAllMapThumbnails() { }

	public static void InvalidateMapThumbnail(string id) { }

	private static AsyncOperationHandle<GameObject> LoadMapProp(MapEditorPropData prop, Transform parent) { }

	[AsyncStateMachine(typeof(<LoadMapThumbnailAsync>d__18))]
	public static Task<Texture2D> LoadMapThumbnailAsync(CustomMapModel customMapModel, string cacheId, Size size, Options renderOpts = 211, CancellationToken cancellationToken = null) { }

	public static void ReleaseTextureForImage(Image img) { }

	private static Byte[] Shuffle(Byte[] source) { }

	private static void ShuffleInPlace(Span<Byte> bytes) { }

	private static string SizedId(string id, Size size) { }

	private static int SizeHeight(Size size) { }

}

