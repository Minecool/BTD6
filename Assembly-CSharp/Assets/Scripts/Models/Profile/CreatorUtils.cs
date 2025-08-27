namespace Assets.Scripts.Models.Profile;

public static class CreatorUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MapEditorCreatorModel> <>9__16_0; //Field offset: 0x8
		public static Action<MapEditorCreatorModel> <>9__16_1; //Field offset: 0x10
		public static Func<GameEditorCreatorModel> <>9__17_0; //Field offset: 0x18
		public static Action<GameEditorCreatorModel> <>9__17_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal GameEditorCreatorModel <PlayerGameEditorCreatorModel>b__17_0() { }

		internal void <PlayerGameEditorCreatorModel>b__17_1(GameEditorCreatorModel model) { }

		internal MapEditorCreatorModel <PlayerMapEditorCreatorModel>b__16_0() { }

		internal void <PlayerMapEditorCreatorModel>b__16_1(MapEditorCreatorModel model) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public string prefix; //Field offset: 0x0

		public <>c__DisplayClass13_0`1() { }

		internal bool <StoredCreations>b__0(string key) { }

		internal string <StoredCreations>b__1(string key) { }

	}

	[CompilerGenerated]
	private sealed class <GameCreationIds>d__12 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private IEnumerator<String> <>7__wrap1; //Field offset: 0x28

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
		public <GameCreationIds>d__12(int <>1__state) { }

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

	[CompilerGenerated]
	private struct <LoadOrCreateDefaultGame>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CreatorModelWrapper`1<GameEditorCreatorModel>> <>t__builder; //Field offset: 0x8
		public string creationId; //Field offset: 0x20
		private CreatorModelWrapper<GameEditorCreatorModel> <modelWrapper>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadOrCreateDefaultMap>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CreatorModelWrapper`1<MapEditorCreatorModel>> <>t__builder; //Field offset: 0x8
		public string creationId; //Field offset: 0x20
		private CreatorModelWrapper<MapEditorCreatorModel> <modelWrapper>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <MapCreationIds>d__11 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private IEnumerator<String> <>7__wrap1; //Field offset: 0x28

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
		public <MapCreationIds>d__11(int <>1__state) { }

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

	private sealed class PlayerModelWrapper : CreatorModelWrapper<T>
	{
		private readonly Func<T> _get; //Field offset: 0x0
		private readonly Action<T> _set; //Field offset: 0x0

		public virtual T Model
		{
			 get { } //Length: 37
			 set { } //Length: 34
		}

		public PlayerModelWrapper`1(Func<T> get, Action<T> set) { }

		public virtual void Delete() { }

		public virtual T get_Model() { }

		public virtual Task LoadAsync() { }

		public virtual Task SaveAsync() { }

		public virtual void set_Model(T value) { }

	}

	private enum StorageStrategy
	{
		PlayerProfile = 0,
		LocalStorage = 1,
	}

	private sealed class StoredModelWrapper : CreatorModelWrapper<T>
	{
		[CompilerGenerated]
		private struct <LoadAsync>d__7 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public StoredModelWrapper<T> <>4__this; //Field offset: 0x0
			private TaskAwaiter<T> <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private string key; //Field offset: 0x0
		private T model; //Field offset: 0x0

		public virtual T Model
		{
			 get { } //Length: 5
			 set { } //Length: 381
		}

		public StoredModelWrapper`1(string key) { }

		public virtual void Delete() { }

		public virtual T get_Model() { }

		private static string KeyWithPrefix(string key) { }

		[AsyncStateMachine(typeof(<LoadAsync>d__7))]
		public virtual Task LoadAsync() { }

		public virtual Task SaveAsync() { }

		public virtual void set_Model(T value) { }

	}

	private const StorageStrategy MapStorageStrategy = 0; //Field offset: 0x0
	private const StorageStrategy GameStorageStrategy = 1; //Field offset: 0x0
	private static readonly StorageManager Storage; //Field offset: 0x0
	[CompilerGenerated]
	private static CreatorModelWrapper<MapEditorCreatorModel> <CurrentMapEditorCreatorModel>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static CreatorModelWrapper<GameEditorCreatorModel> <CurrentGameEditorCreatorModel>k__BackingField; //Field offset: 0x10

	public static bool CanHaveMultipleGameCreations
	{
		 get { } //Length: 3
	}

	public static bool CanHaveMultipleMapCreations
	{
		 get { } //Length: 3
	}

	public static CreatorModelWrapper<GameEditorCreatorModel> CurrentGameEditorCreatorModel
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		 set { } //Length: 85
	}

	public static CreatorModelWrapper<MapEditorCreatorModel> CurrentMapEditorCreatorModel
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		 set { } //Length: 85
	}

	private static CreatorUtils() { }

	private static string Decode(Byte[] data) { }

	private static Byte[] Encode(string data) { }

	[IteratorStateMachine(typeof(<GameCreationIds>d__12))]
	public static IEnumerable<String> GameCreationIds() { }

	public static CreatorModelWrapper<GameEditorCreatorModel> GameEditorCreatorModelWrapper(string key = null) { }

	public static bool get_CanHaveMultipleGameCreations() { }

	public static bool get_CanHaveMultipleMapCreations() { }

	[CompilerGenerated]
	public static CreatorModelWrapper<GameEditorCreatorModel> get_CurrentGameEditorCreatorModel() { }

	[CompilerGenerated]
	public static CreatorModelWrapper<MapEditorCreatorModel> get_CurrentMapEditorCreatorModel() { }

	[AsyncStateMachine(typeof(<LoadOrCreateDefaultGame>d__21))]
	public static Task<CreatorModelWrapper`1<GameEditorCreatorModel>> LoadOrCreateDefaultGame(string creationId) { }

	[AsyncStateMachine(typeof(<LoadOrCreateDefaultMap>d__20))]
	public static Task<CreatorModelWrapper`1<MapEditorCreatorModel>> LoadOrCreateDefaultMap(string creationId) { }

	[IteratorStateMachine(typeof(<MapCreationIds>d__11))]
	public static IEnumerable<String> MapCreationIds() { }

	public static CreatorModelWrapper<MapEditorCreatorModel> MapEditorCreatorModelWrapper(string key = null) { }

	private static CreatorModelWrapper<GameEditorCreatorModel> PlayerGameEditorCreatorModel() { }

	private static CreatorModelWrapper<MapEditorCreatorModel> PlayerMapEditorCreatorModel() { }

	private static string PrefixForCreation() { }

	[CompilerGenerated]
	public static void set_CurrentGameEditorCreatorModel(CreatorModelWrapper<GameEditorCreatorModel> value) { }

	[CompilerGenerated]
	public static void set_CurrentMapEditorCreatorModel(CreatorModelWrapper<MapEditorCreatorModel> value) { }

	private static IEnumerable<String> StoredCreations() { }

}

