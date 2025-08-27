namespace Ninjakiwi.BuildAutomation;

public static class BundleLoader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, BundleInfo>, Int64> <>9__15_1; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, BundleInfo>, Int64> <>9__15_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal long <GetDownloadSizeAsync>b__15_1(KeyValuePair<String, BundleInfo> kv) { }

		internal long <GetDownloadSizeAsync>b__15_2(KeyValuePair<String, BundleInfo> kv) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public string hash; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal bool <ClearBundleCacheAsync>b__0(BundleInfo v) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public TaskCompletionSource<IResourceLocator> tcs; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal void <InitialiseAddressablesAsync>b__0(AsyncOperationHandle<IResourceLocator> op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public TaskCompletionSource<String> tcs; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal void <GetBundleInfosAsync>b__0(AsyncOperationHandle<String> op) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public Dictionary<String, BundleInfo> bundleInfos; //Field offset: 0x10
		public TaskCompletionSource<Int64> tcs; //Field offset: 0x18

		public <>c__DisplayClass15_0() { }

		internal void <GetDownloadSizeAsync>b__0(AsyncOperationHandle<Int64> op) { }

	}

	[CompilerGenerated]
	private struct <ClearBundleCacheAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Dictionary<String, BundleInfo> bundleInfos; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DownloadDependenciesAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable<Object> keys; //Field offset: 0x20
		public IBundleLoaderProgressReporter progressReporter; //Field offset: 0x28
		private AsyncOperationHandle <downloadDependenciesReq>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetBundleInfosAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Dictionary`2<String, BundleInfo>> <>t__builder; //Field offset: 0x8
		public string path; //Field offset: 0x20
		private TaskAwaiter<String> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetDownloadSizeAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int64> <>t__builder; //Field offset: 0x8
		public Dictionary<String, BundleInfo> bundleInfos; //Field offset: 0x20
		public IEnumerable<Object> keys; //Field offset: 0x28
		private TaskAwaiter<Int64> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitialiseAddressablesAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IResourceLocator> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<IResourceLocator> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadBundlesAsync>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IBundleLoaderProgressReporter progressReporter; //Field offset: 0x20
		private int <currentSleepTimeout>5__2; //Field offset: 0x28
		private IResourceLocator <resourceLocator>5__3; //Field offset: 0x30
		private long <bytesToDownload>5__4; //Field offset: 0x38
		private TaskAwaiter<IResourceLocator> <>u__1; //Field offset: 0x40
		private Dictionary<String, BundleInfo> <bundleInfos>5__5; //Field offset: 0x48
		private TaskAwaiter<Dictionary`2<String, BundleInfo>> <>u__2; //Field offset: 0x50
		private TaskAwaiter <>u__3; //Field offset: 0x58
		private TaskAwaiter<Int64> <>u__4; //Field offset: 0x60
		private Exception <ex>5__6; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForSecondsAsync>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public float seconds; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitUntilUserIsOnlineAsync>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IBundleLoaderProgressReporter progressReporter; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static readonly string ActiveVariant; //Field offset: 0x0

	private static AnalyticsManager AnalyticsManager
	{
		private get { } //Length: 54
	}

	private static bool HasBundlesCached
	{
		private get { } //Length: 107
	}

	private static AssetScale HighResolution
	{
		private get { } //Length: 25
	}

	private static AssetScale LowResolution
	{
		private get { } //Length: 26
	}

	private static BundleLoader() { }

	private static IEnumerable<String> CachedBundles() { }

	[AsyncStateMachine(typeof(<ClearBundleCacheAsync>d__12))]
	private static Task ClearBundleCacheAsync(Dictionary<String, BundleInfo> bundleInfos) { }

	[AsyncStateMachine(typeof(<DownloadDependenciesAsync>d__17))]
	private static Task DownloadDependenciesAsync(IEnumerable<Object> keys, IBundleLoaderProgressReporter progressReporter) { }

	private static AnalyticsManager get_AnalyticsManager() { }

	private static bool get_HasBundlesCached() { }

	private static AssetScale get_HighResolution() { }

	private static AssetScale get_LowResolution() { }

	[AsyncStateMachine(typeof(<GetBundleInfosAsync>d__14))]
	private static Task<Dictionary`2<String, BundleInfo>> GetBundleInfosAsync(string path) { }

	[AsyncStateMachine(typeof(<GetDownloadSizeAsync>d__15))]
	private static Task<Int64> GetDownloadSizeAsync(IEnumerable<Object> keys, Dictionary<String, BundleInfo> bundleInfos) { }

	[AsyncStateMachine(typeof(<InitialiseAddressablesAsync>d__13))]
	private static Task<IResourceLocator> InitialiseAddressablesAsync() { }

	[AsyncStateMachine(typeof(<LoadBundlesAsync>d__18))]
	public static Task LoadBundlesAsync(IBundleLoaderProgressReporter progressReporter) { }

	[AsyncStateMachine(typeof(<WaitForSecondsAsync>d__6))]
	private static Task WaitForSecondsAsync(float seconds) { }

	[AsyncStateMachine(typeof(<WaitUntilUserIsOnlineAsync>d__16))]
	private static Task WaitUntilUserIsOnlineAsync(IBundleLoaderProgressReporter progressReporter) { }

}

