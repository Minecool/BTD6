namespace Assets.Scripts.Simulation.Towers.Mutators;

public abstract class TowerMutator : RootBehavior
{
	public BehaviorMutator mutator; //Field offset: 0x58
	protected Conditional conditional; //Field offset: 0x60

	protected TowerMutator() { }

	public bool EvaluateConditional() { }

	protected virtual void OnDestroy() { }

}

