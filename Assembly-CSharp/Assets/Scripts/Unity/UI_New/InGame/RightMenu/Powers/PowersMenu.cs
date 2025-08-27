namespace Assets.Scripts.Unity.UI_New.InGame.RightMenu.Powers;

public class PowersMenu : RatioObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<PowerModel, Boolean> <>9__52_0; //Field offset: 0x8
		public static Func<PowerModel, Boolean> <>9__52_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <RebuildPowers>b__52_0(PowerModel p) { }

		internal bool <RebuildPowers>b__52_1(PowerModel p) { }

	}

	public static PowersMenu instance; //Field offset: 0x0
	private const int animationStateOpen = 1; //Field offset: 0x0
	private const int animationStateClosed = 0; //Field offset: 0x0
	private const string powersPopupEvent = "ft_powers"; //Field offset: 0x0
	private const int animationStateClosed43 = 4; //Field offset: 0x0
	private const int animationStateOpen43 = 5; //Field offset: 0x0
	private const int animationStateClosedLeft = 2; //Field offset: 0x0
	private const int animationStateOpenLeft = 3; //Field offset: 0x0
	public GameObject powerButtons; //Field offset: 0x20
	public GameObject unusedButtons; //Field offset: 0x28
	public GameObject powerButtonPrefab; //Field offset: 0x30
	public ScrollRectWithDragCancel scrollRect; //Field offset: 0x38
	public Button getMorePowersLarge; //Field offset: 0x40
	public RectTransform powersMenuRect; //Field offset: 0x48
	public GameObject showInstaMonkeysButton; //Field offset: 0x50
	public InstaTowerGroupMenu instaTowerGroupMenu; //Field offset: 0x58
	public InstaTowersMenu instaTowerMenu; //Field offset: 0x60
	[Header("Filters")]
	public Toggle filterPowers; //Field offset: 0x68
	public Toggle filterPowersPro; //Field offset: 0x70
	public Toggle filterInstas; //Field offset: 0x78
	public AudioClip click3Sound; //Field offset: 0x80
	public AudioClip tabSound; //Field offset: 0x88
	private bool resetButtonPositions; //Field offset: 0x90
	private bool open; //Field offset: 0x91
	private bool scrollingToInstaMonkeys; //Field offset: 0x92
	private float scrollToInstasNormalizedPosition; //Field offset: 0x94
	private readonly string visibleStateLabel; //Field offset: 0x98
	private Animator panelAnimator; //Field offset: 0xA0
	private bool useLeftSide; //Field offset: 0xA8
	private List<GameObject> powerUseButtons; //Field offset: 0xB0
	private bool instasDisabled; //Field offset: 0xB8
	private bool disablePowerPurchases; //Field offset: 0xB9
	private bool dontUsePlayerInventory; //Field offset: 0xBA
	private bool rogueInventory; //Field offset: 0xBB
	private bool overrideHideInstaMonkeysButton; //Field offset: 0xBC
	private PowerButton selectedButton; //Field offset: 0xC0

	public bool DisablePowerPurchases
	{
		 get { } //Length: 8
	}

	public bool DontUsePlayerInventory
	{
		 get { } //Length: 8
	}

	public PowerButton SelectedButton
	{
		 get { } //Length: 8
	}

	public PowersMenu() { }

	[CompilerGenerated]
	private void <Initialise>b__43_0(BaseEventData _) { }

	[CompilerGenerated]
	private void <Initialise>b__43_1(BaseEventData _) { }

	[CompilerGenerated]
	private void <Initialise>b__43_2(BaseEventData _) { }

	public void ClearButtons() { }

	public void Close() { }

	protected void CreateTowerButton(PowerModel model) { }

	public void EndPowerPlacement(PowerButton powerButton) { }

	public bool get_DisablePowerPurchases() { }

	public bool get_DontUsePlayerInventory() { }

	public PowerButton get_SelectedButton() { }

	public GameObject GetNextButton() { }

	private bool HasAPowerToUse() { }

	public virtual void Initialise() { }

	public bool InsideMenuRect(Vector2 pos) { }

	public bool IsOpen() { }

	public bool IsSelected(PowerButton b) { }

	public void LoadPowers() { }

	private void MenuScrolled() { }

	private void OnDestroy() { }

	private void OnEnable() { }

	private void OnSceneHit() { }

	public virtual void OnUpdate() { }

	public void Open() { }

	public void PowerUseFailed(PowerButton powerButton) { }

	public void PowerUseSuccess(PowerButton powerButton) { }

	protected void RebuildPowers() { }

	public void Select(PowerButton b, bool playSound, string nameDisplayOverride = null) { }

	private void SelectBase(PowerButton b, bool playSound, string nameDisplayOverride = null, bool upgradesButtonInteractableOverride = false) { }

	public void SelectPowerPro(string powerProBaseId, bool playSound) { }

	public void SetupQuestEditorMode() { }

	private void ShowAll() { }

	private void ShowInstaMonkeys() { }

	private void ShowInstas(bool show) { }

	private void ShowPurchasePowerUpScreen() { }

	public void StartPowerPlacement(PowerButton powerButton) { }

	public void ToggleFilterInstas() { }

	public void ToggleFilterPowers() { }

	public void ToggleFilterPowersPro() { }

	private void Update() { }

	public void UpdatePowerPlacer(Vector2 pos, bool canPlace) { }

	public void UpdateShowInstaMonkeysButton() { }

}

