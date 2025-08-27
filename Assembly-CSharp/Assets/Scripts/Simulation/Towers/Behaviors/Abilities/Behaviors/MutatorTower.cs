namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

internal class MutatorTower : BehaviorMutator
{
	private readonly DamageModifierModel damageModifierModel; //Field offset: 0x70

	public MutatorTower(DamageModifierModel damageModifierModel, bool isUnique, string mutatorId, BuffIndicatorModel buffIndicator) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

