namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class ContestedTerritoryTilePopup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public int tileID; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal bool <Init>b__0(CtTileFocus x) { }

	}

	[CompilerGenerated]
	private struct <SetMarkerClicked>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryTilePopup <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowAnimatedThenHide>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameObject image; //Field offset: 0x20
		public ContestedTerritoryTilePopup <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateMapTileVisualsAsync>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryTilePopup <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Image gameTypeImg; //Field offset: 0x20
	public Sprite raceSpr; //Field offset: 0x28
	public Sprite leastCashSpr; //Field offset: 0x30
	public Sprite leastTiersSpr; //Field offset: 0x38
	public TMP_Text gameTypeTxt; //Field offset: 0x40
	public Image mapImage; //Field offset: 0x48
	public GameObject bannerTileObj; //Field offset: 0x50
	public GameObject relicTileObj; //Field offset: 0x58
	public Image relicIcon; //Field offset: 0x60
	public Sprite defaultRelicSpr; //Field offset: 0x68
	public TMP_Text relicNameTxt; //Field offset: 0x70
	public GameObject uncapturedObject; //Field offset: 0x78
	public GameObject capturedObject; //Field offset: 0x80
	public Image bannerImg; //Field offset: 0x88
	public TMP_Text ownerTxt; //Field offset: 0x90
	public TMP_Text scoreTxt; //Field offset: 0x98
	public TMP_Text neutralInTxt; //Field offset: 0xA0
	public TMP_Text tileInfoTxt; //Field offset: 0xA8
	public TMP_Text roundNumbersTxt; //Field offset: 0xB0
	public Button playBtn; //Field offset: 0xB8
	public Button closeBtn; //Field offset: 0xC0
	public Button bgBtn; //Field offset: 0xC8
	public Button setMarkerBtn; //Field offset: 0xD0
	public GameObject focusTickImg; //Field offset: 0xD8
	public GameObject focusLoadingImg; //Field offset: 0xE0
	public GameObject removeMarkerStrikeImg; //Field offset: 0xE8
	public NK_TextMeshProUGUI pointRateTxt; //Field offset: 0xF0
	public Action OnCloseClicked; //Field offset: 0xF8
	private int tileID; //Field offset: 0x100
	private ContestedTerritoryIslandTile tile; //Field offset: 0x108
	private float timer; //Field offset: 0x110

	public ContestedTerritoryTilePopup() { }

	[CompilerGenerated]
	private bool <SetMarkerClicked>b__42_0(CtTileFocus x) { }

	protected void Awake() { }

	private void CloseClicked() { }

	public void DeInit() { }

	public void Init(int tileID) { }

	private void OnDestroy() { }

	private void PlayClicked() { }

	private void SetMap(string mapId) { }

	[AsyncStateMachine(typeof(<SetMarkerClicked>d__42))]
	private void SetMarkerClicked() { }

	[AsyncStateMachine(typeof(<ShowAnimatedThenHide>d__43))]
	private Task ShowAnimatedThenHide(GameObject image) { }

	private void Update() { }

	private void UpdateAttackableVisuals() { }

	private void UpdateCapturedVisuals() { }

	[AsyncStateMachine(typeof(<UpdateMapTileVisualsAsync>d__39))]
	private void UpdateMapTileVisualsAsync() { }

}

