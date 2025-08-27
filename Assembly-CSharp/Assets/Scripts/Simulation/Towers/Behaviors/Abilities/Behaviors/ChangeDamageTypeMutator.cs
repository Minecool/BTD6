namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

internal class ChangeDamageTypeMutator : BehaviorMutator
{
	private ChangeDamageTypeModel changeDamageTypeModel; //Field offset: 0x70

	public ChangeDamageTypeMutator(ChangeDamageTypeModel changeDamageTypeModel, string mutatorId) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

