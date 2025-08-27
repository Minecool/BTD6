namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SupportStackCounter : SelfStackingSupportCompounding
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly SupportStackCounter parent; //Field offset: 0x70

		public MutatorTower(SupportStackCounter parent, string mutatorId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public SupportStackCounterModel supportStackCounterModel; //Field offset: 0xA0

	public SupportStackCounter() { }

	protected virtual void CreateMutator(string mutatorIdToUse) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

