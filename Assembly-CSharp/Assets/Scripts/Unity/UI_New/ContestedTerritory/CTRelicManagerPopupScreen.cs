namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class CTRelicManagerPopupScreen : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TeamsStoreItem, Boolean> <>9__25_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <PopulateRelics>b__25_0(TeamsStoreItem storeItem) { }

	}

	[CompilerGenerated]
	private struct <Awake>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CTRelicManagerPopupScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<IReadOnlyCollection`1<ContestedTerritoryRelicType>> <>u__1; //Field offset: 0x30
		private TaskAwaiter<ContestedTerritoryRelicType[]> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class OnPopupClosed : MulticastDelegate
	{

		public OnPopupClosed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public TeamsStoreUiPanel teamsStoreItemPrefab; //Field offset: 0x20
	public ContestedTerritoryTileDetailsScreen parentScreen; //Field offset: 0x28
	public GridLayoutGroup selectedRelicsGroup; //Field offset: 0x30
	public GridLayoutGroup availableRelicsGroup; //Field offset: 0x38
	public GameObject selectButtonGroup; //Field offset: 0x40
	public Button cancelBtn; //Field offset: 0x48
	public Lightbox bgBackBtn; //Field offset: 0x50
	public Button selectBtn; //Field offset: 0x58
	public Button deSelectBtn; //Field offset: 0x60
	public GameObject bottomInfo; //Field offset: 0x68
	public TMP_Text heading; //Field offset: 0x70
	public TMP_Text description; //Field offset: 0x78
	public TMP_Text countTxt; //Field offset: 0x80
	public Animator animator; //Field offset: 0x88
	protected bool initialised; //Field offset: 0x90
	private CTEventData ctEventData; //Field offset: 0x98
	private readonly List<TeamsStoreUiPanel> uiPanels; //Field offset: 0xA0
	private readonly List<ContestedTerritoryRelicType> orderedRelics; //Field offset: 0xA8
	private IReadOnlyCollection<ContestedTerritoryRelicType> teamRelicItems; //Field offset: 0xB0
	private TeamsStoreUiPanelBase selectedUiPanel; //Field offset: 0xB8
	private ContestedTerritoryRelicType[] currentCTRelics; //Field offset: 0xC0

	private bool IsInGuild
	{
		private get { } //Length: 64
	}

	public CTRelicManagerPopupScreen() { }

	[CompilerGenerated]
	private void <Awake>b__24_0() { }

	[CompilerGenerated]
	private void <Awake>b__24_1() { }

	[AsyncStateMachine(typeof(<Awake>d__24))]
	protected void Awake() { }

	public void ClosePopup() { }

	private void DisplaySelectButton(bool selected) { }

	private bool get_IsInGuild() { }

	public void OnPanelSelected(TeamsStoreUiPanelBase selection) { }

	public void OnSelectRelicPressed(bool selected) { }

	private void PopulateRelics() { }

	private int SortFunction(TeamsStoreUiPanel uiPanel) { }

	private void UpdateAndClosePopup() { }

	private void UpdateInfoPanel() { }

	private void UpdateSelectedRelicsDisplay() { }

	private void ValidateSelectedRelics() { }

}

