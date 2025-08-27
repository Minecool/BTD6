namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DestroyProjectileIfTowerDestroyed : ProjectileBehavior
{
	public DestroyProjectileIfTowerDestroyedModel destroyProjectileIfTowerDestroyedModel; //Field offset: 0x68

	public DestroyProjectileIfTowerDestroyed() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

