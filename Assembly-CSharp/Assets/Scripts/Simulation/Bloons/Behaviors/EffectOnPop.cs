namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class EffectOnPop : BloonBehavior
{
	private EffectOnPopModel effectOnPopModel; //Field offset: 0x70

	public EffectOnPop() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PreDegrade(DamageResult damageResult, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

