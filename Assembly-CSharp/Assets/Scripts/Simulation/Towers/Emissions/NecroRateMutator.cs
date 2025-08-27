namespace Assets.Scripts.Simulation.Towers.Emissions;

public class NecroRateMutator : BehaviorMutator
{
	private readonly float multiplier; //Field offset: 0x70

	public NecroRateMutator(bool isUnique, string mutatorId, float multiplier, int priority, BuffIndicatorModel buffIndicator) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

