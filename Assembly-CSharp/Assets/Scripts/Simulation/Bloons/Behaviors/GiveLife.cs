namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class GiveLife : BloonBehavior
{
	public GiveLifeModel giveLifeModel; //Field offset: 0x70

	public GiveLife() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PreDegrade(DamageResult damageResult, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

