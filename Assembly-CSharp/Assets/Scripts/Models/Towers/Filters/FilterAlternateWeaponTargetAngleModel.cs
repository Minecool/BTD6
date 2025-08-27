namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterAlternateWeaponTargetAngle), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterAlternateWeaponTargetAngleModel : FilterModel
{
	public float fieldOfView; //Field offset: 0x30
	public float baseTowerRotationOffset; //Field offset: 0x34

	public FilterAlternateWeaponTargetAngleModel(string name, float fieldOfView, float baseTowerRotationOffset) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

