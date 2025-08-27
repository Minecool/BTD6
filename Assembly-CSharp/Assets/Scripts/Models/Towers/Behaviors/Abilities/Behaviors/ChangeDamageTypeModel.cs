namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ChangeDamageType), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ChangeDamageTypeModel : AbilityBehaviorModel
{
	public int lifespanFrames; //Field offset: 0x30
	public bool cantBeAbsorbed; //Field offset: 0x34
	public BloonProperties immuneBloonProperties; //Field offset: 0x38

	public ChangeDamageTypeModel(string name, int lifespanFrames, bool cantBeAbsorbed, BloonProperties immuneBloonProperties) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

