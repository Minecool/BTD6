namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(IgnoreDmgImmunity), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class IgnoreDmgImmunityModel : BloonBehaviorModel
{
	public BloonProperties removeBloonProperties; //Field offset: 0x30
	public float chance; //Field offset: 0x34

	public IgnoreDmgImmunityModel() { }

	public IgnoreDmgImmunityModel(string name, BloonProperties removeBloonProperties, float chance) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

