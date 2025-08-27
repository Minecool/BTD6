namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class DamageOverTime : BloonBehavior
{
	public DamageOverTimeModel damageOverTimeModel; //Field offset: 0x70
	public int lastTick; //Field offset: 0x78
	public int addedAt; //Field offset: 0x7C

	public DamageOverTime() { }

	public virtual void Attatched() { }

	private void CheckTick() { }

	protected override void DealDamage() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void PostDegrade(DamageResult damageResult, List<Bloon> childrenCreatedOut, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

