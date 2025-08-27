namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class HeroXpPerBloonLayerBehavior : ItemArtifactBehavior
{
	public HeroXpPerBloonLayerBehaviorModel heroXpPerBloonLayerBehaviorModel; //Field offset: 0x78

	public HeroXpPerBloonLayerBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnBloonDegrade(Projectile projectile, Bloon bloon, Tower poppedBy, DamageResult damageResult) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

