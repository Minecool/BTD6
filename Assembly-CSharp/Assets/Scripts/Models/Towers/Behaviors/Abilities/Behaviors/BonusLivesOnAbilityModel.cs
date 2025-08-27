namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(BonusLivesOnAbility), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BonusLivesOnAbilityModel : AbilityBehaviorModel
{
	public float amount; //Field offset: 0x30

	public BonusLivesOnAbilityModel(string name, float amount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

