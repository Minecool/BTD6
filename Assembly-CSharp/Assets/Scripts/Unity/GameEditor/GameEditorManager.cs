namespace Assets.Scripts.Unity.GameEditor;

public class GameEditorManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <TryGetProp>b__0(Prop x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public int hash; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <TryGetPropByHash>b__0(Prop x) { }

	}

	[CompilerGenerated]
	private struct <Initialise>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEditorManager <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static GameEditorManager instance; //Field offset: 0x0
	[CompilerGenerated]
	private Prop <DefaultProp>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private EntityEvent <DefaultEventSystem>k__BackingField; //Field offset: 0x18
	public Dictionary<Type, IGameEditorAsset> DefaultEntities; //Field offset: 0x20
	public List<Prop> gameEditorProps; //Field offset: 0x28
	public List<EntityEvent> gameEditorEventSystems; //Field offset: 0x30

	public private EntityEvent DefaultEventSystem
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public SpriteReference DefaultIcon
	{
		 get { } //Length: 83
	}

	public private Prop DefaultProp
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public GameEditorManager() { }

	[CompilerGenerated]
	private void <Initialise>b__16_0(AsyncOperationHandle<ScriptableObject> h) { }

	[CompilerGenerated]
	private void <Initialise>b__16_1(AsyncOperationHandle<ScriptableObject> h) { }

	[CompilerGenerated]
	public EntityEvent get_DefaultEventSystem() { }

	public SpriteReference get_DefaultIcon() { }

	[CompilerGenerated]
	public Prop get_DefaultProp() { }

	[AsyncStateMachine(typeof(<Initialise>d__16))]
	public Task Initialise() { }

	[CompilerGenerated]
	private void set_DefaultEventSystem(EntityEvent value) { }

	[CompilerGenerated]
	private void set_DefaultProp(Prop value) { }

	public bool TryGetProp(string name, out Prop data) { }

	public bool TryGetPropByHash(int hash, out Prop data) { }

}

