namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class DistributeCash : BloonBehavior
{
	public DistributeCashModel distributeCashModel; //Field offset: 0x70
	public bool calculateButDontAwardCashThisFrame; //Field offset: 0x78

	public DistributeCash() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PostDegrade(DamageResult damageResult, List<Bloon> childrenCreatedOut, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

