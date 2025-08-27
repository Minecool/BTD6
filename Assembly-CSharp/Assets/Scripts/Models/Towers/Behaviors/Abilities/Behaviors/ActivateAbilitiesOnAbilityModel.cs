namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ActivateAbilitiesOnAbility), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ActivateAbilitiesOnAbilityModel : AbilityBehaviorModel
{
	public string abilityToFind; //Field offset: 0x30

	public ActivateAbilitiesOnAbilityModel(string name, string abilityToFind) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

