namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(SlowMinusAbilityDuration), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SlowMinusAbilityDurationModel : SlowModel
{
	public string abilityId; //Field offset: 0x88

	public SlowMinusAbilityDurationModel(string name, float multiplier, float lifespan, string mutationId, int layers, string overlayType, string abilityId, bool isUnique, bool dontRefreshDuration, EffectModel effectModel, bool cascadeMutators, bool removeMutatorIfNotMatching) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

