namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DetonateEffect : ProjectileBehavior
{
	public DetonateEffectModel detonateEffectModel; //Field offset: 0x68
	private String[] effectTagsArray; //Field offset: 0x70

	public DetonateEffect() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

