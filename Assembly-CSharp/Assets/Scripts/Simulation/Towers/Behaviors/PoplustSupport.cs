namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class PoplustSupport : TowerBehaviorBuff
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public PoplustSupport <>4__this; //Field offset: 0x10
		public Simulation sim; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <Attatched>b__0(Tower t) { }

		internal void <Attatched>b__1(Tower t) { }

	}

	public class PoplustMutator : BehaviorMutator
	{
		private PoplustSupportModel poplustSupportModel; //Field offset: 0x70
		private readonly int stackCount; //Field offset: 0x78

		public PoplustMutator(string mutatorId, PoplustSupportModel poplustSupportModel, int stackCount) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

		public virtual int StackCount() { }

	}

	public PoplustSupportModel poplustSupportModel; //Field offset: 0x70
	public int previousMultiplier; //Field offset: 0x78
	private Zoned<Tower> zone; //Field offset: 0x80
	private bool ignore; //Field offset: 0x88
	private string supportedBaseId; //Field offset: 0x90

	public PoplustSupport() { }

	public virtual void Attatched() { }

	public float GetRange() { }

	public int GetStacks(Tower towerToCheck, Simulation sim) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void RefreshAllAffectedTowers() { }

	public virtual BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateMutatorForTower(Tower towerToUpdate, Simulation _sim) { }

	private void ZoneEnter(Tower towerInZone, Simulation _sim) { }

	private void ZoneExit(Tower towerInZone, Simulation _sim) { }

}

