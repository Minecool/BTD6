namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(Spikeageddon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpikeaggedonModel : AbilityBehaviorModel
{
	public ProjectileModel projectileModel; //Field offset: 0x30
	public SingleEmissionModel singleEmissionModel; //Field offset: 0x38
	public EffectModel effectDuringFiring; //Field offset: 0x40
	public int explodeProjectilesAnimationState; //Field offset: 0x48

	public SpikeaggedonModel(string name, ProjectileModel projectileModel, EffectModel effectDuringFiring, int explodeProjectilesAnimationState) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

