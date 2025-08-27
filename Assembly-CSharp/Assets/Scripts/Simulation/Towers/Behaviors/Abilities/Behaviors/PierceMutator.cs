namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

internal class PierceMutator : BehaviorMutator
{
	private readonly ActivatePierceSupportZone parent; //Field offset: 0x70
	private readonly DisplayModel display; //Field offset: 0x78

	public PierceMutator(ActivatePierceSupportZone parent, DisplayModel display) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

