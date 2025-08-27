namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class KineticChargeDisplayBehavior : BloonBehavior
{
	public KineticChargeDisplayBehaviorModel kineticChargeDisplayBehaviorModel; //Field offset: 0x70
	public DisplayMutator displayMutator; //Field offset: 0x78

	public KineticChargeDisplayBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PostDegrade(DamageResult damageResult, List<Bloon> childrenCreatedOut, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

