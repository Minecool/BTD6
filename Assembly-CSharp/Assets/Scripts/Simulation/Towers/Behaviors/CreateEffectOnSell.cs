namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateEffectOnSell : TowerBehavior
{
	public CreateEffectOnSellModel createEffectOnSellModel; //Field offset: 0x68
	public float scaleOverride; //Field offset: 0x70

	public CreateEffectOnSell() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnSold(float amount) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

