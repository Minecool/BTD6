namespace Assets.Scripts.Unity.UI_New.InGame.RightMenu.Powers;

public class StandardInstaTowerButton : StandardPowerButton
{
	public NK_TextMeshProUGUI tiers; //Field offset: 0x78
	private bool locked; //Field offset: 0x80
	private TowerModel instaTowerModel; //Field offset: 0x88

	public StandardInstaTowerButton() { }

	protected virtual void DoubleClickedPowerButton() { }

	public virtual int GetUseCount() { }

	public bool HasInventory() { }

	public virtual bool IsAvailable() { }

	protected virtual void PowerButtonDown() { }

	public virtual void SetPower(PowerModel powerModel, bool isInsta) { }

	public virtual void UpdatePowerDisplay() { }

	private void UpdateUseCount(int useCount) { }

}

