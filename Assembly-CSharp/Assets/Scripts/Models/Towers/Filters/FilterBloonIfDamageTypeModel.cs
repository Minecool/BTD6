namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterBloonIfDamageType), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterBloonIfDamageTypeModel : FilterModel
{
	public BloonProperties ifCantHitBloonProperties; //Field offset: 0x30
	public DamageModel damageModel; //Field offset: 0x38

	public FilterBloonIfDamageTypeModel(string name, BloonProperties ifCantHitBloonProperties, DamageModel damageModel) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

