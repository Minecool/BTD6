namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public class TowerPurchaseButton2D : TowerPurchaseButton
{
	[SerializeField]
	protected Image bg; //Field offset: 0xE0
	[SerializeField]
	private Image icon; //Field offset: 0xE8
	[SerializeField]
	private Material grayscaleMaterial; //Field offset: 0xF0
	[SerializeField]
	private Image monkeyTeamsTopImg; //Field offset: 0xF8
	[SerializeField]
	private Animator monkeyTeamsBreakPrefab; //Field offset: 0x100
	[SerializeField]
	private SpriteReference primarySprite; //Field offset: 0x108
	[SerializeField]
	private SpriteReference militarySprite; //Field offset: 0x110
	[SerializeField]
	private SpriteReference magicSprite; //Field offset: 0x118
	[SerializeField]
	private SpriteReference supportSprite; //Field offset: 0x120
	[SerializeField]
	private SpriteReference heroSprite; //Field offset: 0x128
	[SerializeField]
	private SpriteReference monkeyTeamsBgSprite; //Field offset: 0x130
	[SerializeField]
	private SpriteReference monkeyTeamsTopSprite; //Field offset: 0x138

	public TowerPurchaseButton2D() { }

	public void Bind(RatioObject menu, Model model, SpriteReference iconSprite, bool showCount, int buttonIndex) { }

	protected SpriteReference DetermineBackgroundSprite() { }

	protected virtual void SetAvailable() { }

	protected virtual void SetCountIconGrayscale(bool grayScale) { }

	public virtual void SetLocked() { }

	protected virtual void SetNotEnoughCash() { }

	protected virtual void SetUnavailable() { }

	public virtual void StartDragging() { }

	public virtual void StopDragging() { }

	public virtual void UpdateDisplay(bool canPlayMonkeyTeamBrokenAnim = false) { }

}

