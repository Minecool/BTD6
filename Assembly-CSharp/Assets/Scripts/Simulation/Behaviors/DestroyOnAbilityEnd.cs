namespace Assets.Scripts.Simulation.Behaviors;

public class DestroyOnAbilityEnd : RootBehavior
{
	public DestroyOnAbilityEndModel destroyOnAbilityEndModel; //Field offset: 0x58

	public DestroyOnAbilityEnd() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

