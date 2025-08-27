namespace Assets.Scripts.Unity.Player;

[Extension]
public static class DataConflict
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ReturnCallback <>9__3_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ShowUpdatePopup>b__3_2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		private struct <<HandleConflictWithUi>g__CloseAndUnloadConflictScene|3>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass1_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private struct <<HandleConflictWithUi>g__useLocal|1>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass1_0 <>4__this; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private struct <<HandleConflictWithUi>g__useRemote|2>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass1_0 <>4__this; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public DataConflictScreen conflictUi; //Field offset: 0x10
		public DataConflict<ProfileModel> dataConflict; //Field offset: 0x18
		public Action onCompleted; //Field offset: 0x20
		public LoadingScreen loadingScreen; //Field offset: 0x28
		public AnimatedSceneLoader<DataConflictScreen> conflictScene; //Field offset: 0x30

		public <>c__DisplayClass1_0() { }

		[AsyncStateMachine(typeof(<<HandleConflictWithUi>g__CloseAndUnloadConflictScene|3>d))]
		internal Task <HandleConflictWithUi>g__CloseAndUnloadConflictScene|3() { }

		internal void <HandleConflictWithUi>g__removeButtonListeners|0() { }

		[AsyncStateMachine(typeof(<<HandleConflictWithUi>g__useLocal|1>d))]
		internal void <HandleConflictWithUi>g__useLocal|1() { }

		[AsyncStateMachine(typeof(<<HandleConflictWithUi>g__useRemote|2>d))]
		internal void <HandleConflictWithUi>g__useRemote|2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public TaskCompletionSource<Boolean> tcs; //Field offset: 0x10
		public DataConflict<ProfileModel> dataConflict; //Field offset: 0x18
		public bool canIgnore; //Field offset: 0x20
		public Action <>9__4; //Field offset: 0x28

		public <>c__DisplayClass3_0() { }

		internal void <ShowUpdatePopup>b__0() { }

		internal void <ShowUpdatePopup>b__1() { }

		internal void <ShowUpdatePopup>b__3(AsyncOperationHandle<GameObject> h) { }

		internal void <ShowUpdatePopup>b__4() { }

	}

	[CompilerGenerated]
	private sealed class <enumerateThenCompleteTask>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public IEnumerator enumerator; //Field offset: 0x20
		public TaskCompletionSource<Boolean> tcs; //Field offset: 0x28

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
		public <enumerateThenCompleteTask>d__7(int <>1__state) { }

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

	[CompilerGenerated]
	private struct <HandleConflictWithUi>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DataConflict<ProfileModel> dataConflict; //Field offset: 0x28
		public Action onCompleted; //Field offset: 0x30
		private <>c__DisplayClass1_0 <>8__1; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[IteratorStateMachine(typeof(<enumerateThenCompleteTask>d__7))]
	private static IEnumerator enumerateThenCompleteTask(IEnumerator enumerator, TaskCompletionSource<Boolean> tcs) { }

	[Extension]
	private static TaskAwaiter GetAwaiter(IEnumerator enumerator) { }

	public static void HandleConflict(DataConflict<ProfileModel> dataConflict) { }

	[AsyncStateMachine(typeof(<HandleConflictWithUi>d__1))]
	private static void HandleConflictWithUi(DataConflict<ProfileModel> dataConflict, Action onCompleted = null) { }

	public static bool IsCompatibleWithThisGameVersion(Version remoteVersion) { }

	public static void ReportIncompatibleDataVersion(Version remoteVersion, bool fromConflict) { }

	public static TaskCompletionSource<Boolean> ShowUpdatePopup(DataConflict<ProfileModel> dataConflict, Version saveVersion, bool canStagingIgnore) { }

	[Extension]
	private static Task ToTask(IEnumerator enumerator) { }

}

