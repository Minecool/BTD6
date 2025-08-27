namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ChangeDamageType), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ChangeDamageTypeModel : AbilityBehaviorModel
{
	public int lifespanFrames; //Field offset: 0x30
	public BloonProperties immuneBloonProperties; //Field offset: 0x34

	public ChangeDamageTypeModel(string name, int lifespanFrames, BloonProperties immuneBloonProperties) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

