namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateEffectOnExpire : ProjectileBehavior
{
	private CreateEffectOnExpireModel createEffectOnExpireModel; //Field offset: 0x68
	private bool isDone; //Field offset: 0x70

	public CreateEffectOnExpire() { }

	public virtual void Expired() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

