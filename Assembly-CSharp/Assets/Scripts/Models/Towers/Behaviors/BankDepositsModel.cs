namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(BankDeposits), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BankDepositsModel : TowerBehaviorModel
{
	public float depositPercent; //Field offset: 0x30
	public PrefabReference displayPath; //Field offset: 0x38
	public float displayLifetime; //Field offset: 0x40

	public BankDepositsModel(string name, float depositPercent, PrefabReference displayPath, float displayLifetime) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

