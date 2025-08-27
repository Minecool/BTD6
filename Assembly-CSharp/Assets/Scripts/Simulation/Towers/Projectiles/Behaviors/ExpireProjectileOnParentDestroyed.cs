namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ExpireProjectileOnParentDestroyed : ProjectileBehavior
{
	public ExpireProjectileOnParentDestroyedModel expireProjectileOnParentDestroyedModel; //Field offset: 0x68
	private Tower parentTower; //Field offset: 0x70

	public ExpireProjectileOnParentDestroyed() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

