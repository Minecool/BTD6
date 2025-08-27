namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DestroyProjectileIfModelChanged : ProjectileBehavior
{
	private Tower tower; //Field offset: 0x68
	public DestroyProjectileIfModelChangedModel destroyProjectileIfModelChangedModel; //Field offset: 0x70

	public DestroyProjectileIfModelChanged() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

