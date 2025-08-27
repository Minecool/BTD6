namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ExpireProjectileOnBossSpawned : ProjectileBehavior
{
	public ExpireProjectileOnBossSpawnedModel expireProjectileOnBossSpawned; //Field offset: 0x68

	public ExpireProjectileOnBossSpawned() { }

	private void BossSpawnedEvent() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

