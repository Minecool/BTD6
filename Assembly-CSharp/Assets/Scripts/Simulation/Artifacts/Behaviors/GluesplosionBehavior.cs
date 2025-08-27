namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class GluesplosionBehavior : ItemArtifactBehavior
{
	public GluesplosionBehaviorModel gluesplosionBehaviorModel; //Field offset: 0x78
	private BloonProperties immunitiesFromExplosion; //Field offset: 0x80

	public GluesplosionBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnBloonDegrade(Projectile projectile, Bloon bloon, Tower poppedBy, DamageResult damageResult) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

