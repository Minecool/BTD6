namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class FreezeImmunityRemoval : BloonBehavior
{
	public FreezeImmunityRemovalModel freezeImmunityRemovalModel; //Field offset: 0x70

	public FreezeImmunityRemoval() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PostDegrade(DamageResult damageResult, List<Bloon> childrenCreatedOut, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

