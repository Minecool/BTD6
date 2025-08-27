namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class AbsorbTowerBuffsAction : BloonBehaviorAction
{
	public AbsorbTowerBuffsActionModel absorbTowerBuffsActionModel; //Field offset: 0x78
	private readonly List<TimedMutator> mutatorsToRemove; //Field offset: 0x80
	private readonly Dictionary<String, Int32> mutatorCounts; //Field offset: 0x88
	private readonly Dictionary<String, Int32> mutatorLimits; //Field offset: 0x90
	private readonly List<Tower> healedFromTowersInZone; //Field offset: 0x98

	public AbsorbTowerBuffsAction() { }

	private bool CheckStackLimitForMutator(BehaviorMutator mutator) { }

	private int HealFromBuff(string mutatorId, Tower fromTower) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void PerformAction() { }

	private bool ShouldIgnoreTower(Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

