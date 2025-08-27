namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class MoabBarrageBloonBehavior : BloonBehavior
{
	public MoabBarrageBloonBehaviorModel moabBarrageBloonBehaviorModel; //Field offset: 0x70
	public int lastMissileTick; //Field offset: 0x78
	public int lastExplosionTick; //Field offset: 0x7C
	private readonly List<Entity> missileEffects; //Field offset: 0x80
	private string towerName; //Field offset: 0x88
	private int missileCount; //Field offset: 0x90
	private int explosionCount; //Field offset: 0x94

	public MoabBarrageBloonBehavior() { }

	private void CheckExplosionTick() { }

	private void CheckMissileTick() { }

	protected override void DealDamage() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void PlaySound() { }

	public virtual void PostDegrade(DamageResult damageResult, List<Bloon> childrenCreatedOut, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

