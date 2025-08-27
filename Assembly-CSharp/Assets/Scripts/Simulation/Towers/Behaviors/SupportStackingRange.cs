namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SupportStackingRange : SelfStackingSupportCompounding
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly SupportStackingRange parent; //Field offset: 0x70

		public MutatorTower(SupportStackingRange parent, string mutatorId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public SupportStackingRangeModel supportStackingRangeModel; //Field offset: 0xA0

	public SupportStackingRange() { }

	protected virtual void CreateMutator(string mutatorIdToUse) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

