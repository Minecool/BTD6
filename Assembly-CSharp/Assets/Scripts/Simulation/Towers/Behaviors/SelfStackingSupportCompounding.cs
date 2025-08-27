namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SelfStackingSupportCompounding : TowerBehaviorBuff
{
	public SelfStackingSupportCompoundingModel selfStackingSupportCompoundingModel; //Field offset: 0x70
	protected BehaviorMutator mutator; //Field offset: 0x78
	private Zoned<Tower> zone; //Field offset: 0x80
	public string thisUniqueMutatorId; //Field offset: 0x88
	private List<RootBehavior> createdBehaviors; //Field offset: 0x90
	private int count; //Field offset: 0x98

	public int Count
	{
		 get { } //Length: 7
	}

	public SelfStackingSupportCompounding() { }

	private void AddMutator(Tower towerInZone) { }

	public virtual void Attatched() { }

	public bool CheckBehavior(Tower tower) { }

	protected override void CreateMutator(string mutatorIdToUse) { }

	public override bool Filter(RootBehavior behavior) { }

	public int get_Count() { }

	public float GetRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void RemoveMutator(Tower towerInZone) { }

	public void RunZone() { }

	public virtual BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	private void TowerSuspendedStateChanged() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

