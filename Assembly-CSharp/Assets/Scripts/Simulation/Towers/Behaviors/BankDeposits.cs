namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class BankDeposits : TowerBehavior
{
	public BankDepositsModel bankDepositsModel; //Field offset: 0x68
	private Bank bank; //Field offset: 0x70
	private TSMInfoModel tsmInfoModel; //Field offset: 0x78

	public BankDeposits() { }

	public float GetDepositAmount() { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnTsmThemeAction(string themeId, string buttonId, TSMInfoModel info) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

