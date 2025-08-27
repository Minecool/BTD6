namespace Assets.Scripts.Unity.UI_New.MapSelect;

public class MapSelectPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Toggle, Boolean> <>9__24_2; //Field offset: 0x8
		public static Func<Toggle, Boolean> <>9__24_3; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <Initialise>b__24_2(Toggle j) { }

		internal bool <Initialise>b__24_3(Toggle j) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public List<Toggle> buttons; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal void <Initialise>b__0() { }

		internal void <Initialise>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public MapSelectPanel <>4__this; //Field offset: 0x10
		public Action OnSelectedMapComplete; //Field offset: 0x18

		public <>c__DisplayClass27_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_1
	{
		public MapDetails map; //Field offset: 0x10
		public <>c__DisplayClass27_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass27_1() { }

		internal void <MapSelectClicked>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public MapSelectPanel <>4__this; //Field offset: 0x10
		public Action OnSelectedMapComplete; //Field offset: 0x18

		public <>c__DisplayClass28_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_1
	{
		public MapDetails browserOnlyMap; //Field offset: 0x10
		public <>c__DisplayClass28_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass28_1() { }

		internal void <ShowHiddenMaps>b__0() { }

	}

	public Lightbox mapBGBackBtn; //Field offset: 0x20
	public Material grayscaleMaterial; //Field offset: 0x28
	public ScrollRect mapSelectScrollRect; //Field offset: 0x30
	public GameObject mapDisplayPrefab; //Field offset: 0x38
	public Transform mapDisplayParent; //Field offset: 0x40
	public Toggle mapDisplayBeginner; //Field offset: 0x48
	public Toggle mapDisplayInter; //Field offset: 0x50
	public Toggle mapDisplayAdvanced; //Field offset: 0x58
	public Toggle mapDisplayExpert; //Field offset: 0x60
	public Button mapPrevDifficultyBtn; //Field offset: 0x68
	public Button mapNextDifficultyBtn; //Field offset: 0x70
	public Toggle mapDisplayDebugShowHidden; //Field offset: 0x78
	public float mapScrollSpeedAdjuster; //Field offset: 0x80
	private bool mapSelectInit; //Field offset: 0x84
	private GameObject selectedMapButton; //Field offset: 0x88
	private String[] currDiffGameModes; //Field offset: 0x90
	private RectTransform targetMap; //Field offset: 0x98
	private RectTransform beginnerMap; //Field offset: 0xA0
	private RectTransform interMap; //Field offset: 0xA8
	private RectTransform advancedMap; //Field offset: 0xB0
	private RectTransform expertMap; //Field offset: 0xB8
	private bool mapScroller; //Field offset: 0xC0
	private bool hiddenMapsShown; //Field offset: 0xC1

	public MapSelectPanel() { }

	protected void Awake() { }

	private void GamepadSelectFirst() { }

	public void Initialise() { }

	public void MapBackgroundClicked() { }

	private void MapSelectAdvancedToggled(bool isOn) { }

	private void MapSelectBeginnerToggled(bool isOn) { }

	public void MapSelectClicked(Action OnSelectedMapComplete) { }

	private void MapSelectExpertToggled(bool isOn) { }

	private void MapSelectInterToggled(bool isOn) { }

	private void OnCoopDivisionLeftClicked() { }

	private void OnCoopDivisionRightClicked() { }

	private void SetCoopMapDivision() { }

	private void ShowHiddenMaps(Action OnSelectedMapComplete, bool value) { }

	private void Update() { }

}

