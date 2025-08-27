namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SupportShinobiTactics : SelfStackingSupportCompounding
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly SupportShinobiTactics parent; //Field offset: 0x70

		public MutatorTower(SupportShinobiTactics parent, string mutatorId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public SupportShinobiTacticsModel supportShinobiTacticsModel; //Field offset: 0xA0

	public SupportShinobiTactics() { }

	public virtual void Attatched() { }

	protected virtual void CreateMutator(string mutatorIdToUse) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

