namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class SetTargetIndexFromBase : AttackBehavior
{
	public SetTargetIndexFromBaseModel setTargetIndexFromBaseModel; //Field offset: 0x68

	public SetTargetIndexFromBase() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTargetTypeChanged(Tower tower, TargetType targetType) { }

	public virtual void ThrowCacheUpdated() { }

	private void Update() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

