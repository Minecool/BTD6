namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class CashBoostMutator : BehaviorMutator
{
	private CashBoostModel cashBoostModel; //Field offset: 0x70

	public CashBoostMutator(CashBoostModel cashBoostModel) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

