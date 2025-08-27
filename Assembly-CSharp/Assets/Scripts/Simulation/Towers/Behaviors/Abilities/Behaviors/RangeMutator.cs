namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

internal class RangeMutator : BehaviorMutator
{
	private readonly float additive; //Field offset: 0x70
	private readonly float multiplier; //Field offset: 0x74

	public RangeMutator(bool isUnique, string mutatorId, float additive, float multiplier, BuffIndicatorModel buffIndicator) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

