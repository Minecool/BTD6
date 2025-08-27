namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterTargetAngle), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterTargetAngleModel : FilterModel
{
	public float fieldOfView; //Field offset: 0x30
	public float baseTowerRotationOffset; //Field offset: 0x34
	public bool ignoreTowerRotation; //Field offset: 0x38

	public FilterTargetAngleModel(string name, float fieldOfView, float baseTowerRotationOffset, bool ignoreBaseTowerRotation) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

