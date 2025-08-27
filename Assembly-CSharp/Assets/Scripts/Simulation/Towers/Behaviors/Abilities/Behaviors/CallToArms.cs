namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class CallToArms : AbilityBehavior
{
	public CallToArmsModel callToArmsModel; //Field offset: 0x68
	protected BehaviorMutator mutator; //Field offset: 0x70
	private int lifespan; //Field offset: 0x78

	public CallToArms() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	private void RemoveProcess() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

