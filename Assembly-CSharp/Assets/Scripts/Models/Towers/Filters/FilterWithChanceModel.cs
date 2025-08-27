namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterWithChance), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterWithChanceModel : FilterModel
{
	public float filterChance; //Field offset: 0x30

	public FilterWithChanceModel(string name, float filterChance) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

