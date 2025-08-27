namespace Assets.Scripts.Unity.UI_New;

public class MapSelectSimpleScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Toggle, Boolean> <>9__22_2; //Field offset: 0x8
		public static Func<Toggle, Boolean> <>9__22_3; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <SetupUI>b__22_2(Toggle j) { }

		internal bool <SetupUI>b__22_3(Toggle j) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public List<Toggle> buttons; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal void <SetupUI>b__0() { }

		internal void <SetupUI>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public MapSelectSimpleScreen <>4__this; //Field offset: 0x10
		public MapDetails map; //Field offset: 0x18

		public <>c__DisplayClass24_0() { }

		internal void <CreateMapInfoPane>b__0() { }

	}

	public Material grayscaleMaterial; //Field offset: 0x48
	public ScrollRect mapSelectScrollRect; //Field offset: 0x50
	public GameObject mapDisplayPrefab; //Field offset: 0x58
	public Transform mapDisplayParent; //Field offset: 0x60
	public Toggle mapDisplayBeginner; //Field offset: 0x68
	public Toggle mapDisplayInter; //Field offset: 0x70
	public Toggle mapDisplayAdvanced; //Field offset: 0x78
	public Toggle mapDisplayExpert; //Field offset: 0x80
	public Button mapPrevDifficultyBtn; //Field offset: 0x88
	public Button mapNextDifficultyBtn; //Field offset: 0x90
	public Lightbox mapBGBackBtn; //Field offset: 0x98
	public Toggle mapDisplayDebugShowHidden; //Field offset: 0xA0
	public float mapScrollSpeedAdjuster; //Field offset: 0xA8
	private GameObject selectedMapButton; //Field offset: 0xB0
	private RectTransform targetMap; //Field offset: 0xB8
	private RectTransform beginnerMap; //Field offset: 0xC0
	private RectTransform interMap; //Field offset: 0xC8
	private RectTransform advancedMap; //Field offset: 0xD0
	private RectTransform expertMap; //Field offset: 0xD8
	public Action<String> MapSelectedAction; //Field offset: 0xE0
	private int playerNumber; //Field offset: 0xE8
	private bool isScrolling; //Field offset: 0xEC

	public MapSelectSimpleScreen() { }

	private GameObject CreateMapInfoPane(MapDetails map) { }

	private void Initialise() { }

	private void MapBackgroundClicked() { }

	private void MapSelectAdvancedToggled(bool isOn) { }

	private void MapSelectBeginnerToggled(bool isOn) { }

	private void MapSelectExpertToggled(bool isOn) { }

	private void MapSelectInterToggled(bool isOn) { }

	public virtual void Open(object data) { }

	private void SetupUI() { }

	private void Update() { }

}

