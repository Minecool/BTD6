namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class PopsFiredBehavior : ItemArtifactBehavior
{
	public PopsFiredBehaviorModel popsFiredBehaviorModel; //Field offset: 0x78
	private BloonProperties immunitiesFromFire; //Field offset: 0x80

	public PopsFiredBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnBloonDegrade(Projectile projectile, Bloon bloon, Tower poppedBy, DamageResult damageResult) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

