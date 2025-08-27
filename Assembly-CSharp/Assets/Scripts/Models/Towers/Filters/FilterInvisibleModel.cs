namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterInvisible), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterInvisibleModel : FilterModel
{
	public bool isActive; //Field offset: 0x30
	public bool ignoreBroadPhase; //Field offset: 0x31

	public FilterInvisibleModel(string name, bool isActive, bool ignoreBroadPhase) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

