namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterBloonsToWithinAngle), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterBloonsToWithinAngleModel : FilterModel
{
	public float originDegrees; //Field offset: 0x30
	public float angleDegrees; //Field offset: 0x34
	public bool useTowerOrigin; //Field offset: 0x38

	public FilterBloonsToWithinAngleModel(string name, float originDegrees, float angleDegrees, bool useTowerOrigin) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

