namespace Assets.Scripts.Unity.UI_New.InGame.RightMenu.Powers;

public class StandardInstaTowerButton : StandardPowerButton
{
	public NK_TextMeshProUGUI tiers; //Field offset: 0x90
	private bool locked; //Field offset: 0x98
	private TowerModel instaTowerModel; //Field offset: 0xA0

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

