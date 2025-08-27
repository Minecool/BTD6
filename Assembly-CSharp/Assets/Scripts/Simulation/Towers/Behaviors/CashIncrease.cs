namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CashIncrease : TowerBehavior
{
	public class BloonWorthMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70
		private readonly float additive; //Field offset: 0x74

		public BloonWorthMutator(string id, float multiplier, float additive) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public CashIncreaseModel cashIncreaseModel; //Field offset: 0x68
	private BloonWorthMutator mutator; //Field offset: 0x70

	public CashIncrease() { }

	public float GetCashIncrease() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnBloonDamaged(Bloon bloon, float amount) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

