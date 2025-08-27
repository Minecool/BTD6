namespace Assets.Scripts.Unity.UI_New.Legends;

public class RogueTile : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public int heightDiff; //Field offset: 0x10
		public Quaternion rotation; //Field offset: 0x14
		public RogueTile <>4__this; //Field offset: 0x28

		public <>c__DisplayClass35_0() { }

		internal void <SetProp>b__0(AsyncOperationHandle<GameObject> handle) { }

		internal void <SetProp>b__1(AsyncOperationHandle<GameObject> handle) { }

	}

	[CompilerGenerated]
	private struct <Load>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueTile <>4__this; //Field offset: 0x20
		public RogueTileSaveData data; //Field offset: 0x28
		public bool ignoreID; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetBoss>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueTile <>4__this; //Field offset: 0x20
		public BossType bossType; //Field offset: 0x28
		public int stage; //Field offset: 0x2C
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <SetColorOverTime>d__42 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RogueTile <>4__this; //Field offset: 0x20
		public Color targetColor; //Field offset: 0x28
		public float duration; //Field offset: 0x38
		public MeshRenderer[] renderers; //Field offset: 0x40
		public Color initialColor; //Field offset: 0x48
		private float <time>5__2; //Field offset: 0x58

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
		public <SetColorOverTime>d__42(int <>1__state) { }

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
	private struct <SetProp>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueTile <>4__this; //Field offset: 0x20
		public int propGroupIndex; //Field offset: 0x28
		public bool dontLoadAsset; //Field offset: 0x2C
		public bool waterfalls; //Field offset: 0x2D
		public int randomIndex; //Field offset: 0x30
		private RogueData <rogueData>5__2; //Field offset: 0x38
		private bool <isBridgeTile>5__3; //Field offset: 0x40
		private List<RogueTileData> <adjacentTiles>5__4; //Field offset: 0x48
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetType>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueTile <>4__this; //Field offset: 0x20
		public RogueTileType tileType; //Field offset: 0x28
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const float heightMultiplier = 4; //Field offset: 0x0
	public RogueTileType tileType; //Field offset: 0x20
	public MapDetails map; //Field offset: 0x28
	public BossType boss; //Field offset: 0x30
	public int height; //Field offset: 0x34
	public Vector2Int coords; //Field offset: 0x38
	public RogueMiniGameData miniGameData; //Field offset: 0x40
	public bool isLegendary; //Field offset: 0x48
	public bool defeated; //Field offset: 0x49
	public string tileID; //Field offset: 0x50
	public int propType; //Field offset: 0x58
	public bool shufflePosition; //Field offset: 0x5C
	public int seed; //Field offset: 0x60
	public RogueBloonModifier modifier; //Field offset: 0x64
	public bool isReverse; //Field offset: 0x68
	public TextMeshPro debugTileIDTxt; //Field offset: 0x70
	public GameObject tileObj; //Field offset: 0x78
	[SerializeField]
	private Transform tileContainer; //Field offset: 0x80
	[SerializeField]
	private Color defeatedColor; //Field offset: 0x88
	public GameObject decorationSlot; //Field offset: 0x98
	[SerializeField]
	private GameObject bossDecorationContainer; //Field offset: 0xA0
	private GameObject bossDecoration; //Field offset: 0xA8
	private GameObject decorationProp; //Field offset: 0xB0
	private List<GameObject> waterfallProps; //Field offset: 0xB8
	[SerializeField]
	private float decorationOffsetY; //Field offset: 0xC0
	public RogueMap rogueMap; //Field offset: 0xC8
	[SerializeField]
	private GameObject bigBossContainer; //Field offset: 0xD0
	public GameObject bigBossContainerOffset; //Field offset: 0xD8
	private bool playedBossAnim; //Field offset: 0xE0
	private Color currentColor; //Field offset: 0xE4

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueTile() { }

	private void ClearProp() { }

	private LegendsDataModel get_LegendsData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	private PrefabReference GetBloonProp(RogueBloonModifier modifier) { }

	public static int GetPropAssetTypeFromTileType(RogueTileType type) { }

	[AsyncStateMachine(typeof(<Load>d__43))]
	public Task Load(RogueTileSaveData data, bool ignoreID = false) { }

	private void OnDestroy() { }

	public void PlayBossDeathAnim() { }

	public void PlayBossSpawnAnim(int rotationIndex, bool instant = false) { }

	[AsyncStateMachine(typeof(<SetBoss>d__47))]
	public Task SetBoss(BossType bossType, int stage) { }

	[IteratorStateMachine(typeof(<SetColorOverTime>d__42))]
	private IEnumerator SetColorOverTime(Color initialColor, Color targetColor, float duration, MeshRenderer[] renderers) { }

	public void SetDefeated(bool defeated, bool animate = true) { }

	public void SetHeight(int height) { }

	public void SetMinigameType(RogueMiniGameData miniGameData) { }

	[AsyncStateMachine(typeof(<SetProp>d__35))]
	public Task SetProp(int propGroupIndex, int randomIndex, bool dontLoadAsset = false, bool waterfalls = false) { }

	public void SetPropAnim(string triggerName) { }

	public void SetPropRotation() { }

	[AsyncStateMachine(typeof(<SetType>d__40))]
	public Task SetType(RogueTileType tileType) { }

}

