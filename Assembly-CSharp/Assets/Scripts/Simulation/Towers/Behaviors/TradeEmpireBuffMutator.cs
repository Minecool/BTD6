namespace Assets.Scripts.Simulation.Towers.Behaviors;

internal class TradeEmpireBuffMutator : BehaviorMutator
{
	public readonly float cashBonus; //Field offset: 0x70
	public readonly int damageBuff; //Field offset: 0x74
	public readonly int ceramicDamageBuff; //Field offset: 0x78
	public readonly int moabDamageBuff; //Field offset: 0x7C
	public int stacks; //Field offset: 0x80

	public TradeEmpireBuffMutator(float cashBonus, int damageBuff, int ceramicDamageBuff, int moabDamageBuff, BuffIndicatorModel buffIndicator, int stacks, string mutatorId) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

	public virtual int StackCount() { }

}

