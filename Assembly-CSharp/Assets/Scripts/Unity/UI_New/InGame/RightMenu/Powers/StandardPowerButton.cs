namespace Assets.Scripts.Unity.UI_New.InGame.RightMenu.Powers;

public class StandardPowerButton : PowerButton
{
	public Image icon; //Field offset: 0x38
	public Color lockedColor; //Field offset: 0x40
	public Color lockedTextColor; //Field offset: 0x50
	public GameObject powerCountIcon; //Field offset: 0x60
	public NK_TextMeshProUGUI powerCountText; //Field offset: 0x68
	public GameObject selectedHighlight; //Field offset: 0x70

	public StandardPowerButton() { }

	protected virtual void DoubleClickedPowerButton() { }

	public virtual Image GetIcon() { }

	public override int GetUseCount() { }

	public virtual void Highlight() { }

	protected virtual void PowerButtonDown() { }

	public virtual void StartDragging() { }

	public virtual void StopDragging() { }

	public virtual void StopHighlight() { }

	public virtual void UpdateIcon() { }

	public virtual void UpdatePowerDisplay() { }

	private void UpdateUseCount(int useCount) { }

}

