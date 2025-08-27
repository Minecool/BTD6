namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

internal class CPOEPMutator : BehaviorMutator
{
	private int countIncrease; //Field offset: 0x70
	private string targetCPOEPId; //Field offset: 0x78

	public CPOEPMutator(int countIncrease, string targetCPOEPId) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

