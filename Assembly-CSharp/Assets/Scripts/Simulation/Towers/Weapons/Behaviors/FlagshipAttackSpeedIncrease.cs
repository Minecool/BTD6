namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class FlagshipAttackSpeedIncrease : TowerBehaviorBuff
{
	public class Mutator : BehaviorMutator
	{
		private FlagshipAttackSpeedIncreaseModel flagshipAttackSpeedIncreaseModel; //Field offset: 0x70

		public Mutator(FlagshipAttackSpeedIncreaseModel flagshipAttackSpeedIncreaseModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public FlagshipAttackSpeedIncreaseModel flagshipAttackSpeedIncreaseModel; //Field offset: 0x70
	private Zoned<Tower> zone; //Field offset: 0x78
	private Mutator towerAttackSpeedMutator; //Field offset: 0x80

	public FlagshipAttackSpeedIncrease() { }

	public virtual void Attatched() { }

	private int CanBuff(TowerModel towModel, Tower tower, Vector3 pos) { }

	public float GetRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void InitialiseZone() { }

	protected virtual void OnDestroy() { }

	public virtual BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	private void TowerEnter(Tower towerToCheck) { }

	private void TowerExit(Tower tower) { }

	private bool TowerFilter(RootBehavior behavior) { }

	private void TowerSuspendedStateChanged() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

