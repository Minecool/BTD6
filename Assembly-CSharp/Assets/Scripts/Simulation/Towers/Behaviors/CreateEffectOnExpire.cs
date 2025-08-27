namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateEffectOnExpire : TowerBehavior
{
	public CreateEffectOnExpireModel createEffectOnExpireModel; //Field offset: 0x68
	public float scaleOverride; //Field offset: 0x70

	public CreateEffectOnExpire() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnExpire() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

