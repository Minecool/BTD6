namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

internal class ProjectileCreateEffectOnEmit : ProjectileBehaviorOnEmit
{
	public ProjectileCreateEffectOnEmitModel projectileCreateEffectOnEmitModel; //Field offset: 0x68

	public ProjectileCreateEffectOnEmit() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnEmit() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

