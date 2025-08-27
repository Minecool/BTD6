namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

internal class DamageMutator : BehaviorMutator
{
	private readonly ActivateTowerDamageSupportZone parent; //Field offset: 0x70
	private readonly DisplayModel display; //Field offset: 0x78

	public DamageMutator(ActivateTowerDamageSupportZone parent, DisplayModel display) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

