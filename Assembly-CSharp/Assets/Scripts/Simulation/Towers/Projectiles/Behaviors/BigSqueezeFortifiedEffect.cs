namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class BigSqueezeFortifiedEffect : ProjectileBehavior
{
	private BigSqueezeFortifiedEffectModel bigSqueezeFortifiedEffectModel; //Field offset: 0x68
	private bool isDone; //Field offset: 0x70

	public BigSqueezeFortifiedEffect() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

