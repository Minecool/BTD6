namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

internal class RateMutator : BehaviorMutator
{
	private readonly ActivateRateSupportZone parent; //Field offset: 0x70
	private readonly DisplayModel display; //Field offset: 0x78

	public RateMutator(ActivateRateSupportZone parent, DisplayModel display) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

