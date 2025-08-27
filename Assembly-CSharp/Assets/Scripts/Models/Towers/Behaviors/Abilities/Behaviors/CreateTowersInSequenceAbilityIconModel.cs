namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(CreateTowersInSequenceAbilityIcon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateTowersInSequenceAbilityIconModel : AbilityBehaviorModel
{
	public SpriteReference[] icons; //Field offset: 0x30

	public CreateTowersInSequenceAbilityIconModel(string name, SpriteReference[] icons) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

