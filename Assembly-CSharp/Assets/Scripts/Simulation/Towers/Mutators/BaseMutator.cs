namespace Assets.Scripts.Simulation.Towers.Mutators;

internal class BaseMutator : BehaviorMutator
{
	public string mutationId; //Field offset: 0x70

	public BaseMutator(bool unique, string mutationId, int priority = 1) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

