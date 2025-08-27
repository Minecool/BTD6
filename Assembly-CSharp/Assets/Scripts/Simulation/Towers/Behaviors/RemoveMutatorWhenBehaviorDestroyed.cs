namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class RemoveMutatorWhenBehaviorDestroyed : TowerBehavior
{
	public RemoveMutatorWhenBehaviorDestroyedModel removeMutatorWhenBehaviorDestroyedModel; //Field offset: 0x68

	public RemoveMutatorWhenBehaviorDestroyed() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

