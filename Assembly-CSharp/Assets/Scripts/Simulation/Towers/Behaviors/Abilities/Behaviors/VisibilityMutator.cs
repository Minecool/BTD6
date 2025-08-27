namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

internal class VisibilityMutator : BehaviorMutator
{
	private readonly DisplayModel display; //Field offset: 0x70

	public VisibilityMutator(ActivateVisibilitySupportZone parent, DisplayModel display) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

