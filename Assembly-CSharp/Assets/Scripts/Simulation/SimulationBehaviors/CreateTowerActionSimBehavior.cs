namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class CreateTowerActionSimBehavior : SimulationBehavior
{
	private const float leniency = 0.01; //Field offset: 0x0
	public CreateTowerActionSimBehaviorModel createTowerActionSimBehaviorModel; //Field offset: 0x58
	private TowerModel towerModel; //Field offset: 0x60
	public bool isReleased; //Field offset: 0x68
	private List<Vector3> possibleOffsets; //Field offset: 0x70
	private List<Vector3> inRangeUnblocked; //Field offset: 0x78
	private List<Vector3> inRangeBlocked; //Field offset: 0x80
	private TowerModel towerModelBlocks; //Field offset: 0x88
	private TowerModel towerModelDoesNotBlock; //Field offset: 0x90
	private Vector3 destination; //Field offset: 0x98
	private Tower placeholderTower; //Field offset: 0xA8
	private int releaseAt; //Field offset: 0xB0
	private int ownerOfReleasedTower; //Field offset: 0xB4

	public CreateTowerActionSimBehavior() { }

	private void CalculatePossibleOffsets(int ringsToCalculate) { }

	private void CheckPositions() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void PerformAction() { }

	private void Process(int elapsed) { }

	private void Shuffle(List<T> list) { }

	private void SpawnTower() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

