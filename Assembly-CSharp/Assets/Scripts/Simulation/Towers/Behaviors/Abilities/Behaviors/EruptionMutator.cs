namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class EruptionMutator : BehaviorMutator
{
	private readonly EruptionModel eruptionModel; //Field offset: 0x70

	public EruptionMutator(EruptionModel eruptionModel) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

