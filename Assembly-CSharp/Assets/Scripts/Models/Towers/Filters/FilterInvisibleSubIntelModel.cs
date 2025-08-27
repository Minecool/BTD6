namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterInvisibleSubIntel), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterInvisibleSubIntelModel : FilterInvisibleModel
{

	public FilterInvisibleSubIntelModel(string name, bool isActive, bool ignoreBroadPhase) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

