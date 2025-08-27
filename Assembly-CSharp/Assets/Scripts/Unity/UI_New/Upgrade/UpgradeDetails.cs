namespace Assets.Scripts.Unity.UI_New.Upgrade;

public class UpgradeDetails : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private struct <LoadIcon>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SpriteReference iconRef; //Field offset: 0x20
		public UpgradeDetails <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum TowerUnlockThemeType
	{
		Standard = 0,
		Tier5 = 1,
		Paragon = 2,
	}

	internal class UpgradeDetailsTheme
	{
		public TowerUnlockThemeType themeType; //Field offset: 0x10
		public Image upgradeButton; //Field offset: 0x18
		public GameObject selected; //Field offset: 0x20
		public SpriteReference avaliable; //Field offset: 0x28
		public SpriteReference cantAfford; //Field offset: 0x30
		public SpriteReference owned; //Field offset: 0x38
		public SpriteReference paragonPurchased; //Field offset: 0x40
		public Color avaliableTextColor; //Field offset: 0x48
		public Color unAvaliableTextColor; //Field offset: 0x58
		public GameObject newlyUnlockedEffect; //Field offset: 0x68
		public bool showNotPurchasedIcon; //Field offset: 0x70
		public GameObject purchaseEffect; //Field offset: 0x78

		public UpgradeDetailsTheme() { }

	}

	public const float popupCountdownCursor = 0.5; //Field offset: 0x0
	public Image icon; //Field offset: 0x20
	public NK_TextMeshProUGUI upgradeName; //Field offset: 0x28
	public NK_TextMeshProUGUI upgradeCost; //Field offset: 0x30
	public GameObject abilityObject; //Field offset: 0x38
	public string baseTowerID; //Field offset: 0x40
	public SpriteReference portrait; //Field offset: 0x48
	public UpgradeModel upgrade; //Field offset: 0x50
	public Image restrictedIcon; //Field offset: 0x58
	public Material spriteMaterial; //Field offset: 0x60
	public Material lockedMaterial; //Field offset: 0x68
	public UpgradeDetailsTheme standardTheme; //Field offset: 0x70
	public UpgradeDetailsTheme tier5Theme; //Field offset: 0x78
	public UpgradeDetailsTheme paragonTheme; //Field offset: 0x80
	public int path; //Field offset: 0x88
	private bool hasUpgrade; //Field offset: 0x8C
	private UpgradeDetailsTheme theme; //Field offset: 0x90
	private bool isLocked; //Field offset: 0x98
	private UpgradeScreen upgradeScreen; //Field offset: 0xA0
	private bool prevHadUpgrade; //Field offset: 0xA8
	public bool beginShowPopup; //Field offset: 0xA9
	public float popupTimer; //Field offset: 0xAC

	public bool HasUpgradeUnlocked
	{
		 get { } //Length: 8
	}

	public UpgradeDetails() { }

	[CompilerGenerated]
	private bool <CheckDcRestriction>b__40_0(TowerData x) { }

	public bool CheckDcRestriction() { }

	public bool get_HasUpgradeUnlocked() { }

	public Button GetButton() { }

	public void HideGamepadPopup() { }

	public void HideUpgrade() { }

	public bool IsLocked() { }

	[AsyncStateMachine(typeof(<LoadIcon>d__24))]
	private Task LoadIcon(SpriteReference iconRef) { }

	public void OnClick() { }

	public override void OnPointerEnter(PointerEventData data) { }

	public override void OnPointerExit(PointerEventData data) { }

	public void OnPressed() { }

	public void OnRelease() { }

	public void SetAvaliable() { }

	public void SetLocked() { }

	public void SetNewlyUnlocked() { }

	public void SetNoLongerNew() { }

	public void SetNotEnoughXP() { }

	public void SetPurchased(bool isParagonPurchased) { }

	public void SetRestricted(bool hasUpgrade, out bool lockParagonPanel) { }

	public void SetSelected() { }

	public void SetUnSelected() { }

	public void SetUpgrade(string baseTowerID, UpgradeModel upgrade, ICollection<AbilityModel> abilities, int path, SpriteReference portrait) { }

	public void SetUpgradeScreen(UpgradeScreen screen) { }

	public void ShowGamepadPopup() { }

	private void Update() { }

	private void UpdateSelected() { }

}

