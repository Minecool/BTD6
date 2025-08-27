namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(MonkeyCityIncomeSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MonkeyCityIncomeSupportModel : SupportModel
{
	public string uniqueMutatorId; //Field offset: 0x60
	public float incomeModifier; //Field offset: 0x68

	public MonkeyCityIncomeSupportModel(string name, string uniqueMutatorId, float incomeModifier, TowerFilterModel[] filters, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

