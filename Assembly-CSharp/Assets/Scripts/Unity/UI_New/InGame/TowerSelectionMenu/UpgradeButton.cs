namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class UpgradeButton : DynamicUiObject, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
{
	[CompilerGenerated]
	private sealed class <Initialise>d__58 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public UpgradeButton <>4__this; //Field offset: 0x20

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
		public <Initialise>d__58(int <>1__state) { }

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

	internal enum UpgradeStatus
	{
		None = 0,
		Locked = 1,
		DcLocked = 2,
		Upgradable = 3,
		NotEnoughXp = 4,
		Purchasable = 5,
		SpecialLocked = 6,
		CanNotAfford = 7,
		Paragon = 8,
		NoTiersLeft = 9,
		WornHerosCape = 10,
		ParagonLimitReached = 11,
		NeedsWater = 12,
		NeedsBeasts = 13,
		NeedsTrack = 14,
	}

	public static float upgradeCashOffset; //Field offset: 0x0
	public NK_TextMeshProUGUI label; //Field offset: 0x20
	public NK_TextMeshProUGUI cost; //Field offset: 0x28
	public NK_TextMeshProUGUI labelParagon; //Field offset: 0x30
	public NK_TextMeshProUGUI costParagon; //Field offset: 0x38
	public Color costActiveColor; //Field offset: 0x40
	public Color costInactiveColor; //Field offset: 0x50
	public NK_TextMeshProUGUI lockedText; //Field offset: 0x60
	public Image icon; //Field offset: 0x68
	public GameObject purchaseArrowGlow; //Field offset: 0x70
	private TowerToSimulation tts; //Field offset: 0x78
	public SpriteReference backgroundActive; //Field offset: 0x80
	public SpriteReference backgroundInactive; //Field offset: 0x88
	public SpriteReference backgroundParagon; //Field offset: 0x90
	public SpriteReference backgroundBeastHandlerContributed; //Field offset: 0x98
	private UpgradeModel upgrade; //Field offset: 0xA0
	private Image background; //Field offset: 0xA8
	public Image restrictedIcon; //Field offset: 0xB0
	public Image lockedIcon; //Field offset: 0xB8
	public Image upgradableIcon; //Field offset: 0xC0
	public GameObject wornHerosCape; //Field offset: 0xC8
	public GameObject needsWater; //Field offset: 0xD0
	public GameObject needsBeasts; //Field offset: 0xD8
	public GameObject needsTrack; //Field offset: 0xE0
	public Color upgradeAvailableColor; //Field offset: 0xE8
	public Color upgradeUnavailableColor; //Field offset: 0xF8
	public Color purchasableColor; //Field offset: 0x108
	public Color nonPurchasableColor; //Field offset: 0x118
	public Material lockedMaterial; //Field offset: 0x128
	public Material unlockedMaterial; //Field offset: 0x130
	public Animator wobbleAnimation; //Field offset: 0x138
	public GameObject monkeyVillageRequirement; //Field offset: 0x140
	public NK_TextMeshProUGUI monkeyVillageRequirementText; //Field offset: 0x148
	public Image needsBeastsIcon; //Field offset: 0x150
	public NK_TextMeshProUGUI needsBeastsCountText; //Field offset: 0x158
	public NK_TextMeshProUGUI needsBeastsText; //Field offset: 0x160
	public GameObject needsBeastsCountBackground; //Field offset: 0x168
	public int row; //Field offset: 0x170
	public GameObject beastPowerAddObject; //Field offset: 0x178
	public NK_TextMeshProUGUI beastPowerAddText; //Field offset: 0x180
	public NK_TextMeshProUGUI costBeastMerge; //Field offset: 0x188
	public GameObject mergeButtonContainer; //Field offset: 0x190
	public Button mergeButton; //Field offset: 0x198
	private float upgradeCost; //Field offset: 0x1A0
	private UpgradeStatus upgradeStatus; //Field offset: 0x1A4
	private string title; //Field offset: 0x1A8
	private string desc; //Field offset: 0x1B0
	private float hoverPopupDelay; //Field offset: 0x1B8
	private bool hovering; //Field offset: 0x1BC
	private float hoverTimer; //Field offset: 0x1C0

	public NK_TextMeshProUGUI Cost
	{
		 get { } //Length: 172
	}

	public bool IsBeastHandler
	{
		 get { } //Length: 97
	}

	public bool IsBeastHandlerContributionUpgradeAvailable
	{
		 get { } //Length: 386
	}

	public bool IsParagon
	{
		 get { } //Length: 61
	}

	public NK_TextMeshProUGUI Label
	{
		 get { } //Length: 66
	}

	public UpgradeButton() { }

	public void CheckCash() { }

	public bool CheckDcLocked(int path, bool upgradeClicked) { }

	public void CheckXP() { }

	public bool DoesNotOwn() { }

	public NK_TextMeshProUGUI get_Cost() { }

	public bool get_IsBeastHandler() { }

	public bool get_IsBeastHandlerContributionUpgradeAvailable() { }

	public bool get_IsParagon() { }

	public NK_TextMeshProUGUI get_Label() { }

	public ValueTuple<Boolean, String, String> GetShowTitleDesc() { }

	public float GetUpgradeCost() { }

	public UpgradeModel GetUpgradeModel() { }

	public UpgradeStatus GetUpgradeStatus(int path, bool upgradeClicked = false) { }

	private bool HasUnlockedUpgrade() { }

	[IteratorStateMachine(typeof(<Initialise>d__58))]
	public virtual IEnumerator Initialise() { }

	public string IsUpgradeBlocked() { }

	public void LoadBackground(bool isBackgroundInactive = false) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	private void SetImageActive(GameObject obj, bool active) { }

	private void SetSpecialLocksActive(string customLockId) { }

	private void SetSpecialLocksNotActive() { }

	private void SetTextActive(GameObject obj, bool active) { }

	public void SetTextColour() { }

	public void SetTower(TowerToSimulation tts) { }

	public void SetUpgradeModel(UpgradeModel um) { }

	public void Update() { }

	private void UpdateBeastHandlerUI(UpgradeStatus upgradeStatus, int path) { }

	public void UpdateCost() { }

	private void UpdateCostVisuals() { }

	private void UpdateMergeButton(TowerToSimulation tts) { }

	private void UpdateNeedsBeastsDetails(UpgradeStatus upgradeStatus, int path) { }

	public void UpdateSpecialButtons(int path, TowerToSimulation tts) { }

	public void UpdateSpecialLockUI() { }

	public void UpdateVisuals(int path, bool upgradeClicked) { }

	public void WobbleUpgrade() { }

}

