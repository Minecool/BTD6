namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(FilterFractionOfBloonType), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterFractionOfBloonTypeModel : ProjectileBehaviorModel
{
	public float fraction; //Field offset: 0x38
	public string bloon; //Field offset: 0x40

	public FilterFractionOfBloonTypeModel(string name, float fraction, string bloon) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

