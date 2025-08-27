namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(DamageModifierSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageModifierSupportModel : SupportModel
{
	public string mutatorId; //Field offset: 0x60
	public bool isUnique; //Field offset: 0x68
	[SerializeReference]
	public DamageModifierModel damageModifierModel; //Field offset: 0x70

	public DamageModifierSupportModel(string name, bool isUnique, string mutatorId, TowerFilterModel[] filters, bool isGlobal, DamageModifierModel damageModifierModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

