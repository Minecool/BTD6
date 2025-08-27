namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateEffectOnExhausted : ProjectileBehavior
{
	private CreateEffectOnExhaustedModel createEffectOnExhaustedModel; //Field offset: 0x68
	private bool isDone; //Field offset: 0x70

	public CreateEffectOnExhausted() { }

	public virtual void Exhausted() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

