//Type is in global namespace

public class BossRushTile : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Hide>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushTile <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshTile>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushTile <>4__this; //Field offset: 0x20
		public Transform position; //Field offset: 0x28
		public PrefabReference statue; //Field offset: 0x30
		public int currentTileIndex; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetMapVisuals>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushTile <>4__this; //Field offset: 0x20
		public int currentTileIndex; //Field offset: 0x28
		public PrefabReference statuePrefab; //Field offset: 0x30
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Show>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushTile <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Transform mapAssetContainer; //Field offset: 0x20
	public TileInteractable tile; //Field offset: 0x28
	[SerializeField]
	private Animator anim; //Field offset: 0x30
	private GameObject currentStatue; //Field offset: 0x38
	private PrefabReference loadedStatue; //Field offset: 0x40
	[SerializeField]
	private int hideAnimationLengthMs; //Field offset: 0x48
	[SerializeField]
	private int showAnimationLengthMs; //Field offset: 0x4C

	public BossRushTile() { }

	[AsyncStateMachine(typeof(<Hide>d__11))]
	public Task Hide() { }

	[AsyncStateMachine(typeof(<RefreshTile>d__8))]
	public Task RefreshTile(PrefabReference statue, int currentTileIndex, Transform position) { }

	[AsyncStateMachine(typeof(<SetMapVisuals>d__7))]
	public Task SetMapVisuals(PrefabReference statuePrefab, int currentTileIndex) { }

	public void SetSelected(bool isSelected) { }

	[AsyncStateMachine(typeof(<Show>d__10))]
	public Task Show() { }

}

