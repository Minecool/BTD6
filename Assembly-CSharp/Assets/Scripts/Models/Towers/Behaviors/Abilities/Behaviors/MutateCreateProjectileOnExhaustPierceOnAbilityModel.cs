namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(MutateCreateProjectileOnExhaustPierceOnAbility), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MutateCreateProjectileOnExhaustPierceOnAbilityModel : AbilityBehaviorModel
{
	public int lifespanFrames; //Field offset: 0x30
	public int countIncrease; //Field offset: 0x34
	public string targetCPOEPId; //Field offset: 0x38

	public MutateCreateProjectileOnExhaustPierceOnAbilityModel(string name, int lifespanFrames, int countIncrease, string targetProjectileId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

