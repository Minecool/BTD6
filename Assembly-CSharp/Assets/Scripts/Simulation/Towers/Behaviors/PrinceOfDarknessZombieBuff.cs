namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class PrinceOfDarknessZombieBuff : TowerBehaviorBuff
{
	public class PrinceOfDarknessZombieBuffMutator : BehaviorMutator
	{
		public float damageIncrease; //Field offset: 0x70
		public float distanceMultiplier; //Field offset: 0x74

		public PrinceOfDarknessZombieBuffMutator(float damageIncrease, float distanceMultiplier, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public PrinceOfDarknessZombieBuffModel princeOfDarknessZombieBuffModel; //Field offset: 0x70
	private PrinceOfDarknessZombieBuffMutator mutator; //Field offset: 0x78
	private Zoned<Tower> zone; //Field offset: 0x80

	public PrinceOfDarknessZombieBuff() { }

	public virtual void Attatched() { }

	public float GetRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void InitialiseZone() { }

	protected virtual void OnDestroy() { }

	private void OnTowerSuspendedStateChanged() { }

	public void OnTowerUpgraded(Tower towerInZone) { }

	public virtual BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	private void TowerEnter(Tower towerInZone) { }

	private void TowerExit(Tower towerInZone) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

