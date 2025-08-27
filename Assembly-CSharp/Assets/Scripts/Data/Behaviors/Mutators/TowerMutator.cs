namespace Assets.Scripts.Data.Behaviors.Mutators;

public abstract class TowerMutator : EntityBehavior<TowerMutatorModel>
{
	public Conditional conditional; //Field offset: 0x28
	public string mutationId; //Field offset: 0x30

	protected TowerMutator() { }

}

