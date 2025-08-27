namespace Assets.Scripts.Unity.UI_New.InGame.RightMenu.Powers;

public class RoguePowerButton : PowerButton
{
	[SerializeField]
	private Image icon; //Field offset: 0x38
	[SerializeField]
	private GameObject selectedHighlight; //Field offset: 0x40
	[SerializeField]
	private NK_TextMeshProUGUI costTxt; //Field offset: 0x48
	[SerializeField]
	private Color lockedColor; //Field offset: 0x50
	[SerializeField]
	private Color lockedTextColor; //Field offset: 0x60
	private int cost; //Field offset: 0x70
	private RogueInstaMonkey rogueInsta; //Field offset: 0x78

	public RoguePowerButton() { }

	private bool CanAfford() { }

	protected virtual void DoubleClickedPowerButton() { }

	public virtual Image GetIcon() { }

	public override int GetUseCount() { }

	public virtual void Highlight() { }

	public virtual bool IsAvailable() { }

	protected virtual void PowerButtonDown() { }

	public void PurchaseRoguePower() { }

	public void SetInsta(RogueInstaMonkey rogueInsta) { }

	public virtual void StartDragging() { }

	public virtual void StopDragging() { }

	public virtual void StopHighlight() { }

	public virtual void UpdateIcon() { }

	public virtual void UpdatePowerDisplay() { }

}

