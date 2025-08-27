namespace Assets.Scripts.Data.MapEditor;

public class MapEditorProp : MapEditorItem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Area, AreaModel> <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal AreaModel <LoadDataAsync>b__10_0(Area area) { }

	}

	[CompilerGenerated]
	private struct <LoadDataAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorProp <>4__this; //Field offset: 0x20
		private AsyncOperationHandle<GameObject> <h>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter<GameObject> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public PrefabReference asset; //Field offset: 0x40
	public SpriteReference sprite; //Field offset: 0x48
	public PropSetType propSetType; //Field offset: 0x50
	public TrophyStoreItem linkedToTrophyStoreItem; //Field offset: 0x58
	private AreaModel[] areaModels; //Field offset: 0x60
	private bool hasValidAnimationController; //Field offset: 0x68
	private Model[] behaviors; //Field offset: 0x70

	public bool IsSpecialEffect
	{
		 get { } //Length: 78
	}

	public MapEditorProp() { }

	public PropModel Def() { }

	private Model[] GatherBehaviors(GameObject gameObject) { }

	public Model[] GatherBehaviors(GameObject gameObject) { }

	public bool get_IsSpecialEffect() { }

	[AsyncStateMachine(typeof(<LoadDataAsync>d__10))]
	public Task LoadDataAsync() { }

}

