namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public class TowerPurchaseButtonRogue : TowerPurchaseButton
{
	[SerializeField]
	private Image bg; //Field offset: 0xE0
	[SerializeField]
	private Image icon; //Field offset: 0xE8
	[SerializeField]
	private Material grayscaleMaterial; //Field offset: 0xF0
	[SerializeField]
	private NK_TextMeshProUGUI crossPathTxt; //Field offset: 0xF8
	[SerializeField]
	private NK_TextMeshProUGUI cooldownTxt; //Field offset: 0x100
	[SerializeField]
	private GameObject cooldownObj; //Field offset: 0x108
	[SerializeField]
	private Animator cooldownAnimator; //Field offset: 0x110
	public RogueInstaMonkey rogueInsta; //Field offset: 0x118
	public bool cooldownChanged; //Field offset: 0x120
	[SerializeField]
	private SpriteReference primarySprite; //Field offset: 0x128
	[SerializeField]
	private SpriteReference militarySprite; //Field offset: 0x130
	[SerializeField]
	private SpriteReference magicSprite; //Field offset: 0x138
	[SerializeField]
	private SpriteReference supportSprite; //Field offset: 0x140
	[SerializeField]
	private SpriteReference heroSprite; //Field offset: 0x148

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueGameSaveData RogueSaveGameData
	{
		private get { } //Length: 211
	}

	public TowerPurchaseButtonRogue() { }

	public void Bind(RatioObject menu, Model model, SpriteReference iconSprite, bool showCount, int buttonIndex, RogueInstaMonkey rogueInsta) { }

	public virtual void ButtonActivated(bool isFromHotkey) { }

	private void CooldownUpdated() { }

	protected SpriteReference DetermineBackgroundSprite() { }

	private ITowerPurchaseButton FindNextAvailableButton(int startingIndex) { }

	private LegendsDataModel get_LegendsData() { }

	private RogueGameSaveData get_RogueSaveGameData() { }

	public int GetCost() { }

	private TowerPurchaseLockState GetLockedState() { }

	public virtual void OnDestroy() { }

	public void PlayUnlockAnim() { }

	public void PrimeTower() { }

	protected virtual void SetAvailable() { }

	protected virtual void SetCountIconGrayscale(bool grayScale) { }

	public virtual void SetLocked() { }

	public void SetMaxCooldown() { }

	protected virtual void SetNotEnoughCash() { }

	protected virtual void SetUnavailable() { }

	private void Start() { }

	public virtual void StartDragging() { }

	public virtual void StopDragging() { }

	protected virtual void Update() { }

	public void UpdateCooldown() { }

	public virtual void UpdateDisplay(bool canPlayMonkeyTeamBrokenAnim = false) { }

}

